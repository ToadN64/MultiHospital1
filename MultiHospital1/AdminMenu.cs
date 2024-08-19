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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminConsultasMenu form1 = new AdminConsultasMenu();
            this.Hide();
            form1.ShowDialog();
            
        }

        private void HospiBut_Click(object sender, EventArgs e)
        {
            AdminHospitalMenu form2 = new AdminHospitalMenu();
            this.Hide();
            form2.ShowDialog();
            
        }

        private void EspeciBut_Click(object sender, EventArgs e)
        {
            AdminEspecialidadecs form3 = new AdminEspecialidadecs();
            this.Hide();
            form3.ShowDialog();
            
        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            Menu snd3 = new Menu();
            this.Hide();
            snd3.ShowDialog();
        }
    }
}
