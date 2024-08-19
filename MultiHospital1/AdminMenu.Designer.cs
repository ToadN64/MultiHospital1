
namespace MultiHospital1
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.ConsuBut = new System.Windows.Forms.Button();
            this.HospiBut = new System.Windows.Forms.Button();
            this.EspeciBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SairBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsuBut
            // 
            this.ConsuBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsuBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsuBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsuBut.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsuBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsuBut.Location = new System.Drawing.Point(20, 57);
            this.ConsuBut.Name = "ConsuBut";
            this.ConsuBut.Size = new System.Drawing.Size(90, 68);
            this.ConsuBut.TabIndex = 0;
            this.ConsuBut.Text = "Consultas";
            this.ConsuBut.UseVisualStyleBackColor = false;
            this.ConsuBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // HospiBut
            // 
            this.HospiBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HospiBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HospiBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HospiBut.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospiBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HospiBut.Location = new System.Drawing.Point(163, 57);
            this.HospiBut.Name = "HospiBut";
            this.HospiBut.Size = new System.Drawing.Size(90, 68);
            this.HospiBut.TabIndex = 1;
            this.HospiBut.Text = "Hospitais";
            this.HospiBut.UseVisualStyleBackColor = false;
            this.HospiBut.Click += new System.EventHandler(this.HospiBut_Click);
            // 
            // EspeciBut
            // 
            this.EspeciBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EspeciBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EspeciBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EspeciBut.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspeciBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EspeciBut.Location = new System.Drawing.Point(301, 57);
            this.EspeciBut.Name = "EspeciBut";
            this.EspeciBut.Size = new System.Drawing.Size(90, 68);
            this.EspeciBut.TabIndex = 2;
            this.EspeciBut.Text = "Especialidades";
            this.EspeciBut.UseVisualStyleBackColor = false;
            this.EspeciBut.Click += new System.EventHandler(this.EspeciBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Administrativo";
            // 
            // SairBut
            // 
            this.SairBut.BackColor = System.Drawing.Color.White;
            this.SairBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBut.Location = new System.Drawing.Point(13, 135);
            this.SairBut.Name = "SairBut";
            this.SairBut.Size = new System.Drawing.Size(60, 23);
            this.SairBut.TabIndex = 4;
            this.SairBut.Text = "Sair";
            this.SairBut.UseVisualStyleBackColor = false;
            this.SairBut.Click += new System.EventHandler(this.SairBut_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(407, 170);
            this.Controls.Add(this.SairBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EspeciBut);
            this.Controls.Add(this.HospiBut);
            this.Controls.Add(this.ConsuBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsuBut;
        private System.Windows.Forms.Button HospiBut;
        private System.Windows.Forms.Button EspeciBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SairBut;
    }
}