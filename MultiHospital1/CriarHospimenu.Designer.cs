
namespace MultiHospital1
{
    partial class CriarHospimenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarHospimenu));
            this.label1 = new System.Windows.Forms.Label();
            this.Nif_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pass_Box = new System.Windows.Forms.TextBox();
            this.PassVeri_Box = new System.Windows.Forms.TextBox();
            this.SairBut = new System.Windows.Forms.Button();
            this.CriarBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Nome_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Hospital";
            // 
            // Nif_Box
            // 
            this.Nif_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nif_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nif_Box.Location = new System.Drawing.Point(12, 96);
            this.Nif_Box.MaxLength = 9;
            this.Nif_Box.Name = "Nif_Box";
            this.Nif_Box.Size = new System.Drawing.Size(232, 21);
            this.Nif_Box.TabIndex = 1;
            this.Nif_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inisra o Nif do seu Hospital";
            // 
            // Email_Box
            // 
            this.Email_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Email_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Box.Location = new System.Drawing.Point(12, 174);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(232, 21);
            this.Email_Box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira o Email do Hospital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insira a Password do Hospital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Insira a Password novamente";
            // 
            // Pass_Box
            // 
            this.Pass_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pass_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Box.Location = new System.Drawing.Point(11, 213);
            this.Pass_Box.Name = "Pass_Box";
            this.Pass_Box.PasswordChar = '•';
            this.Pass_Box.Size = new System.Drawing.Size(231, 21);
            this.Pass_Box.TabIndex = 7;
            // 
            // PassVeri_Box
            // 
            this.PassVeri_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassVeri_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassVeri_Box.Location = new System.Drawing.Point(11, 252);
            this.PassVeri_Box.Name = "PassVeri_Box";
            this.PassVeri_Box.PasswordChar = '•';
            this.PassVeri_Box.Size = new System.Drawing.Size(232, 21);
            this.PassVeri_Box.TabIndex = 8;
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(12, 278);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(75, 23);
            this.SairBut.TabIndex = 9;
            this.SairBut.Text = "Sair";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriarBut
            // 
            this.CriarBut.BackColor = System.Drawing.Color.Lime;
            this.CriarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBut.Location = new System.Drawing.Point(162, 278);
            this.CriarBut.Name = "CriarBut";
            this.CriarBut.Size = new System.Drawing.Size(82, 23);
            this.CriarBut.TabIndex = 10;
            this.CriarBut.Text = "Criar";
            this.CriarBut.UseVisualStyleBackColor = false;
            this.CriarBut.Click += new System.EventHandler(this.CriarBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insira o Nome do Hospital";
            // 
            // Nome_Box
            // 
            this.Nome_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nome_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Box.Location = new System.Drawing.Point(12, 135);
            this.Nome_Box.Name = "Nome_Box";
            this.Nome_Box.Size = new System.Drawing.Size(232, 21);
            this.Nome_Box.TabIndex = 12;
            // 
            // CriarHospimenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(265, 313);
            this.Controls.Add(this.Nome_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CriarBut);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.PassVeri_Box);
            this.Controls.Add(this.Pass_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nif_Box);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarHospimenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Hospital ";
            this.Load += new System.EventHandler(this.CriarHospimenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nif_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pass_Box;
        private System.Windows.Forms.TextBox PassVeri_Box;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button CriarBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nome_Box;
    }
}