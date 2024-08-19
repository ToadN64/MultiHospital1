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
    public partial class ConsultaPacienteVer : Form
    {
        int ID_Paciente1;
        public ConsultaPacienteVer(int UD)
        {
            ID_Paciente1 = UD;
            InitializeComponent();
            ComboMedi();
            ComboHospi();
            ComboConsul();

        }
        private void ConsultaPacienteVer_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.AddWithValue("@ID", ID_Paciente1);
            string query = "SELECT DISTINCT tp.TiposConsulta, h.NomeH, m.NomeMedico, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Hospital h, Paciente p, Medico m WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Hospital = h.ID_Hospital AND c.ID_Paciente = @ID AND c.ID_Medico = m.ID_Medico";
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
                    row.CreateCells(a);

                    string Consulta = reader[0].ToString();
                    row.Cells[0].Value = Consulta;

                    string Hospital = reader[1].ToString();
                    row.Cells[1].Value = Hospital;

                    string Medico = reader[2].ToString();
                    row.Cells[2].Value = Medico;

                    string hora = reader.GetString(3);
                    row.Cells[3].Value = hora;

                    string data = reader.GetString(4);
                    row.Cells[4].Value = data;

                    a.Rows.Add(row);
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
            cmd.Parameters.Add(new SQLiteParameter("@Medico", MediBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Hospital", HospiBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@ID", ID_Paciente1));
            string sql = "SELECT tp.TiposConsulta, h.NomeH, m.NomeMedico, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Hospital h, Medico m WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Hospital = h.ID_Hospital AND c.ID_Medico = m.ID_Medico AND ID_Paciente = @ID AND c.ID_TipoConsulta = @Consultas AND c.Data = @dataConsultas AND c.ID_Medico = @Medico AND c.ID_Hospital = @Hospital;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                a.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(a);

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

                    a.Rows.Add(row);
                }

                ConBox.ResetText();
                MediBox.ResetText();
                HospiBox.ResetText();
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
        private void ComboHospi()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDM", ID_Paciente1);
            cmd.CommandText = "Select DISTINCT(c.ID_Hospital), h.NomeH from Hospital h, Consulta c where h.ID_Hospital = c.ID_Hospital and c.ID_Paciente = @IDM  order by h.NomeH;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                HospiBox.DataSource = de;
                HospiBox.ValueMember = "ID_Hospital";
                HospiBox.DisplayMember = "NomeH";
                HospiBox.SelectedValue = -1;
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
            cmd.Parameters.AddWithValue("@IDP", ID_Paciente1);
            cmd.CommandText = "Select DISTINCT(c.ID_TipoConsulta), tp.TiposConsulta from Tipo_Consulta tp, Consulta c where c.ID_TipoConsulta = tp.ID_TipoConsultas and c.ID_Paciente = @IDP  order by tp.TiposConsulta;";

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
        private void ComboMedi()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDP", ID_Paciente1);
            cmd.CommandText = "Select DISTINCT(c.ID_Medico), NomeMedico from  Medico m, Consulta c where m.ID_Medico = c.ID_Medico and c.ID_Paciente = @IDP  order by NomeMedico;";

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
        private void ConBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HospiBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaciBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaConsul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPaciente ms = new MenuPaciente(ID_Paciente1);
            this.Hide();
            ms.ShowDialog();
        }

        private void PesquisaBut_Click(object sender, EventArgs e)
        {
            DateTime dataEscolhida = DataEscolha.Value;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@DataConsultas", DataEscolha.Value.ToString("yyyy/MM/dd")));
            cmd.Parameters.Add(new SQLiteParameter("@Consultas", ConBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Medico", MediBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Hospital", HospiBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@ID", ID_Paciente1));
            string sql = "SELECT tp.TiposConsulta, h.NomeH, m.NomeMedico, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Hospital h, Medico m WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Hospital = h.ID_Hospital AND c.ID_Medico = m.ID_Medico AND ID_Paciente = @ID AND c.ID_TipoConsulta = @Consultas AND c.Data = @dataConsultas AND c.ID_Medico = @Medico AND c.ID_Hospital = @Hospital;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                a.Rows.Clear();
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(a);

                    string Consulta = reader[0].ToString();
                    row.Cells[0].Value = Consulta;

                    string Hospital = reader[1].ToString();
                    row.Cells[1].Value = Hospital;

                    string Medi = reader[2].ToString();
                    row.Cells[2].Value = Medi;

                    string hora = reader.GetString(3);
                    row.Cells[3].Value = hora;

                    string data = reader.GetString(4);
                    row.Cells[4].Value = data;

                    a.Rows.Add(row);
                }

                ConBox.ResetText();
                MediBox.ResetText();
                HospiBox.ResetText();
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
    }
}
