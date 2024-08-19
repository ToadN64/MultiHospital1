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
    public partial class CriarEspe : Form
    {
        public CriarEspe()
        {
            InitializeComponent();
        }

        private void CriarEspeBut_Click(object sender, EventArgs e)
        {
            if(EspeciBox.Text == string.Empty)
            {
                MessageBox.Show("Deves preencher a Especialidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@Especie", EspeciBox.Text));
            string sql = "Insert into Especialidade (Especialidade) values (@Especie);";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Especialidade Criada");
                EspeciBox.Clear();
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

        private void EspeciBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            AdminEspecialidadecs r = new AdminEspecialidadecs();
            this.Hide();
            r.ShowDialog();
        }
    }
}
