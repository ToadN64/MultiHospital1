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
    public partial class AssConEspeci : Form
    {
        public AssConEspeci()
        {
            InitializeComponent();
            ComboEspe();
            ComboConsu();
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
                EspeBox.DataSource = de;
                EspeBox.ValueMember = "ID_Especialidade";
                EspeBox.DisplayMember = "Especialidade";
                EspeBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void ComboConsu()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ID_TipoConsultas, TiposConsulta from Tipo_Consulta;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                ConBox.DataSource = de;
                ConBox.ValueMember = "ID_TipoConsultas";
                ConBox.DisplayMember = "TiposConsulta";
                ConBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEspecialidadecs a = new AdminEspecialidadecs();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EspeBox.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher a Especialidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ConBox.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Tipo de Consulta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@Especialidade", EspeBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Consulta", ConBox.SelectedValue));
            string sql = "INSERT INTO Consulta_Especialidade (ID_Especialidade, ID_TipoConsultas) VALUES (@Especialidade, @Consulta);";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                // Obter o ID_Consulta criado
                MessageBox.Show("Associado!");
                EspeBox.ResetText();
                ConBox.ResetText();

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

        private void ConBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
