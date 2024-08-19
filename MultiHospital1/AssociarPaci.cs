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
    public partial class AssociarPaci : Form
    {
        int IDHosp;
        public AssociarPaci(int H)
        {
            InitializeComponent();
            IDHosp = H;
        }

        private void AssociarPaci_Load(object sender, EventArgs e)
        {

        }

        private void assb_Click(object sender, EventArgs e)
        {
            if (nifbox.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o NIF do Paciente");
                return;
            }
            if (NomeBox.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o Nome do Paciente");
                return;
            }
            if (Ebox.Text == string.Empty)
            {
                using (SQLiteConnection con = new SQLiteConnection(Globais.Constring))
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Paciente_Hospital WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF) AND ID_Hospital = @IDM;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sl, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                        cmd.Parameters.AddWithValue("@IDM", IDHosp);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("A associação já existe.");
                        }
                        else
                        {
                            string sq = "SELECT COUNT(*) FROM Paciente WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF)";
                            using (SQLiteCommand cm = new SQLiteCommand(sq, con))
                            {
                                cm.CommandType = CommandType.Text;

                                cmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                                int counta = Convert.ToInt32(cmd.ExecuteScalar());
                                if (counta == 0)
                                {
                                    MessageBox.Show("Não existe esse paciente");
                                }
                                else
                                {
                                    string sql = "INSERT INTO Paciente_Hospital SELECT ID_Paciente, @IDM FROM Paciente WHERE NIF_Paciente = @NIF;";
                                    using (SQLiteCommand insertCmd = new SQLiteCommand(sql, con))
                                    {
                                        insertCmd.CommandType = CommandType.Text;

                                        insertCmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                                        insertCmd.Parameters.AddWithValue("@IDM", IDHosp);

                                        insertCmd.ExecuteNonQuery();
                                        MessageBox.Show("ASSOCIADO");
                                    }
                                }
                            }




                        }
                    }
                }
            }
            else
            {
                using (SQLiteConnection con = new SQLiteConnection(Globais.Constring))
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Paciente_Hospital WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF AND Email_Paciente = @Email) AND ID_Hospital = @IDM;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sl, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                        cmd.Parameters.AddWithValue("@IDM", IDHosp);
                        cmd.Parameters.AddWithValue("@Email", Ebox.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("A associação já existe.");
                        }
                        else
                        {
                            string sq = "SELECT COUNT(*) FROM Paciente WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF)";
                            using (SQLiteCommand cm = new SQLiteCommand(sq, con))
                            {
                                cm.CommandType = CommandType.Text;

                                cmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                                int counta = Convert.ToInt32(cmd.ExecuteScalar());
                                if (counta == 0)
                                {
                                    MessageBox.Show("Não existe esse paciente");
                                }
                                else
                                {
                                    string sql = "INSERT INTO Paciente_Medico SELECT ID_Paciente, @IDM FROM Paciente WHERE NIF_Paciente = @NIF AND Email_Paciente = @Email;";
                                    using (SQLiteCommand insertCmd = new SQLiteCommand(sql, con))
                                    {
                                        insertCmd.CommandType = CommandType.Text;

                                        insertCmd.Parameters.AddWithValue("@NIF", nifbox.Text);
                                        insertCmd.Parameters.AddWithValue("@IDM", IDHosp);
                                        insertCmd.Parameters.AddWithValue("@Email", Ebox.Text);

                                        insertCmd.ExecuteNonQuery();
                                        MessageBox.Show("ASSOCIADO");
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        private void vltb_Click(object sender, EventArgs e)
        {
            MenuHospital ms = new MenuHospital(IDHosp);
            this.Hide();
            ms.ShowDialog();
        }

        private void nifbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
