using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDiogo
{
    public partial class Form1 : Form
    {
        public static string utilizador = null;
        public void desativarButtons()
        {
            ficheiroToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            vendasToolStripMenuItem.Enabled = false;
            reparaçõesToolStripMenuItem.Enabled = false;

            toolStrip1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------
       /*
        public class Taskbar
        {
            [DllImport("user32.dll")]
            private static extern int FindWindow(string className, string windowText);

            [DllImport("user32.dll")]
            private static extern int ShowWindow(int hwnd, int command);

            [DllImport("user32.dll")]
            public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

            [DllImport("user32.dll")]
            private static extern int GetDesktopWindow();

            private const int SW_HIDE = 0;
            private const int SW_SHOW = 1;


            protected static int Handle
            {
                get
                {
                    return FindWindow("Shell_TrayWnd", "");
                }
            }

            protected static int HandleOfStartButton
            {
                get
                {
                    int handleOfDesktop = GetDesktopWindow();
                    int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                    return handleOfStartButton;
                }
            }

            public static void ShowTask()
            {
               ShowWindow(Handle, SW_SHOW);
               ShowWindow(HandleOfStartButton, SW_SHOW);
            }
            public static void HideTask()
            {
                ShowWindow(Handle, SW_HIDE);
                ShowWindow(HandleOfStartButton, SW_HIDE);
            }
        }

        */
            //-----------------------------------------------------------------------------------------------------

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
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                f2.Dock = DockStyle.Fill;
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
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            desativarButtons();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void closeallforms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

        private void loginToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            if(loginToolStripMenuItem.Text != "Login")
            {
                ativarButtons();
            }
            else
            {
                closeallforms();
                desativarButtons();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
            f2.Dock = DockStyle.Fill;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
            f5.Dock = DockStyle.Fill;
        }
    }
}
