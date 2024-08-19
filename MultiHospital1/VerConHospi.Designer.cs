
namespace MultiHospital1
{
    partial class VerConHospi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerConHospi));
            this.sair = new System.Windows.Forms.Button();
            this.DataEscolha = new System.Windows.Forms.DateTimePicker();
            this.bs = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaciBox = new System.Windows.Forms.ComboBox();
            this.MediBox = new System.Windows.Forms.ComboBox();
            this.ConBox = new System.Windows.Forms.ComboBox();
            this.PesquisaBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.White;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(13, 315);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 25;
            this.sair.Text = "Voltar";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // DataEscolha
            // 
            this.DataEscolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataEscolha.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEscolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEscolha.Location = new System.Drawing.Point(363, 35);
            this.DataEscolha.Name = "DataEscolha";
            this.DataEscolha.Size = new System.Drawing.Size(109, 21);
            this.DataEscolha.TabIndex = 24;
            this.DataEscolha.ValueChanged += new System.EventHandler(this.DataEscolha_ValueChanged);
            // 
            // bs
            // 
            this.bs.AllowUserToAddRows = false;
            this.bs.AllowUserToDeleteRows = false;
            this.bs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.ID_Medico,
            this.ID_Paciente,
            this.Data,
            this.Hora});
            this.bs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bs.Location = new System.Drawing.Point(12, 71);
            this.bs.Name = "bs";
            this.bs.ReadOnly = true;
            this.bs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.bs.Size = new System.Drawing.Size(544, 237);
            this.bs.TabIndex = 23;
            this.bs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaConsul_CellContentClick);
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.HeaderText = "Consulta";
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            // 
            // ID_Medico
            // 
            this.ID_Medico.HeaderText = "Médico";
            this.ID_Medico.Name = "ID_Medico";
            this.ID_Medico.ReadOnly = true;
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.HeaderText = "Paciente";
            this.ID_Paciente.Name = "ID_Paciente";
            this.ID_Paciente.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Médico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consulta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PaciBox
            // 
            this.PaciBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaciBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaciBox.FormattingEnabled = true;
            this.PaciBox.Location = new System.Drawing.Point(246, 34);
            this.PaciBox.Name = "PaciBox";
            this.PaciBox.Size = new System.Drawing.Size(111, 21);
            this.PaciBox.TabIndex = 18;
            this.PaciBox.SelectedIndexChanged += new System.EventHandler(this.PaciBox_SelectedIndexChanged);
            // 
            // MediBox
            // 
            this.MediBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediBox.FormattingEnabled = true;
            this.MediBox.Location = new System.Drawing.Point(129, 34);
            this.MediBox.Name = "MediBox";
            this.MediBox.Size = new System.Drawing.Size(111, 21);
            this.MediBox.TabIndex = 17;
            this.MediBox.SelectedIndexChanged += new System.EventHandler(this.HospiBox_SelectedIndexChanged);
            // 
            // ConBox
            // 
            this.ConBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBox.FormattingEnabled = true;
            this.ConBox.Location = new System.Drawing.Point(13, 34);
            this.ConBox.Name = "ConBox";
            this.ConBox.Size = new System.Drawing.Size(110, 21);
            this.ConBox.TabIndex = 16;
            this.ConBox.SelectedIndexChanged += new System.EventHandler(this.ConBox_SelectedIndexChanged);
            // 
            // PesquisaBut
            // 
            this.PesquisaBut.BackColor = System.Drawing.Color.White;
            this.PesquisaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisaBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisaBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaBut.Location = new System.Drawing.Point(481, 32);
            this.PesquisaBut.Name = "PesquisaBut";
            this.PesquisaBut.Size = new System.Drawing.Size(75, 23);
            this.PesquisaBut.TabIndex = 15;
            this.PesquisaBut.Text = "Pesquisar";
            this.PesquisaBut.UseVisualStyleBackColor = false;
            this.PesquisaBut.Click += new System.EventHandler(this.PesquisaBut_Click);
            // 
            // VerConHospi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(570, 344);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.DataEscolha);
            this.Controls.Add(this.bs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaciBox);
            this.Controls.Add(this.MediBox);
            this.Controls.Add(this.ConBox);
            this.Controls.Add(this.PesquisaBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerConHospi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.VerConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.DateTimePicker DataEscolha;
        private System.Windows.Forms.DataGridView bs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaciBox;
        private System.Windows.Forms.ComboBox MediBox;
        private System.Windows.Forms.ComboBox ConBox;
        private System.Windows.Forms.Button PesquisaBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}