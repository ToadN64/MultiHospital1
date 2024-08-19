
namespace MultiHospital1
{
    partial class AssociarPaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociarPaci));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nifbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.vltb = new System.Windows.Forms.Button();
            this.assb = new System.Windows.Forms.Button();
            this.Ebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Associar Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o NIF do Paciente que deseja associar";
            // 
            // nifbox
            // 
            this.nifbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nifbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nifbox.Location = new System.Drawing.Point(17, 79);
            this.nifbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nifbox.MaxLength = 9;
            this.nifbox.Name = "nifbox";
            this.nifbox.Size = new System.Drawing.Size(368, 23);
            this.nifbox.TabIndex = 2;
            this.nifbox.TextChanged += new System.EventHandler(this.nifbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o Nome do Paciente que deseja associar";
            // 
            // NomeBox
            // 
            this.NomeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeBox.Location = new System.Drawing.Point(17, 128);
            this.NomeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(368, 23);
            this.NomeBox.TabIndex = 4;
            // 
            // vltb
            // 
            this.vltb.BackColor = System.Drawing.Color.White;
            this.vltb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vltb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vltb.Location = new System.Drawing.Point(17, 212);
            this.vltb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vltb.Name = "vltb";
            this.vltb.Size = new System.Drawing.Size(100, 28);
            this.vltb.TabIndex = 5;
            this.vltb.Text = "Voltar";
            this.vltb.UseVisualStyleBackColor = false;
            this.vltb.Click += new System.EventHandler(this.vltb_Click);
            // 
            // assb
            // 
            this.assb.BackColor = System.Drawing.Color.Lime;
            this.assb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assb.Location = new System.Drawing.Point(287, 212);
            this.assb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assb.Name = "assb";
            this.assb.Size = new System.Drawing.Size(100, 30);
            this.assb.TabIndex = 6;
            this.assb.Text = "Associar";
            this.assb.UseVisualStyleBackColor = false;
            this.assb.Click += new System.EventHandler(this.assb_Click);
            // 
            // Ebox
            // 
            this.Ebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebox.Location = new System.Drawing.Point(17, 178);
            this.Ebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ebox.Name = "Ebox";
            this.Ebox.Size = new System.Drawing.Size(368, 23);
            this.Ebox.TabIndex = 8;
            this.Ebox.TextChanged += new System.EventHandler(this.Ebox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o email do Paciente que deseja associar (opcional)";
            // 
            // AssociarPaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.Ebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assb);
            this.Controls.Add(this.vltb);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nifbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssociarPaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Paciente";
            this.Load += new System.EventHandler(this.AssociarPaci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nifbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Button vltb;
        private System.Windows.Forms.Button assb;
        private System.Windows.Forms.TextBox Ebox;
        private System.Windows.Forms.Label label4;
    }
}