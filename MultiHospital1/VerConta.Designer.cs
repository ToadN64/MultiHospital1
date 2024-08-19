
namespace MultiHospital1
{
    partial class VerConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.Nif = new System.Windows.Forms.Label();
            this.Nifbox = new System.Windows.Forms.TextBox();
            this.DataPic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EspeBox = new System.Windows.Forms.ComboBox();
            this.VoltBut = new System.Windows.Forms.Button();
            this.AltBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // NomeBox
            // 
            this.NomeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeBox.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeBox.Location = new System.Drawing.Point(20, 65);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(197, 27);
            this.NomeBox.TabIndex = 2;
            this.NomeBox.TextChanged += new System.EventHandler(this.NomeBox_TextChanged);
            // 
            // Nif
            // 
            this.Nif.AutoSize = true;
            this.Nif.Location = new System.Drawing.Point(17, 95);
            this.Nif.Name = "Nif";
            this.Nif.Size = new System.Drawing.Size(24, 13);
            this.Nif.TabIndex = 3;
            this.Nif.Text = "NIF";
            // 
            // Nifbox
            // 
            this.Nifbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nifbox.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nifbox.Location = new System.Drawing.Point(20, 111);
            this.Nifbox.Name = "Nifbox";
            this.Nifbox.Size = new System.Drawing.Size(197, 27);
            this.Nifbox.TabIndex = 4;
            // 
            // DataPic
            // 
            this.DataPic.Location = new System.Drawing.Point(20, 204);
            this.DataPic.Name = "DataPic";
            this.DataPic.Size = new System.Drawing.Size(197, 20);
            this.DataPic.TabIndex = 5;
            this.DataPic.ValueChanged += new System.EventHandler(this.DataPic_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SexBox
            // 
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Location = new System.Drawing.Point(20, 243);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(197, 21);
            this.SexBox.TabIndex = 7;
            this.SexBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo Biologico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Especialidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EspeBox
            // 
            this.EspeBox.FormattingEnabled = true;
            this.EspeBox.Location = new System.Drawing.Point(20, 283);
            this.EspeBox.Name = "EspeBox";
            this.EspeBox.Size = new System.Drawing.Size(197, 21);
            this.EspeBox.TabIndex = 10;
            this.EspeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // VoltBut
            // 
            this.VoltBut.Location = new System.Drawing.Point(20, 311);
            this.VoltBut.Name = "VoltBut";
            this.VoltBut.Size = new System.Drawing.Size(75, 23);
            this.VoltBut.TabIndex = 11;
            this.VoltBut.Text = "Voltar";
            this.VoltBut.UseVisualStyleBackColor = true;
            this.VoltBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltBut
            // 
            this.AltBut.Location = new System.Drawing.Point(142, 311);
            this.AltBut.Name = "AltBut";
            this.AltBut.Size = new System.Drawing.Size(75, 23);
            this.AltBut.TabIndex = 12;
            this.AltBut.Text = "Alterar";
            this.AltBut.UseVisualStyleBackColor = true;
            this.AltBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(20, 157);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(197, 27);
            this.EmailBox.TabIndex = 14;
            // 
            // VerConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 343);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AltBut);
            this.Controls.Add(this.VoltBut);
            this.Controls.Add(this.EspeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataPic);
            this.Controls.Add(this.Nifbox);
            this.Controls.Add(this.Nif);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VerConta";
            this.Text = "VerConta";
            this.Load += new System.EventHandler(this.VerConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label Nif;
        private System.Windows.Forms.TextBox Nifbox;
        private System.Windows.Forms.DateTimePicker DataPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EspeBox;
        private System.Windows.Forms.Button VoltBut;
        private System.Windows.Forms.Button AltBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailBox;
    }
}