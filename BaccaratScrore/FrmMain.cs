using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using BaccaratScrore.Properties;
using Tesseract;

namespace BaccaratScrore
{
    [Obfuscation(Feature = "Apply to member * when method or constructor: virtualization", Exclude = false)]
    [Obfuscation(Feature = "PEVerify", Exclude = false)]
    [Obfuscation(Feature = "debug [secure] with password 12345A", Exclude = false)]
    [Obfuscation(Feature = "encrypt resources", Exclude = false)]
    public partial class FrmMain : Form
    {
        private readonly int _time = Variable._time;
        private string _nameSaved;
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Load/Save

        private void FrmLayoutSettingEditor_Load(object sender, EventArgs e)
        {
            if (File.Exists($"Settings{_nameSaved}.dat"))
            {
                using (var bw = new BinaryReader(File.Open($"Settings{_nameSaved}.dat", FileMode.Open)))
                {
                    CatcherX1 = bw.ReadInt32();
                    CatcherX2 = bw.ReadInt32();
                    CatcherY1 = bw.ReadInt32();
                    CatcherY2 = bw.ReadInt32();
                    PosX1 = bw.ReadInt32();
                    PosX2 = bw.ReadInt32();
                    PosY1 = bw.ReadInt32();
                    PosY2 = bw.ReadInt32();
                    txtResultXCount.Text = bw.ReadString();
                    txtResultYCount.Text = bw.ReadString();
                    txtImageSec.Text = bw.ReadString();
                }
                lblCountDownXY.Text = $@"({PosX1}, {PosY1}) ({CatcherX1}, {CatcherY1})";
                lblResultXY.Text = $@"({PosX2}, {PosY2}) ({CatcherX2}, {CatcherY2})";
                //tmCount.Start();
                //tmResult.Start();
            }
            LoadLocation();
        }
        private void LoadLocation()
        {
            if (Settings.Default.Location == new Point(0, 0))
            {
                CenterToScreen();
            }
            else
            {
                Location = Settings.Default.Location;
            }
        }

