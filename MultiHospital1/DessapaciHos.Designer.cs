
namespace MultiHospital1
{
    partial class DessapaciHos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessapaciHos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conp = new System.Windows.Forms.ComboBox();
            this.vltb = new System.Windows.Forms.Button();
            this.desab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desassociar Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o Paciente que deseja desassociar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // conp
            // 
            this.conp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conp.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conp.FormattingEnabled = true;
            this.conp.Location = new System.Drawing.Point(12, 60);
            this.conp.Name = "conp";
            this.conp.Size = new System.Drawing.Size(236, 21);
            this.conp.TabIndex = 2;
            this.conp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vltb
            // 
            this.vltb.BackColor = System.Drawing.Color.White;
            this.vltb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vltb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vltb.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vltb.Location = new System.Drawing.Point(12, 87);
            this.vltb.Name = "vltb";
            this.vltb.Size = new System.Drawing.Size(75, 23);
            this.vltb.TabIndex = 3;
            this.vltb.Text = "Voltar";
            this.vltb.UseVisualStyleBackColor = false;
            this.vltb.Click += new System.EventHandler(this.button1_Click);
            // 
            // desab
            // 
            this.desab.BackColor = System.Drawing.Color.Red;
            this.desab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desab.FlatAppearance.BorderSize = 0;
            this.desab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desab.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desab.ForeColor = System.Drawing.Color.White;
            this.desab.Location = new System.Drawing.Point(171, 87);
            this.desab.Name = "desab";
            this.desab.Size = new System.Drawing.Size(77, 23);
            this.desab.TabIndex = 4;
            this.desab.Text = "Desassociar";
            this.desab.UseVisualStyleBackColor = false;
            this.desab.Click += new System.EventHandler(this.button2_Click);
            // 
            // DessapaciHos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(261, 121);
            this.Controls.Add(this.desab);
            this.Controls.Add(this.vltb);
            this.Controls.Add(this.conp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DessapaciHos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desassociar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox conp;
        private System.Windows.Forms.Button vltb;
        private System.Windows.Forms.Button desab;
    }
}