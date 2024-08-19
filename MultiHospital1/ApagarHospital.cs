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
    public partial class ApagarHospital : Form
    {
        public ApagarHospital()
        {
            InitializeComponent();
            ComboHosp();
        }
        private void ComboHosp()
        {
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ID_Hospital, NomeH from Hospital;";

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
        private void button2_Click(object sender, EventArgs e)
        {
            if (HospiBox.Text == string.Empty)
            {
                MessageBox.Show("Deve escolher o Hospital que deseja apagar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Parameters.Add(new SQLiteParameter("@Hospital", HospiBox.SelectedValue));
            string sql = "DELETE FROM Hospital WHERE ID_Hospital = @Hospital;";
            SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apagado!");
                HospiBox.ResetText();

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

        private void HospiBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHospitalMenu ad = new AdminHospitalMenu();
            this.Hide();
            ad.ShowDialog();
        }
    }
}
