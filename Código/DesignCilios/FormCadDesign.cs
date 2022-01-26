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
    public partial class FormCadDesign : Form
    {
        DB banco = new DB();

        public void populaCombo()
        {
            
            string query1 = "SELECT * FROM tipo";
            string query2 = "SELECT cli_id, cli_nome FROM cliente";
            string query3 = "SELECT * FROM modelo";
            string query4 = "SELECT * FROM tamanho";
            string query5 = "SELECT * FROM espessura";
            string query6 = "SELECT * FROM curvatura";

            if(banco.populaCombo1(query1)==false){
                MessageBox.Show("Problema aconteceu ao popular combo do tipo");
            }
            else
            {
                cmbTipo.DataSource = banco.tipo;
            }

            if(banco.populaCombo2(query2)==false){
                MessageBox.Show("Problema aconteceu ao popular combo do cliente");
            }
            else
            {
                cmbCliente.DataSource = banco.cliente;
            }

            if(banco.populaCombo3(query3)==false){
                MessageBox.Show("Problema aconteceu ao popular combo do modelo");
            }
            else
            {
                cmbModelo.DataSource = banco.modelo;
            }

            if (banco.populaComboEsp(query5) == false)
            {
                MessageBox.Show("Problema aconteceu ao popular combo do modelo");
            }
            else
            {
                cmbEspMaA.DataSource = banco.espessura1;
                cmbEspMaB.DataSource = banco.espessura2;
                cmbEspMaC.DataSource = banco.espessura3;
                cmbEspMaD.DataSource = banco.espessura4;
                cmbEspMiA.DataSource = banco.espessura5;
                cmbEspMiB.DataSource = banco.espessura6;
                cmbEspMiC.DataSource = banco.espessura7;
                cmbEspMiD.DataSource = banco.espessura8;
            }
            
            if (banco.populaComboTam(query4) == false)
            {
                MessageBox.Show("Problema aconteceu ao popular combo do modelo");
            }
            else
            {
                cmbTamMaA.DataSource = banco.tamanho1;
                cmbTamMaB.DataSource = banco.tamanho2;
                cmbTamMaC.DataSource = banco.tamanho3;
                cmbTamMaD.DataSource = banco.tamanho4;
                cmbTamMiA.DataSource = banco.tamanho5;
                cmbTamMiB.DataSource = banco.tamanho6;
                cmbTamMiC.DataSource = banco.tamanho7;
                cmbTamMiD.DataSource = banco.tamanho8;
            }

            if (banco.populaComboCurv(query6) == false)
            {
                MessageBox.Show("Problema aconteceu ao popular combo do modelo");
            }
            else
            {
                cmbCurMaA.DataSource = banco.curvatura1;
                cmbCurMaB.DataSource = banco.curvatura2;
                cmbCurMaC.DataSource = banco.curvatura3;
                cmbCurMaD.DataSource = banco.curvatura4;
                cmbCurMiA.DataSource = banco.curvatura5;
                cmbCurMiB.DataSource = banco.curvatura6;
                cmbCurMiC.DataSource = banco.curvatura7;
                cmbCurMiD.DataSource = banco.curvatura8;
            }


        }


        public FormCadDesign()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadDesign_Load(object sender, EventArgs e)
        {
            populaCombo();
        }

        //Cadastro de um novo design - FUNCIONANDO =D
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passa informações de cliente, tipo e modelo para string
            string cliente = cmbCliente.SelectedItem.ToString();
            string modelo = cmbModelo.SelectedItem.ToString();
            string tipo = cmbTipo.SelectedItem.ToString();


            //Passa para string os valores selecionados de tamanho em cada macro e micro reg
            string macregA_tam = cmbTamMaA.SelectedItem.ToString(); int mrA_tam = Convert.ToInt32(macregA_tam);
            string macregB_tam = cmbTamMaB.SelectedItem.ToString(); double mrB_tam = Convert.ToInt32(macregB_tam);
            string macregC_tam = cmbTamMaC.SelectedItem.ToString(); double mrC_tam = Convert.ToInt32(macregC_tam);
            string macregD_tam = cmbTamMaD.SelectedItem.ToString(); double mrD_tam = Convert.ToInt32(macregD_tam);
            string micregA_tam = cmbTamMaA.SelectedItem.ToString(); double miA_tam = Convert.ToInt32(micregA_tam);
            string micregB_tam = cmbTamMiB.SelectedItem.ToString(); double miB_tam = Convert.ToInt32(micregB_tam);
            string micregC_tam = cmbTamMiC.SelectedItem.ToString(); double miC_tam = Convert.ToInt32(micregC_tam);
            string micregD_tam = cmbTamMiD.SelectedItem.ToString(); double miD_tam = Convert.ToInt32(micregD_tam);

            //Passa para string os valores selecionados de espessura em cada macro e micro reg
            string macregA_esp = cmbEspMaA.SelectedItem.ToString(); //double mrA_esp = Convert.ToDouble(macregA_esp);
            string macregB_esp = cmbEspMaB.SelectedItem.ToString(); double mrB_esp = Convert.ToDouble(macregB_esp);
            string macregC_esp = cmbEspMaC.SelectedItem.ToString(); double mrC_esp = Convert.ToDouble(macregC_esp);
            string macregD_esp = cmbEspMaD.SelectedItem.ToString(); double mrD_esp = Convert.ToDouble(macregD_esp);
            string micregA_esp = cmbEspMaA.SelectedItem.ToString(); double miA_esp = Convert.ToDouble(micregA_esp);
            string micregB_esp = cmbEspMiB.SelectedItem.ToString(); double miB_esp = Convert.ToDouble(micregB_esp);
            string micregC_esp = cmbEspMiC.SelectedItem.ToString(); double miC_esp = Convert.ToDouble(micregC_esp);
            string micregD_esp = cmbEspMiD.SelectedItem.ToString(); double miD_esp = Convert.ToDouble(micregD_esp);

            //Passa para string os valores selecionados de curvatura em cada macro e micro reg
            string macregA_cur = cmbCurMaA.SelectedItem.ToString();
            string macregB_cur = cmbCurMaB.SelectedItem.ToString();
            string macregC_cur = cmbCurMaC.SelectedItem.ToString();
            string macregD_cur = cmbCurMaD.SelectedItem.ToString();
            string micregA_cur = cmbCurMaA.SelectedItem.ToString();
            string micregB_cur = cmbCurMiB.SelectedItem.ToString();
            string micregC_cur = cmbCurMiC.SelectedItem.ToString();
            string micregD_cur = cmbCurMiD.SelectedItem.ToString();

            MessageBox.Show("Valor de espessura: "+micregA_esp);

            //Strings de inserção
            string macregA = "INSERT INTO macrorega(mra_tam, mra_esp, mra_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + mrA_tam + "), (SELECT espe_id from espessura where espe_tam='" + macregA_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + macregA_cur + "'));";
            string macregB = "INSERT INTO macroregb(mrb_tam, mrb_esp, mrb_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + mrB_tam + "), (SELECT espe_id from espessura where espe_tam='" + macregB_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + macregB_cur + "'));";
            string macregC = "INSERT INTO macroregc(mrc_tam, mrc_esp, mrc_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + mrC_tam + "), (SELECT espe_id from espessura where espe_tam='" + macregC_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + macregC_cur + "'));";
            string macregD = "INSERT INTO macroregd(mrd_tam, mrd_esp, mrd_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + mrD_tam + "), (SELECT espe_id from espessura where espe_tam='" + macregD_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + macregD_cur + "'));";
            string micregA = "INSERT INTO microrega(mia_tam, mia_esp, mia_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + miA_tam + "), (SELECT espe_id from espessura where espe_tam='" + micregA_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + micregA_cur + "'));";
            string micregB = "INSERT INTO microregb(mib_tam, mib_esp, mib_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + miB_tam + "), (SELECT espe_id from espessura where espe_tam='" + micregB_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + micregB_cur + "'));";
            string micregC = "INSERT INTO microregc(mic_tam, mic_esp, mic_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + miC_tam + "), (SELECT espe_id from espessura where espe_tam='" + micregC_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + micregC_cur + "'));";
            string micregD = "INSERT INTO microregd(mid_tam, mid_esp, mid_cur) values ((SELECT tam_id from tamanho where tam_cilios=" + miD_tam + "), (SELECT espe_id from espessura where espe_tam='" + macregD_esp + "'), (SELECT curv_id from curvatura where curv_tam='" + micregD_cur + "'));" ;


            //Insere no banco as macro regiões
            if (banco.insereAgendamento(macregA) == true && banco.insereAgendamento(macregB) == true && banco.insereAgendamento(macregC) == true && banco.insereAgendamento(macregD) == true)
            {
                MessageBox.Show("Todas as macroregiões foram inseridas com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro em inserção");
            }

            //Insere no banco as micro regiões
            if (banco.insereAgendamento(micregA) == true && banco.insereAgendamento(micregB) == true && banco.insereAgendamento(micregC) == true && banco.insereAgendamento(micregD) == true)
            {
               MessageBox.Show("Todas as macroregiões foram inseridas com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro em inserção");
            }

            //String com o id das ultimas inserções realizadas
            string idmaA = "(SELECT mra_id FROM macrorega  ORDER BY mra_id DESC LIMIT 1)";
            string idmaB = "(SELECT mrb_id FROM macroregb  ORDER BY mrb_id DESC LIMIT 1)";
            string idmaC = "(SELECT mrc_id FROM macroregc  ORDER BY mrc_id DESC LIMIT 1)";
            string idmaD = "(SELECT mrd_id FROM macroregd  ORDER BY mrd_id DESC LIMIT 1)";
            string idmiA = "(SELECT mia_id FROM microrega  ORDER BY mia_id DESC LIMIT 1)";
            string idmiB = "(SELECT mib_id FROM microregb  ORDER BY mib_id DESC LIMIT 1)";
            string idmiC = "(SELECT mic_id FROM microregc  ORDER BY mic_id DESC LIMIT 1)";
            string idmiD = "(SELECT mid_id FROM microregd  ORDER BY mid_id DESC LIMIT 1)";

            string queryfinal = "INSERT INTO design(des_cli, des_tipo, des_model, des_macA, des_macB, des_macC, des_macD, des_micA, des_micB, des_micC, des_micD, des_anotacoes) values ((SELECT cli_id from cliente where cli_nome='" + cliente + "'),(SELECT tipo_id from tipo where tipo_nome='"+ tipo +"'),(SELECT model_id from modelo where model_nome='" + modelo + "')," + idmaA +"," + idmaB + "," + idmaC + "," + idmaD + "," + idmiA + "," + idmiB + "," + idmiC + "," + idmiD + ",'" + txtAnotacoes.Text+"');";

            if (banco.insereAgendamento(queryfinal) == true)
            {
                MessageBox.Show("SHOW!! DESIGN CADASTRO!!");
            }
            else
            {
                MessageBox.Show("Erro em inserção");
            }
        }
    }
}
