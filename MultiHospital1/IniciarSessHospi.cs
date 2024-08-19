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
    public partial class IniciarSessHospi : Form
    {
        public int ID_Hospital = 0;
        public IniciarSessHospi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NifHos.Text == string.Empty) /*trocar para uma text box*/
            {
                MessageBox.Show("Deve preencher o NIF", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NifHos.TextLength != 9)
            {
                MessageBox.Show("O NIF deve ter 9 caracteres", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(NifHos.Text) && !int.TryParse(NifHos.Text, out _))
            {
                // Exibe uma mensagem de erro e define o foco para o controle
                MessageBox.Show("O campo deve conter apenas números.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                NifHos.Focus();
                NifHos.SelectAll();
                return;
            }
            if (EmailHos.Text == string.Empty)
            {
                MessageBox.Show("Deve Preencher o Email do seu hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassHosp.Text == string.Empty)
            {
                MessageBox.Show("Deve Preencher a Password do seu Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteDataReader sdr = null;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@NIF", NifHos.Text));
            cmd.Parameters.Add(new SQLiteParameter("@Password", CHash.HashString(PassHosp.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@Email", EmailHos.Text));
            string sql = "Select PassH, NomeH, ID_Hospital from Hospital where NifH = @NIF and PassH = @Password and EmailH = @Email;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                //cmd.ExecuteNonQuery();

                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        MessageBox.Show("Sessão Iniciada");
                        ID_Hospital = Convert.ToInt32(sdr["ID_Hospital"]);

                        sdr.Close();

                        MenuHospital form4 = new MenuHospital(ID_Hospital);
                        this.Hide();
                        /*form4.IdMedi.Text = ID_Medico.ToString();*/
                        form4.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Esta Conta Não existe");
                    NifHos.Clear();
                    PassHosp.Clear();
                    EmailHos.Clear();
                }


            }
            catch (Exception ex)
            {
                if (sdr != null)
                    sdr.Close();

                MessageBox.Show("Erro:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sdr != null)
                    sdr.Close();

                con.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuHospiPrinci form4 = new MenuHospiPrinci();
            this.Hide();
            form4.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailHos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSessHospi_Load(object sender, EventArgs e)
        {

        }
    }
}
