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
    public partial class ApagarTipoConsultasMenu : Form
    {
        public ApagarTipoConsultasMenu()
        {
            InitializeComponent();
            ComboCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminConsultasMenu ds = new AdminConsultasMenu();
            this.Hide();
            ds.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Contp.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Tipo de Consulta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@TP", Contp.SelectedValue));
            string sql = "DELETE FROM Tipo_Consulta WHERE ID_TipoConsultas = @TP;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apagado!");
                Contp.ResetText();

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
        private void ComboCon()
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
                Contp.DataSource = de;
                Contp.ValueMember = "ID_TipoConsultas";
                Contp.DisplayMember = "TiposConsulta";
                Contp.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void Contp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApagarTipoConsultasMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
