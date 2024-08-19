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
    public partial class AdminHospitalMenu : Form
    {
        public AdminHospitalMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApagarHospital sf = new ApagarHospital();
            this.Hide();
            sf.ShowDialog();
        }

        private void SairBut_Click(object sender, EventArgs e)
        {
            AdminMenu sw = new AdminMenu();
            this.Hide();
            sw.ShowDialog();
        }
    }
}
