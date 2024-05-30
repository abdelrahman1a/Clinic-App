using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSystem
{
    public partial class CustomControlTextBox : TextBox
    {
        private Color _BottomBorderColor = Color.Black;
        private Color _OnFocusColor = Color.Blue;

        public CustomControlTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _BottomBorderColor,
            });

            InitializeComponent();
        }
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BottomBorderColor
        {
            get { return _BottomBorderColor; }
            set
            {
                _BottomBorderColor = value;
                Controls[0].BackColor = _BottomBorderColor;
            }
        }

        public Color BottomBorderOnFocusColor
        {
            get { return _OnFocusColor; }
            set
            {
                _OnFocusColor = value;
            }
        }

        private void CustomControlTextBox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _OnFocusColor;
        }

        private void CustomControlTextBox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _BottomBorderColor;

        }
    }
}
