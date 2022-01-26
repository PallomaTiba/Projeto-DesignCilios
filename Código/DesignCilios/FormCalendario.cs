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
    public partial class FormCalendario : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; User Id=root; database=designcilios; password=usbw; charset=utf8");

        public FormCalendario()
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

        public void populaGrid()
        {
            string query2 = "select distinct cliente.cli_nome as Nome, calendario.cal_data as Dia, calendario.cal_hora as Hora from calendario, cliente where cal_data = DATE_SUB(CURDATE(), INTERVAL 14 DAY) and cliente.cli_id = calendario.id_cliente;";
            string query = "select calendario.cal_data as Data , calendario.cal_hora as Hora, cliente.cli_nome as Nome from calendario, cliente where cal_data = '"+ calendarioMes.SelectionStart.ToString("yyyy-MM-dd") + "' and cliente.cli_id = calendario.id_cliente; ";
            if (abreConexao() == true)
            {
                try
                {
                    MySqlCommand objCmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCmd);
                    DataTable dtLista = new DataTable();
                    objAdp.Fill(dtLista);
                    dtgCliHoje.DataSource = dtLista;
                }
                catch (Exception ex)
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

            //Popula grid com manutenções da semana
            if (abreConexao() == true)
            {
                try
                {
                    MySqlCommand objCmd = new MySqlCommand(query2, connection);
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCmd);
                    DataTable dtLista2 = new DataTable();
                    objAdp.Fill(dtLista2);
                    dtgManutenSem.DataSource = dtLista2;
                }
                catch (Exception ex)
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

        private void btnAgendarCliente_Click_1(object sender, EventArgs e)
        {
            FormAgendarCli agendarcli = new FormAgendarCli();
            agendarcli.Show();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            string dataSel = calendarioMes.SelectionStart.ToString("yyyy-MM-dd");
            populaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "select calendario.cal_data as Data , calendario.cal_hora as Hora, cliente.cli_nome as Nome from calendario, cliente where cal_data = '" + calendarioMes.SelectionStart.ToString("yyyy-MM-dd") + "' and cliente.cli_id = calendario.id_cliente; ";
            if (abreConexao() == true)
            {
                try
                {
                    MySqlCommand objCmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCmd);
                    DataTable dtLista = new DataTable();
                    objAdp.Fill(dtLista);
                    dtgCliHoje.DataSource = dtLista;
                }
                catch (Exception ex)
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
    }
}
