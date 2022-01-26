namespace DesignCilios
{
    partial class FormHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnNewDsg = new System.Windows.Forms.Button();
            this.btnCalend = new System.Windows.Forms.Button();
            this.btnExibirCli = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(8, 188);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(202, 50);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            this.btnCliente.MouseHover += new System.EventHandler(this.btnCliente_MouseHover);
            // 
            // btnNewDsg
            // 
            this.btnNewDsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewDsg.BackgroundImage")));
            this.btnNewDsg.FlatAppearance.BorderSize = 0;
            this.btnNewDsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDsg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDsg.ForeColor = System.Drawing.Color.White;
            this.btnNewDsg.Location = new System.Drawing.Point(8, 266);
            this.btnNewDsg.Name = "btnNewDsg";
            this.btnNewDsg.Size = new System.Drawing.Size(202, 50);
            this.btnNewDsg.TabIndex = 1;
            this.btnNewDsg.Text = "Novo Design";
            this.btnNewDsg.UseVisualStyleBackColor = true;
            this.btnNewDsg.Click += new System.EventHandler(this.btnNewDsg_Click);
            this.btnNewDsg.MouseHover += new System.EventHandler(this.btnCliente_MouseHover);
            // 
            // btnCalend
            // 
            this.btnCalend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalend.BackgroundImage")));
            this.btnCalend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalend.FlatAppearance.BorderSize = 0;
            this.btnCalend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalend.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalend.ForeColor = System.Drawing.Color.White;
            this.btnCalend.Location = new System.Drawing.Point(8, 341);
            this.btnCalend.Name = "btnCalend";
            this.btnCalend.Size = new System.Drawing.Size(202, 50);
            this.btnCalend.TabIndex = 2;
            this.btnCalend.Text = "Calendário";
            this.btnCalend.UseVisualStyleBackColor = true;
            this.btnCalend.Click += new System.EventHandler(this.btnCalend_Click);
            this.btnCalend.MouseHover += new System.EventHandler(this.btnCliente_MouseHover);
            // 
            // btnExibirCli
            // 
            this.btnExibirCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExibirCli.FlatAppearance.BorderSize = 0;
            this.btnExibirCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCli.ForeColor = System.Drawing.Color.Black;
            this.btnExibirCli.Location = new System.Drawing.Point(333, 319);
            this.btnExibirCli.Name = "btnExibirCli";
            this.btnExibirCli.Size = new System.Drawing.Size(136, 42);
            this.btnExibirCli.TabIndex = 3;
            this.btnExibirCli.Text = "Exibir Cliente";
            this.btnExibirCli.UseVisualStyleBackColor = true;
            this.btnExibirCli.Click += new System.EventHandler(this.btnExibirCli_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadCli.FlatAppearance.BorderSize = 0;
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.ForeColor = System.Drawing.Color.Black;
            this.btnCadCli.Location = new System.Drawing.Point(333, 263);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(136, 42);
            this.btnCadCli.TabIndex = 0;
            this.btnCadCli.Text = "Cadastrar Cliente";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.Controls.Add(this.btnNewDsg);
            this.panel2.Controls.Add(this.btnCalend);
            this.panel2.Location = new System.Drawing.Point(108, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 413);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(867, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 48);
            this.panel1.TabIndex = 5;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.btnExibirCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnNewDsg;
        private System.Windows.Forms.Button btnCalend;
        private System.Windows.Forms.Button btnExibirCli;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

