using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LojaDiogo
{
    public partial class Form6 : Form
    {
        private const int MaxAvarias = 200;
        private readonly Avarias[] avarias;
        private int num_avarias;
        public Form6()
        {
            avarias = new Avarias[MaxAvarias];
            num_avarias = 0;
            InitializeComponent();
        }

        private void Limpar()
        {
            txtCodigo.ResetText();
            dtData.Value = DateTime.Now;
            txtNome.ResetText();
            txtTelefone.ResetText();
            txtEmail.ResetText();
            cbAvaria.SelectedIndex = -1;
            chkGarantia.Checked = false;
            txtCodigo.Focus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cbAvaria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvaria.Items.Clear();
            cbAvaria.Items.Add("Não Liga");
            cbAvaria.Items.Add("Bloqueia");
            cbAvaria.Items.Add("Ecrã com defeito");
            cbAvaria.Items.Add("Teclado com defeito");
            cbAvaria.Items.Add("Software com erros");
            cbAvaria.Items.Add("Não lê cartão de memória");
            cbAvaria.Items.Add("Não lê cartão SIM");
            cbAvaria.Items.Add("Desliga-se");
            cbAvaria.Items.Add("Não carrega");
            cbAvaria.SelectedIndex = -1;

            //definir as propriedades do datagridview
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.AllowUserToResizeRows = false;
            grelha.ColumnCount = 6;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[1].Name = "Data";
            grelha.Columns[2].Name = "Cliente";
            grelha.Columns[3].Name = "Contacto";
            grelha.Columns[4].Name = "Descrição";
            grelha.Columns[5].Name = "Garantia";
            grelha.Columns[0].Width = 100;
            grelha.Columns[1].Width = 100;
            grelha.Columns[2].Width = 300;
            grelha.Columns[3].Width = 150;
            grelha.Columns[4].Width = 350;
            grelha.Columns[5].Width = 50;
            grelha.Rows.Clear();
            Limpar();
            statusMsg.Text = String.Empty;
        }
    }
}
