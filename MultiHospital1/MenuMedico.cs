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
    public partial class MenuMedico : Form
    {
        public int ID_Medico;

        public MenuMedico(int ID)
        {
            InitializeComponent();
            ID_Medico = ID;

        }


        private void VerBut_Click(object sender, EventArgs e)
        {
            VerConsultas form3 = new VerConsultas(ID_Medico);
            this.Hide();
            form3.Show();
        }

        private void CriaBut_Click(object sender, EventArgs e)
        {
            int x = ID_Medico;
            CriarConsulta form4 = new CriarConsulta(ID_Medico);
            this.Hide();
            form4.Show();
        }

        private void IdMedi_Click(object sender, EventArgs e)
        {


        }

        private void MenuMedico_Load(object sender, EventArgs e)
        {


            //int x = Convert.ToInt32(IdMedi.Text);
            //int x = ID_Medico;
            //if (x == 0)
            //{
            //    MessageBox.Show("Ñão devia ter acesso aqui", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Tem ID numero : " + x.ToString());
            //}
        }

        private void AssPaciBut_Click(object sender, EventArgs e)
        {
            AssociarMedico form5 = new AssociarMedico(ID_Medico);
            this.Hide();
            /*form4.IdMedi.Text = ID_Medico.ToString();*/
            form5.ShowDialog();
        }

        private void VerCont_Click(object sender, EventArgs e)
        {
            AssociarEspeci form6 = new AssociarEspeci(ID_Medico);
            this.Hide();
            form6.ShowDialog();
        }

        private void sb_Click(object sender, EventArgs e)
        {
            IniciarSessao dffff = new IniciarSessao();
            this.Hide();
            dffff.ShowDialog();
        }
    }
}
