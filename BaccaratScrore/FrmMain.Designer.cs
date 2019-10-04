namespace BaccaratScrore
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImageSec = new System.Windows.Forms.TextBox();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.lblCountDownXY = new System.Windows.Forms.Label();
            this.picCountDown = new System.Windows.Forms.PictureBox();
            this.btnCountDownYDec = new System.Windows.Forms.Button();
            this.btnCountDownXDec = new System.Windows.Forms.Button();
            this.btnCountDownYInc = new System.Windows.Forms.Button();
            this.btnCountDownRight = new System.Windows.Forms.Button();
            this.btnCountDownXInc = new System.Windows.Forms.Button();
            this.btnCountDownLeft = new System.Windows.Forms.Button();
            this.btnCountDownUp = new System.Windows.Forms.Button();
            this.btnCountDownDown = new System.Windows.Forms.Button();
            this.btnSetCountDown = new System.Windows.Forms.Button();
            this.picCountDown2 = new System.Windows.Forms.PictureBox();
            this.picBitmap = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultXY = new System.Windows.Forms.Label();
            this.txtResultXCount = new System.Windows.Forms.TextBox();
            this.txtResultYCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linklbShowTest = new System.Windows.Forms.LinkLabel();
            this.btnSetResult = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnResultYDec = new System.Windows.Forms.Button();
            this.btnResultYInc = new System.Windows.Forms.Button();
            this.btnResultXDec = new System.Windows.Forms.Button();
            this.btnResultDown = new System.Windows.Forms.Button();
            this.btnResultUp = new System.Windows.Forms.Button();
            this.btnResultRight = new System.Windows.Forms.Button();
            this.btnResultLeft = new System.Windows.Forms.Button();
            this.btnResultXInc = new System.Windows.Forms.Button();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.tmCatcher = new System.Windows.Forms.Timer(this.components);
            this.tmResult = new System.Windows.Forms.Timer(this.components);
            this.tmCount = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCurrentResultImg = new System.Windows.Forms.DataGridView();
            this.tmRealtimeResult = new System.Windows.Forms.Timer(this.components);
            this.tmRealtimeCount = new System.Windows.Forms.Timer(this.components);
            this.panelHideObjects = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtScrore = new System.Windows.Forms.TextBox();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            this.lbScrore = new System.Windows.Forms.Label();
            this.tmScore = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tmReadStatus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBitmap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentResultImg)).BeginInit();
            this.panelHideObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtImageSec);
            this.groupBox1.Controls.Add(this.lbCountDown);
            this.groupBox1.Controls.Add(this.lblCountDownXY);
            this.groupBox1.Controls.Add(this.picCountDown);
            this.groupBox1.Controls.Add(this.btnCountDownYDec);
            this.groupBox1.Controls.Add(this.btnCountDownXDec);
            this.groupBox1.Controls.Add(this.btnCountDownYInc);
            this.groupBox1.Controls.Add(this.btnCountDownRight);
            this.groupBox1.Controls.Add(this.btnCountDownXInc);
            this.groupBox1.Controls.Add(this.btnCountDownLeft);
            this.groupBox1.Controls.Add(this.btnCountDownUp);
            this.groupBox1.Controls.Add(this.btnCountDownDown);
            this.groupBox1.Controls.Add(this.btnSetCountDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "นับถอยหลัง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(402, 45);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 22;
            this.lbStatus.Text = "AAAA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ตัวอย่าง";
            // 
            // txtImageSec
            // 
            this.txtImageSec.Location = new System.Drawing.Point(427, 19);
            this.txtImageSec.Name = "txtImageSec";
            this.txtImageSec.Size = new System.Drawing.Size(27, 20);
            this.txtImageSec.TabIndex = 20;
            this.txtImageSec.Text = "15";
            this.txtImageSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Location = new System.Drawing.Point(402, 23);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(19, 13);
            this.lbCountDown.TabIndex = 11;
            this.lbCountDown.Text = "00";
            // 
            // lblCountDownXY
            // 
            this.lblCountDownXY.AutoSize = true;
            this.lblCountDownXY.Location = new System.Drawing.Point(350, 115);
            this.lblCountDownXY.Name = "lblCountDownXY";
            this.lblCountDownXY.Size = new System.Drawing.Size(54, 13);
            this.lblCountDownXY.TabIndex = 10;
            this.lblCountDownXY.Text = "(0,0) (0x0)";
            // 
            // picCountDown
            // 
            this.picCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCountDown.Location = new System.Drawing.Point(135, 45);
            this.picCountDown.Name = "picCountDown";
            this.picCountDown.Size = new System.Drawing.Size(60, 60);
            this.picCountDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCountDown.TabIndex = 9;
            this.picCountDown.TabStop = false;
            // 
            // btnCountDownYDec
            // 
            this.btnCountDownYDec.Location = new System.Drawing.Point(168, 19);
            this.btnCountDownYDec.Name = "btnCountDownYDec";
            this.btnCountDownYDec.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownYDec.TabIndex = 8;
            this.btnCountDownYDec.Text = "-";
            this.btnCountDownYDec.UseVisualStyleBackColor = true;
            this.btnCountDownYDec.Click += new System.EventHandler(this.BtnCountDownYDec_Click);
            // 
            // btnCountDownXDec
            // 
            this.btnCountDownXDec.Location = new System.Drawing.Point(109, 78);
            this.btnCountDownXDec.Name = "btnCountDownXDec";
            this.btnCountDownXDec.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownXDec.TabIndex = 7;
            this.btnCountDownXDec.Text = "-";
            this.btnCountDownXDec.UseVisualStyleBackColor = true;
            this.btnCountDownXDec.Click += new System.EventHandler(this.BtnCountDownXDec_Click);
            // 
            // btnCountDownYInc
            // 
            this.btnCountDownYInc.Location = new System.Drawing.Point(168, 111);
            this.btnCountDownYInc.Name = "btnCountDownYInc";
            this.btnCountDownYInc.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownYInc.TabIndex = 6;
            this.btnCountDownYInc.Text = "+";
            this.btnCountDownYInc.UseVisualStyleBackColor = true;
            this.btnCountDownYInc.Click += new System.EventHandler(this.BtnCountDownYInc_Click);
            // 
            // btnCountDownRight
            // 
            this.btnCountDownRight.Location = new System.Drawing.Point(201, 52);
            this.btnCountDownRight.Name = "btnCountDownRight";
            this.btnCountDownRight.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownRight.TabIndex = 5;
            this.btnCountDownRight.Text = "→";
            this.btnCountDownRight.UseVisualStyleBackColor = true;
            this.btnCountDownRight.Click += new System.EventHandler(this.BtnCountDownRight_Click);
            // 
            // btnCountDownXInc
            // 
            this.btnCountDownXInc.Location = new System.Drawing.Point(201, 78);
            this.btnCountDownXInc.Name = "btnCountDownXInc";
            this.btnCountDownXInc.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownXInc.TabIndex = 4;
            this.btnCountDownXInc.Text = "+";
            this.btnCountDownXInc.UseVisualStyleBackColor = true;
            this.btnCountDownXInc.Click += new System.EventHandler(this.BtnCountDownXInc_Click);
            // 
            // btnCountDownLeft
            // 
            this.btnCountDownLeft.Location = new System.Drawing.Point(109, 52);
            this.btnCountDownLeft.Name = "btnCountDownLeft";
            this.btnCountDownLeft.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownLeft.TabIndex = 3;
            this.btnCountDownLeft.Text = "←";
            this.btnCountDownLeft.UseVisualStyleBackColor = true;
            this.btnCountDownLeft.Click += new System.EventHandler(this.BtnCountDownLeft_Click);
            // 
            // btnCountDownUp
            // 
            this.btnCountDownUp.Location = new System.Drawing.Point(142, 19);
            this.btnCountDownUp.Name = "btnCountDownUp";
            this.btnCountDownUp.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownUp.TabIndex = 2;
            this.btnCountDownUp.Text = "↑";
            this.btnCountDownUp.UseVisualStyleBackColor = true;
            this.btnCountDownUp.Click += new System.EventHandler(this.BtnCountDownUp_Click);
            // 
            // btnCountDownDown
            // 
            this.btnCountDownDown.Location = new System.Drawing.Point(142, 111);
            this.btnCountDownDown.Name = "btnCountDownDown";
            this.btnCountDownDown.Size = new System.Drawing.Size(20, 20);
            this.btnCountDownDown.TabIndex = 1;
            this.btnCountDownDown.Text = "↓";
            this.btnCountDownDown.UseVisualStyleBackColor = true;
            this.btnCountDownDown.Click += new System.EventHandler(this.BtnCountDownDown_Click);
            // 
            // btnSetCountDown
            // 
            this.btnSetCountDown.Location = new System.Drawing.Point(347, 82);
            this.btnSetCountDown.Name = "btnSetCountDown";
            this.btnSetCountDown.Size = new System.Drawing.Size(107, 23);
            this.btnSetCountDown.TabIndex = 0;
            this.btnSetCountDown.Text = "ตั้งค่านับถอยหลัง";
            this.btnSetCountDown.UseVisualStyleBackColor = true;
            this.btnSetCountDown.Click += new System.EventHandler(this.BtnSetCountDown_Click);
            // 
            // picCountDown2
            // 
            this.picCountDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCountDown2.Location = new System.Drawing.Point(3, 3);
            this.picCountDown2.Name = "picCountDown2";
            this.picCountDown2.Size = new System.Drawing.Size(66, 53);
            this.picCountDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCountDown2.TabIndex = 21;
            this.picCountDown2.TabStop = false;
            // 
            // picBitmap
            // 
            this.picBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBitmap.Location = new System.Drawing.Point(147, 3);
            this.picBitmap.Name = "picBitmap";
            this.picBitmap.Size = new System.Drawing.Size(66, 53);
            this.picBitmap.TabIndex = 21;
            this.picBitmap.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultXY);
            this.groupBox2.Controls.Add(this.txtResultXCount);
            this.groupBox2.Controls.Add(this.txtResultYCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linklbShowTest);
            this.groupBox2.Controls.Add(this.btnSetResult);
            this.groupBox2.Controls.Add(this.picResult);
            this.groupBox2.Controls.Add(this.btnResultYDec);
            this.groupBox2.Controls.Add(this.btnResultYInc);
            this.groupBox2.Controls.Add(this.btnResultXDec);
            this.groupBox2.Controls.Add(this.btnResultDown);
            this.groupBox2.Controls.Add(this.btnResultUp);
            this.groupBox2.Controls.Add(this.btnResultRight);
            this.groupBox2.Controls.Add(this.btnResultLeft);
            this.groupBox2.Controls.Add(this.btnResultXInc);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ผลลัพธ์";
            // 
            // lblResultXY
            // 
            this.lblResultXY.AutoSize = true;
            this.lblResultXY.Location = new System.Drawing.Point(350, 153);
            this.lblResultXY.Name = "lblResultXY";
            this.lblResultXY.Size = new System.Drawing.Size(54, 13);
            this.lblResultXY.TabIndex = 12;
            this.lblResultXY.Text = "(0,0) (0x0)";
            // 
            // txtResultXCount
            // 
            this.txtResultXCount.Location = new System.Drawing.Point(427, 36);
            this.txtResultXCount.Name = "txtResultXCount";
            this.txtResultXCount.Size = new System.Drawing.Size(27, 20);
            this.txtResultXCount.TabIndex = 10;
            this.txtResultXCount.Text = "12";
            this.txtResultXCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultYCount
            // 
            this.txtResultYCount.Location = new System.Drawing.Point(427, 66);
            this.txtResultYCount.Name = "txtResultYCount";
            this.txtResultYCount.Size = new System.Drawing.Size(27, 20);
            this.txtResultYCount.TabIndex = 11;
            this.txtResultYCount.Text = "6";
            this.txtResultYCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "จำนวนแถว Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "จำนวนแถว(ตั้ง) X";
            // 
            // linklbShowTest
            // 
            this.linklbShowTest.AutoSize = true;
            this.linklbShowTest.Location = new System.Drawing.Point(220, 153);
            this.linklbShowTest.Name = "linklbShowTest";
            this.linklbShowTest.Size = new System.Drawing.Size(71, 13);
            this.linklbShowTest.TabIndex = 17;
            this.linklbShowTest.TabStop = true;
            this.linklbShowTest.Text = "กดเพื่อทดลอง";
            this.linklbShowTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklbShowTest_LinkClicked);
            // 
            // btnSetResult
            // 
            this.btnSetResult.Location = new System.Drawing.Point(347, 120);
            this.btnSetResult.Name = "btnSetResult";
            this.btnSetResult.Size = new System.Drawing.Size(107, 23);
            this.btnSetResult.TabIndex = 10;
            this.btnSetResult.Text = "ตั้งผลลัพธ์";
            this.btnSetResult.UseVisualStyleBackColor = true;
            this.btnSetResult.Click += new System.EventHandler(this.BtnSetResult_Click);
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(67, 43);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(198, 100);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 10;
            this.picResult.TabStop = false;
            // 
            // btnResultYDec
            // 
            this.btnResultYDec.Location = new System.Drawing.Point(168, 17);
            this.btnResultYDec.Name = "btnResultYDec";
            this.btnResultYDec.Size = new System.Drawing.Size(20, 20);
            this.btnResultYDec.TabIndex = 16;
            this.btnResultYDec.Text = "-";
            this.btnResultYDec.UseVisualStyleBackColor = true;
            this.btnResultYDec.Click += new System.EventHandler(this.BtnResultYDec_Click);
            // 
            // btnResultYInc
            // 
            this.btnResultYInc.Location = new System.Drawing.Point(168, 149);
            this.btnResultYInc.Name = "btnResultYInc";
            this.btnResultYInc.Size = new System.Drawing.Size(20, 20);
            this.btnResultYInc.TabIndex = 14;
            this.btnResultYInc.Text = "+";
            this.btnResultYInc.UseVisualStyleBackColor = true;
            this.btnResultYInc.Click += new System.EventHandler(this.BtnResultYInc_Click);
            // 
            // btnResultXDec
            // 
            this.btnResultXDec.Location = new System.Drawing.Point(41, 95);
            this.btnResultXDec.Name = "btnResultXDec";
            this.btnResultXDec.Size = new System.Drawing.Size(20, 20);
            this.btnResultXDec.TabIndex = 15;
            this.btnResultXDec.Text = "-";
            this.btnResultXDec.UseVisualStyleBackColor = true;
            this.btnResultXDec.Click += new System.EventHandler(this.BtnResultXDec_Click);
            // 
            // btnResultDown
            // 
            this.btnResultDown.Location = new System.Drawing.Point(142, 149);
            this.btnResultDown.Name = "btnResultDown";
            this.btnResultDown.Size = new System.Drawing.Size(20, 20);
            this.btnResultDown.TabIndex = 9;
            this.btnResultDown.Text = "↓";
            this.btnResultDown.UseVisualStyleBackColor = true;
            this.btnResultDown.Click += new System.EventHandler(this.BtnResultDown_Click);
            // 
            // btnResultUp
            // 
            this.btnResultUp.Location = new System.Drawing.Point(142, 17);
            this.btnResultUp.Name = "btnResultUp";
            this.btnResultUp.Size = new System.Drawing.Size(20, 20);
            this.btnResultUp.TabIndex = 10;
            this.btnResultUp.Text = "↑";
            this.btnResultUp.UseVisualStyleBackColor = true;
            this.btnResultUp.Click += new System.EventHandler(this.BtnResultUp_Click);
            // 
            // btnResultRight
            // 
            this.btnResultRight.Location = new System.Drawing.Point(271, 69);
            this.btnResultRight.Name = "btnResultRight";
            this.btnResultRight.Size = new System.Drawing.Size(20, 20);
            this.btnResultRight.TabIndex = 13;
            this.btnResultRight.Text = "→";
            this.btnResultRight.UseVisualStyleBackColor = true;
            this.btnResultRight.Click += new System.EventHandler(this.BtnResultRight_Click);
            // 
            // btnResultLeft
            // 
            this.btnResultLeft.Location = new System.Drawing.Point(41, 69);
            this.btnResultLeft.Name = "btnResultLeft";
            this.btnResultLeft.Size = new System.Drawing.Size(20, 20);
            this.btnResultLeft.TabIndex = 11;
            this.btnResultLeft.Text = "←";
            this.btnResultLeft.UseVisualStyleBackColor = true;
            this.btnResultLeft.Click += new System.EventHandler(this.BtnResultLeft_Click);
            // 
            // btnResultXInc
            // 
            this.btnResultXInc.Location = new System.Drawing.Point(271, 95);
            this.btnResultXInc.Name = "btnResultXInc";
            this.btnResultXInc.Size = new System.Drawing.Size(20, 20);
            this.btnResultXInc.TabIndex = 12;
            this.btnResultXInc.Text = "+";
            this.btnResultXInc.UseVisualStyleBackColor = true;
            this.btnResultXInc.Click += new System.EventHandler(this.BtnResultXInc_Click);
            // 
            // picResult2
            // 
            this.picResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult2.Location = new System.Drawing.Point(75, 3);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(66, 53);
            this.picResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult2.TabIndex = 20;
            this.picResult2.TabStop = false;
            // 
            // tmCatcher
            // 
            this.tmCatcher.Interval = 10;
            this.tmCatcher.Tick += new System.EventHandler(this.TmCatcher_Tick);
            // 
            // tmResult
            // 
            this.tmResult.Interval = 10;
            this.tmResult.Tick += new System.EventHandler(this.TmResult_Tick);
            // 
            // tmCount
            // 
            this.tmCount.Interval = 10;
            this.tmCount.Tick += new System.EventHandler(this.TmCount_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ผลลัพธ์แบบ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 179);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 179);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvCurrentResultImg
            // 
            this.dgvCurrentResultImg.AllowUserToAddRows = false;
            this.dgvCurrentResultImg.AllowUserToDeleteRows = false;
            this.dgvCurrentResultImg.AllowUserToResizeColumns = false;
            this.dgvCurrentResultImg.AllowUserToResizeRows = false;
            this.dgvCurrentResultImg.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvCurrentResultImg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurrentResultImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentResultImg.ColumnHeadersVisible = false;
            this.dgvCurrentResultImg.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCurrentResultImg.Location = new System.Drawing.Point(3, 62);
            this.dgvCurrentResultImg.Name = "dgvCurrentResultImg";
            this.dgvCurrentResultImg.ReadOnly = true;
            this.dgvCurrentResultImg.RowHeadersVisible = false;
            this.dgvCurrentResultImg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCurrentResultImg.Size = new System.Drawing.Size(448, 179);
            this.dgvCurrentResultImg.TabIndex = 1;
            // 
            // tmRealtimeResult
            // 
            this.tmRealtimeResult.Interval = 10;
            this.tmRealtimeResult.Tick += new System.EventHandler(this.TmRealtimeResult_Tick);
            // 
            // tmRealtimeCount
            // 
            this.tmRealtimeCount.Interval = 10;
            this.tmRealtimeCount.Tick += new System.EventHandler(this.TmRealtimeCount_Tick);
            // 
            // panelHideObjects
            // 
            this.panelHideObjects.Controls.Add(this.picResult2);
            this.panelHideObjects.Controls.Add(this.picBitmap);
            this.panelHideObjects.Controls.Add(this.listView1);
            this.panelHideObjects.Controls.Add(this.txtScrore);
            this.panelHideObjects.Controls.Add(this.picCountDown2);
            this.panelHideObjects.Controls.Add(this.dgvCurrentResultImg);
            this.panelHideObjects.Location = new System.Drawing.Point(478, 12);
            this.panelHideObjects.Name = "panelHideObjects";
            this.panelHideObjects.Size = new System.Drawing.Size(541, 597);
            this.panelHideObjects.TabIndex = 5;
            this.panelHideObjects.Visible = false;
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 247);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 237);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // txtScrore
            // 
            this.txtScrore.Location = new System.Drawing.Point(269, 247);
            this.txtScrore.Multiline = true;
            this.txtScrore.Name = "txtScrore";
            this.txtScrore.Size = new System.Drawing.Size(260, 327);
            this.txtScrore.TabIndex = 23;
            // 
            // tmStart
            // 
            this.tmStart.Tick += new System.EventHandler(this.TmStart_Tick);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 586);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(460, 23);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "เริ่ม";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // lbScrore
            // 
            this.lbScrore.AutoSize = true;
            this.lbScrore.Location = new System.Drawing.Point(15, 562);
            this.lbScrore.Name = "lbScrore";
            this.lbScrore.Size = new System.Drawing.Size(245, 13);
            this.lbScrore.TabIndex = 7;
            this.lbScrore.Text = "Player:    Banker:    Tie:    Empty:    All:    LastWin: ";
            // 
            // tmScore
            // 
            this.tmScore.Tick += new System.EventHandler(this.TmScore_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(372, 556);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 24;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name: ";
            // 
            // tmReadStatus
            // 
            this.tmReadStatus.Interval = 10;
            this.tmReadStatus.Tick += new System.EventHandler(this.TmReadStatus_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbScrore);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.panelHideObjects);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 660);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Baccarat Score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLayoutSettingEditor_FormClosed);
            this.Load += new System.EventHandler(this.FrmLayoutSettingEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBitmap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentResultImg)).EndInit();
            this.panelHideObjects.ResumeLayout(false);
            this.panelHideObjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCountDown;
        private System.Windows.Forms.Button btnCountDownYDec;
        private System.Windows.Forms.Button btnCountDownXDec;
        private System.Windows.Forms.Button btnCountDownYInc;
        private System.Windows.Forms.Button btnCountDownRight;
        private System.Windows.Forms.Button btnCountDownXInc;
        private System.Windows.Forms.Button btnCountDownLeft;
        private System.Windows.Forms.Button btnCountDownUp;
        private System.Windows.Forms.Button btnCountDownDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultXCount;
        private System.Windows.Forms.TextBox txtResultYCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklbShowTest;
        private System.Windows.Forms.Button btnSetResult;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnResultYDec;
        private System.Windows.Forms.Button btnResultYInc;
        private System.Windows.Forms.Button btnResultXDec;
        private System.Windows.Forms.Button btnResultDown;
        private System.Windows.Forms.Button btnResultUp;
        private System.Windows.Forms.Button btnResultRight;
        private System.Windows.Forms.Button btnResultLeft;
        private System.Windows.Forms.Button btnResultXInc;
        private System.Windows.Forms.Label lblCountDownXY;
        private System.Windows.Forms.Label lblResultXY;
        public System.Windows.Forms.Button btnSetCountDown;
        private System.Windows.Forms.Timer tmCatcher;
        private System.Windows.Forms.Timer tmResult;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Timer tmCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCurrentResultImg;
        private System.Windows.Forms.Timer tmRealtimeResult;
        private System.Windows.Forms.TextBox txtImageSec;
        private System.Windows.Forms.PictureBox picResult2;
        private System.Windows.Forms.PictureBox picBitmap;
        private System.Windows.Forms.Timer tmRealtimeCount;
        private System.Windows.Forms.PictureBox picCountDown2;
        private System.Windows.Forms.Panel panelHideObjects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbScrore;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer tmScore;
        private System.Windows.Forms.TextBox txtScrore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmReadStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label5;
    }
}

