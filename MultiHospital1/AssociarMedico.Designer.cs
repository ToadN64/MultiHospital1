
namespace MultiHospital1
{
    partial class AssociarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociarMedico));
            this.label1 = new System.Windows.Forms.Label();
            this.SairBut = new System.Windows.Forms.Button();
            this.AssBut = new System.Windows.Forms.Button();
            this.Nif_Box = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSOCIAR PACIENTE";
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(26, 173);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(124, 23);
            this.SairBut.TabIndex = 1;
            this.SairBut.Text = "Voltar";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssBut
            // 
            this.AssBut.BackColor = System.Drawing.Color.Lime;
            this.AssBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssBut.Location = new System.Drawing.Point(170, 173);
            this.AssBut.Name = "AssBut";
            this.AssBut.Size = new System.Drawing.Size(124, 23);
            this.AssBut.TabIndex = 2;
            this.AssBut.Text = "Associar";
            this.AssBut.UseVisualStyleBackColor = false;
            this.AssBut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Nif_Box
            // 
            this.Nif_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nif_Box.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nif_Box.Location = new System.Drawing.Point(12, 68);
            this.Nif_Box.MaxLength = 9;
            this.Nif_Box.Name = "Nif_Box";
            this.Nif_Box.Size = new System.Drawing.Size(298, 21);
            this.Nif_Box.TabIndex = 3;
            this.Nif_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NomeBox
            // 
            this.NomeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NomeBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeBox.Location = new System.Drawing.Point(12, 107);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(298, 21);
            this.NomeBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o NIF do Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insira o Nome/Username do Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insira o email do Paciente (opcional)";
            // 
            // EmailBox
            // 
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(12, 147);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(298, 21);
            this.EmailBox.TabIndex = 8;
            // 
            // AssociarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(322, 201);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.Nif_Box);
            this.Controls.Add(this.AssBut);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssociarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button AssBut;
        private System.Windows.Forms.TextBox Nif_Box;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
    }
}