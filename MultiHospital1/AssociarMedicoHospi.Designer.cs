
namespace MultiHospital1
{
    partial class AssociarMedicoHospi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociarMedicoHospi));
            this.label1 = new System.Windows.Forms.Label();
            this.Nif_Txt = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SairBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSOCIAR MEDICO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nif_Txt
            // 
            this.Nif_Txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nif_Txt.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nif_Txt.Location = new System.Drawing.Point(18, 61);
            this.Nif_Txt.MaxLength = 9;
            this.Nif_Txt.Name = "Nif_Txt";
            this.Nif_Txt.Size = new System.Drawing.Size(227, 21);
            this.Nif_Txt.TabIndex = 1;
            this.Nif_Txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(18, 100);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(227, 21);
            this.emailBox.TabIndex = 2;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIF do Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email do Medico (Opcional)";
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(37, 126);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(74, 23);
            this.SairBut.TabIndex = 5;
            this.SairBut.Text = "Voltar";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.Lime;
            this.AddBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBut.Location = new System.Drawing.Point(142, 126);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 6;
            this.AddBut.Text = "Associar";
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // AssociarMedicoHospi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(264, 167);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.Nif_Txt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssociarMedicoHospi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Medico";
            this.Load += new System.EventHandler(this.AssociarMedicoHospi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nif_Txt;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button AddBut;
    }
}