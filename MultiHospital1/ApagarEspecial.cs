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
    public partial class ApagarEspecial : Form
    {
        public ApagarEspecial()
        {
            InitializeComponent();
            ComboEspe();
        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            AdminEspecialidadecs a = new AdminEspecialidadecs();
            this.Hide();
            a.ShowDialog();
        }
        private void ComboEspe()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ID_Especialidade, Especialidade from Especialidade;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                BoxEspeci.DataSource = de;
                BoxEspeci.ValueMember = "ID_Especialidade";
                BoxEspeci.DisplayMember = "Especialidade";
                BoxEspeci.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApagarBut_Click(object sender, EventArgs e)
        {
            if (BoxEspeci.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher a Especialidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@Especialidade", BoxEspeci.SelectedValue));
            string sql = "DELETE FROM Especialidade WHERE ID_Especialidade = @Especialidade;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apagado!");
                BoxEspeci.ResetText();

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
    }
}
