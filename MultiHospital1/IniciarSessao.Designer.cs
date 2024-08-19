namespace MultiHospital1
{
    partial class IniciarSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSessao));
            this.IniciaSessa = new System.Windows.Forms.Button();
            this.Nif_Box = new System.Windows.Forms.TextBox();
            this.asknif_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.CargoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SairBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniciaSessa
            // 
            this.IniciaSessa.BackColor = System.Drawing.Color.Lime;
            this.IniciaSessa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciaSessa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciaSessa.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciaSessa.Location = new System.Drawing.Point(216, 142);
            this.IniciaSessa.Name = "IniciaSessa";
            this.IniciaSessa.Size = new System.Drawing.Size(104, 23);
            this.IniciaSessa.TabIndex = 0;
            this.IniciaSessa.Text = "Iniciar Sessão";
            this.IniciaSessa.UseVisualStyleBackColor = false;
            this.IniciaSessa.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nif_Box
            // 
            this.Nif_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nif_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nif_Box.Location = new System.Drawing.Point(12, 25);
            this.Nif_Box.MaxLength = 9;
            this.Nif_Box.Name = "Nif_Box";
            this.Nif_Box.Size = new System.Drawing.Size(308, 21);
            this.Nif_Box.TabIndex = 1;
            // 
            // asknif_label
            // 
            this.asknif_label.AutoSize = true;
            this.asknif_label.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asknif_label.ForeColor = System.Drawing.Color.White;
            this.asknif_label.Location = new System.Drawing.Point(12, 9);
            this.asknif_label.Name = "asknif_label";
            this.asknif_label.Size = new System.Drawing.Size(103, 13);
            this.asknif_label.TabIndex = 2;
            this.asknif_label.Text = "Insira o seu NIF aqui";
            this.asknif_label.Click += new System.EventHandler(this.asknif_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira aqui o seu email(opcional)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email_box
            // 
            this.Email_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Email_box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_box.Location = new System.Drawing.Point(12, 65);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(308, 21);
            this.Email_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira a sua palavra-Passe";
            // 
            // PassBox
            // 
            this.PassBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(12, 105);
            this.PassBox.MaxLength = 100;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(308, 21);
            this.PassBox.TabIndex = 6;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // CargoBox
            // 
            this.CargoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargoBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CargoBox.Location = new System.Drawing.Point(12, 144);
            this.CargoBox.Name = "CargoBox";
            this.CargoBox.Size = new System.Drawing.Size(121, 21);
            this.CargoBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insira o seu cargo";
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(12, 171);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(43, 22);
            this.SairBut.TabIndex = 23;
            this.SairBut.Text = "Sair";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // IniciarSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(365, 207);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CargoBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asknif_label);
            this.Controls.Add(this.Nif_Box);
            this.Controls.Add(this.IniciaSessa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IniciarSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sessão";
            this.Load += new System.EventHandler(this.IniciarSessao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciaSessa;
        private System.Windows.Forms.TextBox Nif_Box;
        private System.Windows.Forms.Label asknif_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.ComboBox CargoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SairBut;
    }
}