        private void FrmLayoutSettingEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Location = Location;
            Settings.Default.Save();
            try
            {
                using (var bw = new BinaryWriter(File.Open($"Settings{_nameSaved}.dat", FileMode.Create)))
                {
                    bw.Write(CatcherX1);
                    bw.Write(CatcherX2);
                    bw.Write(CatcherY1);
                    bw.Write(CatcherY2);
                    bw.Write(PosX1);
                    bw.Write(PosX2);
                    bw.Write(PosY1);
                    bw.Write(PosY2);
                    bw.Write(txtResultXCount.Text);
                    bw.Write(txtResultYCount.Text);
                    bw.Write(txtImageSec.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion Load/Save

        #region Variable

        private Bitmap _picBit1;
        private Bitmap _picBit2;
        private int _mode;
        public int PosX1, PosY1, CatcherX1, CatcherY1, PosX2, PosY2, CatcherX2, CatcherY2, BitWidth, BitHeight;
        private int _player, _banker, _tie, _empty, _all;
        private readonly frmResultImageTester _frmResultImage = new frmResultImageTester();
        private int _allNow, _allMax;
        private bool _allChanging1, _allChanging2, _allChanging3, _firstTime;
        //private string _fileName, _namePrev;
        //private bool _strFirst;
        #endregion Variable

        #region Countdown
        private void BtnSetCountDown_Click(object sender, EventArgs e)
        {
            if (btnSetCountDown.Text == @"ตั้งค่านับถอยหลัง")
            {
                Catcher(1);
                btnSetCountDown.Text = @"ยืนยันค่านับถอยหลัง";
            }
            else
            {
                Variable.Catcher().Close();
                btnSetCountDown.Text = @"ตั้งค่านับถอยหลัง";
            }
        }

        private void TmCount_Tick(object sender, EventArgs e)
        {
            try
            {
                picCountDown.Image = ScreenCatcher.BuildBitmap(PosX1, PosY1, CatcherX1, CatcherY1);
            }
            catch
            {

            }
        }

        private void TmRealtimeCount_Tick(object sender, EventArgs e)
        {
            if (tmCatcher.Enabled)
                return;
            try
            {
                picCountDown2.Image = ScreenCatcher.BuildBitmap(PosX1, PosY1, CatcherX1, CatcherY1);

                var img = new Bitmap(picCountDown2.Image);
                var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                var page = engine.Process(img, PageSegMode.Count);
                var result = page.GetText();

                if (double.TryParse(result, out _))
                {
                    lbCountDown.Text = result;
                }

                if (lbCountDown.Text.StartsWith("0") || lbCountDown.Text.StartsWith("1"))
                {
                    tmReadStatus.Start();
                }
                else
                {
                    tmReadStatus.Stop();
                    lbStatus.Text = "";
                }

            }
            catch
            {

            }
        }
        private void TmReadStatus_Tick(object sender, EventArgs e)
        {
            if (tmCatcher.Enabled)
                return;
            try
            {
                picCountDown2.Image = ScreenCatcher.BuildBitmap(PosX1, PosY1, CatcherX1, CatcherY1);

                var img = new Bitmap(picCountDown2.Image);
                var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                var page = engine.Process(img, PageSegMode.Auto);
                var result = page.GetText();

                if (result.StartsWith("Dea"))
                {
                    lbStatus.Text = "Dealing";
                }
                else if (result.StartsWith("Bank"))
                {
                    lbStatus.Text = "Banker Win";
                }
                else if(result.StartsWith("May")|| result.StartsWith("Play"))
                {
                    lbStatus.Text = "Player Win";
                }
                else if (result.StartsWith("Shu"))
                {
                    lbStatus.Text = "Shuffling";
                }
                else
                {
                    lbStatus.Text = result;
                }

            }
            catch
            {

            }
        }


        private void BtnCountDownUp_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Up);
        }

        private void BtnCountDownYDec_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.DecHeight);
        }

