using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesignCilios
{
    public partial class FormCliente : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; User Id=root; database=designcilios; password=usbw; charset=utf8");
        
        public FormCliente()
        {
            InitializeComponent();
        }

        private bool abreConexao()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //Erro --> TRATAMENTO
                MessageBox.Show("VUSH! NÃO ABRIU RAPÁ. \n Veja o que aconteceu: " + ex.Message, "IIIIIIIIIHHHHHH");
                return false;
            }
        }

        private bool fechaConexao()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //Erro --> TRATAMENTO
                MessageBox.Show("Conexão com o banco de dados não foi fechada corretamente. \n Veja o que aconteceu: " + ex.Message, "IIIIIIIIIHHHHHH");
                return false;
            }
        }

        //Popula data grid view
        public void populaGrid()
        {
            string query = "SELECT cliente.cli_nome as Nome, cliente.cli_cpf as CPF, cliente.cli_insta as Insta, cliente.cli_facebook as Face, cliente.cli_telefone as Telefone, endereco.end_logradouro as Endereco, endereco.end_bairro as Bairro, cliente.cli_numero_cas as Numero, cliente.cli_complemento as Complemento, endereco.end_cep as CEP FROM cliente, endereco WHERE cliente.cli_endereco = endereco.end_id;";
            if (abreConexao() == true)
            {
                try
                {
                    MySqlCommand objCmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCmd);
                    DataTable dtLista = new DataTable();
                    objAdp.Fill(dtLista);
                    dtgClientes.DataSource = dtLista;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Erro! Não conectado");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            populaGrid();
        }

        //Remove celular selecionada
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM cliente WHERE cli_cpf='"+dtgClientes.SelectedRows[0].Cells[1].Value.ToString()+"'";
            if (abreConexao() == true)
            {
                try
                {
                    if(MessageBox.Show("Você realmente deseja excluir o cliente do sistema?", "Remover" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                       MySqlCommand objCmd = new MySqlCommand(query, connection);
                       objCmd.ExecuteNonQuery();
                        MessageBox.Show("Remoção feita!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    fechaConexao();
                    populaGrid();
                }
            }
            else
            {
                MessageBox.Show("Erro! Não conectado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

                  }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            FormAtualizaCliente frm = new FormAtualizaCliente(dtgClientes.CurrentRow);
            frm.Show();
            populaGrid();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //Sera gerado um relatorio com todas as infos do cliente
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("Dados do cliente", font, PdfSharp.Drawing.XBrushes.Blue, new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height));
                textFormatter.DrawString("Nome: "+ dtgClientes.SelectedRows[0].Cells[0].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 30, page.Width, page.Height));
                textFormatter.DrawString("CPF: " + dtgClientes.SelectedRows[0].Cells[1].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 60, page.Width, page.Height));
                textFormatter.DrawString("Insta: " + dtgClientes.SelectedRows[0].Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 90, page.Width, page.Height));
                textFormatter.DrawString("Face: " + dtgClientes.SelectedRows[0].Cells[3].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 120, page.Width, page.Height));
                textFormatter.DrawString("Telefone: " + dtgClientes.SelectedRows[0].Cells[4].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 150, page.Width, page.Height));
                textFormatter.DrawString("Endereço: " + dtgClientes.SelectedRows[0].Cells[5].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 180, page.Width, page.Height));
                textFormatter.DrawString("-  " + dtgClientes.SelectedRows[0].Cells[7].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(275, 180, page.Width, page.Height));


                doc.Save("arquivo.pdf");
                System.Diagnostics.Process.Start("arquivo.pdf");
            }
        }
    }
}
