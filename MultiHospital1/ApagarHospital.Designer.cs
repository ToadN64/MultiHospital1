﻿
namespace MultiHospital1
{
    partial class ApagarHospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarHospital));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ApagarBut = new System.Windows.Forms.Button();
            this.HospiBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apagar Hospital";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApagarBut
            // 
            this.ApagarBut.BackColor = System.Drawing.Color.Red;
            this.ApagarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApagarBut.FlatAppearance.BorderSize = 0;
            this.ApagarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApagarBut.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApagarBut.ForeColor = System.Drawing.Color.White;
            this.ApagarBut.Location = new System.Drawing.Point(167, 93);
            this.ApagarBut.Name = "ApagarBut";
            this.ApagarBut.Size = new System.Drawing.Size(85, 23);
            this.ApagarBut.TabIndex = 3;
            this.ApagarBut.Text = "Apagar";
            this.ApagarBut.UseVisualStyleBackColor = false;
            this.ApagarBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // HospiBox
            // 
            this.HospiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HospiBox.FormattingEnabled = true;
            this.HospiBox.Location = new System.Drawing.Point(12, 66);
            this.HospiBox.Name = "HospiBox";
            this.HospiBox.Size = new System.Drawing.Size(240, 21);
            this.HospiBox.TabIndex = 4;
            this.HospiBox.SelectedIndexChanged += new System.EventHandler(this.HospiBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione o Hospital que deseja apagar.";
            // 
            // ApagarHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(264, 128);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HospiBox);
            this.Controls.Add(this.ApagarBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApagarHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apagar Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ApagarBut;
        private System.Windows.Forms.ComboBox HospiBox;
        private System.Windows.Forms.Label label2;
    }
}