using CambioPE;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CambioPE
{
    public partial class F_licencia : Form
    {
        //
        // Carga o formulario
        public F_licencia()
        {
            InitializeComponent();
        }

        // carba a licencia
        public static String F_cargar_licencia()
        {
            string path = @"Resources\LICENSE.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                return "Non se atopou o ficheiro da licencia";
            }

            // Abrir e ler ficheiro
            string readText = File.ReadAllText(path);
            return readText;
        }

        //      
        // Carga a información da licencia para mostrala
        private void F_licencia_Load(object sender, EventArgs e)
        {
            RTB_Licencia.Text = F_cargar_licencia();
            RTB_Licencia.SelectionAlignment = HorizontalAlignment.Center;
            L_autor.Text = "Autor: " + Application.CompanyName.ToString();
            L_nome_programa.Text = "" + Application.ProductName.ToString();
            L_version.Text = "versión: " + Application.ProductVersion.ToString();
        }

        //
        // Pecha o formulario
        private void B_aceptar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
