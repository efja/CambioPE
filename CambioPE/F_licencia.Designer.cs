namespace CambioPE
{
    partial class F_licencia
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
            this.B_aceptar = new System.Windows.Forms.Button();
            this.RTB_Licencia = new System.Windows.Forms.RichTextBox();
            this.L_licencia = new System.Windows.Forms.Label();
            this.dialogo_buscar = new System.Windows.Forms.OpenFileDialog();
            this.PB_esquerda = new System.Windows.Forms.PictureBox();
            this.L_autor = new System.Windows.Forms.Label();
            this.L_version = new System.Windows.Forms.Label();
            this.L_nome_programa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_esquerda)).BeginInit();
            this.SuspendLayout();
            // 
            // B_aceptar
            // 
            this.B_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_aceptar.Location = new System.Drawing.Point(213, 429);
            this.B_aceptar.Name = "B_aceptar";
            this.B_aceptar.Size = new System.Drawing.Size(82, 24);
            this.B_aceptar.TabIndex = 20;
            this.B_aceptar.Text = "Aceptar";
            this.B_aceptar.UseVisualStyleBackColor = true;
            this.B_aceptar.Click += new System.EventHandler(this.B_aceptar_Click);
            // 
            // RTB_Licencia
            // 
            this.RTB_Licencia.BackColor = System.Drawing.Color.White;
            this.RTB_Licencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Licencia.Location = new System.Drawing.Point(12, 97);
            this.RTB_Licencia.Name = "RTB_Licencia";
            this.RTB_Licencia.ReadOnly = true;
            this.RTB_Licencia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTB_Licencia.ShowSelectionMargin = true;
            this.RTB_Licencia.Size = new System.Drawing.Size(484, 326);
            this.RTB_Licencia.TabIndex = 22;
            this.RTB_Licencia.TabStop = false;
            this.RTB_Licencia.Text = "";
            // 
            // L_licencia
            // 
            this.L_licencia.AutoSize = true;
            this.L_licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_licencia.Location = new System.Drawing.Point(194, 78);
            this.L_licencia.Name = "L_licencia";
            this.L_licencia.Size = new System.Drawing.Size(121, 16);
            this.L_licencia.TabIndex = 25;
            this.L_licencia.Text = "Licencia de uso:";
            // 
            // dialogo_buscar
            // 
            this.dialogo_buscar.FileName = "openFileDialog1";
            // 
            // PB_esquerda
            // 
            this.PB_esquerda.Image = global::CambioPE.Properties.Resources.icono1;
            this.PB_esquerda.Location = new System.Drawing.Point(12, 0);
            this.PB_esquerda.Name = "PB_esquerda";
            this.PB_esquerda.Size = new System.Drawing.Size(100, 94);
            this.PB_esquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_esquerda.TabIndex = 30;
            this.PB_esquerda.TabStop = false;
            // 
            // L_autor
            // 
            this.L_autor.AutoSize = true;
            this.L_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_autor.Location = new System.Drawing.Point(153, 9);
            this.L_autor.Name = "L_autor";
            this.L_autor.Size = new System.Drawing.Size(242, 13);
            this.L_autor.TabIndex = 27;
            this.L_autor.Text = "Autor: Francisco Javier González Campos";
            // 
            // L_version
            // 
            this.L_version.AutoSize = true;
            this.L_version.Location = new System.Drawing.Point(216, 49);
            this.L_version.Name = "L_version";
            this.L_version.Size = new System.Drawing.Size(77, 13);
            this.L_version.TabIndex = 28;
            this.L_version.Text = "versión 1.0.0.0";
            // 
            // L_nome_programa
            // 
            this.L_nome_programa.AutoSize = true;
            this.L_nome_programa.Location = new System.Drawing.Point(226, 29);
            this.L_nome_programa.Name = "L_nome_programa";
            this.L_nome_programa.Size = new System.Drawing.Size(56, 13);
            this.L_nome_programa.TabIndex = 29;
            this.L_nome_programa.Text = "CambioPE";
            // 
            // F_licencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 462);
            this.Controls.Add(this.L_nome_programa);
            this.Controls.Add(this.L_version);
            this.Controls.Add(this.L_autor);
            this.Controls.Add(this.PB_esquerda);
            this.Controls.Add(this.L_licencia);
            this.Controls.Add(this.RTB_Licencia);
            this.Controls.Add(this.B_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_licencia";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Licencia de uso";
            this.Load += new System.EventHandler(this.F_licencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_esquerda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button B_aceptar;
        private System.Windows.Forms.RichTextBox RTB_Licencia;
        internal System.Windows.Forms.Label L_licencia;
        private System.Windows.Forms.OpenFileDialog dialogo_buscar;
        private System.Windows.Forms.PictureBox PB_esquerda;
        private System.Windows.Forms.Label L_autor;
        private System.Windows.Forms.Label L_version;
        private System.Windows.Forms.Label L_nome_programa;
    }
}