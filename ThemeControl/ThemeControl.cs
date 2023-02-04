using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeControl
{
    public partial class ThemeControl: UserControl
    {
        public int Red { get => tbred.Value; }
        public int Green { get => tbgreen.Value; }
        public int Blue { get => tbblue.Value; }
        public ThemeControl()
        {
            InitializeComponent();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
