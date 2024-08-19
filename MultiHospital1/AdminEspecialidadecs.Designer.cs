
namespace MultiHospital1
{
    partial class AdminEspecialidadecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEspecialidadecs));
            this.label1 = new System.Windows.Forms.Label();
            this.CriarEspeBut = new System.Windows.Forms.Button();
            this.ApagEspeBut = new System.Windows.Forms.Button();
            this.SairBu = new System.Windows.Forms.Button();
            this.AssCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Especialidades";
            // 
            // CriarEspeBut
            // 
            this.CriarEspeBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CriarEspeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarEspeBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CriarEspeBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarEspeBut.Location = new System.Drawing.Point(12, 87);
            this.CriarEspeBut.Name = "CriarEspeBut";
            this.CriarEspeBut.Size = new System.Drawing.Size(82, 76);
            this.CriarEspeBut.TabIndex = 1;
            this.CriarEspeBut.Text = "Criar Especialidade";
            this.CriarEspeBut.UseVisualStyleBackColor = false;
            this.CriarEspeBut.Click += new System.EventHandler(this.CriarEspeBut_Click);
            // 
            // ApagEspeBut
            // 
            this.ApagEspeBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApagEspeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApagEspeBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApagEspeBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApagEspeBut.Location = new System.Drawing.Point(253, 87);
            this.ApagEspeBut.Name = "ApagEspeBut";
            this.ApagEspeBut.Size = new System.Drawing.Size(82, 76);
            this.ApagEspeBut.TabIndex = 2;
            this.ApagEspeBut.Text = "Apagar Especialidade";
            this.ApagEspeBut.UseVisualStyleBackColor = false;
            this.ApagEspeBut.Click += new System.EventHandler(this.ApagEspeBut_Click);
            // 
            // SairBu
            // 
            this.SairBu.BackColor = System.Drawing.Color.White;
            this.SairBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBu.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBu.Location = new System.Drawing.Point(13, 189);
            this.SairBu.Name = "SairBu";
            this.SairBu.Size = new System.Drawing.Size(60, 23);
            this.SairBu.TabIndex = 3;
            this.SairBu.Text = "Voltar";
            this.SairBu.UseVisualStyleBackColor = false;
            this.SairBu.Click += new System.EventHandler(this.SairBu_Click);
            // 
            // AssCon
            // 
            this.AssCon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AssCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssCon.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssCon.Location = new System.Drawing.Point(132, 87);
            this.AssCon.Name = "AssCon";
            this.AssCon.Size = new System.Drawing.Size(82, 76);
            this.AssCon.TabIndex = 4;
            this.AssCon.Text = "Associar Consultas";
            this.AssCon.UseVisualStyleBackColor = false;
            this.AssCon.Click += new System.EventHandler(this.AssCon_Click);
            // 
            // AdminEspecialidadecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(347, 224);
            this.Controls.Add(this.AssCon);
            this.Controls.Add(this.SairBu);
            this.Controls.Add(this.ApagEspeBut);
            this.Controls.Add(this.CriarEspeBut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminEspecialidadecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Especialidades";
            this.Load += new System.EventHandler(this.AdminEspecialidadecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CriarEspeBut;
        private System.Windows.Forms.Button ApagEspeBut;
        private System.Windows.Forms.Button SairBu;
        private System.Windows.Forms.Button AssCon;
    }
}