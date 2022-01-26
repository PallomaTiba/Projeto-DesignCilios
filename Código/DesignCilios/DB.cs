using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace DesignCilios
{
    class DB
    {
        private MySqlConnection connection;

        public string cidade;
        public string bairro;
        public string endereco;
        public string cep;
        public List<String> tipo = new List<string>();
        public List<String> cliente = new List<string>();
        public List<String> modelo = new List<string>();
        
        public List<String> espessura1 = new List<string>();
        public List<String> espessura2 = new List<string>();
        public List<String> espessura3 = new List<string>();
        public List<String> espessura4 = new List<string>();
        public List<String> espessura5 = new List<string>();
        public List<String> espessura6 = new List<string>();
        public List<String> espessura7 = new List<string>();
        public List<String> espessura8 = new List<string>();
        
        public List<String> tamanho1 = new List<string>();
        public List<String> tamanho2 = new List<string>();
        public List<String> tamanho3 = new List<string>();
        public List<String> tamanho4 = new List<string>();
        public List<String> tamanho5 = new List<string>();
        public List<String> tamanho6 = new List<string>();
        public List<String> tamanho7 = new List<string>();
        public List<String> tamanho8 = new List<string>();

        public List<String> curvatura1 = new List<string>();
        public List<String> curvatura2 = new List<string>();
        public List<String> curvatura3 = new List<string>();
        public List<String> curvatura4 = new List<string>();
        public List<String> curvatura5 = new List<string>();
        public List<String> curvatura6 = new List<string>();
        public List<String> curvatura7 = new List<string>();
        public List<String> curvatura8 = new List<string>();

        public DB()
        {
            //string connectionString = "SERVER=" + host + ";" + "DATABASE=" + database + ";" +"UID=" + username + ";" +"PASSWORD=" + senha + ";";
            //Passo a conexão pra funçao de conexão
            connection = new MySqlConnection("server = localhost; port = 3307; User Id = root; database = designcilios; password = usbw; charset = utf8");
        }

        //Responsavel por abrir a conexao com o banco de dados
        public bool openConexao()
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
        
        //Responsavel por fechar a conexao com o Banco
        public bool fechaConexao()
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


        public bool selectBanco(string query){
                if (openConexao() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        //Esse trem vai conter as informações que foram retornadas pelo SGBD
                        MySqlDataReader data = cmd.ExecuteReader();
                        if (data.HasRows)
                        {
                            MessageBox.Show("Ok, entrou aqui");
                            data.Read();
                            cep = data["end_cep"].ToString();
                            endereco = data["end_logradouro"].ToString();
                            bairro = data["end_bairro"].ToString();
                            cidade = data["end_cidade"].ToString();
                            return true;
                        }
                        else
                        {
                        MessageBox.Show("CEP não encontrado");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro Select MySQL: " + ex.Message, "Erro");
                        return false;
                    }
                    finally
                    {
                        fechaConexao();
                    }
                }
                return false;
            }

        public bool inserirCliente(string query)
        {
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message, "Erro!");
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            return false;

        }

        public bool populaCombo1(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao()==true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cad.cmbTipo.Items.Clear();
                    while (reader.Read())
                    {
                        tipo.Add(reader["tipo_nome"].ToString());
                        
                    }
                    return true;
                }   
                catch(Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool populaCombo2(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cad.cmbModelo.Items.Clear();
                    while (reader.Read())
                    {
                        cliente.Add(reader.GetString("cli_nome"));
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool populaCombo3(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cad.cmbModelo.Items.Clear();
                    while (reader.Read())
                    {
                        modelo.Add(reader.GetString("model_nome"));
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool populaComboEsp(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        espessura1.Add(reader["espe_tam"].ToString());
                        espessura2.Add(reader["espe_tam"].ToString());
                        espessura3.Add(reader["espe_tam"].ToString());
                        espessura4.Add(reader["espe_tam"].ToString());
                        espessura5.Add(reader["espe_tam"].ToString());
                        espessura6.Add(reader["espe_tam"].ToString());
                        espessura7.Add(reader["espe_tam"].ToString());
                        espessura8.Add(reader["espe_tam"].ToString());
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool populaComboTam(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cad.cmbTipo.Items.Clear();
                    while (reader.Read())
                    {
                        tamanho1.Add(reader["tam_cilios"].ToString());
                        tamanho2.Add(reader["tam_cilios"].ToString());
                        tamanho3.Add(reader["tam_cilios"].ToString());
                        tamanho4.Add(reader["tam_cilios"].ToString());
                        tamanho5.Add(reader["tam_cilios"].ToString());
                        tamanho6.Add(reader["tam_cilios"].ToString());
                        tamanho7.Add(reader["tam_cilios"].ToString());
                        tamanho8.Add(reader["tam_cilios"].ToString());

                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool populaComboCurv(string query)
        {
            FormCadDesign cad = new FormCadDesign();
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cad.cmbTipo.Items.Clear();
                    while (reader.Read())
                    {
                        curvatura1.Add(reader["curv_tam"].ToString());
                        curvatura2.Add(reader["curv_tam"].ToString());
                        curvatura3.Add(reader["curv_tam"].ToString());
                        curvatura4.Add(reader["curv_tam"].ToString());
                        curvatura5.Add(reader["curv_tam"].ToString());
                        curvatura6.Add(reader["curv_tam"].ToString());
                        curvatura7.Add(reader["curv_tam"].ToString());
                        curvatura8.Add(reader["curv_tam"].ToString());

                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            else
            {
                MessageBox.Show("Deu erro na hora de conectar. Tente novamente");
            }
            return false;
        }

        public bool insereAgendamento(string query)
        {
            if (openConexao() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Deu erro: " + ex.Message, "Erro!");
                    return false;
                }
                finally
                {
                    fechaConexao();
                }
            }
            return false;

        }
    }
}
