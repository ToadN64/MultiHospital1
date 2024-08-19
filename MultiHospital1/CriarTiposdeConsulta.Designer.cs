
namespace MultiHospital1
{
    partial class CriarTiposdeConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarTiposdeConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoConsul = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Tipo de Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira o Nome do tipo de Consulta";
            // 
            // TipoConsul
            // 
            this.TipoConsul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipoConsul.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoConsul.Location = new System.Drawing.Point(15, 75);
            this.TipoConsul.Name = "TipoConsul";
            this.TipoConsul.Size = new System.Drawing.Size(331, 21);
            this.TipoConsul.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Criar
            // 
            this.Criar.BackColor = System.Drawing.Color.Lime;
            this.Criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Criar.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criar.Location = new System.Drawing.Point(195, 101);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(120, 23);
            this.Criar.TabIndex = 4;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = false;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // CriarTiposdeConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(359, 132);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoConsul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarTiposdeConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Tipos de Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TipoConsul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Criar;
    }
}