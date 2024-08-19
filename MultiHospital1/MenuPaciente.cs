using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiHospital1
{
    public partial class MenuPaciente : Form
    {
        int PacienteID;
        public MenuPaciente(int i)
        {
            InitializeComponent();
            PacienteID = i;
        }

        private void VerBut_Click(object sender, EventArgs e)
        {
            try
            {
            ConsultaPacienteVer form2 = new ConsultaPacienteVer(PacienteID);
            this.Hide();
            form2.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void MenuPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSessao sds = new IniciarSessao();
            this.Hide();
            sds.ShowDialog();
        }
    }
}
