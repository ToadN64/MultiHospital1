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
    public partial class VerConHospi : Form
    {
        int ID_Hospital;
        public VerConHospi(int IDH)
        {
            InitializeComponent();
            ID_Hospital = IDH;
            ComboHospi();
            ComboPaci();
            ComboConsul();
        }

        private void TabelaConsul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ComboHospi()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDH", ID_Hospital);
            cmd.CommandText = "Select DISTINCT(c.ID_Medico), m.NomeMedico from Medico m, Consulta c where m.ID_Medico = c.ID_Medico and c.ID_Hospital = @IDH  order by m.NomeMedico;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                MediBox.DataSource = de;
                MediBox.ValueMember = "ID_Medico";
                MediBox.DisplayMember = "NomeMedico";
                MediBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void ComboConsul()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDH", ID_Hospital);
            cmd.CommandText = "Select DISTINCT(c.ID_TipoConsulta), tp.TiposConsulta from Tipo_Consulta tp, Consulta c where c.ID_TipoConsulta = tp.ID_TipoConsultas and c.ID_Hospital = @IDH  order by tp.TiposConsulta;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                ConBox.DataSource = de;
                ConBox.ValueMember = "ID_TipoConsulta";
                ConBox.DisplayMember = "TiposConsulta";
                ConBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void ComboPaci()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDH", ID_Hospital);
            cmd.CommandText = "Select DISTINCT(c.ID_Paciente), p.NomePaciente from  Paciente p, Consulta c where p.ID_Paciente = c.ID_Paciente and c.ID_Hospital = @IDH  order by NomePaciente;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                PaciBox.DataSource = de;
                PaciBox.ValueMember = "ID_Paciente";
                PaciBox.DisplayMember = "NomePaciente";
                PaciBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void VerConsultas_Load(object sender, EventArgs e)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.AddWithValue("@ID", ID_Hospital);
            string query = "SELECT tp.TiposConsulta, m.NomeMedico, p.NomePaciente, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Medico m, Paciente p WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Medico = m.ID_Medico AND c.ID_Paciente = p.ID_Paciente AND ID_Hospital = @ID";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                cmd.Connection = con;
                con.Open();

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(bs);

                    string consulta = reader.GetString(0);
                    string medico = reader.GetString(1);
                    string paciente = reader.GetString(2);
                    string data = reader.GetString(3);
                    string hora = reader.GetString(4);

                    bs.Rows.Add(consulta, medico, paciente, data, hora);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataEscolhida = DataEscolha.Value;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@DataConsultas", DataEscolha.Value.ToString("yyyy/MM/dd")));
            cmd.Parameters.Add(new SQLiteParameter("@Consultas", ConBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Paciente", PaciBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Medico", MediBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@ID", ID_Hospital));
            string sql = "SELECT tp.TiposConsulta, m.NomeMedico, p.NomePaciente, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Medico m, Paciente p WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Medico = m.ID_Medico AND c.ID_Paciente = p.ID_Paciente AND c.ID_Hospital = @ID AND c.ID_TipoConsulta = @Consultas AND c.Data = @dataConsultas AND c.ID_Paciente = @Paciente AND c.ID_Medico = @Medico;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                bs.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(bs);

                    string Consulta = reader[0].ToString();
                    row.Cells[0].Value = Consulta;

                    string Hospital = reader[1].ToString();
                    row.Cells[1].Value = Hospital;

                    string Paciente = reader[2].ToString();
                    row.Cells[2].Value = Paciente;

                    string hora = reader.GetString(3);
                    row.Cells[3].Value = hora;

                    string data = reader.GetString(4);
                    row.Cells[4].Value = data;

                    bs.Rows.Add(row);
                }

                ConBox.ResetText();
                PaciBox.ResetText();
                MediBox.ResetText();
                DataEscolha.ResetText();
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
        private void DataEscolha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            MenuHospital sds = new MenuHospital(ID_Hospital);
            this.Hide();
            sds.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PaciBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HospiBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaBut_Click(object sender, EventArgs e)
        {

        }
    }
}
