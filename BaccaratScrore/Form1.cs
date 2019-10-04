using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaccaratScrore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CreatePanel();
        }

        #region ojb move

        #region Ojb Move
        private Point _mouseDownLocation;
        //SetMouseDown(e);
        public void SetMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
            }
        }

        //SetMouseMovePanel(e, panelx);
        public void SetMouseMovePanel(MouseEventArgs e, Panel panel)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel.Left = e.X + panel.Left - _mouseDownLocation.X;
                panel.Top = e.Y + panel.Top - _mouseDownLocation.Y;
            }
        }
        public void SetMouseMovePanel(MouseEventArgs e, GroupBox group)
        {
            if (e.Button == MouseButtons.Left)
            {
                group.Left = e.X + group.Left - _mouseDownLocation.X;
                group.Top = e.Y + group.Top - _mouseDownLocation.Y;
            }
        }

        #endregion

        #region Ojb Move upgrade
        // formload : SetMovable(move_obj2, move_obj2);
        public void SetMovable(Control ctrl, Panel panel)
        {
            ctrl.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                SetMouseDown(e);
            };
            ctrl.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                SetMouseMovePanel(e, panel);
            };
        }
        public void SetMovable(Control ctrl, GroupBox group)
        {
            ctrl.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                SetMouseDown(e);
            };
            ctrl.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                SetMouseMovePanel(e, group);
            };
        }
        #endregion

        #endregion

        private int _num;
        private void CreatePanel()
        {
            _num++;
            var myPanel = new Panel
            {
                BackColor = Color.Silver,
                Dock = DockStyle.Fill,
            };
            var myGroup = new GroupBox
            {
                Height = int.Parse(textBox1.Text)+19,
                Width = int.Parse(textBox2.Text)+6,
                Text = $@"Panel{_num}",
                Location = new Point(12, 41)
            };
            myGroup.Controls.Add(myPanel);
            Controls.Add(myGroup);
            SetMovable(myGroup, myGroup);
            //label1.Text = $@"panel({myPanel.Size}), group({myGroup.Size})";
        }

    }
}
