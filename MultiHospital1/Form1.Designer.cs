
namespace MultiHospital1
{
    partial class MultiHospital
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiHospital));
            this.Comeca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comeca
            // 
            this.Comeca.BackColor = System.Drawing.Color.White;
            this.Comeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Comeca.CausesValidation = false;
            this.Comeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comeca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Comeca.FlatAppearance.BorderSize = 3;
            this.Comeca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Comeca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Comeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comeca.Font = new System.Drawing.Font("Lato Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comeca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Comeca.Location = new System.Drawing.Point(324, 277);
            this.Comeca.Name = "Comeca";
            this.Comeca.Size = new System.Drawing.Size(137, 53);
            this.Comeca.TabIndex = 0;
            this.Comeca.Text = "Começa";
            this.Comeca.UseVisualStyleBackColor = false;
            this.Comeca.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "MULTIHOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiHospital
            // 
            this.AcceptButton = this.Comeca;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comeca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comeca;
        private System.Windows.Forms.Label label1;
    }
}