        private void BtnCountDownRight_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Right);
        }

        private void BtnCountDownXInc_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.IncWidth);
        }

        private void BtnCountDownYInc_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.IncHeight);
        }

        private void BtnCountDownDown_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Down);
        }

        private void BtnCountDownXDec_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.DecWidth);
        }

        private void BtnCountDownLeft_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Left);
        }
        #endregion Button Countdown

        #region CatcherControl

        private void CatcherController(ControlType modeType)
        {
            if (Variable.Catcher() == null) return;
            var screenCatcher = Variable.Catcher();
            switch (modeType)
            {
                case ControlType.Up:
                    checked
                    {
                        screenCatcher.Top--;
                    }

                    break;

                case ControlType.Down:
                    checked
                    {
                        screenCatcher.Top++;
                    }

                    break;

                case ControlType.Right:
                    checked
                    {
                        screenCatcher.Left++;
                    }

                    break;

                case ControlType.Left:
                    checked
                    {
                        screenCatcher.Left--;
                    }

                    break;

                case ControlType.DecHeight:
                    checked
                    {
                        screenCatcher.Height--;
                    }

                    break;

                case ControlType.DecWidth:
                    checked
                    {
                        screenCatcher.Width--;
                    }

                    break;

                case ControlType.IncHeight:
                    checked
                    {
                        screenCatcher.Height++;
                    }

                    break;

                case ControlType.IncWidth:
                    checked
                    {
                        screenCatcher.Width++;
                    }

                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(modeType), modeType, null);
            }
        }

        private enum ControlType
        {
            Up,
            Right,
            Down,
            Left,
            DecHeight,
            DecWidth,
            IncHeight,
            IncWidth
        }

        internal static void CatcherShow()
        {
            if (Variable.Catcher() == null || Variable.Catcher().IsDisposed)
            {
                Variable.ScreenCatcher(new ScreenCatcher());
            }
            Variable.Catcher().Show();
        }

        private void Catcher(int mode)
        {
            try
            {
                CatcherShow();
                if (mode == 1)
                {
                    btnSetResult.Enabled = false;
                    if (PosX1 > 0 && PosY1 > 0 && CatcherX1 > 0 && CatcherY1 > 0)
                    {
                        Variable.Catcher().GetPosition(PosX1, PosY1, CatcherX1, CatcherY1);
                        tmCount.Stop();
                    }
                }
                else
                {
                    btnSetCountDown.Enabled = false;
                    if (PosX2 > 0 && PosY2 > 0 && CatcherX2 > 0 && CatcherY2 > 0)
                    {
                        Variable.Catcher().GetPosition(PosX2, PosY2, CatcherX2, CatcherY2);
                        tmResult.Stop();
                    }
                }

                _mode = mode;
                tmCatcher.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TmCatcher_Tick(object sender, EventArgs e)
        {
            try
            {
                Variable.Catcher().GetBitMap();
                switch (_mode)
                {
                    case 1:

                        _picBit1 = Variable.Catcher().PicShow;
                        PosX1 = Variable.Catcher().RecLeft;
                        PosY1 = Variable.Catcher().RecTop;
                        CatcherX1 = Variable.Catcher().RecWidth;
                        CatcherY1 = Variable.Catcher().RecHeight;
                        picCountDown.Image = _picBit1;
                        lblCountDownXY.Text = $@"({PosX1}, {PosY1}) ({CatcherX1}, {CatcherY1})";
                        tmCount.Start();
                        break;

                    case 2:
                        _picBit2 = Variable.Catcher().PicShow;
                        PosX2 = Variable.Catcher().RecLeft;
                        PosY2 = Variable.Catcher().RecTop;
                        CatcherX2 = Variable.Catcher().RecWidth;
                        CatcherY2 = Variable.Catcher().RecHeight;
                        picResult.Image = _picBit2;
                        lblResultXY.Text = $@"({PosX2}, {PosY2}) ({CatcherX2}, {CatcherY2})";
                        tmResult.Start();
                        break;
                }
            }
            catch
            {
            }
            if (Variable.Catcher() != null && Variable.Catcher().IsDisposed)
            {
                tmCatcher.Stop();
                tmResult.Stop();
                tmCount.Stop();
                btnSetCountDown.Enabled = true;
                btnSetCountDown.Text = @"ตั้งค่านับถอยหลัง";
                btnSetResult.Enabled = true;
                btnSetResult.Text = @"ตั้งผลลัพธ์";
            }
        }

        #endregion CatcherControl

        #region Result

        private void LinklbShowTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                tmCatcher.Stop();
                _frmResultImage.GetPicture((Bitmap)picResult.Image, int.Parse(txtResultXCount.Text), int.Parse(txtResultYCount.Text));
                _frmResultImage.ShowDialog();
            }
            catch
            {

            }

        }

        private void BtnSetResult_Click(object sender, EventArgs e)
        {
            if (btnSetResult.Text == @"ตั้งผลลัพธ์")
            {
                Catcher(2);
                btnSetResult.Text = @"ยืนยันผลลัพธ์";
            }
            else
            {
                Variable.Catcher().Close();
                btnSetResult.Text = @"ตั้งผลลัพธ์";
            }
        }

        private void TmResult_Tick(object sender, EventArgs e)
        {
            try
            {
                picResult.Image = ScreenCatcher.BuildBitmap(PosX2, PosY2, CatcherX2, CatcherY2);

            }
            catch
            {

            }
        }



        private void TmRealtimeResult_Tick(object sender, EventArgs e)
        {
            if (tmCatcher.Enabled)
                return;
            try
            {
                picResult2.Image = ScreenCatcher.BuildBitmap(PosX2, PosY2, CatcherX2, CatcherY2);
                GetScore((Bitmap)picResult2.Image, int.Parse(txtResultXCount.Text), int.Parse(txtResultYCount.Text));
            }
            catch
            {

            }
        }



        private void BtnResultUp_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Up);
        }

  

        private void BtnResultYDec_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.DecHeight);
        }

        private void BtnResultRight_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Right);
        }



        private void BtnResultXInc_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.IncWidth);
        }

        private void BtnResultYInc_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.IncHeight);
        }

        private void BtnResultDown_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Down);
        }

        private void BtnResultXDec_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.DecWidth);
        }

        private void BtnResultLeft_Click(object sender, EventArgs e)
        {
            CatcherController(ControlType.Left);
        }



        #endregion Button Result

        #region Function Get PTB

        private void BtStart_Click(object sender, EventArgs e)
        {
          
            btStart.Text = btStart.Text.EndsWith("หยุด") ? "เริ่ม" : "หยุด";
            try
            {
                switch (btStart.Text)
                {
                    case "หยุด":
                        CheckName();
                        tmStart.Start();
                        tmRealtimeCount.Start();
                        tmRealtimeResult.Start();
                        tmCount.Start();
                        TopMost = true;
                        btnSetCountDown.Enabled = false;
                        btnSetResult.Enabled = false;
                        tmScore.Start();
                        _firstTime = true;
                        txtName.Enabled = false;
                        //_strFirst = true;
                        break;
                    case "เริ่ม":
                        tmStart.Stop();
                        tmRealtimeCount.Stop();
                        tmRealtimeResult.Stop();
                        tmCount.Stop();
                        TopMost = false;
                        btnSetCountDown.Enabled = true;
                        btnSetResult.Enabled = true;
                        tmScore.Stop();
                        _firstTime = false;
                        txtName.Enabled = true;
                        // _strFirst = false;
                        break;
                }

            }
            catch
            {
               
            }
        }

        private string _lastWin;
        private void TmStart_Tick(object sender, EventArgs e)
        {
            _player = 0;
            _banker = 0;
            _tie = 0;
            _empty = 0;
            _lastWin = null;
            try
            {
                var columnsCount = int.Parse(txtResultXCount.Text);
                var rowCount = int.Parse(txtResultYCount.Text);

                //add 
                try
                {
                    if (dataGridView1.ColumnCount < columnsCount)
                    {

                        for (int i = 0; i < columnsCount; i++)
                        {
                            dataGridView1.Columns.Add(i.ToString(), i.ToString());


                            for (int j = 0; j < rowCount; j++)
                            {
                                if (dataGridView1.RowCount < rowCount)
                                {
                                    dataGridView1.Rows.Add("");
                                }
                            }
                        }
                    }
                }
                catch
                {

                }

                //update value
                try
                {
                    if (dataGridView1.ColumnCount == columnsCount && dataGridView1.RowCount == rowCount)
                    {
                        for (int i = 0; i < columnsCount; i++)
                        {
                            for (int j = 0; j < rowCount; j++)
                            {
                                var str = Bitmap2Char(j, i);
                                dataGridView1[i, j].Value = str;
                                if (str == "B")
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Red;
                                    _banker++;
                                    _lastWin = "Banker";
                                }

                                if (str == "T")
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LimeGreen;
                                    _tie++;
                                    _lastWin = "Tie";
                                }

                                if (str == "P")
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Blue;
                                    _player++;
                                    _lastWin = "Player";
                                }

                                if (str == " ")
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                                    _empty++;
                                }

                                if (str == "")
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Black;
                                }
                            }
                        }

                        dataGridView1.ClearSelection();
                    }
                }
                catch
                {

                }
                
                _all = _player + _banker + _tie;
                lbScrore.Text = $@"Player: {_player}   Banker: {_banker}   Tie: {_tie}   Empty: {_empty}   All: {_all}/{_player+_banker+_tie+_empty}   LastWin: {_lastWin}";

                //label3.Text = $@"ตัวอย่าง
                //เวลา:{lbCountDown.Text}
                //ชนะสุดท้าย:{_lastWin}";

            }
            catch
            {

            }



        }
        private string Bitmap2Char(int row, int cell)
        {
            try
            {
                picBitmap.Image = (Bitmap)dgvCurrentResultImg.Rows[row].Cells[cell].Value;
                var img = new Bitmap(picBitmap.Image);
                var pixel = img.GetPixel(BitWidth / 2, BitHeight / 2);
               
                if (pixel.R > pixel.G && pixel.R > pixel.B)
                {
                    return "B";
                }

                if (pixel.G > pixel.R && pixel.G > pixel.B)
                {
                    return "T";
                }

                if (pixel.B > pixel.R && pixel.B > pixel.G)
                {
                    return "P";
                }
                if (pixel.B == pixel.R && pixel.R == pixel.G)
                {
                    pixel = img.GetPixel(BitWidth / 2, (BitHeight / 2) - 1);
                    if (pixel.R > pixel.G && pixel.R > pixel.B)
                    {
                        return "B";
                    }
                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        return "T";
                    }

                    if (pixel.B > pixel.R && pixel.B > pixel.G)
                    {
                        return "P";
                    }

                    if (pixel.B == pixel.R && pixel.R == pixel.G)
                    {
                        pixel = img.GetPixel(BitWidth / 2, (BitHeight / 2) - 2);
                        if (pixel.R > pixel.G && pixel.R > pixel.B)
                        {
                            return "B";
                        }
                        if (pixel.G > pixel.R && pixel.G > pixel.B)
                        {
                            return "T";
                        }

                        if (pixel.B > pixel.R && pixel.B > pixel.G)
                        {
                            return "P";
                        }
                        if (pixel.B == pixel.R && pixel.R == pixel.G)
                        {
                            pixel = img.GetPixel(BitWidth / 2, (BitHeight / 2) +1);
                            if (pixel.R > pixel.G && pixel.R > pixel.B)
                            {
                                return "B";
                            }
                            if (pixel.G > pixel.R && pixel.G > pixel.B)
                            {
                                return "T";
                            }

                            if (pixel.B > pixel.R && pixel.B > pixel.G)
                            {
                                return "P";
                            }
                            if (pixel.B == pixel.R && pixel.R == pixel.G)
                            {
                                pixel = img.GetPixel(BitWidth / 2, (BitHeight / 2)+2);
                                if (pixel.R > pixel.G && pixel.R > pixel.B)
                                {
                                    return "B";
                                }
                                if (pixel.G > pixel.R && pixel.G > pixel.B)
                                {
                                    return "T";
                                }

                                if (pixel.B > pixel.R && pixel.B > pixel.G)
                                {
                                    return "P";
                                }
                            }
                        }
                    }

                    return " ";
                }
                return "Error";
            }
            catch
            {
                return "Error";
            }
        }
        private unsafe void GetScore(Bitmap _picture, int _xCount, int _yCount)
        {
            var frmLayout = new FrmMain();
            void* ptr = stackalloc byte[44];
            try
            {
                if (_xCount > 0 & _yCount > 0 && _picture != null && _picture.Width >= 10 && _picture.Height >= 10)
                {
                    frmLayout.PosX2 = _xCount;
                    frmLayout.PosY2 = _yCount;
                    *(int*)((byte*)ptr + 8) = 0;
                    *(int*)((byte*)ptr + 4) = 0;
                    var list = GridBuild(frmLayout, _picture, ref *(int*)((byte*)ptr + 8), ref *(int*)((byte*)ptr + 4));
                    *(int*)((byte*)ptr + 8) = checked(*(int*)((byte*)ptr + 8) + 6);
                    *(int*)((byte*)ptr + 4) = checked(*(int*)((byte*)ptr + 4) + 6);
                    var list2 = new List<string>();
                    dgvCurrentResultImg.Columns.Clear();
                    ref var ptr2 = ref *(int*)((byte*)ptr + 12);
                    var num = 0;
                    *(int*)((byte*)ptr + 28) = checked(_xCount - 1);
                    ptr2 = num;
                    while (*(int*)((byte*)ptr + 12) <= *(int*)((byte*)ptr + 28))
                    {
                        var dataGridViewImageColumn = new DataGridViewImageColumn();
                        dataGridViewImageColumn.Width = *(int*)((byte*)ptr + 8);
                        BitWidth = dataGridViewImageColumn.Width;
                        dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                        dgvCurrentResultImg.Columns.Add(dataGridViewImageColumn);
                        *(int*)((byte*)ptr + 12) = checked(*(int*)((byte*)ptr + 12) + 1);
                    }
                    ref var ptr3 = ref *(int*)((byte*)ptr + 16);
                    var num2 = 0;
                    *(int*)((byte*)ptr + 32) = checked(_yCount - 1);
                    ptr3 = num2;
                    while (*(int*)((byte*)ptr + 16) <= *(int*)((byte*)ptr + 32))
                    {
                        dgvCurrentResultImg.Rows.Add(list2.ToArray());
                        dgvCurrentResultImg.Rows[checked(dgvCurrentResultImg.Rows.Count - 1)].Height = *(int*)((byte*)ptr + 4);
                        BitHeight = *(int*)((byte*)ptr + 4);
                        *(int*)((byte*)ptr + 16) = checked(*(int*)((byte*)ptr + 16) + 1);
                    }
                    dgvCurrentResultImg.ClearSelection();
                    *(int*)ptr = 0;
                    ref var ptr4 = ref *(int*)((byte*)ptr + 20);
                    var num3 = 0;
                    *(int*)((byte*)ptr + 36) = checked(_xCount - 1);
                    ptr4 = num3;
                    while (*(int*)((byte*)ptr + 20) <= *(int*)((byte*)ptr + 36))
                    {
                        ref var ptr5 = ref *(int*)((byte*)ptr + 24);
                        var num4 = 0;
                        *(int*)((byte*)ptr + 40) = checked(_yCount - 1);
                        ptr5 = num4;
                        while (*(int*)((byte*)ptr + 24) <= *(int*)((byte*)ptr + 40))
                        {
                            var value = new Bitmap(*(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 4));
                            if (*(int*)ptr < list.Count)
                            {
                                value = list[*(int*)ptr];
                                dgvCurrentResultImg.Rows[*(int*)((byte*)ptr + 24)].Cells[*(int*)((byte*)ptr + 20)].Value = value;
                                dgvCurrentResultImg.Rows[*(int*)((byte*)ptr + 24)].Cells[*(int*)((byte*)ptr + 20)].Style.BackColor = Color.DarkGray;
                            }
                            *(int*)ptr = checked(*(int*)ptr + 1);
                            *(int*)((byte*)ptr + 24) = checked(*(int*)((byte*)ptr + 24) + 1);
                        }
                        *(int*)((byte*)ptr + 20) = checked(*(int*)((byte*)ptr + 20) + 1);
                    }
                }
            }
            catch
            {
            }
        }
        internal static unsafe List<Bitmap> GridBuild(FrmMain frmLayout, Bitmap picture, ref int posX, ref int posY)
        {
            void* ptr = stackalloc byte[48];
            var list = new List<Bitmap>();
            *(int*)((byte*)ptr + 4) = 0;
            *(int*)ptr = 0;
            if (frmLayout != null && picture.Width > 10 && picture.Height > 10)
            {
                if (frmLayout.PosX2 > 0 & frmLayout.PosY2 > 0)
                {
                    var d = new decimal(picture.Width / (double)frmLayout.PosX2);
                    var d2 = new decimal(picture.Height / (double)frmLayout.PosY2);
                    ref var ptr2 = ref *(int*)((byte*)ptr + 16);
                    var num = 0;
                    *(int*)((byte*)ptr + 40) = checked(frmLayout.PosX2 - 1);
                    ptr2 = num;
                    while (*(int*)((byte*)ptr + 16) <= *(int*)((byte*)ptr + 40))
                    {
                        *(int*)((byte*)ptr + 8) = (int)Math.Round((Convert.ToDouble(decimal.Multiply(d, new decimal(*(int*)((byte*)ptr + 16)))) + 0.5));
                        *(int*)((byte*)ptr + 12) = 0;
                        if (*(int*)((byte*)ptr + 16) < checked(frmLayout.PosX2 - 1))
                        {
                            *(int*)((byte*)ptr + 20) = (int)Math.Round((Convert.ToDouble(decimal.Multiply(d, new decimal(checked(*(int*)((byte*)ptr + 16) + 1)))) + 0.5));
                            *(int*)((byte*)ptr + 12) = checked(*(int*)((byte*)ptr + 20) - *(int*)((byte*)ptr + 8));
                        }
                        else
                        {
                            *(int*)((byte*)ptr + 12) = checked(picture.Width - *(int*)((byte*)ptr + 8));
                        }
                        ref var ptr3 = ref *(int*)((byte*)ptr + 32);
                        var num2 = 0;
                        *(int*)((byte*)ptr + 44) = checked(frmLayout.PosY2 - 1);
                        ptr3 = num2;
                        while (*(int*)((byte*)ptr + 32) <= *(int*)((byte*)ptr + 44))
                        {
                            *(int*)((byte*)ptr + 28) = (int)Math.Round((Convert.ToDouble(decimal.Multiply(d2, new decimal(*(int*)((byte*)ptr + 32)))) + 0.5));
                            *(int*)((byte*)ptr + 24) = 0;
                            if (*(int*)((byte*)ptr + 32) < checked(frmLayout.PosY2 - 1))
                            {
                                *(int*)((byte*)ptr + 36) = (int)Math.Round((Convert.ToDouble(decimal.Multiply(d2, new decimal(checked(*(int*)((byte*)ptr + 32) + 1)))) + 0.5));
                                *(int*)((byte*)ptr + 24) = checked(*(int*)((byte*)ptr + 36) - *(int*)((byte*)ptr + 28));
                            }
                            else
                            {
                                *(int*)((byte*)ptr + 24) = checked(picture.Height - *(int*)((byte*)ptr + 28));
                            }
                            if (*(int*)((byte*)ptr + 24) > 5 & *(int*)((byte*)ptr + 12) > 5)
                            {
                                var rect = new Rectangle(*(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 28), *(int*)((byte*)ptr + 12), *(int*)((byte*)ptr + 24));
                                var item = picture.Clone(rect, PixelFormat.Format32bppArgb);
                                list.Add(item);
                                if (*(int*)((byte*)ptr + 12) > *(int*)((byte*)ptr + 4))
                                {
                                    *(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 12);
                                }
                                if (*(int*)((byte*)ptr + 24) > *(int*)ptr)
                                {
                                    *(int*)ptr = *(int*)((byte*)ptr + 24);
                                }
                            }
                            *(int*)((byte*)ptr + 32) = checked(*(int*)((byte*)ptr + 32) + 1);
                        }
                        *(int*)((byte*)ptr + 16) = checked(*(int*)((byte*)ptr + 16) + 1);
                    }
                }
            }
            posX = *(int*)((byte*)ptr + 4);
            posY = *(int*)ptr;
            return list;
        }

        /// <summary>
        /// 1 = ถ้าค่าเปลี่ยนแปลง,
        /// 2 = ถ้าค่าเพิ่มขึ้น,
        /// 3 = ถ้าค่าลดลง
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        private bool NumberChanging(int mode)
        {
            if (_firstTime)
            {
                _firstTime = false;
                _allNow = _all;
                _allMax = _all;
                return true;
            }

            switch (mode)
            {
                case 1:
                    if (_allNow != _all) // ถ้า all เปลี่ยนแปลง
                    {
                        _allNow = _all;
                        return true;
                    }
                    break;
                case 2:
                    if (_allMax < _all) // ถ้า all เพิ่มขึ้น
                    {
                        _allMax = _all;
                        return true;
                    }
                    break;
                case 3:
                    if (_allMax > _allNow) // ถ้า all น้อยลง
                    {
                        return true;
                    }
                    break;
                case 0:
                    return false;
            }

            return false;
        }
        private void TmScore_Tick(object sender, EventArgs e)
        {
            _allChanging1 = NumberChanging(1);
            _allChanging2 = NumberChanging(2);
            _allChanging3 = NumberChanging(3);
            try
            {
                var columnsCount = int.Parse(txtResultXCount.Text);
                var rowCount = int.Parse(txtResultYCount.Text);
              //  var num = 0; // เลขหน้า PBT
              label5.Text = _allChanging1.ToString();
                if (_allChanging1)
                {
                   // listView1.Clear();
                   txtScrore.Clear();
                    if (dataGridView1.ColumnCount == columnsCount && dataGridView1.RowCount == rowCount)
                    {
                        for (int i = 0; i < columnsCount; i++)
                        {
                            for (int j = 0; j < rowCount; j++)
                            {
                                var str = Bitmap2Char(j, i);
                                dataGridView1[i, j].Value = str;
                               
                                if (str == " ")
                                {
                                    return;
                                }

                                if (str != "" || str != " ")
                                {
                                    txtScrore.AppendText(str + ",");
                                }

                            }
                        }
                    }

                    var score = txtScrore.Text;
                    score = score.Remove(score.Length-1);
                    _allChanging1 = NumberChanging(0);


                    //บันทึก
                    try
                    {
                        File.WriteAllText($"score{_nameSaved}.json", score);
                        File.WriteAllText($"time{_nameSaved}.json", lbCountDown.Text);
                       
                        //_fileName = DateTime.Now.ToString("MM-dd-yyyy H-mm-ss") + ".json";
                        //if (_strFirst)
                        //{
                        //    _strFirst = false;
                        //    _namePrev = _fileName;
                        //}

                        //if (_allChanging2) // all เพิ่ม
                        //{
                        //    File.WriteAllText(_namePrev, txtScrore.Text);
                        //    //using (var tw = new StreamWriter(_namePrev))
                        //    //{
                        //    //    foreach (ListViewItem item in listView1.Items)
                        //    //    {
                        //    //        tw.WriteLine(item.Text);
                        //    //    }
                        //    //}

                        //    _allChanging2 = NumberChanging(0);
                        //}

                        //if (_allChanging3) // all ลดลง
                        //{
                        //    _firstTime = true;
                        //    _namePrev = _fileName;
                        //    File.WriteAllText(_fileName, txtScrore.Text);
                        //    //using (var tw = new StreamWriter(_fileName))
                        //    //{
                        //    //    foreach (ListViewItem item in listView1.Items)
                        //    //    {
                        //    //        tw.WriteLine(item.Text);
                        //    //    }
                        //    //}

                        //    _allChanging3 = NumberChanging(0);
                        //}

                    }
                    catch
                    {
                        File.WriteAllText($"error{_nameSaved}.json", DateTime.Now.ToLongTimeString()+ @":Saved Error");
                    }
                }

                
            }
            catch
            {

            }


           
            
            
        }
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            CheckName();
        }
        private void CheckName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                Text = @"Baccarat Score " + _time;
                _nameSaved = _time.ToString();
            }
            else
            {
                Text = @"Baccarat Score " + txtName.Text;
                _nameSaved = txtName.Text;
            }
        }
        #endregion


    }
}