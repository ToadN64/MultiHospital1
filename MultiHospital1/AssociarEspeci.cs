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
    public partial class AssociarEspeci : Form
    {
        int IDM;
        public AssociarEspeci( int ID_m)
        {
            InitializeComponent();
            IDM = ID_m;
            ComboEspe();

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
                ConEspecia.DataSource = de;
                ConEspecia.ValueMember = "ID_Especialidade";
                ConEspecia.DisplayMember = "Especialidade";
                ConEspecia.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void VerifiEspeci()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count (ID_Especialidade) from Medico where ID_Medico = @ID;";
            cmd.Parameters.Add(new SQLiteParameter("@ID", IDM));
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Já tem uma Especialidade");
                return;
                MenuMedico s = new MenuMedico(IDM);
                this.Hide();
                s.ShowDialog();
            }

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                ConEspecia.DataSource = de;
                ConEspecia.ValueMember = "ID_Especialidade";
                ConEspecia.DisplayMember = "Especialidade";
                ConEspecia.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ConEspecia.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher a Especialidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@Especialidade", ConEspecia.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@ID", IDM));
            string sql = "UPDATE Medico SET ID_Especialidade = @Especialidade WHERE ID_Medico = @ID;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                // Obter o ID_Consulta criado
                MessageBox.Show("Associado");
                ConEspecia.ResetText();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMedico cs = new MenuMedico(IDM);
            this.Hide();
            cs.ShowDialog();
        }

        private void AssociarEspeci_Load(object sender, EventArgs e)
        {

        }
    }
}
