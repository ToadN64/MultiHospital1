
namespace MultiHospital1
{
    partial class DessasociarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessasociarMedico));
            this.label1 = new System.Windows.Forms.Label();
            this.MedicoBOX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBut = new System.Windows.Forms.Button();
            this.DesaBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "DE-ASSOCIAR MEDICO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicoBOX
            // 
            this.MedicoBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicoBOX.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicoBOX.FormattingEnabled = true;
            this.MedicoBOX.Location = new System.Drawing.Point(18, 62);
            this.MedicoBOX.Name = "MedicoBOX";
            this.MedicoBOX.Size = new System.Drawing.Size(258, 21);
            this.MedicoBOX.TabIndex = 2;
            this.MedicoBOX.SelectedIndexChanged += new System.EventHandler(this.MedicoBOX_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleciona o Medico";
            // 
            // ExitBut
            // 
            this.ExitBut.BackColor = System.Drawing.Color.White;
            this.ExitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBut.Location = new System.Drawing.Point(18, 89);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(75, 23);
            this.ExitBut.TabIndex = 4;
            this.ExitBut.Text = "Sair";
            this.ExitBut.UseVisualStyleBackColor = false;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // DesaBut
            // 
            this.DesaBut.BackColor = System.Drawing.Color.Red;
            this.DesaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesaBut.FlatAppearance.BorderSize = 0;
            this.DesaBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesaBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesaBut.ForeColor = System.Drawing.Color.White;
            this.DesaBut.Location = new System.Drawing.Point(197, 89);
            this.DesaBut.Name = "DesaBut";
            this.DesaBut.Size = new System.Drawing.Size(79, 23);
            this.DesaBut.TabIndex = 5;
            this.DesaBut.Text = "Dessasociar";
            this.DesaBut.UseVisualStyleBackColor = false;
            this.DesaBut.Click += new System.EventHandler(this.DesaBut_Click);
            // 
            // DessasociarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(295, 128);
            this.Controls.Add(this.DesaBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicoBOX);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DessasociarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desassociar Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MedicoBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button DesaBut;
    }
}