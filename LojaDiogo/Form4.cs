using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            textBox1.Text = Form1.utilizador;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.desativarButtons();
     
            string nomelogin = "Login";
            Form1.utilizador = nomelogin;
            Form1 pobjForm = (Form1)this.MdiParent;
            pobjForm.MostrarLogin(Form1.utilizador);
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
