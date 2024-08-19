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
    public partial class VerConsultas : Form
    {
        public int ID_Medico;
        public int ID_Consul;
        public VerConsultas(int idMedico)
        {
            InitializeComponent();
                ID_Medico = idMedico;
            ComboHospi();
            ComboConsul();
            ComboPaci();
 

        }
        private void ComboHospi()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDM", ID_Medico);
            cmd.CommandText = "Select DISTINCT(c.ID_Hospital), h.NomeH from Hospital h, Consulta c where h.ID_Hospital = c.ID_Hospital and c.ID_Medico = @IDM  order by h.NomeH;";

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
            cmd.Parameters.AddWithValue("@IDM", ID_Medico);
            cmd.CommandText = "Select DISTINCT(c.ID_TipoConsulta), tp.TiposConsulta from Tipo_Consulta tp, Consulta c where c.ID_TipoConsulta = tp.ID_TipoConsultas and c.ID_Medico = @IDM  order by tp.TiposConsulta;";

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
            cmd.Parameters.AddWithValue("@IDM", ID_Medico);
            cmd.CommandText = "Select DISTINCT (c.ID_Paciente),NomePaciente from  Paciente p, Consulta c where p.ID_Paciente = c.ID_Paciente and c.ID_Medico = @IDM  order by NomePaciente;";

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
/*        private void ComboData()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDM", ID_Medico);
            cmd.CommandText = "Select Data from Consulta where ID_Medico = @IDM order by Data;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);

                DataTable formattedTable = new DataTable();
                formattedTable.Columns.Add("DataFormatada", typeof(string));

                foreach (DataRow row in de.Rows)
                {
                    DateTime date = DateTime.Parse(row["Data"].ToString());
                    string formattedDate = date.ToString("dd/MM/yyyy HH:mm:ss");
                    formattedTable.Rows.Add(formattedDate);
                }

                DataBox.DataSource = formattedTable;
                DataBox.ValueMember = "DataFormatada";
                DataBox.DisplayMember = "DataFormatada";
                DataBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
*/

        private void VerConsultas_Load(object sender, EventArgs e)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.AddWithValue("@ID", ID_Medico);
            string query = "SELECT tp.TiposConsulta, h.NomeH, p.NomePaciente, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Hospital h, Paciente p WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Hospital = h.ID_Hospital AND c.ID_Paciente = p.ID_Paciente AND ID_Medico = @ID";
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
                    row.CreateCells(TabelaConsul);

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

                    TabelaConsul.Rows.Add(row);
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
            TabelaConsul.CellDoubleClick += TabelaConsul_RowDoubleClick;
        }

        private void TabelaConsul_RowDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaConsul.Rows.Count)
            {
                DataGridViewRow selectedRow = TabelaConsul.Rows[e.RowIndex];

                string data = selectedRow.Cells["Data"].Value.ToString();
                string hora = selectedRow.Cells["Hora"].Value.ToString();

                // Executar uma nova consulta para obter o ID_Consulta com base nos dados selecionados
                string query = "SELECT c.ID_Consulta FROM Consulta c " +
                               "WHERE c.Data = @Data AND c.Hora = @Hora";

                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@Data", data);
                cmd.Parameters.AddWithValue("@Hora", hora);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        ID_Consul = Convert.ToInt32(result);

                        // Crie uma instância do formulário "AlterarConsulta" e passe o ID_Consulta para ele
                        AlterarConsulta alterarConsulta = new AlterarConsulta(ID_Consul, ID_Medico, data, hora);
                        this.Hide();
                        alterarConsulta.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Consulta não encontrada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataEscolhida = DataEscolha.Value;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@DataConsultas", DataEscolha.Value.ToString("yyyy/MM/dd")));
            cmd.Parameters.Add(new SQLiteParameter("@Consultas", ConBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Paciente", PaciBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@Hospital", HospiBox.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@ID", ID_Medico));
            string sql = "SELECT tp.TiposConsulta, h.NomeH, p.NomePaciente, c.Data, c.Hora FROM Consulta c, Tipo_Consulta tp, Hospital h, Paciente p WHERE c.ID_TipoConsulta = tp.ID_TipoConsultas AND c.ID_Hospital = h.ID_Hospital AND c.ID_Paciente = p.ID_Paciente AND ID_Medico = @ID AND c.ID_TipoConsulta = @Consultas AND c.Data = @dataConsultas AND c.ID_Paciente = @Paciente AND c.ID_Hospital = @Hospital;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                TabelaConsul.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TabelaConsul);

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

                    TabelaConsul.Rows.Add(row);
                }

                ConBox.ResetText();
                PaciBox.ResetText();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaConsul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerConsultas_Load_1(object sender, EventArgs e)
        {
            VerConsultas_Load(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            MenuMedico scs = new MenuMedico(ID_Medico);
            this.Hide();
            scs.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
