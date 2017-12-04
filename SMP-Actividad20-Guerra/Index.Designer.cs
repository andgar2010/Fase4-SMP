namespace SMP_Actividad20_Guerra
{
    partial class Index
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBatalla = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaGuerreros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCrearGuerreros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picxClose = new System.Windows.Forms.PictureBox();
            this.btnHistoricoPartidos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistoricoPartidos);
            this.panel1.Controls.Add(this.btnBatalla);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnListaGuerreros);
            this.panel1.Controls.Add(this.btnCrearGuerreros);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 328);
            this.panel1.TabIndex = 0;
            // 
            // btnBatalla
            // 
            this.btnBatalla.AutoSize = true;
            this.btnBatalla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBatalla.Depth = 0;
            this.btnBatalla.Icon = null;
            this.btnBatalla.Location = new System.Drawing.Point(40, 203);
            this.btnBatalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Primary = true;
            this.btnBatalla.Size = new System.Drawing.Size(152, 36);
            this.btnBatalla.TabIndex = 5;
            this.btnBatalla.Text = "Campo de Batalla";
            this.btnBatalla.UseVisualStyleBackColor = true;
            this.btnBatalla.Click += new System.EventHandler(this.btnBatalla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Acerca de";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "War Greek - Trojan";
            // 
            // btnListaGuerreros
            // 
            this.btnListaGuerreros.AutoSize = true;
            this.btnListaGuerreros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaGuerreros.Depth = 0;
            this.btnListaGuerreros.Icon = null;
            this.btnListaGuerreros.Location = new System.Drawing.Point(239, 120);
            this.btnListaGuerreros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaGuerreros.Name = "btnListaGuerreros";
            this.btnListaGuerreros.Primary = true;
            this.btnListaGuerreros.Size = new System.Drawing.Size(159, 36);
            this.btnListaGuerreros.TabIndex = 1;
            this.btnListaGuerreros.Text = "Lista de guerreros";
            this.btnListaGuerreros.UseVisualStyleBackColor = true;
            this.btnListaGuerreros.Click += new System.EventHandler(this.btnListaGuerreros_Click);
            // 
            // btnCrearGuerreros
            // 
            this.btnCrearGuerreros.AutoSize = true;
            this.btnCrearGuerreros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearGuerreros.Depth = 0;
            this.btnCrearGuerreros.Icon = null;
            this.btnCrearGuerreros.Location = new System.Drawing.Point(40, 120);
            this.btnCrearGuerreros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearGuerreros.Name = "btnCrearGuerreros";
            this.btnCrearGuerreros.Primary = true;
            this.btnCrearGuerreros.Size = new System.Drawing.Size(145, 36);
            this.btnCrearGuerreros.TabIndex = 0;
            this.btnCrearGuerreros.Text = "Crear guerreros";
            this.btnCrearGuerreros.UseVisualStyleBackColor = true;
            this.btnCrearGuerreros.Click += new System.EventHandler(this.btnCrearGuerreros_Click);
            // 
            // picxClose
            // 
            this.picxClose.BackColor = System.Drawing.Color.Transparent;
            this.picxClose.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.buttonClose;
            this.picxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picxClose.Location = new System.Drawing.Point(391, 0);
            this.picxClose.Name = "picxClose";
            this.picxClose.Size = new System.Drawing.Size(66, 36);
            this.picxClose.TabIndex = 1;
            this.picxClose.TabStop = false;
            this.picxClose.Click += new System.EventHandler(this.picxClose_Click);
            // 
            // btnHistoricoPartidos
            // 
            this.btnHistoricoPartidos.AutoSize = true;
            this.btnHistoricoPartidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistoricoPartidos.Depth = 0;
            this.btnHistoricoPartidos.Icon = null;
            this.btnHistoricoPartidos.Location = new System.Drawing.Point(238, 203);
            this.btnHistoricoPartidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricoPartidos.Name = "btnHistoricoPartidos";
            this.btnHistoricoPartidos.Primary = true;
            this.btnHistoricoPartidos.Size = new System.Drawing.Size(160, 36);
            this.btnHistoricoPartidos.TabIndex = 36;
            this.btnHistoricoPartidos.Text = "Historico partidos";
            this.btnHistoricoPartidos.UseVisualStyleBackColor = true;
            this.btnHistoricoPartidos.Click += new System.EventHandler(this.btnHistoricoPartidos_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.GreekTrojanWar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 396);
            this.Controls.Add(this.picxClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "SMP-Actividad20 Guerra";
            this.Load += new System.EventHandler(this.Index_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnListaGuerreros;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearGuerreros;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialRaisedButton btnBatalla;
        private System.Windows.Forms.PictureBox picxClose;
        private MaterialSkin.Controls.MaterialRaisedButton btnHistoricoPartidos;
    }
}

