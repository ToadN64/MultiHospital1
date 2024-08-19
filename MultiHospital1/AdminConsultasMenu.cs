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
    public partial class AdminConsultasMenu : Form
    {
        public AdminConsultasMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarTiposdeConsulta fm = new CriarTiposdeConsulta();
            this.Hide();
            fm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApagarTipoConsultasMenu fm = new ApagarTipoConsultasMenu();
            this.Hide();
            fm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu ad = new AdminMenu();
            this.Hide();
            ad.ShowDialog();
        }
    }
}
