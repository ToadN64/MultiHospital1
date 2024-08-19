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
    public partial class MenuHospiPrinci : Form
    {
        public MenuHospiPrinci()
        {
            InitializeComponent();
        }

        private void CriarHospi_Click(object sender, EventArgs e)
        {
            CriarHospimenu form3 = new CriarHospimenu();
            this.Hide();
            form3.ShowDialog();
        }

        private void IniciarSBut_Click(object sender, EventArgs e)
        {
            IniciarSessHospi form4 = new IniciarSessHospi();
            this.Hide();
            form4.ShowDialog();
        }

        private void sairb_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
