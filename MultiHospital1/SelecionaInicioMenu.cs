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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void criarBut_Click(object sender, EventArgs e)
        {
            Menu_antes_is form3 = new Menu_antes_is();
            this.Hide();
            form3.ShowDialog();
        }

        private void IniciaBut_Click(object sender, EventArgs e)
        {
            IniciarSessao form3 = new IniciarSessao();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
