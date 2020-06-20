namespace CambioPE
{
    partial class F_config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_conexion2_pe = new System.Windows.Forms.TextBox();
            this.TB_conexion2_nome = new System.Windows.Forms.TextBox();
            this.L_conexion2 = new System.Windows.Forms.Label();
            this.TB_conexion1_pe = new System.Windows.Forms.TextBox();
            this.B_cancelar = new System.Windows.Forms.Button();
            this.B_aceptar = new System.Windows.Forms.Button();
            this.TB_conexion1_nome = new System.Windows.Forms.TextBox();
            this.L_conexion1 = new System.Windows.Forms.Label();
            this.TB_remoto = new System.Windows.Forms.TextBox();
            this.L_remoto = new System.Windows.Forms.Label();
            this.dialogo_buscar_remoto = new System.Windows.Forms.OpenFileDialog();
            this.B_examinar = new System.Windows.Forms.Button();
            this.B_copiarIP1 = new System.Windows.Forms.Button();
            this.B_copiarIP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_conexion2_pe
            // 
            this.TB_conexion2_pe.Location = new System.Drawing.Point(20, 190);
            this.TB_conexion2_pe.Multiline = true;
            this.TB_conexion2_pe.Name = "TB_conexion2_pe";
            this.TB_conexion2_pe.Size = new System.Drawing.Size(187, 21);
            this.TB_conexion2_pe.TabIndex = 6;
            // 
            // TB_conexion2_nome
            // 
            this.TB_conexion2_nome.Location = new System.Drawing.Point(20, 163);
            this.TB_conexion2_nome.Multiline = true;
            this.TB_conexion2_nome.Name = "TB_conexion2_nome";
            this.TB_conexion2_nome.Size = new System.Drawing.Size(243, 21);
            this.TB_conexion2_nome.TabIndex = 5;
            // 
            // L_conexion2
            // 
            this.L_conexion2.AutoSize = true;
            this.L_conexion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_conexion2.Location = new System.Drawing.Point(20, 141);
            this.L_conexion2.Name = "L_conexion2";
            this.L_conexion2.Size = new System.Drawing.Size(63, 13);
            this.L_conexion2.TabIndex = 21;
            this.L_conexion2.Text = "Conexion 2:";
            // 
            // TB_conexion1_pe
            // 
            this.TB_conexion1_pe.Location = new System.Drawing.Point(20, 111);
            this.TB_conexion1_pe.Multiline = true;
            this.TB_conexion1_pe.Name = "TB_conexion1_pe";
            this.TB_conexion1_pe.Size = new System.Drawing.Size(187, 21);
            this.TB_conexion1_pe.TabIndex = 4;
            // 
            // B_cancelar
            // 
            this.B_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_cancelar.Location = new System.Drawing.Point(102, 236);
            this.B_cancelar.Name = "B_cancelar";
            this.B_cancelar.Size = new System.Drawing.Size(82, 24);
            this.B_cancelar.TabIndex = 8;
            this.B_cancelar.Text = "Cancelar";
            this.B_cancelar.UseVisualStyleBackColor = true;
            this.B_cancelar.Click += new System.EventHandler(this.B_cancelar_Click);
            // 
            // B_aceptar
            // 
            this.B_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_aceptar.Location = new System.Drawing.Point(190, 236);
            this.B_aceptar.Name = "B_aceptar";
            this.B_aceptar.Size = new System.Drawing.Size(82, 24);
            this.B_aceptar.TabIndex = 7;
            this.B_aceptar.Text = "Aceptar";
            this.B_aceptar.UseVisualStyleBackColor = true;
            this.B_aceptar.Click += new System.EventHandler(this.B_aceptar_Click);
            // 
            // TB_conexion1_nome
            // 
            this.TB_conexion1_nome.Location = new System.Drawing.Point(20, 84);
            this.TB_conexion1_nome.Multiline = true;
            this.TB_conexion1_nome.Name = "TB_conexion1_nome";
            this.TB_conexion1_nome.Size = new System.Drawing.Size(243, 21);
            this.TB_conexion1_nome.TabIndex = 3;
            // 
            // L_conexion1
            // 
            this.L_conexion1.AutoSize = true;
            this.L_conexion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_conexion1.Location = new System.Drawing.Point(20, 62);
            this.L_conexion1.Name = "L_conexion1";
            this.L_conexion1.Size = new System.Drawing.Size(63, 13);
            this.L_conexion1.TabIndex = 16;
            this.L_conexion1.Text = "Conexion 1:";
            // 
            // TB_remoto
            // 
            this.TB_remoto.AutoCompleteCustomSource.AddRange(new string[] {
            "TeamViewerQS.exe",
            "AnyDesk.exe"});
            this.TB_remoto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_remoto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_remoto.Location = new System.Drawing.Point(20, 34);
            this.TB_remoto.Name = "TB_remoto";
            this.TB_remoto.Size = new System.Drawing.Size(187, 20);
            this.TB_remoto.TabIndex = 1;
            this.TB_remoto.WordWrap = false;
            // 
            // L_remoto
            // 
            this.L_remoto.AutoSize = true;
            this.L_remoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_remoto.Location = new System.Drawing.Point(20, 16);
            this.L_remoto.Name = "L_remoto";
            this.L_remoto.Size = new System.Drawing.Size(89, 13);
            this.L_remoto.TabIndex = 24;
            this.L_remoto.Text = "Conexion remota:";
            // 
            // dialogo_buscar_remoto
            // 
            this.dialogo_buscar_remoto.DefaultExt = "exe";
            this.dialogo_buscar_remoto.FileName = "TeamViewerQS.exe";
            this.dialogo_buscar_remoto.Filter = "Executables (*.exe)|*.exe";
            // 
            // B_examinar
            // 
            this.B_examinar.Location = new System.Drawing.Point(213, 32);
            this.B_examinar.Name = "B_examinar";
            this.B_examinar.Size = new System.Drawing.Size(59, 25);
            this.B_examinar.TabIndex = 2;
            this.B_examinar.Text = "Buscar...";
            this.B_examinar.UseVisualStyleBackColor = true;
            this.B_examinar.Click += new System.EventHandler(this.B_examinar_Click);
            // 
            // B_copiarIP1
            // 
            this.B_copiarIP1.Location = new System.Drawing.Point(212, 111);
            this.B_copiarIP1.Name = "B_copiarIP1";
            this.B_copiarIP1.Size = new System.Drawing.Size(59, 25);
            this.B_copiarIP1.TabIndex = 25;
            this.B_copiarIP1.Text = "Copiar IP";
            this.B_copiarIP1.UseVisualStyleBackColor = true;
            this.B_copiarIP1.Click += new System.EventHandler(this.B_copiarIP1_Click);
            // 
            // B_copiarIP2
            // 
            this.B_copiarIP2.Location = new System.Drawing.Point(212, 190);
            this.B_copiarIP2.Name = "B_copiarIP2";
            this.B_copiarIP2.Size = new System.Drawing.Size(59, 25);
            this.B_copiarIP2.TabIndex = 26;
            this.B_copiarIP2.Text = "Copiar IP";
            this.B_copiarIP2.UseVisualStyleBackColor = true;
            this.B_copiarIP2.Click += new System.EventHandler(this.B_copiarIP2_Click);
            // 
            // F_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_cancelar;
            this.ClientSize = new System.Drawing.Size(283, 283);
            this.Controls.Add(this.B_copiarIP2);
            this.Controls.Add(this.B_copiarIP1);
            this.Controls.Add(this.B_examinar);
            this.Controls.Add(this.TB_remoto);
            this.Controls.Add(this.L_remoto);
            this.Controls.Add(this.TB_conexion2_pe);
            this.Controls.Add(this.TB_conexion2_nome);
            this.Controls.Add(this.L_conexion2);
            this.Controls.Add(this.TB_conexion1_pe);
            this.Controls.Add(this.B_cancelar);
            this.Controls.Add(this.B_aceptar);
            this.Controls.Add(this.TB_conexion1_nome);
            this.Controls.Add(this.L_conexion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.F_config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox TB_conexion2_pe;
        internal System.Windows.Forms.TextBox TB_conexion2_nome;
        internal System.Windows.Forms.Label L_conexion2;
        internal System.Windows.Forms.TextBox TB_conexion1_pe;
        internal System.Windows.Forms.Button B_cancelar;
        internal System.Windows.Forms.Button B_aceptar;
        internal System.Windows.Forms.TextBox TB_conexion1_nome;
        internal System.Windows.Forms.Label L_conexion1;
        internal System.Windows.Forms.TextBox TB_remoto;
        internal System.Windows.Forms.Label L_remoto;
        private System.Windows.Forms.OpenFileDialog dialogo_buscar_remoto;
        private System.Windows.Forms.Button B_examinar;
        private System.Windows.Forms.Button B_copiarIP1;
        private System.Windows.Forms.Button B_copiarIP2;
    }
}