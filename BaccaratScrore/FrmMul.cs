using System;
using System.Windows.Forms;

namespace BaccaratScrore
{
    public partial class FrmMul : Form
    {
        public FrmMul()
        {
            InitializeComponent();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            var frmMain = new FrmMain();
            frmMain.Text = frmMain.Text + @" "+ Variable._time;
                frmMain.Show();
                Variable._time++;
        }
    }
}
