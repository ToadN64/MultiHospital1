
namespace MultiHospital1
{
    partial class MenuHospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHospital));
            this.label1 = new System.Windows.Forms.Label();
            this.AddMedi = new System.Windows.Forms.Button();
            this.DaddMed = new System.Windows.Forms.Button();
            this.VerCon = new System.Windows.Forms.Button();
            this.vltb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Hospital";
            // 
            // AddMedi
            // 
            this.AddMedi.BackColor = System.Drawing.Color.White;
            this.AddMedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMedi.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedi.Location = new System.Drawing.Point(82, 47);
            this.AddMedi.Name = "AddMedi";
            this.AddMedi.Size = new System.Drawing.Size(85, 63);
            this.AddMedi.TabIndex = 1;
            this.AddMedi.Text = "Associar Medico";
            this.AddMedi.UseVisualStyleBackColor = false;
            this.AddMedi.Click += new System.EventHandler(this.AddMedi_Click);
            // 
            // DaddMed
            // 
            this.DaddMed.BackColor = System.Drawing.Color.White;
            this.DaddMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DaddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaddMed.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaddMed.Location = new System.Drawing.Point(173, 47);
            this.DaddMed.Name = "DaddMed";
            this.DaddMed.Size = new System.Drawing.Size(85, 63);
            this.DaddMed.TabIndex = 2;
            this.DaddMed.Text = "Desassociar Medico";
            this.DaddMed.UseVisualStyleBackColor = false;
            this.DaddMed.Click += new System.EventHandler(this.DaddMed_Click);
            // 
            // VerCon
            // 
            this.VerCon.BackColor = System.Drawing.Color.White;
            this.VerCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerCon.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerCon.Location = new System.Drawing.Point(264, 47);
            this.VerCon.Name = "VerCon";
            this.VerCon.Size = new System.Drawing.Size(85, 63);
            this.VerCon.TabIndex = 3;
            this.VerCon.Text = "Ver Consultas";
            this.VerCon.UseVisualStyleBackColor = false;
            this.VerCon.Click += new System.EventHandler(this.VerCon_Click);
            // 
            // vltb
            // 
            this.vltb.BackColor = System.Drawing.Color.White;
            this.vltb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vltb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vltb.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vltb.Location = new System.Drawing.Point(1, 118);
            this.vltb.Name = "vltb";
            this.vltb.Size = new System.Drawing.Size(75, 23);
            this.vltb.TabIndex = 4;
            this.vltb.Text = "Voltar";
            this.vltb.UseVisualStyleBackColor = false;
            this.vltb.Click += new System.EventHandler(this.vltb_Click);
            // 
            // MenuHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(425, 142);
            this.Controls.Add(this.vltb);
            this.Controls.Add(this.VerCon);
            this.Controls.Add(this.DaddMed);
            this.Controls.Add(this.AddMedi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Hospital";
            this.Load += new System.EventHandler(this.MenuHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMedi;
        private System.Windows.Forms.Button DaddMed;
        private System.Windows.Forms.Button VerCon;
        private System.Windows.Forms.Button vltb;
    }
}