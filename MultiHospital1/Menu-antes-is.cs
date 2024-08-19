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
    public partial class Menu_antes_is : Form
    {
        public Menu_antes_is()
        {
            InitializeComponent();
            Genero_paci.Items.Add("Masculino");
            Genero_paci.Items.Add("Feminino");
            Genero_paci.SelectedIndex = -1;
            CargoBox.Items.Add("Paciente");
            CargoBox.Items.Add("Medico");
            CargoBox.SelectedIndex = -1;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SQLiteConnection con = new SQLiteConnection(Globais.Constring);
            //SQLiteCommand cmd = new SQLiteCommand(Sql, con);
            DateTime dataEscolhida = DataNasci_Paci.Value;
            DateTime dataAtual = DateTime.Now.Date;

            string nif = Nif_Text.Text;

            // Verificar se o NIF já existe na tabela Paciente
            string sqlVerificarPaciente = "SELECT COUNT(*) FROM Paciente WHERE NIF_Paciente = @NIF";
            SQLiteConnection can = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmdVerificarPaciente = new SQLiteCommand(sqlVerificarPaciente, can);
            cmdVerificarPaciente.Parameters.AddWithValue("@NIF", nif);
            can.Open();
            cmdVerificarPaciente.ExecuteScalar();
            int countPaciente = Convert.ToInt32(cmdVerificarPaciente.ExecuteScalar());
            if (countPaciente > 0)
            {
                MessageBox.Show("O NIF já existe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                can.Close();
                return;
            }

            // Verificar se o NIF já existe na tabela Medico
            string sqlVerificarMedico = "SELECT COUNT(*) FROM Medico WHERE NIF_Medico = @NIF";
            SQLiteConnection cen = new SQLiteConnection(Globais.Constring);
            SQLiteCommand cmdVerificarMedico = new SQLiteCommand(sqlVerificarMedico, cen);
            cmdVerificarMedico.Parameters.AddWithValue("@NIF", nif);
            cen.Open();
            cmdVerificarMedico.ExecuteScalar();
            int countMedico = Convert.ToInt32(cmdVerificarMedico.ExecuteScalar());
            if (countMedico > 0)
            {
                MessageBox.Show("O NIF já existe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cen.Close();
                return;

            }
            TimeSpan idadeMinima = TimeSpan.FromDays(365 * 18); // Definindo a idade mínima como 18 anos

            TimeSpan diferencaIdade = dataAtual - dataEscolhida;

            if (CargoBox.Text == "Medico" && diferencaIdade < idadeMinima)
            {
                MessageBox.Show("É necessário ter pelo menos 18 anos para criar uma conta de médico.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nif_Text.Text == string.Empty) /*trocar para uma text box*/
            {
                MessageBox.Show("Deve preencher o NIF do cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nif_Text.TextLength != 9)
            {
                MessageBox.Show("O NIF deve ter 9 caracteres", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nome_Box.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o Nome do cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataEscolhida > dataAtual)
            {
                MessageBox.Show("A data está superior", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Genero_paci.Text == string.Empty)
            {
                MessageBox.Show("Deve preencher o seu sexo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Pass_Txt.Text == string.Empty)
            {
                MessageBox.Show("Deva colocar a sua password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassVeri.Text == string.Empty)
            {
                MessageBox.Show("Deve voltar preencher a sua password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassVeri.Text != Pass_Txt.Text)
            {
                MessageBox.Show("As palavras passes não são iguais", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(Nif_Text.Text) && !int.TryParse(Nif_Text.Text, out _))
            {
                // Exibe uma mensagem de erro e define o foco para o controle
                MessageBox.Show("O campo deve conter apenas números.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nif_Text.Focus();
                Nif_Text.SelectAll();
                return;
            }
            //if(CargoBox.Text == string.Empty)
            //{
            //    MessageBox.Show("Deve indicar o seu cargo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (CargoBox.Text == "Paciente")
            {

                string senhahash = CHash.HashString(Pass_Txt.Text);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Text.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Nome", Nome_Box.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Password", senhahash));
                cmd.Parameters.Add(new SQLiteParameter("@Nascimento", DataNasci_Paci.Value.ToString("yyyy/MM/dd")));
                cmd.Parameters.Add(new SQLiteParameter("@Genero", Genero_paci.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Email", Email_Box.Text));
                string sql = "Insert into Paciente (NIF_Paciente, NomePaciente, password, DatadeNascimentoP, Genero, Email_Paciente) values (@NIF, @Nome, @Password, @Nascimento, @Genero, @Email);";
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                try
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta Criada");
                    Nif_Text.Clear();
                    Nome_Box.Clear();
                    Pass_Txt.Clear();
                    PassVeri.Clear();
                    Email_Box.Clear();
                    DataNasci_Paci.ResetText();
                    Genero_paci.ResetText();
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
            else if (CargoBox.Text == "Medico")
            {
                string senhahash = CHash.HashString(Pass_Txt.Text);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.Add(new SQLiteParameter("@NIF", Nif_Text.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Nome", Nome_Box.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Password", senhahash));
                cmd.Parameters.Add(new SQLiteParameter("@Nascimento", DataNasci_Paci.Value.ToString("yyyy/MM/dd")));
                cmd.Parameters.Add(new SQLiteParameter("@Genero", Genero_paci.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Email", Email_Box.Text));
                string sql = "Insert into Medico (NIF_Medico, NomeMedico, pass_medi, DataDeNascimento_Medico, Genero_Medico, Email_Medico) values (@NIF, @Nome, @Password, @Nascimento, @Genero, @Email)";
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                try
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta Criada");
                    Nif_Text.Clear();
                    Nome_Box.Clear();
                    Pass_Txt.Clear();
                    PassVeri.Clear();
                    Email_Box.Clear();
                    DataNasci_Paci.ResetText();
                    Genero_paci.ResetText();
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
                if (Nif_Text.Text == "133357789" & Nome_Box.Text == "HOSPI" & Pass_Txt.Text == "Hospitalini" & PassVeri.Text == "Hospitalini")
                {
                    MenuHospiPrinci form3 = new MenuHospiPrinci();
                    this.Hide();
                    form3.ShowDialog();
                }
                if (Pass_Txt.Text == "10" & PassVeri.Text == "10" & Nome_Box.Text == "Admin" & Email_Box.Text == "Admin")
                {
                    AdminMenu form1 = new AdminMenu();
                    this.Hide();
                    form1.ShowDialog();
                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Email_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Genero_paci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PassVeri_TextChanged(object sender, EventArgs e)
        {

        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            this.Hide();
            form2.ShowDialog();
        }

        private void Nif_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu sd = new Menu();
            this.Hide();
            sd.ShowDialog();
        }
    }
}
