using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignCilios
{
    public partial class FormAtualizaCliente : Form
    {
        public FormAtualizaCliente(DataGridViewRow linha)
        {
            InitializeComponent();
            txtNome.Text = linha.Cells[0].Value.ToString();
            txtInsta.Text = linha.Cells[2].Value.ToString();
            txtCPF.Text = linha.Cells[1].Value.ToString();
            txtFace.Text = linha.Cells[3].Value.ToString();
            txtCel.Text = linha.Cells[4].Value.ToString();
            txtNum.Text = linha.Cells[7].Value.ToString();
            txtRua.Text = linha.Cells[5].Value.ToString();
            txtBairro.Text = linha.Cells[6].Value.ToString();
            txtComp.Text = linha.Cells[8].Value.ToString();
            txtCEP.Text = linha.Cells[9].Value.ToString();
        }
        DB banco = new DB();

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE cliente SET cli_facebook='"+txtFace.Text+"',cli_insta='"+txtInsta.Text + "', cli_telefone='"+txtCel.Text + "', cli_endereco=(SELECT end_id from endereco where end_cep='"+txtCEP.Text+"' limit 1) where cli_cpf='"+txtCPF.Text+"';";
            if (banco.inserirCliente(query))
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Alguma coisa deu errado. Tente novamente");
            }
        }

        private void FormAtualizaCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
