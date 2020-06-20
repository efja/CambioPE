using CambioPE;
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


namespace CambioPE
{
    public partial class F_config : Form
    {
        // Carga a información do ficheiro de configuración
        string remoto = ConfigurationManager.AppSettings.Get("remoto");
        string conexion1 = ConfigurationManager.AppSettings.Get("conexion1");
        string conexion1_pe = ConfigurationManager.AppSettings.Get("conexion1_pe");
        string conexion2 = ConfigurationManager.AppSettings.Get("conexion2");
        string conexion2_pe = ConfigurationManager.AppSettings.Get("conexion2_pe");

        // 
        // Carga o formulario de configuración
        public F_config()
        {
            InitializeComponent();
        }

        // 
        // Carga a información do ficheiro de configuración nos cadros de texto
        private void F_config_Load(object sender, EventArgs e)
        {
            TB_remoto.Text = remoto;
            TB_conexion1_nome.Text = conexion1;
            TB_conexion1_pe.Text = conexion1_pe;
            TB_conexion2_nome.Text = conexion2;
            TB_conexion2_pe.Text = conexion2_pe;
        }

        // 
        // Garda a información dos cadros de texto no ficheiro de configuración e pecha o formulario
        private void B_aceptar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["remoto"].Value = TB_remoto.Text;
            config.AppSettings.Settings["conexion1"].Value = TB_conexion1_nome.Text;
            config.AppSettings.Settings["conexion1_pe"].Value = TB_conexion1_pe.Text;
            config.AppSettings.Settings["conexion2"].Value = TB_conexion2_nome.Text;
            config.AppSettings.Settings["conexion2_pe"].Value = TB_conexion2_pe.Text;
            config.Save(ConfigurationSaveMode.Modified);

            ActiveForm.Close();
        }

        // 
        // Copia a IP actual no cadro de texto pasado
        private void F_copiarIP(System.Windows.Forms.TextBox TB)
        {
            TB.Text = rede.F_pe_actual().ToString();
        }

        // 
        // Pecha o formulario sen máis
        private void B_cancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void B_examinar_Click(object sender, EventArgs e)
        {
            dialogo_buscar_remoto.InitialDirectory = Application.StartupPath.ToString();
            if (dialogo_buscar_remoto.ShowDialog() == DialogResult.OK)
            {
                TB_remoto.Text = dialogo_buscar_remoto.FileName.ToString();
            }
        }

        private void B_copiarIP1_Click(object sender, EventArgs e)
        {
            F_copiarIP(TB_conexion1_pe);
        }

        private void B_copiarIP2_Click(object sender, EventArgs e)
        {
            F_copiarIP(TB_conexion2_pe);
        }
    }
}
