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
    public partial class AssociarMedico : Form
    {
        public int ID_Medico;
        public AssociarMedico(int ID)
        {
            InitializeComponent();
            ID_Medico = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMedico m = new MenuMedico(ID_Medico);
            this.Hide();
            m.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Nif_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o NIF do Paciente");
                return;
            }
            if (NomeBox.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o Nome do Paciente");
                return;
            }
            if (EmailBox.Text == string.Empty)
            {
                using (SQLiteConnection con = new SQLiteConnection(Globais.Constring))
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Paciente_Medico WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF) AND ID_Medico = @IDM;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sl, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
                        cmd.Parameters.AddWithValue("@IDM", ID_Medico);

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

                                cmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
                                int counta = Convert.ToInt32(cmd.ExecuteScalar());
                                if (counta == 0)
                                {
                                    MessageBox.Show("Não existe esse paciente");
                                }
                                else
                                {
                                    string sql = "INSERT INTO Paciente_Medico SELECT ID_Paciente, @IDM FROM Paciente WHERE NIF_Paciente = @NIF;";
                                    using (SQLiteCommand insertCmd = new SQLiteCommand(sql, con))
                                    {
                                        insertCmd.CommandType = CommandType.Text;

                                        insertCmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
                                        insertCmd.Parameters.AddWithValue("@IDM", ID_Medico);

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
                    string sl = "SELECT COUNT(*) FROM Paciente_Medico WHERE ID_Paciente = (SELECT ID_Paciente FROM Paciente WHERE NIF_Paciente = @NIF AND Email_Paciente = @Email) AND ID_Medico = @IDM;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sl, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
                        cmd.Parameters.AddWithValue("@IDM", ID_Medico);
                        cmd.Parameters.AddWithValue("@Email", EmailBox.Text);

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

                                cmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
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

                                        insertCmd.Parameters.AddWithValue("@NIF", Nif_Box.Text);
                                        insertCmd.Parameters.AddWithValue("@IDM", ID_Medico);
                                        insertCmd.Parameters.AddWithValue("@Email", EmailBox.Text);

                                        insertCmd.ExecuteNonQuery();
                                        MessageBox.Show("ASSOCIADO!");
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
