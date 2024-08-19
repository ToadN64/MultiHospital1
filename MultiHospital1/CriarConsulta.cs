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
    public partial class CriarConsulta : Form
    {
        public int ID_Medico;
        public int ID_Consul;
        public CriarConsulta(int IDMedico)
        {
            InitializeComponent();
            ID_Medico = IDMedico;
            TipoConsultaBox();
            ComboPaciente();
            ComboHospital();
        }
        private void CriarConsulta_Load(object sender, EventArgs e)
        {
        }
        private void ComboHospital()
        {
            int x = ID_Medico;
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDM", x);
            cmd.CommandText = "Select h.ID_Hospital, h.NomeH from Hospital h, Medico_Hospital mh where h.ID_Hospital = mh.ID_Hospital and mh.ID_Medico = @IDM  order by h.NomeH;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                HospitalBox.DataSource = de;
                HospitalBox.ValueMember = "ID_Hospital";
                HospitalBox.DisplayMember = "NomeH";
                HospitalBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void ComboPaciente()
        {
            int x = ID_Medico;
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDM", x);
            cmd.CommandText = "SELECT pm.ID_Paciente, p.NomePaciente FROM Paciente p, Paciente_Medico pm WHERE pm.ID_Paciente = p.ID_Paciente AND pm.ID_Medico = @IDM ORDER BY p.NomePaciente";
            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);

                ComboPaci.DataSource = de;
                ComboPaci.ValueMember = "ID_Paciente";
                ComboPaci.DisplayMember = "NomePaciente";
                ComboPaci.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void TipoConsultaBox()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ce.ID_TipoConsultas, tp.TiposConsulta from Tipo_Consulta tp, Especialidade e, Medico m, Consulta_Especialidade ce where m.ID_Medico = @ID and m.ID_Especialidade = e.ID_Especialidade and ce.ID_Especialidade = m.ID_Especialidade and ce.ID_TipoConsultas = tp.ID_TipoConsultas  order by TiposConsulta";
            cmd.Parameters.Add(new SQLiteParameter("@ID", ID_Medico));
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TipoConsulBox.DataSource = dt;
                TipoConsulBox.ValueMember = "ID_TipoConsultas";
                TipoConsulBox.DisplayMember = "TiposConsulta";
                TipoConsulBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataEscolhida = DataEscolha.Value;
            DateTime dataAtual = DateTime.Now.Date;
            DateTime horaescolhida = EscolheHora.Value;
            DateTime horaatual = DateTime.Now.Date;

            if (dataEscolhida < dataAtual)
            {
                MessageBox.Show("A data está inferior a de hoje", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TipoConsulBox.Text == string.Empty)
            {
                MessageBox.Show("Não selecionou a consulta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComboPaci.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Paciente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (HospitalBox.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Hospital", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (horaescolhida < horaatual)
            {
                MessageBox.Show("A hora está inferior ou igual a deste momento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Exibir pop-up de confirmação
            DialogResult result = MessageBox.Show("Deseja criar a consulta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.Add(new SQLiteParameter("@DataConsultas", DataEscolha.Value.ToString("yyyy/MM/dd")));
                cmd.Parameters.Add(new SQLiteParameter("@Consultas", TipoConsulBox.SelectedValue));
                cmd.Parameters.Add(new SQLiteParameter("@Paciente", ComboPaci.SelectedValue));
                cmd.Parameters.Add(new SQLiteParameter("@Hospital", HospitalBox.SelectedValue));
                cmd.Parameters.Add(new SQLiteParameter("@Hora", EscolheHora.Value.ToString("HH:mm:ss")));
                cmd.Parameters.Add(new SQLiteParameter("@Medico", ID_Medico));
                string sql = "Insert into Consulta (ID_Hospital, ID_Paciente, ID_Medico, ID_TipoConsulta, Data, Hora) values (@Hospital,  @Paciente, @Medico, @Consultas, @DataConsultas, @Hora);";
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                try
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta Criada");
                    TipoConsulBox.ResetText();
                    ComboPaci.ResetText();
                    HospitalBox.ResetText();
                    DataEscolha.ResetText();
                    EscolheHora.ResetText();
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



        private void DataEscolha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TipoConsulBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboPaci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EscolheHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            MenuMedico ds = new MenuMedico(ID_Medico);
            this.Hide();
            ds.ShowDialog();
        }
    }
}
