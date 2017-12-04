namespace SMP_Actividad20_Guerra
{
    partial class NuevoGuerrero
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgStauts = new System.Windows.Forms.Label();
            this.gbxGuerrero = new System.Windows.Forms.GroupBox();
            this.rbTroyano = new System.Windows.Forms.RadioButton();
            this.rbGriego = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCrearGuerrero = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picxClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbxGuerrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsgStauts);
            this.panel1.Controls.Add(this.gbxGuerrero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFuerza);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnCrearGuerrero);
            this.panel1.Location = new System.Drawing.Point(22, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 269);
            this.panel1.TabIndex = 0;
            // 
            // lblMsgStauts
            // 
            this.lblMsgStauts.AutoSize = true;
            this.lblMsgStauts.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgStauts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMsgStauts.Location = new System.Drawing.Point(39, 249);
            this.lblMsgStauts.Name = "lblMsgStauts";
            this.lblMsgStauts.Size = new System.Drawing.Size(22, 22);
            this.lblMsgStauts.TabIndex = 27;
            this.lblMsgStauts.Text = "   ";
            // 
            // gbxGuerrero
            // 
            this.gbxGuerrero.Controls.Add(this.rbTroyano);
            this.gbxGuerrero.Controls.Add(this.rbGriego);
            this.gbxGuerrero.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGuerrero.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxGuerrero.Location = new System.Drawing.Point(322, 83);
            this.gbxGuerrero.Name = "gbxGuerrero";
            this.gbxGuerrero.Size = new System.Drawing.Size(163, 100);
            this.gbxGuerrero.TabIndex = 26;
            this.gbxGuerrero.TabStop = false;
            this.gbxGuerrero.Text = "Tipo de guerrero";
            // 
            // rbTroyano
            // 
            this.rbTroyano.AutoSize = true;
            this.rbTroyano.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTroyano.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTroyano.Location = new System.Drawing.Point(19, 60);
            this.rbTroyano.Name = "rbTroyano";
            this.rbTroyano.Size = new System.Drawing.Size(94, 26);
            this.rbTroyano.TabIndex = 1;
            this.rbTroyano.TabStop = true;
            this.rbTroyano.Text = "Troyano";
            this.rbTroyano.UseVisualStyleBackColor = true;
            // 
            // rbGriego
            // 
            this.rbGriego.AutoSize = true;
            this.rbGriego.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGriego.ForeColor = System.Drawing.SystemColors.Control;
            this.rbGriego.Location = new System.Drawing.Point(19, 28);
            this.rbGriego.Name = "rbGriego";
            this.rbGriego.Size = new System.Drawing.Size(80, 26);
            this.rbGriego.TabIndex = 0;
            this.rbGriego.TabStop = true;
            this.rbGriego.Text = "Griego";
            this.rbGriego.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(29, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fuerza:";
            // 
            // txtFuerza
            // 
            this.txtFuerza.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuerza.Location = new System.Drawing.Point(110, 181);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(195, 28);
            this.txtFuerza.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(110, 138);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(195, 28);
            this.txtEdad.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(110, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 28);
            this.txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(29, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 22);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nuevo guerrero";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Depth = 0;
            this.btnMenu.Icon = null;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = true;
            this.btnMenu.Size = new System.Drawing.Size(59, 36);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCrearGuerrero
            // 
            this.btnCrearGuerrero.AutoSize = true;
            this.btnCrearGuerrero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearGuerrero.Depth = 0;
            this.btnCrearGuerrero.Icon = null;
            this.btnCrearGuerrero.Location = new System.Drawing.Point(336, 202);
            this.btnCrearGuerrero.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearGuerrero.Name = "btnCrearGuerrero";
            this.btnCrearGuerrero.Primary = true;
            this.btnCrearGuerrero.Size = new System.Drawing.Size(136, 36);
            this.btnCrearGuerrero.TabIndex = 11;
            this.btnCrearGuerrero.Text = "Crear Guerrero";
            this.btnCrearGuerrero.UseVisualStyleBackColor = true;
            this.btnCrearGuerrero.Click += new System.EventHandler(this.btnCrearGuerrero_ClickAsync);
            // 
            // picxClose
            // 
            this.picxClose.BackColor = System.Drawing.Color.Transparent;
            this.picxClose.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.buttonClose;
            this.picxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picxClose.Location = new System.Drawing.Point(509, 2);
            this.picxClose.Name = "picxClose";
            this.picxClose.Size = new System.Drawing.Size(44, 35);
            this.picxClose.TabIndex = 1;
            this.picxClose.TabStop = false;
            this.picxClose.Click += new System.EventHandler(this.picxClose_Click);
            // 
            // NuevoGuerrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.TojanSoldados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 342);
            this.Controls.Add(this.picxClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoGuerrero";
            this.Text = "Crear nuevo guerrero";
            this.Load += new System.EventHandler(this.NuevoGuerrero_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxGuerrero.ResumeLayout(false);
            this.gbxGuerrero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearGuerrero;
        private MaterialSkin.Controls.MaterialRaisedButton btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox gbxGuerrero;
        private System.Windows.Forms.RadioButton rbTroyano;
        private System.Windows.Forms.RadioButton rbGriego;
        private System.Windows.Forms.Label lblMsgStauts;
        private System.Windows.Forms.PictureBox picxClose;
    }
}