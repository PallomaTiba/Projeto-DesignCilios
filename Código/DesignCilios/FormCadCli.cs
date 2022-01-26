using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data;

using MySql.Data.MySqlClient;

namespace DesignCilios
{
    public partial class FormCadCli : Form
    {
        // MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; User Id=root; database=designcilios; password=usbw; charset=utf8");
        DB banco = new DB();
        public void estabeleceConexao()
        {
            
        }

        public FormCadCli()
        {
            InitializeComponent();
        }

               
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM endereco WHERE end_cep='" + txtCEP.Text + "'";
            try
            {
                if (banco.selectBanco(query))
                {
                    txtRua.Text = banco.endereco;
                    txtCidade.Text = banco.cidade;
                    txtBairro.Text = banco.bairro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro aconteceu: " + ex.Message);
            }
        }
            
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cliente(cli_nome, cli_cpf, cli_insta, cli_facebook, cli_telefone, cli_numero_cas, cli_complemento, cli_data_cadastro, cli_endereco) values ('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtInsta.Text + "','" + txtFace.Text + "','" + txtCel.Text + "','" + txtNum.Text + "','" + txtComp.Text + "','" + dateCadastro.Value.ToString("yyyy-MM-dd") + "',(SELECT end_id FROM endereco WHERE end_cep='" + txtCEP.Text + "'));";
            if (banco.inserirCliente(query))
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
                txtNome.Text = "";
                txtCPF.Text = "";
                txtCEP.Text = "";
                txtInsta.Text = "";
                txtFace.Text = "";
                txtNum.Text = "";
                txtComp.Text = "";
                txtBairro.Text = "";
                txtCel.Text = "";
                txtRua.Text = "";
                txtCidade.Text = "";
            }
            else
            {
                MessageBox.Show("Alguma coisa deu errado. Tente novamente");
            }
            
        }

        private void FormCadCli_Load(object sender, EventArgs e)
        {
            dateCadastro.Format = DateTimePickerFormat.Custom;
            dateCadastro.CustomFormat = "yyyy-MM-dd";
        }
    }
}
