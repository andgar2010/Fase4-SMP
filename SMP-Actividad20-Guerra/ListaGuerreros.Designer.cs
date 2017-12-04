namespace SMP_Actividad20_Guerra
{
    partial class ListaGuerreros
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnListaGuerreros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvGuerreros = new System.Windows.Forms.DataGridView();
            this.picxClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuerreros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnListaGuerreros);
            this.panel1.Controls.Add(this.dgvGuerreros);
            this.panel1.Location = new System.Drawing.Point(9, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 454);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(121, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de guerreros";
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
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnListaGuerreros
            // 
            this.btnListaGuerreros.AutoSize = true;
            this.btnListaGuerreros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaGuerreros.Depth = 0;
            this.btnListaGuerreros.Icon = null;
            this.btnListaGuerreros.Location = new System.Drawing.Point(136, 74);
            this.btnListaGuerreros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaGuerreros.Name = "btnListaGuerreros";
            this.btnListaGuerreros.Primary = true;
            this.btnListaGuerreros.Size = new System.Drawing.Size(225, 36);
            this.btnListaGuerreros.TabIndex = 15;
            this.btnListaGuerreros.Text = "Muestra lista de guerreros";
            this.btnListaGuerreros.UseVisualStyleBackColor = true;
            this.btnListaGuerreros.Click += new System.EventHandler(this.btnListaGuerreros_Click);
            // 
            // dgvGuerreros
            // 
            this.dgvGuerreros.AllowUserToAddRows = false;
            this.dgvGuerreros.AllowUserToDeleteRows = false;
            this.dgvGuerreros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGuerreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuerreros.Location = new System.Drawing.Point(21, 126);
            this.dgvGuerreros.Name = "dgvGuerreros";
            this.dgvGuerreros.ReadOnly = true;
            this.dgvGuerreros.RowHeadersVisible = false;
            this.dgvGuerreros.Size = new System.Drawing.Size(454, 306);
            this.dgvGuerreros.TabIndex = 14;
            // 
            // picxClose
            // 
            this.picxClose.BackColor = System.Drawing.Color.Transparent;
            this.picxClose.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.buttonClose;
            this.picxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picxClose.Location = new System.Drawing.Point(459, 12);
            this.picxClose.Name = "picxClose";
            this.picxClose.Size = new System.Drawing.Size(44, 35);
            this.picxClose.TabIndex = 21;
            this.picxClose.TabStop = false;
            this.picxClose.Click += new System.EventHandler(this.picxClose_Click);
            // 
            // ListaGuerreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.TojanSoldados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 519);
            this.Controls.Add(this.picxClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaGuerreros";
            this.Text = "ListaGuerreros";
            this.Load += new System.EventHandler(this.ListaGuerreros_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuerreros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGuerreros;
        private MaterialSkin.Controls.MaterialRaisedButton btnListaGuerreros;
        private MaterialSkin.Controls.MaterialRaisedButton btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picxClose;
    }
}