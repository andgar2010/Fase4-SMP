namespace SMP_Actividad20_Guerra
{
    partial class HistoricoPartidos
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
            this.picxClose = new System.Windows.Forms.PictureBox();
            this.btnMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 463);
            this.panel1.TabIndex = 0;
            // 
            // picxClose
            // 
            this.picxClose.BackColor = System.Drawing.Color.Transparent;
            this.picxClose.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.buttonClose;
            this.picxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picxClose.Location = new System.Drawing.Point(749, 3);
            this.picxClose.Name = "picxClose";
            this.picxClose.Size = new System.Drawing.Size(52, 26);
            this.picxClose.TabIndex = 1;
            this.picxClose.TabStop = false;
            this.picxClose.Click += new System.EventHandler(this.picxClose_Click);
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
            // HistoricoPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.batalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 520);
            this.Controls.Add(this.picxClose);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoricoPartidos";
            this.Text = "HistoricoPartidos";
            this.Load += new System.EventHandler(this.HistoricoPartidos_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picxClose;
        private MaterialSkin.Controls.MaterialRaisedButton btnMenu;
    }
}