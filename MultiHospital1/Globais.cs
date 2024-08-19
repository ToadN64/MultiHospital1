using MultiHospital1.Properties;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiHospital1
{
    internal class Globais
    {
        public static string caminhoBd = System.Environment.CurrentDirectory;
        public static string Constring = "Data source = " + caminhoBd + @"\DB\MultiDB";  
        //public static string Constring = Properties.Settings.Default.Connstring;
        public static string caminhoFicheiro = System.Environment.CurrentDirectory + @"\Files\";
        //public static string ID_Paciente = System.Environment.CurrentDirectory + @"\Files\";
    }
}
