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
    public partial class DessapaciHos : Form
    {
        int IDH;
        public DessapaciHos(int ID)
        {
            InitializeComponent();
            IDH = ID;
            CM();

        }
        private void CM()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SQLiteParameter("@H", IDH));
            cmd.CommandText = "Select ph.ID_Paciente, p.NomePaciente from Paciente_Hospital ph, Paciente p where p.ID_Paciente = ph.ID_Paciente and ID_Hospital = @H;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                conp.DataSource = de;
                conp.ValueMember = "ID_Paciente";
                conp.DisplayMember = "NomePaciente";
                conp.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuHospital sm = new MenuHospital(IDH);
            this.Hide();
            sm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conp.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Medico que deseja dessasociar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@M", conp.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@H", IDH));
            string sql = "DELETE FROM Paciente_Hospital WHERE ID_Paciente = @M and ID_Hospital = @H;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apagado!");
                conp.ResetText();

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
