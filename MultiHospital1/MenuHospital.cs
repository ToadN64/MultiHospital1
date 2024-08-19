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
    public partial class MenuHospital : Form
    {
        public int ID_Hospital = 0;
        public MenuHospital(int id_Hosp)
        {
            InitializeComponent();
            ID_Hospital = id_Hosp;
        }
        private void AddMedi_Click(object sender, EventArgs e)
        {
            //int x = ID_Hospital;
            //if (x == 0)
            //{
            //    MessageBox.Show("Não devia ter acesso aqui", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Tem ID numero : " + x.ToString());
            //}
            AssociarMedicoHospi form3 = new AssociarMedicoHospi(ID_Hospital);
            this.Hide();
            form3.ShowDialog();
            /*form4.IdMedi.Text = ID_Medico.ToString();*/

        }

        private void DaddMed_Click(object sender, EventArgs e)
        {
            DessasociarMedico form4 = new DessasociarMedico(ID_Hospital);
            this.Hide();
            form4.ShowDialog();


        }

        private void MenuHospital_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssociarPaci sd = new AssociarPaci(ID_Hospital);
            this.Hide();
            sd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DessapaciHos ds = new DessapaciHos(ID_Hospital);
            this.Hide();
            ds.ShowDialog();
        }

        private void VerCon_Click(object sender, EventArgs e)
        {
            VerConHospi dd = new VerConHospi(ID_Hospital);
            this.Hide();
            dd.ShowDialog();
        }

        private void vltb_Click(object sender, EventArgs e)
        {
            MenuHospiPrinci de = new MenuHospiPrinci();
            this.Hide();
            de.ShowDialog();
        }
    }
}
