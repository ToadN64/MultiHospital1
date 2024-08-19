
namespace MultiHospital1
{
    partial class CriarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarConsulta));
            this.EscolheHora = new System.Windows.Forms.DateTimePicker();
            this.DataEscolha = new System.Windows.Forms.DateTimePicker();
            this.TipoConsulBox = new System.Windows.Forms.ComboBox();
            this.HospitalBox = new System.Windows.Forms.ComboBox();
            this.SairBut = new System.Windows.Forms.Button();
            this.CriarConsulBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboPaci = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EscolheHora
            // 
            this.EscolheHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EscolheHora.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EscolheHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EscolheHora.Location = new System.Drawing.Point(14, 221);
            this.EscolheHora.Name = "EscolheHora";
            this.EscolheHora.Size = new System.Drawing.Size(200, 21);
            this.EscolheHora.TabIndex = 1;
            this.EscolheHora.ValueChanged += new System.EventHandler(this.EscolheHora_ValueChanged);
            // 
            // DataEscolha
            // 
            this.DataEscolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataEscolha.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEscolha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataEscolha.Location = new System.Drawing.Point(14, 62);
            this.DataEscolha.Name = "DataEscolha";
            this.DataEscolha.Size = new System.Drawing.Size(200, 21);
            this.DataEscolha.TabIndex = 2;
            this.DataEscolha.ValueChanged += new System.EventHandler(this.DataEscolha_ValueChanged);
            // 
            // TipoConsulBox
            // 
            this.TipoConsulBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipoConsulBox.FormattingEnabled = true;
            this.TipoConsulBox.Location = new System.Drawing.Point(14, 101);
            this.TipoConsulBox.Name = "TipoConsulBox";
            this.TipoConsulBox.Size = new System.Drawing.Size(200, 21);
            this.TipoConsulBox.TabIndex = 3;
            this.TipoConsulBox.SelectedIndexChanged += new System.EventHandler(this.TipoConsulBox_SelectedIndexChanged);
            // 
            // HospitalBox
            // 
            this.HospitalBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HospitalBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalBox.FormattingEnabled = true;
            this.HospitalBox.Location = new System.Drawing.Point(14, 181);
            this.HospitalBox.Name = "HospitalBox";
            this.HospitalBox.Size = new System.Drawing.Size(200, 21);
            this.HospitalBox.TabIndex = 4;
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(23, 247);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(75, 23);
            this.SairBut.TabIndex = 5;
            this.SairBut.Text = "Voltar";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // CriarConsulBut
            // 
            this.CriarConsulBut.BackColor = System.Drawing.Color.Lime;
            this.CriarConsulBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarConsulBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarConsulBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarConsulBut.Location = new System.Drawing.Point(129, 247);
            this.CriarConsulBut.Name = "CriarConsulBut";
            this.CriarConsulBut.Size = new System.Drawing.Size(75, 23);
            this.CriarConsulBut.TabIndex = 6;
            this.CriarConsulBut.Text = "Criar";
            this.CriarConsulBut.UseVisualStyleBackColor = false;
            this.CriarConsulBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione a data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleciona a Consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecione o Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selecione o Hospital";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleciona a Hora da Consulta";
            // 
            // ComboPaci
            // 
            this.ComboPaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboPaci.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPaci.FormattingEnabled = true;
            this.ComboPaci.Location = new System.Drawing.Point(14, 142);
            this.ComboPaci.Name = "ComboPaci";
            this.ComboPaci.Size = new System.Drawing.Size(200, 21);
            this.ComboPaci.TabIndex = 11;
            this.ComboPaci.SelectedIndexChanged += new System.EventHandler(this.ComboPaci_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "CRIAR CONSULTA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idMedico
            // 
            this.idMedico.AutoSize = true;
            this.idMedico.Location = new System.Drawing.Point(158, 43);
            this.idMedico.Name = "idMedico";
            this.idMedico.Size = new System.Drawing.Size(0, 13);
            this.idMedico.TabIndex = 13;
            // 
            // CriarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(219, 275);
            this.Controls.Add(this.idMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboPaci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriarConsulBut);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.HospitalBox);
            this.Controls.Add(this.TipoConsulBox);
            this.Controls.Add(this.DataEscolha);
            this.Controls.Add(this.EscolheHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Consulta";
            this.Load += new System.EventHandler(this.CriarConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker EscolheHora;
        private System.Windows.Forms.DateTimePicker DataEscolha;
        private System.Windows.Forms.ComboBox TipoConsulBox;
        private System.Windows.Forms.ComboBox HospitalBox;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button CriarConsulBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboPaci;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label idMedico;
    }
}