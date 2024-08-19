
namespace MultiHospital1
{
    partial class VerConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerConsultas));
            this.PesquisaBut = new System.Windows.Forms.Button();
            this.ConBox = new System.Windows.Forms.ComboBox();
            this.HospiBox = new System.Windows.Forms.ComboBox();
            this.PaciBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TabelaConsul = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEscolha = new System.Windows.Forms.DateTimePicker();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConsul)).BeginInit();
            this.SuspendLayout();
            // 
            // PesquisaBut
            // 
            this.PesquisaBut.BackColor = System.Drawing.Color.White;
            this.PesquisaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisaBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisaBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaBut.Location = new System.Drawing.Point(481, 29);
            this.PesquisaBut.Name = "PesquisaBut";
            this.PesquisaBut.Size = new System.Drawing.Size(75, 23);
            this.PesquisaBut.TabIndex = 0;
            this.PesquisaBut.Text = "Pesquisar";
            this.PesquisaBut.UseVisualStyleBackColor = false;
            this.PesquisaBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConBox
            // 
            this.ConBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBox.FormattingEnabled = true;
            this.ConBox.Location = new System.Drawing.Point(13, 31);
            this.ConBox.Name = "ConBox";
            this.ConBox.Size = new System.Drawing.Size(110, 25);
            this.ConBox.TabIndex = 1;
            this.ConBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HospiBox
            // 
            this.HospiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospiBox.FormattingEnabled = true;
            this.HospiBox.Location = new System.Drawing.Point(129, 31);
            this.HospiBox.Name = "HospiBox";
            this.HospiBox.Size = new System.Drawing.Size(111, 25);
            this.HospiBox.TabIndex = 2;
            this.HospiBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PaciBox
            // 
            this.PaciBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaciBox.FormattingEnabled = true;
            this.PaciBox.Location = new System.Drawing.Point(246, 31);
            this.PaciBox.Name = "PaciBox";
            this.PaciBox.Size = new System.Drawing.Size(111, 25);
            this.PaciBox.TabIndex = 3;
            this.PaciBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consulta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hospital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // TabelaConsul
            // 
            this.TabelaConsul.AllowUserToAddRows = false;
            this.TabelaConsul.AllowUserToDeleteRows = false;
            this.TabelaConsul.ColumnHeadersHeight = 29;
            this.TabelaConsul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.ID_Hospital,
            this.ID_Paciente,
            this.Data,
            this.Hora});
            this.TabelaConsul.Location = new System.Drawing.Point(13, 69);
            this.TabelaConsul.Name = "TabelaConsul";
            this.TabelaConsul.ReadOnly = true;
            this.TabelaConsul.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.TabelaConsul.Size = new System.Drawing.Size(544, 237);
            this.TabelaConsul.TabIndex = 12;
            this.TabelaConsul.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaConsul_CellContentClick);
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.HeaderText = "Consulta";
            this.ID_Consulta.MinimumWidth = 6;
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            this.ID_Consulta.Width = 125;
            // 
            // ID_Hospital
            // 
            this.ID_Hospital.HeaderText = "Hospital";
            this.ID_Hospital.MinimumWidth = 6;
            this.ID_Hospital.Name = "ID_Hospital";
            this.ID_Hospital.ReadOnly = true;
            this.ID_Hospital.Width = 125;
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.HeaderText = "Paciente";
            this.ID_Paciente.MinimumWidth = 6;
            this.ID_Paciente.Name = "ID_Paciente";
            this.ID_Paciente.ReadOnly = true;
            this.ID_Paciente.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 125;
            // 
            // DataEscolha
            // 
            this.DataEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEscolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEscolha.Location = new System.Drawing.Point(363, 32);
            this.DataEscolha.Name = "DataEscolha";
            this.DataEscolha.Size = new System.Drawing.Size(109, 23);
            this.DataEscolha.TabIndex = 13;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.White;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(13, 312);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 14;
            this.sair.Text = "Voltar";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // VerConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(569, 341);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.DataEscolha);
            this.Controls.Add(this.TabelaConsul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaciBox);
            this.Controls.Add(this.HospiBox);
            this.Controls.Add(this.ConBox);
            this.Controls.Add(this.PesquisaBut);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.VerConsultas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaConsul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PesquisaBut;
        private System.Windows.Forms.ComboBox ConBox;
        private System.Windows.Forms.ComboBox HospiBox;
        private System.Windows.Forms.ComboBox PaciBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TabelaConsul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DateTimePicker DataEscolha;
        private System.Windows.Forms.Button sair;
    }
}