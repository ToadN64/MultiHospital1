
namespace MultiHospital1
{
    partial class ConsultaPacienteVer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPacienteVer));
            this.a = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConBox = new System.Windows.Forms.ComboBox();
            this.HospiBox = new System.Windows.Forms.ComboBox();
            this.MediBox = new System.Windows.Forms.ComboBox();
            this.DataEscolha = new System.Windows.Forms.DateTimePicker();
            this.PesquisaBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AllowUserToAddRows = false;
            this.a.AllowUserToDeleteRows = false;
            this.a.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.ID_Hospital,
            this.ID_Medico,
            this.Data,
            this.Hora});
            this.a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a.Location = new System.Drawing.Point(11, 110);
            this.a.Name = "a";
            this.a.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.a.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.a.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.a.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Size = new System.Drawing.Size(535, 237);
            this.a.TabIndex = 13;
            this.a.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaConsul_CellContentClick);
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.HeaderText = "Consulta";
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            // 
            // ID_Hospital
            // 
            this.ID_Hospital.HeaderText = "Hospital";
            this.ID_Hospital.Name = "ID_Hospital";
            this.ID_Hospital.ReadOnly = true;
            // 
            // ID_Medico
            // 
            this.ID_Medico.HeaderText = "Medico";
            this.ID_Medico.Name = "ID_Medico";
            this.ID_Medico.ReadOnly = true;
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
            // ConBox
            // 
            this.ConBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBox.FormattingEnabled = true;
            this.ConBox.Location = new System.Drawing.Point(10, 73);
            this.ConBox.Name = "ConBox";
            this.ConBox.Size = new System.Drawing.Size(110, 21);
            this.ConBox.TabIndex = 14;
            this.ConBox.SelectedIndexChanged += new System.EventHandler(this.ConBox_SelectedIndexChanged);
            // 
            // HospiBox
            // 
            this.HospiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HospiBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospiBox.FormattingEnabled = true;
            this.HospiBox.Location = new System.Drawing.Point(126, 73);
            this.HospiBox.Name = "HospiBox";
            this.HospiBox.Size = new System.Drawing.Size(111, 21);
            this.HospiBox.TabIndex = 15;
            this.HospiBox.SelectedIndexChanged += new System.EventHandler(this.HospiBox_SelectedIndexChanged);
            // 
            // MediBox
            // 
            this.MediBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediBox.FormattingEnabled = true;
            this.MediBox.Location = new System.Drawing.Point(243, 73);
            this.MediBox.Name = "MediBox";
            this.MediBox.Size = new System.Drawing.Size(111, 21);
            this.MediBox.TabIndex = 16;
            this.MediBox.SelectedIndexChanged += new System.EventHandler(this.PaciBox_SelectedIndexChanged);
            // 
            // DataEscolha
            // 
            this.DataEscolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataEscolha.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEscolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEscolha.Location = new System.Drawing.Point(360, 74);
            this.DataEscolha.Name = "DataEscolha";
            this.DataEscolha.Size = new System.Drawing.Size(109, 21);
            this.DataEscolha.TabIndex = 17;
            // 
            // PesquisaBut
            // 
            this.PesquisaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisaBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaBut.Location = new System.Drawing.Point(475, 71);
            this.PesquisaBut.Name = "PesquisaBut";
            this.PesquisaBut.Size = new System.Drawing.Size(70, 23);
            this.PesquisaBut.TabIndex = 18;
            this.PesquisaBut.Text = "Pesquisar";
            this.PesquisaBut.UseVisualStyleBackColor = true;
            this.PesquisaBut.Click += new System.EventHandler(this.PesquisaBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hospital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Consultas";
            // 
            // ConsultaPacienteVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(558, 400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PesquisaBut);
            this.Controls.Add(this.DataEscolha);
            this.Controls.Add(this.MediBox);
            this.Controls.Add(this.HospiBox);
            this.Controls.Add(this.ConBox);
            this.Controls.Add(this.a);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaPacienteVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ConsultaPacienteVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView a;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.ComboBox ConBox;
        private System.Windows.Forms.ComboBox HospiBox;
        private System.Windows.Forms.ComboBox MediBox;
        private System.Windows.Forms.DateTimePicker DataEscolha;
        private System.Windows.Forms.Button PesquisaBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}