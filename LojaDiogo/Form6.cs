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
using System.Drawing.Text;

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

        private void tsAdicionar_Click(object sender, EventArgs e)
        {
            Limpar();
            statusMsg.Text = "Preparado para novo registo de avaria.";
        }

        private void tsAnular_Click(object sender, EventArgs e)
        {
            Limpar();
            statusMsg.Text = "Eliminado registo temporário de avaria.";
        }

        private void tsValidar_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código válido.");
                }
                else if (Convert.ToInt32(txtCodigo.Text) < 0)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código com valor positivo.");
                }

                if(txtNome.Text.Equals("") || 
                    txtNome.Text.Length < 3 || txtNome.Text.Length > 50)
                {
                    txtNome.Focus();
                    throw new Exception("INsira o Nome do cliente (3 a 50 caracteres).");
                }

                if(!int.TryParse(txtTelefone.Text, out x))
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um numero de telefone valido.");
                }
                else if (Convert.ToInt32(txtTelefone.Text)< 210000000)
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um numero de telefone valido");
                }

                if(cbAvaria.SelectedIndex == -1)
                {
                    throw new Exception("Escolha da lista uma tipologia de avaria.");
                }
            }
            catch (Exception ex)
            {
                statusMsg.Text = ex.Message;
                return;
            }

            grelha.Rows.Add(txtCodigo.Text.ToString(), dtData.Value.ToString(),
                txtNome.Text, txtTelefone.Text, cbAvaria.SelectedItem, chkGarantia.Checked ? "Sim" : "Não");

            int codigo = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtData.Value;
            string nome = txtNome.Text;
            long telefone = Convert.ToInt64(txtTelefone.Text);
            string email = txtEmail.Text;
            string avaria = cbAvaria.SelectedItem.ToString();
            bool garantia = chkGarantia.Checked;
            AdicionaAvaria(new Avarias(codigo, data, nome, telefone, email, avaria, garantia));

            statusMsg.Text = "Adicionado um novo registo de avaria.";
            Limpar();

        }
        private void AdicionaAvaria(Avarias av)
        {
            if (num_avarias < MaxAvarias)
                avarias[num_avarias++] = av;
        }

        private void tsGuardarSair_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\data";
                if(!Directory.Exists(target))
                {
                    DirectoryInfo di = Directory.CreateDirectory(target);
                }

                string caminho = target + "\\avarias.txt";
                Stream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                StreamWriter registo = new StreamWriter(ficheiro);

                for(int i = 0; i < num_avarias; i++)
                {
                    int codigo = avarias[i].getCodigo();
                    DateTime data = avarias[i].getData();
                    string nome = avarias[i].getNomeCliente();
                    long telefone = avarias[i].getTelefone();
                    string email = avarias[i].getEmail();
                    string avaria = avarias[i].getAvaria();
                    bool garantia = avarias[i].getGarantia();

                    registo.Write(codigo + ";");
                    registo.Write(data + ";");
                    registo.Write(nome + ";");
                    registo.Write(telefone + ";");
                    registo.Write(email + ";");
                    registo.Write(avaria + ";");
                    registo.Write(garantia + ";");
                    registo.Write(Environment.NewLine);

                }

                registo.Close();
                ficheiro.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
