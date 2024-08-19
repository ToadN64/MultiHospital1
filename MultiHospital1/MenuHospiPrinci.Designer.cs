
namespace MultiHospital1
{
    partial class MenuHospiPrinci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHospiPrinci));
            this.label1 = new System.Windows.Forms.Label();
            this.CriarHospi = new System.Windows.Forms.Button();
            this.IniciarSBut = new System.Windows.Forms.Button();
            this.sairb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Hospital";
            // 
            // CriarHospi
            // 
            this.CriarHospi.BackColor = System.Drawing.Color.White;
            this.CriarHospi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarHospi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarHospi.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarHospi.Location = new System.Drawing.Point(12, 57);
            this.CriarHospi.Name = "CriarHospi";
            this.CriarHospi.Size = new System.Drawing.Size(117, 43);
            this.CriarHospi.TabIndex = 1;
            this.CriarHospi.Text = "Criar Hospital";
            this.CriarHospi.UseVisualStyleBackColor = false;
            this.CriarHospi.Click += new System.EventHandler(this.CriarHospi_Click);
            // 
            // IniciarSBut
            // 
            this.IniciarSBut.BackColor = System.Drawing.Color.White;
            this.IniciarSBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSBut.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSBut.Location = new System.Drawing.Point(162, 57);
            this.IniciarSBut.Name = "IniciarSBut";
            this.IniciarSBut.Size = new System.Drawing.Size(117, 43);
            this.IniciarSBut.TabIndex = 2;
            this.IniciarSBut.Text = "Iniciar Sessão";
            this.IniciarSBut.UseVisualStyleBackColor = false;
            this.IniciarSBut.Click += new System.EventHandler(this.IniciarSBut_Click);
            // 
            // sairb
            // 
            this.sairb.BackColor = System.Drawing.Color.White;
            this.sairb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairb.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairb.Location = new System.Drawing.Point(12, 107);
            this.sairb.Name = "sairb";
            this.sairb.Size = new System.Drawing.Size(75, 23);
            this.sairb.TabIndex = 3;
            this.sairb.Text = "Sair";
            this.sairb.UseVisualStyleBackColor = false;
            this.sairb.Click += new System.EventHandler(this.sairb_Click);
            // 
            // MenuHospiPrinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(293, 142);
            this.Controls.Add(this.sairb);
            this.Controls.Add(this.IniciarSBut);
            this.Controls.Add(this.CriarHospi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuHospiPrinci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CriarHospi;
        private System.Windows.Forms.Button IniciarSBut;
        private System.Windows.Forms.Button sairb;
    }
}