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
    public partial class AdminEspecialidadecs : Form
    {
        public AdminEspecialidadecs()
        {
            InitializeComponent();
        }

        private void AdminEspecialidadecs_Load(object sender, EventArgs e)
        {

        }

        private void AssCon_Click(object sender, EventArgs e)
        {
            AssConEspeci a = new AssConEspeci();
            this.Hide();
            a.ShowDialog();
        }

        private void SairBu_Click(object sender, EventArgs e)
        {
            AdminMenu s = new AdminMenu();
            this.Hide();
            s.ShowDialog();
        }

        private void CriarEspeBut_Click(object sender, EventArgs e)
        {
            CriarEspe t = new CriarEspe();
            this.Hide();
            t.ShowDialog();
        }

        private void ApagEspeBut_Click(object sender, EventArgs e)
        {
            ApagarEspecial es = new ApagarEspecial();
            this.Hide();
            es.ShowDialog();
        }
    }
}
