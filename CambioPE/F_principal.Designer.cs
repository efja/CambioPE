namespace CambioPE
{
    partial class F_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.B_remoto = new System.Windows.Forms.Button();
            this.B_opcions = new System.Windows.Forms.Button();
            this.MenuIconaNotificacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemoto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCambiarAConexion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCambiarAConexion2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMostrarAplicativo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPechar = new System.Windows.Forms.ToolStripMenuItem();
            this.IconaNotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_conexion_pe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_PE2 = new System.Windows.Forms.Button();
            this.B_PE1 = new System.Windows.Forms.Button();
            this.TB_conexion_nome = new System.Windows.Forms.TextBox();
            this.MenuIconaNotificacion.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_remoto
            // 
            this.B_remoto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_remoto.Location = new System.Drawing.Point(12, 266);
            this.B_remoto.Name = "B_remoto";
            this.B_remoto.Size = new System.Drawing.Size(101, 29);
            this.B_remoto.TabIndex = 31;
            this.B_remoto.Text = "Asistencia remota";
            this.B_remoto.UseVisualStyleBackColor = true;
            this.B_remoto.Click += new System.EventHandler(this.B_remoto_Click);
            // 
            // B_opcions
            // 
            this.B_opcions.Location = new System.Drawing.Point(174, 266);
            this.B_opcions.Name = "B_opcions";
            this.B_opcions.Size = new System.Drawing.Size(101, 29);
            this.B_opcions.TabIndex = 30;
            this.B_opcions.Text = "Opcións";
            this.B_opcions.UseVisualStyleBackColor = true;
            this.B_opcions.Click += new System.EventHandler(this.B_opcions_Click);
            // 
            // MenuIconaNotificacion
            // 
            this.MenuIconaNotificacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoto,
            this.toolStripSeparator1,
            this.menuCambiarAConexion1,
            this.menuCambiarAConexion2,
            this.toolStripSeparator2,
            this.menuMostrarAplicativo,
            this.toolStripSeparator3,
            this.menuPechar});
            this.MenuIconaNotificacion.Name = "MenuIconaNotificacion";
            this.MenuIconaNotificacion.Size = new System.Drawing.Size(220, 132);
            // 
            // menuRemoto
            // 
            this.menuRemoto.Name = "menuRemoto";
            this.menuRemoto.Size = new System.Drawing.Size(219, 22);
            this.menuRemoto.Text = "Asistencia remota";
            this.menuRemoto.Click += new System.EventHandler(this.B_remoto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // menuCambiarAConexion1
            // 
            this.menuCambiarAConexion1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCambiarAConexion1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuCambiarAConexion1.Name = "menuCambiarAConexion1";
            this.menuCambiarAConexion1.Size = new System.Drawing.Size(219, 22);
            this.menuCambiarAConexion1.Text = "Cambiar á conexión 1";
            this.menuCambiarAConexion1.Click += new System.EventHandler(this.CambiarAConexion1_Click);
            // 
            // menuCambiarAConexion2
            // 
            this.menuCambiarAConexion2.Name = "menuCambiarAConexion2";
            this.menuCambiarAConexion2.Size = new System.Drawing.Size(219, 22);
            this.menuCambiarAConexion2.Text = "Cambiar á conexión 2";
            this.menuCambiarAConexion2.Click += new System.EventHandler(this.CambiarAConexion2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // menuMostrarAplicativo
            // 
            this.menuMostrarAplicativo.Name = "menuMostrarAplicativo";
            this.menuMostrarAplicativo.Size = new System.Drawing.Size(219, 22);
            this.menuMostrarAplicativo.Text = "Mostrar / Ocultar aplicativo";
            this.menuMostrarAplicativo.Click += new System.EventHandler(this.MostrarAplicativo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // menuPechar
            // 
            this.menuPechar.Name = "menuPechar";
            this.menuPechar.Size = new System.Drawing.Size(219, 22);
            this.menuPechar.Text = "Pechar";
            this.menuPechar.Click += new System.EventHandler(this.Pechar_Click);
            // 
            // IconaNotificacion
            // 
            this.IconaNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IconaNotificacion.ContextMenuStrip = this.MenuIconaNotificacion;
            this.IconaNotificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("IconaNotificacion.Icon")));
            this.IconaNotificacion.Text = "Cambio de conexión";
            this.IconaNotificacion.Visible = true;
            this.IconaNotificacion.BalloonTipClosed += new System.EventHandler(this.IconaNotificacion_BalloonTipClosed);
            this.IconaNotificacion.DoubleClick += new System.EventHandler(this.IconaNotificacion_DoubleClick);
            this.IconaNotificacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IconaNotificacion_MouseMove);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenciaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(287, 24);
            this.menu.TabIndex = 32;
            this.menu.Text = "menu";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_conexion_pe);
            this.groupBox1.Controls.Add(this.TB_conexion_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 87);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONEXIÓN ACTUAL";
            // 
            // TB_conexion_pe
            // 
            this.TB_conexion_pe.BackColor = System.Drawing.Color.White;
            this.TB_conexion_pe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_conexion_pe.ForeColor = System.Drawing.Color.Gray;
            this.TB_conexion_pe.Location = new System.Drawing.Point(12, 51);
            this.TB_conexion_pe.Name = "TB_conexion_pe";
            this.TB_conexion_pe.ReadOnly = true;
            this.TB_conexion_pe.Size = new System.Drawing.Size(229, 22);
            this.TB_conexion_pe.TabIndex = 28;
            this.TB_conexion_pe.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_PE2);
            this.groupBox2.Controls.Add(this.B_PE1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(17, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 120);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAMBIAR CONEXIÓN";
            // 
            // B_PE2
            // 
            this.B_PE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_PE2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_PE2.Location = new System.Drawing.Point(12, 68);
            this.B_PE2.Name = "B_PE2";
            this.B_PE2.Size = new System.Drawing.Size(229, 36);
            this.B_PE2.TabIndex = 30;
            this.B_PE2.Text = "B_PE2";
            this.B_PE2.UseVisualStyleBackColor = true;
            this.B_PE2.Click += new System.EventHandler(this.B_PE2_Click);
            // 
            // B_PE1
            // 
            this.B_PE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_PE1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_PE1.Location = new System.Drawing.Point(12, 24);
            this.B_PE1.Name = "B_PE1";
            this.B_PE1.Size = new System.Drawing.Size(229, 38);
            this.B_PE1.TabIndex = 29;
            this.B_PE1.Text = "B_PE1";
            this.B_PE1.UseVisualStyleBackColor = true;
            this.B_PE1.Click += new System.EventHandler(this.B_PE1_Click);
            // 
            // TB_conexion_nome
            // 
            this.TB_conexion_nome.BackColor = System.Drawing.Color.White;
            this.TB_conexion_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_conexion_nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_conexion_nome.Location = new System.Drawing.Point(12, 23);
            this.TB_conexion_nome.Name = "TB_conexion_nome";
            this.TB_conexion_nome.ReadOnly = true;
            this.TB_conexion_nome.Size = new System.Drawing.Size(229, 22);
            this.TB_conexion_nome.TabIndex = 27;
            this.TB_conexion_nome.TabStop = false;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.B_remoto);
            this.Controls.Add(this.B_opcions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio PE";
            this.Load += new System.EventHandler(this.F_principal_Load);
            this.Resize += new System.EventHandler(this.F_principal_Resize);
            this.MenuIconaNotificacion.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button B_remoto;
        internal System.Windows.Forms.Button B_opcions;
        private System.Windows.Forms.ContextMenuStrip MenuIconaNotificacion;
        private System.Windows.Forms.NotifyIcon IconaNotificacion;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarAConexion1;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarAConexion2;
        private System.Windows.Forms.ToolStripMenuItem menuMostrarAplicativo;
        private System.Windows.Forms.ToolStripMenuItem menuPechar;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRemoto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox TB_conexion_pe;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button B_PE2;
        internal System.Windows.Forms.Button B_PE1;
        internal System.Windows.Forms.TextBox TB_conexion_nome;
    }
}

