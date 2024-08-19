
namespace MultiHospital1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.criarBut = new System.Windows.Forms.Button();
            this.IniciaBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // criarBut
            // 
            this.criarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.criarBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarBut.Location = new System.Drawing.Point(17, 39);
            this.criarBut.Name = "criarBut";
            this.criarBut.Size = new System.Drawing.Size(93, 45);
            this.criarBut.TabIndex = 1;
            this.criarBut.Text = "Criar Conta";
            this.criarBut.UseVisualStyleBackColor = true;
            this.criarBut.Click += new System.EventHandler(this.criarBut_Click);
            // 
            // IniciaBut
            // 
            this.IniciaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciaBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciaBut.Location = new System.Drawing.Point(154, 39);
            this.IniciaBut.Name = "IniciaBut";
            this.IniciaBut.Size = new System.Drawing.Size(93, 45);
            this.IniciaBut.TabIndex = 1;
            this.IniciaBut.Text = "Iniciar sessao";
            this.IniciaBut.UseVisualStyleBackColor = true;
            this.IniciaBut.Click += new System.EventHandler(this.IniciaBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleciona uma opção";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(259, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniciaBut);
            this.Controls.Add(this.criarBut);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button criarBut;
        private System.Windows.Forms.Button IniciaBut;
        private System.Windows.Forms.Label label1;
    }
}