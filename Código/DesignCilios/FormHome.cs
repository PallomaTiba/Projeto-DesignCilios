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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            btnCadCli.Visible = false;
            btnExibirCli.Visible = false;
        }

        

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            FormCadCli clients = new FormCadCli();
            clients.Show();
            
        }

        private void btnExibirCli_Click(object sender, EventArgs e)
        {
            FormCliente exibCli = new FormCliente();
            exibCli.Show();
                        
        }

        private void btnNewDsg_Click(object sender, EventArgs e)
        {
            FormCadDesign newDesign = new FormCadDesign();
            newDesign.Show();
            
        }

        private void btnCalend_Click(object sender, EventArgs e)
        {
            FormCalendario calend = new FormCalendario();
            calend.Show();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            if (btnCadCli.Visible == false && btnExibirCli.Visible == false)
            {

                btnCadCli.Visible = true;
                btnExibirCli.Visible = true;
            }
            else
            {
                btnCadCli.Visible = false;
                btnExibirCli.Visible = false;
            }
        }
    }
}
