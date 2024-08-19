using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MultiHospital1
{
    public partial class CriarHospimenu : Form
    {
        public CriarHospimenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuHospiPrinci form3 = new MenuHospiPrinci();
            this.Hide();
            form3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarBut_Click(object sender, EventArgs e)
        {
            if (Nif_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o NIF", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nif_Box.TextLength != 9)
            {
                MessageBox.Show("O NIF deve conter cerca de 9 caracteres", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(Nif_Box.Text) && !int.TryParse(Nif_Box.Text, out _))
            {
                // Exibe uma mensagem de erro e define o foco para o controle
                MessageBox.Show("O campo deve conter apenas números.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nif_Box.Focus();
                Nif_Box.SelectAll();
                return;
            }
            string nifHospital = Nif_Box.Text;

            // Verificar se o NIF já existe na tabela Hospital
            string sqlVerificarHospital = "SELECT COUNT(*) FROM Hospital WHERE NifH = @NIF";
            SQLiteConnection cun = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmdVerificarHospital = new SQLiteCommand(sqlVerificarHospital, cun);
            cmdVerificarHospital.Parameters.AddWithValue("@NIF", nifHospital);
            cun.Open();
            int countHospital = Convert.ToInt32(cmdVerificarHospital.ExecuteScalar());
            if (countHospital > 0)
            {
                MessageBox.Show("O NIF já existe na base de dados dos hospitais.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cun.Close();
                return;
            }
            if (Nome_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o Nome do Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Email_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o Email do Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Pass_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher a Password do Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassVeri_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher novamente a Password do Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Pass_Box.Text != PassVeri_Box.Text)
            {
                MessageBox.Show("A passoword não é igual", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string senhahash = CHash.HashString(Pass_Box.Text);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Box.Text));
            cmd.Parameters.Add(new SQLiteParameter("@Nome", Nome_Box.Text));
            cmd.Parameters.Add(new SQLiteParameter("@Password", senhahash));
            cmd.Parameters.Add(new SQLiteParameter("@Email", Email_Box.Text));
            string sql = "Insert into Hospital (NifH, NomeH, PassH, EmailH) values (@NIF, @Nome, @Password, @Email)";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hospital Criado");
                Nif_Box.Clear();
                Nome_Box.Clear();
                Pass_Box.Clear();
                PassVeri_Box.Clear();
                Email_Box.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void CriarHospimenu_Load(object sender, EventArgs e)
        {

        }
    }
}
