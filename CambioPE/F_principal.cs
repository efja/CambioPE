using CambioPE;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioPE
{
    public partial class F_principal : Form
    {
        // Carga a información do ficheiro de configuración
        string remoto = ConfigurationManager.AppSettings.Get("remoto");
        string conexion1 = ConfigurationManager.AppSettings.Get("conexion1");
        string conexion1_pe = ConfigurationManager.AppSettings.Get("conexion1_pe");
        string conexion2 = ConfigurationManager.AppSettings.Get("conexion2");
        string conexion2_pe = ConfigurationManager.AppSettings.Get("conexion2_pe");

        // Empregase para controlar cando se poden mostrar notificacións
        private bool GloboNotificacion = true;

        public F_principal()
        {
            InitializeComponent();
        }

        //
        // Comproba cal é conexión actual, devolvea e modifica a cor dos botóns para destacala
        private string F_conexion_atual()
        {
            // Restablecer o tamaño de fonte do cadro de texto
            TB_conexion_nome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            menuCambiarAConexion1.Font = new Font("", 10, FontStyle.Regular);
            menuCambiarAConexion2.Font = new Font("", 10, FontStyle.Regular);

            // Para destacar o botón da conexión actual
            B_PE1.BackColor = SystemColors.Control;
            B_PE2.BackColor = SystemColors.Control;

            // Para destacar o menú da conexión actual
            menuCambiarAConexion1.Checked = false;
            menuCambiarAConexion2.Checked = false;

            if (rede.F_pe_actual().ToString() == conexion1_pe)
            {
                B_PE1.BackColor = SystemColors.ScrollBar;
                menuCambiarAConexion1.Font = new Font("", 10, FontStyle.Bold);
                menuCambiarAConexion1.Checked = true;
                return conexion1;
            }
            else if (rede.F_pe_actual().ToString() == conexion2_pe)
            {
                B_PE2.BackColor = SystemColors.ScrollBar;
                menuCambiarAConexion2.Font = new Font("", 10, FontStyle.Bold);
                menuCambiarAConexion2.Checked = true;
                return conexion2;
            }
            else
            {
                // Para que quepa no cadro de texto
                TB_conexion_nome.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                return "Está conexión non está configurada";
            }
        }

        //
        // Mostra a conexión actual nos cadros de texto e provoca unha notificación
        private void F_mostar_conexion_atual()
        {
            GloboNotificacion = true;
            TB_conexion_nome.Text = " " + F_conexion_atual();
            TB_conexion_pe.Text = " " + rede.F_pe_actual() + " (PE)";

            if (GloboNotificacion)
            {
                XerarGloboNotificacion(0);
            }
        }

        //
        // Mostra a conexión actual nos cadros de texto e provoca unha notificación
        private void F_cambiar_conexion_atual(string conexion)
        {
            rede.cambiarPE(conexion);
            F_mostar_conexion_atual();
        }

        //
        // Carga o formulario principal do aplicativo
        private void F_principal_Load(object sender, EventArgs e)
        {
            // Modifica a etiqueta dos botóns de cambio da PE
            B_PE1.Text = conexion1;
            B_PE2.Text = conexion2;

            // Modifica a etiqueta das opcións do menú
            MenuIconaNotificacion.Items["menuCambiarAConexion1"].Text = "Cambiar a " + conexion1;
            MenuIconaNotificacion.Items["menuCambiarAConexion2"].Text = "Cambiar a " + conexion2;
            F_mostar_conexion_atual();
        }


        //
        // Botóns do formulario principal
        //

        //
        // Cambiar á conexión 1

        private void B_PE1_Click(object sender, EventArgs e)
        {
            F_cambiar_conexion_atual(conexion1_pe);
        }

        //
        // Cambiar á conexión 2
        private void B_PE2_Click(object sender, EventArgs e)
        {
            F_cambiar_conexion_atual(conexion2_pe);
        }

        //
        // Carga o aplicativo de conexión remota
        private void B_remoto_Click(object sender, EventArgs e)
        {
            Process executable = new Process();
            executable.EnableRaisingEvents = false;
            executable.StartInfo.FileName = remoto;
            //executable.StartInfo.Arguments = "";
            executable.Start();
        }

        //
        // Mostra o formulario para cambiar o ficheiro de configuración
        private void B_opcions_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Non modifiques nada se non estas segur@ do que vas a facer.",
                "Coidado!!!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                F_config opcions = new F_config();
                opcions.ShowDialog(this);
                Application.Restart();
            }
        }

        //
        // Procesos coa Icona na barra de notificación
        //

        //
        // Xenera un cadro de notificación coa información da conexión actual
        public void XerarGloboNotificacion(int tempo)
        {
            IconaNotificacion.BalloonTipTitle = "Conexión actual:";
            IconaNotificacion.BalloonTipText = F_conexion_atual() + "\nPE: " + rede.F_pe_actual().ToString();
            IconaNotificacion.ShowBalloonTip(tempo);

            GloboNotificacion = false;
        }

        //
        // Opcións do menu para cambiar a conexión
        //

        //
        // Cambia á conexión 1
        private void CambiarAConexion1_Click(object sender, EventArgs e)
        {
            F_cambiar_conexion_atual(conexion1_pe);
        }

        //
        // Cambia á conexión 2
        private void CambiarAConexion2_Click(object sender, EventArgs e)
        {
            F_cambiar_conexion_atual(conexion2_pe);
        }

        //
        // Opcións do menu para manipular o formulario principal do aplicativo
        //

        //
        // Pecha o aplicativo
        private void Pechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //
        // Mostra ou oculta o formulario principal
        private void MostrarAplicativo_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //
        // Mostrar globo de notificacións
        //

        //
        // Mostra ou oculta o formulario principal ao facer dobre click sobre a icona de notificación
        private void IconaNotificacion_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;

            // Se o formulario esta minimizado restaurao
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            GloboNotificacion = true;
        }

        //
        // Oculta o formulario principal ao minimizalo
        private void F_principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        //
        // Mostrar notificación ao pasar o cursor por enriba da icona
        private void IconaNotificacion_MouseMove(object sender, MouseEventArgs e)
        {
            // Para abrir só unha notificación mentres non desaparece a anterior
            if (GloboNotificacion)
            {
                XerarGloboNotificacion(0);
            }
        }

        //
        // Para que deixe mostrar a próxima notificación 
        private void IconaNotificacion_BalloonTipClosed(object sender, EventArgs e)
        {
            GloboNotificacion = true;
        }

        //
        // Menú do aplicativo
        //

        //
        // Abre o formulario que detalla a licencia de uso do aplicativo
        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_licencia licencia = new F_licencia();
            licencia.FormClosing += F_principal_Load;
            licencia.ShowDialog(this);
        }
    }
}
