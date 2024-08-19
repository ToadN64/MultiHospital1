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
    public partial class AssociarMedicoHospi : Form
    {
        public int ID_Medico = 0;
        public int ID_Hospital = 0;
        public AssociarMedicoHospi(int Id)
        {
            InitializeComponent();
            ID_Hospital = Id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nif_Txt.Text) && !int.TryParse(Nif_Txt.Text, out _))
            {
                // Exibe uma mensagem de erro e define o foco para o controle
                MessageBox.Show("O campo deve conter apenas números.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nif_Txt.Focus();
                Nif_Txt.SelectAll();
                return;
            }
            if (Nif_Txt.Text == string.Empty) /*trocar para uma text box*/
            {
                MessageBox.Show("Deve preencher o NIF do cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nif_Txt.TextLength != 9)
            {
                MessageBox.Show("O NIF deve ter 9 caracteres", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (emailBox.Text == string.Empty)
            {
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                SQLiteCommand cmd2 = null;
                try
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Medico_Hospital WHERE ID_Medico = (SELECT ID_Medico FROM Medico WHERE NIF_Medico = @NIF) AND ID_Hospital = @IDH;";
                    cmd2 = new SQLiteCommand(sl, con);
                    cmd2.CommandType = CommandType.Text;

                    cmd2.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                    cmd2.Parameters.AddWithValue("@IDH", ID_Hospital);

                    int count = Convert.ToInt32(cmd2.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("A associação já existe.");
                    }
                    else
                    {
                        string sq = "SELECT COUNT(*) FROM Medico WHERE ID_Medico = (SELECT ID_Medico FROM Medico WHERE NIF_Medico = @NIF)";
                        using (SQLiteCommand cm = new SQLiteCommand(sq, con))
                        {
                            cm.CommandType = CommandType.Text;

                            cm.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                            int counta = Convert.ToInt32(cm.ExecuteScalar());
                            if (counta == 0)
                            {
                                MessageBox.Show("Não existe esse medico");
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Medico_Hospital SELECT ID_Medico, @IDH FROM Medico WHERE NIF_Medico = @NIF and Email_Medico = @Email;";
                                SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con);
                                insertCmd.CommandType = CommandType.Text;

                                insertCmd.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                                insertCmd.Parameters.AddWithValue("@IDH", ID_Hospital);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("ASSOCIADO!");
                            }
                        }

                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd2.Dispose();
                    con.Close();
                }
                Nif_Txt.Clear();
                emailBox.Clear();
            }
            else
            {
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                SQLiteCommand cmd2 = null;
                try
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Medico_Hospital WHERE ID_Medico = (SELECT ID_Medico FROM Medico WHERE NIF_Medico = @NIF) AND ID_Hospital = @IDH;";
                    cmd2 = new SQLiteCommand(sl, con);
                    cmd2.CommandType = CommandType.Text;

                    cmd2.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                    cmd2.Parameters.AddWithValue("@IDH", ID_Hospital);

                    int count = Convert.ToInt32(cmd2.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("A associação já existe.");
                    }
                    else
                    {
                        string sq = "SELECT COUNT(*) FROM Medico WHERE ID_Medico = (SELECT ID_Medico FROM Medico WHERE NIF_Medico = @NIF)";
                        using (SQLiteCommand cm = new SQLiteCommand(sq, con))
                        {
                            cm.CommandType = CommandType.Text;

                            cm.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                            int counta = Convert.ToInt32(cm.ExecuteScalar());
                            if (counta == 0)
                            {
                                MessageBox.Show("Não existe esse medico");
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Medico_Hospital SELECT ID_Medico, @IDH FROM Medico WHERE NIF_Medico = @NIF and Email_Medico = @Email;";
                                SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con);
                                insertCmd.CommandType = CommandType.Text;

                                insertCmd.Parameters.AddWithValue("@NIF", Nif_Txt.Text);
                                insertCmd.Parameters.AddWithValue("@IDH", ID_Hospital);
                                insertCmd.Parameters.AddWithValue("@Email", emailBox.Text);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("ASSOCIADO!");
                            }
                        }

                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd2.Dispose();
                    con.Close();
                }
                Nif_Txt.Clear();
                emailBox.Clear();
            }
        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            MenuHospital form4 = new MenuHospital(ID_Hospital);
            this.Hide();
            form4.ShowDialog();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssociarMedicoHospi_Load(object sender, EventArgs e)
        {

        }
    }
}
