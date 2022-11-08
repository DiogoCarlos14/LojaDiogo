using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDiogo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CenterOfMenuPane();
            label1.Text = Form1.utilizador;

        }
        private Point CenterOfMenuPanel<T>(T control, int height = 0) where T : Control
        {
            Point center = new Point(
                label1.Size.Width / 2 - control.Width * 2,
                height != 0 ? height : label1.Size.Height / 2 - control.Height / 2);

            return center;
        }

    }
}
