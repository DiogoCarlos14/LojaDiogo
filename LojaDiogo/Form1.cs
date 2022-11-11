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
    public partial class Form1 : Form
    {
        public static string utilizador = null;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void MostrarLogin(string u)
        {
            if (u != null)
            {
                loginToolStripMenuItem.Text = utilizador;
            }
            else
            {
                loginToolStripMenuItem.Text = "Login";
            }
            
        }

        //LOGIN
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
            f3.Dock = DockStyle.Fill;

            if(loginToolStripMenuItem.Text != "Login")
            {
                f3.Close();
                //MessageBox.Show("Ja esta com login");
                //---------------------------------------------
                Form4 f4 = new Form4();
                f4.MdiParent = this;
                f4.Show();
                f4.Dock = DockStyle.Fill;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void desativarButtons()
        {
            ficheiroToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            vendasToolStripMenuItem.Enabled = false;
            reparaçõesToolStripMenuItem.Enabled = false;

            toolStrip1.Enabled = false;
        }

        private void ativarButtons()
        {
            ficheiroToolStripMenuItem.Enabled = true;
            produtosToolStripMenuItem.Enabled = true;
            vendasToolStripMenuItem.Enabled = true;
            reparaçõesToolStripMenuItem.Enabled = true;

            toolStrip1.Enabled = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            desativarButtons();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
            f2.Dock = DockStyle.Fill;
        }

        private void loginToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            if(loginToolStripMenuItem.Text != "Login")
            {
                ativarButtons();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
