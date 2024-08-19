
namespace MultiHospital1
{
    partial class Menu_antes_is
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_antes_is));
            this.button1 = new System.Windows.Forms.Button();
            this.Nome_Box = new System.Windows.Forms.TextBox();
            this.DataNasci_Paci = new System.Windows.Forms.DateTimePicker();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.TextoNIF = new System.Windows.Forms.Label();
            this.Nif_Text = new System.Windows.Forms.TextBox();
            this.Pass_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassVeri = new System.Windows.Forms.TextBox();
            this.Genero_paci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CargoBox = new System.Windows.Forms.ComboBox();
            this.SairBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(218, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar Conta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nome_Box
            // 
            this.Nome_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nome_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Box.Location = new System.Drawing.Point(13, 107);
            this.Nome_Box.Name = "Nome_Box";
            this.Nome_Box.Size = new System.Drawing.Size(190, 20);
            this.Nome_Box.TabIndex = 2;
            // 
            // DataNasci_Paci
            // 
            this.DataNasci_Paci.AllowDrop = true;
            this.DataNasci_Paci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataNasci_Paci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNasci_Paci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNasci_Paci.Location = new System.Drawing.Point(218, 70);
            this.DataNasci_Paci.Name = "DataNasci_Paci";
            this.DataNasci_Paci.Size = new System.Drawing.Size(108, 20);
            this.DataNasci_Paci.TabIndex = 4;
            this.DataNasci_Paci.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Email_Box
            // 
            this.Email_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Email_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Box.Location = new System.Drawing.Point(13, 224);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(190, 20);
            this.Email_Box.TabIndex = 6;
            this.Email_Box.TextChanged += new System.EventHandler(this.Email_Box_TextChanged);
            // 
            // TextoNIF
            // 
            this.TextoNIF.AutoSize = true;
            this.TextoNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoNIF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextoNIF.Location = new System.Drawing.Point(10, 54);
            this.TextoNIF.Name = "TextoNIF";
            this.TextoNIF.Size = new System.Drawing.Size(84, 13);
            this.TextoNIF.TabIndex = 7;
            this.TextoNIF.Text = "Insira o seu NIF ";
            this.TextoNIF.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nif_Text
            // 
            this.Nif_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nif_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nif_Text.Location = new System.Drawing.Point(13, 70);
            this.Nif_Text.MaxLength = 9;
            this.Nif_Text.Name = "Nif_Text";
            this.Nif_Text.Size = new System.Drawing.Size(190, 20);
            this.Nif_Text.TabIndex = 8;
            this.Nif_Text.TextChanged += new System.EventHandler(this.Nif_Text_TextChanged);
            // 
            // Pass_Txt
            // 
            this.Pass_Txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pass_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Txt.Location = new System.Drawing.Point(13, 146);
            this.Pass_Txt.MaxLength = 100;
            this.Pass_Txt.Name = "Pass_Txt";
            this.Pass_Txt.PasswordChar = '*';
            this.Pass_Txt.Size = new System.Drawing.Size(190, 20);
            this.Pass_Txt.TabIndex = 9;
            this.Pass_Txt.TextChanged += new System.EventHandler(this.Pass_Txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Insira o seu nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Insira a sua palavra passe";
            // 
            // PassVeri
            // 
            this.PassVeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassVeri.Location = new System.Drawing.Point(13, 185);
            this.PassVeri.MaxLength = 100;
            this.PassVeri.Name = "PassVeri";
            this.PassVeri.PasswordChar = '*';
            this.PassVeri.Size = new System.Drawing.Size(190, 20);
            this.PassVeri.TabIndex = 12;
            this.PassVeri.TextChanged += new System.EventHandler(this.PassVeri_TextChanged);
            // 
            // Genero_paci
            // 
            this.Genero_paci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Genero_paci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero_paci.FormattingEnabled = true;
            this.Genero_paci.Location = new System.Drawing.Point(218, 109);
            this.Genero_paci.Name = "Genero_paci";
            this.Genero_paci.Size = new System.Drawing.Size(108, 21);
            this.Genero_paci.TabIndex = 14;
            this.Genero_paci.SelectedIndexChanged += new System.EventHandler(this.Genero_paci_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Insira novamente a sua palavra passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Insira o seu email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(215, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Insira a sua data de Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(217, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Insira o seu sexo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(97, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "Criar Conta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(215, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insira o seu cargo";
            // 
            // CargoBox
            // 
            this.CargoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoBox.FormattingEnabled = true;
            this.CargoBox.Location = new System.Drawing.Point(218, 149);
            this.CargoBox.Name = "CargoBox";
            this.CargoBox.Size = new System.Drawing.Size(108, 21);
            this.CargoBox.TabIndex = 21;
            // 
            // SairBut
            // 
            this.SairBut.Location = new System.Drawing.Point(694, 374);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(94, 64);
            this.SairBut.TabIndex = 22;
            this.SairBut.Text = "Sair";
            this.SairBut.UseVisualStyleBackColor = true;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(13, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu_antes_is
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(379, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.CargoBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Genero_paci);
            this.Controls.Add(this.PassVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass_Txt);
            this.Controls.Add(this.Nif_Text);
            this.Controls.Add(this.TextoNIF);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.DataNasci_Paci);
            this.Controls.Add(this.Nome_Box);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_antes_is";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Nome_Box;
        private System.Windows.Forms.DateTimePicker DataNasci_Paci;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label TextoNIF;
        private System.Windows.Forms.TextBox Nif_Text;
        private System.Windows.Forms.TextBox Pass_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassVeri;
        private System.Windows.Forms.ComboBox Genero_paci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CargoBox;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button button2;
    }
}