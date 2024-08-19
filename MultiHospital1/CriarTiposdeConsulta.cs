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
    public partial class CriarTiposdeConsulta : Form
    {
        public CriarTiposdeConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminConsultasMenu admc = new AdminConsultasMenu();
            this.Hide();
            admc.ShowDialog();
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            if(TipoConsul.Text == string.Empty)
            {
                MessageBox.Show("Deve Preencher o Tipo de Consulta");
            }
            else
            {
                SQLiteConnection con = new SQLiteConnection(Globais.Constring);
                SQLiteCommand cmd2 = null;
                try
                {
                    con.Open();
                    string sl = "SELECT COUNT(*) FROM Tipo_Consulta WHERE TiposConsulta Like @Nome; ";
                    cmd2 = new SQLiteCommand(sl, con);
                    cmd2.CommandType = CommandType.Text;

                    cmd2.Parameters.AddWithValue("@Nome", TipoConsul.Text);

                    int count = Convert.ToInt32(cmd2.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Esse Tipo de Consulta já existe.");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Tipo_Consulta (TiposConsulta) values (@Nome) ;";
                        SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con);
                        insertCmd.CommandType = CommandType.Text;

                        insertCmd.Parameters.AddWithValue("@Nome", TipoConsul.Text);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Criado!");
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
                TipoConsul.Clear();
            }
        }
    }
}
