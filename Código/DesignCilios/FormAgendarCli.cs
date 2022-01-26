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
    public partial class FormAgendarCli : Form
    {
        DB banco = new DB();

        public FormAgendarCli()
        {
            InitializeComponent();
        }

        public void populaCombo()
        {
            string query = "SELECT cli_id, cli_nome FROM cliente";
            if (banco.populaCombo2(query) == false)
            {
                MessageBox.Show("Problema aconteceu ao popular combo do cliente");
            }
            else
            {
                cmbCliente.DataSource = banco.cliente;
            }
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgendarCli_Load(object sender, EventArgs e)
        {
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = "HH:mm";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "yyyy-MM-dd";
            populaCombo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cliente = cmbCliente.SelectedItem.ToString();
            string data = dtpData.Value.ToString("yyyy-MM-dd");
            string hora = dtpHora.Value.ToString("HH:mm");
            string query = "INSERT INTO calendario(id_cliente, cal_data, cal_hora) values ((select cli_id from cliente where cli_nome ='"+cliente+"'),'"+data+"','"+hora+"');";

            if (banco.insereAgendamento(query) == true)
            {
                MessageBox.Show("Agendamento feito com sucesso!!");
            }
        }
    }
}
