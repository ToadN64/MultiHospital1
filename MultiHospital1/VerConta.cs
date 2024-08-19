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
    public partial class VerConta : Form
    {
        int Id_M;
        public VerConta(int idm)
        {
            InitializeComponent();
            Id_M = idm;
        }
        //private void NomeMed()
        //{
        //    SQLiteConnection con = new SQLiteConnection(Globais.Constring);
        //    SQLiteCommand cmd = new SQLiteCommand();
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.AddWithValue("@IDM", Id_M);
        //    cmd.CommandText = "Select NomeMedico, NIF_Medico, DataDeNascimento_Medico, Genero_Medico, Email_Medico from Medico where ID_Medico = @IDM";

        //    try
        //    {
        //        SQLiteDataAdapter ds = new SQLiteDataAdapter(cmd);
        //        DataTable de = new DataTable();
        //        ds.Fill(de);
        //        if (de.Rows.Count > 0)
        //        {
        //            DataRow row = de.Rows[0];
        //            NomeBox.Text = row["NomeMedico"].ToString();
        //            Nifbox.Text = row["NIF_Medico"].ToString();
        //            if (row["DataDeNascimento_Medico"] != DBNull.Value)
        //            {
        //                DateTime dataNascimento;
        //                if (DateTime.TryParse(row["DataDeNascimento_Medico"].ToString(), out dataNascimento))
        //                {
        //                    DataPic.Value = dataNascimento;
        //                }
        //            }
        //            Genero.Text = row["NIF_Medico"].ToString();
        //            // Atribua os outros valores às respectivas TextBox aqui
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro:" + ex.Message);
        //    }
        //}
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DataPic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VerConta_Load(object sender, EventArgs e)
        {

        }

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
