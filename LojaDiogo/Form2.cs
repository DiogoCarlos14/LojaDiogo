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
    public partial class Form2 : Form
    {

        //declarar um vetor para armazenar os registos
        private const int MaxProdutos = 100;
        private readonly Produtos[] produtos;

        //declarar um contador de registos
        private int num_produtos;

        public Form2()
        {
            //criar e inicializar o vetor 
            produtos = new Produtos[MaxProdutos];
            num_produtos = 0;

            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hardware");
            comboBox1.Items.Add("Software");
            comboBox1.SelectedIndex = -1;
        }

        private void Limpar()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Limpar();
            statusMgs.Text = "";
        }

        private void AdicionarProduto(Produtos p)
        {
            if(num_produtos < MaxProdutos)
            {
                produtos[num_produtos++] = p;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar se os dados sao validos
            int x;
            double y;
            try
            {
                //verificar se o codigo é inteiro
                if (!int.TryParse(textBox1.Text, out x))
                {
                    textBox1.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(textBox1.Text) < 100)
                {
                    textBox1.Focus();
                    throw new Exception("Insira um codigo com 3 ou mais digitos.");
                }

                //verificar se é uma descrição válida
                if(textBox2.Text.Equals("") ||
                    textBox2.Text.Length < 3 ||
                    textBox2.Text.Length > 50)
                {
                    textBox2.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                }

                //verificar categoria
                if(comboBox1.SelectedIndex == -1)
                {
                    throw new Exception("Escolha uma categoria");
                }

                //verificar se preco é double 
                if(!double.TryParse(textBox3.Text, out y))
                {
                    textBox3.Focus();
                    throw new Exception("Insira um preco numerico.");
                }
                else if (Convert.ToDouble(textBox3.Text) <= 0)
                {
                    textBox3.Focus();
                    throw new Exception("Insira em preco um valor superior a 0.");
                }

               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string linha = textBox1.Text + " | " + textBox2.Text + " | " +
                comboBox1.SelectedItem + " | " + textBox3.Text;

            listBox1.Items.Add(linha);

            statusMgs.Text = " Adicionado um novo produto. ";
            Limpar();
        }
    }
}
