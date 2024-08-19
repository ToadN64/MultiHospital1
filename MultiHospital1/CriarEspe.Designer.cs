
namespace MultiHospital1
{
    partial class CriarEspe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarEspe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EspeciBox = new System.Windows.Forms.TextBox();
            this.SairBut = new System.Windows.Forms.Button();
            this.CriarEspeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Especialidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira o Nome da Especialidade";
            // 
            // EspeciBox
            // 
            this.EspeciBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EspeciBox.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspeciBox.Location = new System.Drawing.Point(16, 75);
            this.EspeciBox.Name = "EspeciBox";
            this.EspeciBox.Size = new System.Drawing.Size(264, 21);
            this.EspeciBox.TabIndex = 2;
            this.EspeciBox.TextChanged += new System.EventHandler(this.EspeciBox_TextChanged);
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(16, 101);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(104, 23);
            this.SairBut.TabIndex = 3;
            this.SairBut.Text = "Voltar";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // CriarEspeBut
            // 
            this.CriarEspeBut.BackColor = System.Drawing.Color.Lime;
            this.CriarEspeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarEspeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarEspeBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarEspeBut.Location = new System.Drawing.Point(176, 101);
            this.CriarEspeBut.Name = "CriarEspeBut";
            this.CriarEspeBut.Size = new System.Drawing.Size(104, 23);
            this.CriarEspeBut.TabIndex = 4;
            this.CriarEspeBut.Text = "Criar";
            this.CriarEspeBut.UseVisualStyleBackColor = false;
            this.CriarEspeBut.Click += new System.EventHandler(this.CriarEspeBut_Click);
            // 
            // CriarEspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.CriarEspeBut);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.EspeciBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarEspe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Especialidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EspeciBox;
        private System.Windows.Forms.Button SairBut;
        private System.Windows.Forms.Button CriarEspeBut;
    }
}