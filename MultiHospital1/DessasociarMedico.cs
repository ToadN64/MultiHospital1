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
    public partial class DessasociarMedico : Form
    {
        int Id;
        public DessasociarMedico(int IdHospi)
        {
            InitializeComponent();
            Id = IdHospi;
            CM();
        }
        private void CM()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SQLiteParameter("@H", Id));
            cmd.CommandText = "Select mh.ID_Medico, m.NomeMedico from Medico_Hospital mh, Medico m where m.ID_Medico = mh.ID_Medico and ID_Hospital = @H;";

            try
            {
                SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
                DataTable de = new DataTable();
                ds.Fill(de);
                MedicoBOX.DataSource = de;
                MedicoBOX.ValueMember = "ID_Medico";
                MedicoBOX.DisplayMember = "NomeMedico";
                MedicoBOX.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void MedicoBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DesaBut_Click(object sender, EventArgs e)
        {
            if (MedicoBOX.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Medico que deseja dessasociar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@M", MedicoBOX.SelectedValue));
            cmd.Parameters.Add(new SQLiteParameter("@H", Id));
            string sql = "DELETE FROM Medico_Hospital WHERE ID_Medico = @M and ID_Hospital = @H;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apagado!");
                MedicoBOX.ResetText();

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

        private void ExitBut_Click(object sender, EventArgs e)
        {
            MenuHospital m = new MenuHospital(Id);
            this.Hide();
            m.ShowDialog();
        }
    }
}
