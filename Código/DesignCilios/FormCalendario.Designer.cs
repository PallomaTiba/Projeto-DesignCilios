namespace DesignCilios
{
    partial class FormCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            this.calendarioMes = new System.Windows.Forms.MonthCalendar();
            this.dtgCliHoje = new System.Windows.Forms.DataGridView();
            this.dtgManutenSem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSelecionada = new System.Windows.Forms.Label();
            this.btnAgendarCliente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliHoje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManutenSem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarioMes
            // 
            this.calendarioMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioMes.Location = new System.Drawing.Point(83, 100);
            this.calendarioMes.Name = "calendarioMes";
            this.calendarioMes.TabIndex = 0;
            // 
            // dtgCliHoje
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dtgCliHoje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCliHoje.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtgCliHoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliHoje.Location = new System.Drawing.Point(402, 100);
            this.dtgCliHoje.Name = "dtgCliHoje";
            this.dtgCliHoje.Size = new System.Drawing.Size(496, 151);
            this.dtgCliHoje.TabIndex = 4;
            // 
            // dtgManutenSem
            // 
            this.dtgManutenSem.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtgManutenSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgManutenSem.Location = new System.Drawing.Point(402, 337);
            this.dtgManutenSem.Name = "dtgManutenSem";
            this.dtgManutenSem.Size = new System.Drawing.Size(496, 149);
            this.dtgManutenSem.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 43);
            this.panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(902, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 44);
            this.panel2.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(187, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 24);
            this.label15.TabIndex = 30;
            this.label15.Text = "Calendário";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(398, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Clientes do dia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(398, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manutenções da Semana";
            // 
            // dataSelecionada
            // 
            this.dataSelecionada.AutoSize = true;
            this.dataSelecionada.BackColor = System.Drawing.Color.Thistle;
            this.dataSelecionada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSelecionada.Image = ((System.Drawing.Image)(resources.GetObject("dataSelecionada.Image")));
            this.dataSelecionada.Location = new System.Drawing.Point(554, 64);
            this.dataSelecionada.Name = "dataSelecionada";
            this.dataSelecionada.Size = new System.Drawing.Size(0, 22);
            this.dataSelecionada.TabIndex = 33;
            // 
            // btnAgendarCliente
            // 
            this.btnAgendarCliente.BackColor = System.Drawing.Color.White;
            this.btnAgendarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgendarCliente.BackgroundImage")));
            this.btnAgendarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgendarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgendarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgendarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarCliente.Location = new System.Drawing.Point(83, 372);
            this.btnAgendarCliente.Name = "btnAgendarCliente";
            this.btnAgendarCliente.Size = new System.Drawing.Size(227, 50);
            this.btnAgendarCliente.TabIndex = 34;
            this.btnAgendarCliente.Text = "Agendar Cliente";
            this.btnAgendarCliente.UseVisualStyleBackColor = true;
            this.btnAgendarCliente.Click += new System.EventHandler(this.btnAgendarCliente_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(84, 297);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(227, 50);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar clientes";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgendarCliente);
            this.Controls.Add(this.dataSelecionada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgManutenSem);
            this.Controls.Add(this.dtgCliHoje);
            this.Controls.Add(this.calendarioMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalendario";
            this.Text = "FormCalendario";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliHoje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManutenSem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioMes;
        private System.Windows.Forms.DataGridView dtgCliHoje;
        private System.Windows.Forms.DataGridView dtgManutenSem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dataSelecionada;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAgendarCliente;
        private System.Windows.Forms.Button btnBuscar;
    }
}