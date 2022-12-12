using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaDiogo
{
    public partial class Form5 : Form
    {
        //declarar um vetor para armazenar os registos
        private const int MaxCategorias = 100;
        private readonly Categorias[] categorias;

        //declarar um contador de registos
        private int num_categorias;

        public Form5()
        {
            //criar e inicializar o vetor
            categorias = new Categorias[MaxCategorias];
            num_categorias = 0;

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //configurar o datagrridview
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Name = "Categoria";
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Name = "Zona";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Name = "Fila";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Prateleira";
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Rows.Clear();

            Limpar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtCodigo.ResetText();
        }

        private void Limpar()
        {
            txtCodigo.ResetText();
            txtCategoria.ResetText();
            txtFila.ResetText();
            txtParteleira.ResetText();
            txtZona.ResetText();

            txtCodigo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //verificar se os dados sao validos
            int x;
            double y;
            try
            {
                //verificar se o codigo é inteiro
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(txtCodigo.Text) < 100)
                {
                   txtCodigo.Focus();
                    throw new Exception("Insira um codigo com 3 ou mais digitos.");
                }

                //verificar se é uma descrição válida
                if (txtCategoria.Text.Equals("") ||
                    txtCategoria.Text.Length < 3 ||
                    txtCategoria.Text.Length > 50)
                {
                    txtCategoria.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                }

                if (txtZona.Text.Equals("") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "^[a-zA-Z]"))
                {
                    txtZona.Focus();
                    throw new Exception("Insira a Zona (letra A a Z).");
                }

                if (!int.TryParse(txtFila.Text, out x))
                {
                    txtFila.Focus();
                    throw new Exception("Insira um valor inteiro.");
                }
                else if (Convert.ToInt32(txtFila.Text) < 1 || Convert.ToInt32(txtFila.Text) > 100)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um valor para a fila de 1 a 100.");
                }

                if (!int.TryParse(txtParteleira.Text, out x))
                {
                    txtParteleira.Focus();
                    throw new Exception("Insira um valor inteiro.");
                }
                else if (Convert.ToInt32(txtParteleira.Text) < 1 || Convert.ToInt32(txtParteleira.Text) > 10)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um valor para a prateleira de 1 a 10.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(txtCodigo.Text, txtCategoria.Text, txtZona.Text, txtFila.Text, txtParteleira.Text);
            Limpar();
        
        }

        private int posLista = -1;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            posLista = dataGridView1.CurrentCell.RowIndex;
            if(posLista != -1)
            {
                txtCodigo.Text = dataGridView1.Rows[posLista].Cells[0].Value.ToString();
                txtCategoria.Text = dataGridView1.Rows[posLista].Cells[1].Value.ToString();
                txtZona.Text = dataGridView1.Rows[posLista].Cells[2].Value.ToString();
                txtFila.Text = dataGridView1.Rows[posLista].Cells[3].Value.ToString();
                txtParteleira.Text = dataGridView1.Rows[posLista].Cells[4].Value.ToString();
            }
        }
    }
}
