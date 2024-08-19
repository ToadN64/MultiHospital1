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
    public partial class IniciarSessao : Form
    {
        public int ID_Medico = 0;
        public int ID_Paciente = 0;

        public IniciarSessao()
        {
            InitializeComponent();
            CargoBox.Items.Add("Paciente");
            CargoBox.Items.Add("Medico");
            CargoBox.SelectedIndex = -1;
        }

        private void IniciarSessao_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Nif_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o NIF", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassBox.Text == string.Empty)
            {
                MessageBox.Show("Deve inserir a sua palavra passe", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(Nif_Box.Text) && !int.TryParse(Nif_Box.Text, out _))
            {
                // Exibe uma mensagem de erro e define o foco para o controle
                MessageBox.Show("O campo deve conter apenas números.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nif_Box.Focus();
                Nif_Box.SelectAll();
                return;
            }
            if (CargoBox.Text == "Paciente")
            {
                if (Email_box.Text != string.Empty)
                {

                    SQLiteCommand cmd = new SQLiteCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Box.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", CHash.HashString(PassBox.Text)));
                    cmd.Parameters.Add(new SQLiteParameter("@Email", Email_box.Text));
                    string sql = "Select ID_Paciente, password from Paciente where NIF_Paciente = @NIF and password = @Password and Email_Paciente = @Email;";
                    SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.Connection = con;
                        con.Open();
                        //cmd.ExecuteNonQuery();

                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            if (sdr.Read())
                            {
                                ID_Paciente = Convert.ToInt32(sdr["ID_Paciente"]);
                                MessageBox.Show("Sessão Iniciada");
                                sdr.Close();
                                MenuPaciente form3 = new MenuPaciente(ID_Paciente);
                                this.Hide();
                                form3.ShowDialog();
                            }

                        }
                        else
                            MessageBox.Show("Esta Conta Não existe");

                        Nif_Box.Clear();
                        PassBox.Clear();
                        Email_box.Clear();
                        CargoBox.ResetText();
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
                else
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Box.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", CHash.HashString(PassBox.Text)));
                    string sql = "Select ID_Paciente, password from Paciente where NIF_Paciente = @NIF and password = @Password;";
                    SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.Connection = con;
                        con.Open();
                        //cmd.ExecuteNonQuery();

                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            if (sdr.Read())
                            {
                                ID_Paciente = Convert.ToInt32(sdr["ID_Paciente"]);
                                MessageBox.Show("Sessão Iniciada");
                                sdr.Close();
                                MenuPaciente form3 = new MenuPaciente(ID_Paciente);
                                this.Hide();
                                form3.ShowDialog();
                            }
                        }
                        else
                            MessageBox.Show("Esta Conta Não existe");

                        Nif_Box.Clear();
                        PassBox.Clear();
                        Email_box.Clear();
                        CargoBox.ResetText();
                        //SQLiteDataReader rdr = cmd.ExecuteReader();
                        //if (rdr.HasRows)
                        //{
                        //    rdr.Read();
                        //    int nrPaciente = rdr.GetInt16(0);
                        //    MessageBox.Show(nrPaciente.ToString());
                        //    rdr.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("WOW, que vazio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
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
            else if (CargoBox.Text == "Medico")
            {
                if (Email_box.Text != string.Empty)
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Box.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", CHash.HashString(PassBox.Text)));
                    cmd.Parameters.Add(new SQLiteParameter("@Email", Email_box.Text));
                    string sql = "Select ID_Medico from Medico where NIF_Medico = @NIF and pass_medi = @Password and Email_Medico = @Email;";
                    SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.Connection = con;
                        con.Open();
                        //cmd.ExecuteNonQuery();

                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            if (sdr.Read())
                            {
                                ID_Medico = Convert.ToInt32(sdr["ID_Medico"]);
                                MessageBox.Show("Sessão Iniciada");
                                sdr.Close();
                                MenuMedico form4 = new MenuMedico(ID_Medico);
                                this.Hide();
                                /*form4.IdMedi.Text = ID_Medico.ToString();*/
                                form4.ID_Medico = ID_Medico;
                                form4.ShowDialog();
                            }

                        }

                        else
                            MessageBox.Show("Esta Conta Não existe");

                        Nif_Box.Clear();
                        PassBox.Clear();
                        Email_box.Clear();
                        CargoBox.ResetText();
                        //SQLiteDataReader rdr = cmd.ExecuteReader();
                        //if (rdr.HasRows)
                        //{
                        //    rdr.Read();
                        //    int nrPaciente = rdr.GetInt16(0);
                        //    MessageBox.Show(nrPaciente.ToString());
                        //    rdr.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("WOW, que vazio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
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
                else
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Box.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", CHash.HashString(PassBox.Text)));
                    string sql = "Select ID_Medico from Medico where NIF_Medico = @NIF and pass_medi = @Password;";
                    SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.Connection = con;
                        con.Open();
                        //cmd.ExecuteNonQuery();

                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            if (sdr.Read())
                            {
                                ID_Medico = Convert.ToInt32(sdr["ID_Medico"]);
                                MessageBox.Show("Sessão Iniciada");
                                sdr.Close();
                                MenuMedico form4 = new MenuMedico(ID_Medico);
                                this.Hide();
                                /*form4.IdMedi.Text = ID_Medico.ToString();*/
                                form4.ShowDialog();
                            }

                        }
                        else
                            MessageBox.Show("Esta Conta Não existe");

                        Nif_Box.Clear();
                        PassBox.Clear();
                        Email_box.Clear();
                        CargoBox.ResetText();
                        //SQLiteDataReader rdr = cmd.ExecuteReader();
                        //if (rdr.HasRows)
                        //{
                        //    rdr.Read();
                        //    int nrPaciente = rdr.GetInt16(0);
                        //    MessageBox.Show(nrPaciente.ToString());
                        //    rdr.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("WOW, que vazio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            this.Hide();
            form2.ShowDialog();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void asknif_label_Click(object sender, EventArgs e)
        {

        }
    }
}
