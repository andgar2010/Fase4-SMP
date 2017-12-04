namespace SMP_Actividad20_Guerra
{
    partial class CampoBatalla
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampoBatalla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumFuerzaT = new System.Windows.Forms.Label();
            this.lblNumFuerzaG = new System.Windows.Forms.Label();
            this.picxTrojan = new System.Windows.Forms.PictureBox();
            this.picxGreek = new System.Windows.Forms.PictureBox();
            this.lblMsgStatus = new System.Windows.Forms.Label();
            this.lblFuerzaTroyano = new System.Windows.Forms.Label();
            this.progressBarFuerzaTroyano = new System.Windows.Forms.ProgressBar();
            this.lblFuerzaGriego = new System.Windows.Forms.Label();
            this.progressBarFuerzaGriego = new System.Windows.Forms.ProgressBar();
            this.lblMsgTroyano = new System.Windows.Forms.Label();
            this.lblMsgGriego = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarBatalla = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.picxClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxTrojan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxGreek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumFuerzaT);
            this.panel1.Controls.Add(this.lblNumFuerzaG);
            this.panel1.Controls.Add(this.picxTrojan);
            this.panel1.Controls.Add(this.picxGreek);
            this.panel1.Controls.Add(this.lblMsgStatus);
            this.panel1.Controls.Add(this.lblFuerzaTroyano);
            this.panel1.Controls.Add(this.progressBarFuerzaTroyano);
            this.panel1.Controls.Add(this.lblFuerzaGriego);
            this.panel1.Controls.Add(this.progressBarFuerzaGriego);
            this.panel1.Controls.Add(this.lblMsgTroyano);
            this.panel1.Controls.Add(this.lblMsgGriego);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIniciarBatalla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.animator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 501);
            this.panel1.TabIndex = 0;
            // 
            // lblNumFuerzaT
            // 
            this.lblNumFuerzaT.AutoSize = true;
            this.animator1.SetDecoration(this.lblNumFuerzaT, AnimatorNS.DecorationType.None);
            this.lblNumFuerzaT.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFuerzaT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumFuerzaT.Location = new System.Drawing.Point(136, 321);
            this.lblNumFuerzaT.Name = "lblNumFuerzaT";
            this.lblNumFuerzaT.Size = new System.Drawing.Size(19, 22);
            this.lblNumFuerzaT.TabIndex = 31;
            this.lblNumFuerzaT.Text = "#";
            // 
            // lblNumFuerzaG
            // 
            this.lblNumFuerzaG.AutoSize = true;
            this.animator1.SetDecoration(this.lblNumFuerzaG, AnimatorNS.DecorationType.None);
            this.lblNumFuerzaG.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFuerzaG.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumFuerzaG.Location = new System.Drawing.Point(526, 322);
            this.lblNumFuerzaG.Name = "lblNumFuerzaG";
            this.lblNumFuerzaG.Size = new System.Drawing.Size(19, 22);
            this.lblNumFuerzaG.TabIndex = 30;
            this.lblNumFuerzaG.Text = "#";
            // 
            // picxTrojan
            // 
            this.picxTrojan.BackColor = System.Drawing.Color.Transparent;
            this.picxTrojan.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.SoldadoTroyano;
            this.picxTrojan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.picxTrojan, AnimatorNS.DecorationType.None);
            this.picxTrojan.Location = new System.Drawing.Point(74, 180);
            this.picxTrojan.Name = "picxTrojan";
            this.picxTrojan.Size = new System.Drawing.Size(151, 85);
            this.picxTrojan.TabIndex = 34;
            this.picxTrojan.TabStop = false;
            // 
            // picxGreek
            // 
            this.picxGreek.BackColor = System.Drawing.Color.Transparent;
            this.picxGreek.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.SoldadoGriego;
            this.picxGreek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.picxGreek, AnimatorNS.DecorationType.None);
            this.picxGreek.Location = new System.Drawing.Point(460, 180);
            this.picxGreek.Name = "picxGreek";
            this.picxGreek.Size = new System.Drawing.Size(151, 85);
            this.picxGreek.TabIndex = 33;
            this.picxGreek.TabStop = false;
            // 
            // lblMsgStatus
            // 
            this.lblMsgStatus.AutoSize = true;
            this.lblMsgStatus.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblMsgStatus, AnimatorNS.DecorationType.None);
            this.lblMsgStatus.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMsgStatus.Location = new System.Drawing.Point(3, 127);
            this.lblMsgStatus.Name = "lblMsgStatus";
            this.lblMsgStatus.Size = new System.Drawing.Size(32, 26);
            this.lblMsgStatus.TabIndex = 32;
            this.lblMsgStatus.Text = "....";
            // 
            // lblFuerzaTroyano
            // 
            this.lblFuerzaTroyano.AutoSize = true;
            this.lblFuerzaTroyano.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblFuerzaTroyano, AnimatorNS.DecorationType.None);
            this.lblFuerzaTroyano.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuerzaTroyano.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFuerzaTroyano.Location = new System.Drawing.Point(126, 298);
            this.lblFuerzaTroyano.Name = "lblFuerzaTroyano";
            this.lblFuerzaTroyano.Size = new System.Drawing.Size(47, 17);
            this.lblFuerzaTroyano.TabIndex = 29;
            this.lblFuerzaTroyano.Text = "Fuerza";
            // 
            // progressBarFuerzaTroyano
            // 
            this.animator1.SetDecoration(this.progressBarFuerzaTroyano, AnimatorNS.DecorationType.None);
            this.progressBarFuerzaTroyano.Location = new System.Drawing.Point(74, 318);
            this.progressBarFuerzaTroyano.Name = "progressBarFuerzaTroyano";
            this.progressBarFuerzaTroyano.Size = new System.Drawing.Size(151, 29);
            this.progressBarFuerzaTroyano.TabIndex = 28;
            // 
            // lblFuerzaGriego
            // 
            this.lblFuerzaGriego.AutoSize = true;
            this.lblFuerzaGriego.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblFuerzaGriego, AnimatorNS.DecorationType.None);
            this.lblFuerzaGriego.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuerzaGriego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFuerzaGriego.Location = new System.Drawing.Point(512, 298);
            this.lblFuerzaGriego.Name = "lblFuerzaGriego";
            this.lblFuerzaGriego.Size = new System.Drawing.Size(47, 17);
            this.lblFuerzaGriego.TabIndex = 27;
            this.lblFuerzaGriego.Text = "Fuerza";
            // 
            // progressBarFuerzaGriego
            // 
            this.animator1.SetDecoration(this.progressBarFuerzaGriego, AnimatorNS.DecorationType.None);
            this.progressBarFuerzaGriego.Location = new System.Drawing.Point(460, 318);
            this.progressBarFuerzaGriego.Name = "progressBarFuerzaGriego";
            this.progressBarFuerzaGriego.Size = new System.Drawing.Size(151, 29);
            this.progressBarFuerzaGriego.TabIndex = 26;
            // 
            // lblMsgTroyano
            // 
            this.lblMsgTroyano.AutoSize = true;
            this.lblMsgTroyano.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblMsgTroyano, AnimatorNS.DecorationType.None);
            this.lblMsgTroyano.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTroyano.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMsgTroyano.Location = new System.Drawing.Point(70, 350);
            this.lblMsgTroyano.Name = "lblMsgTroyano";
            this.lblMsgTroyano.Size = new System.Drawing.Size(107, 22);
            this.lblMsgTroyano.TabIndex = 25;
            this.lblMsgTroyano.Text = "msgTroyano";
            // 
            // lblMsgGriego
            // 
            this.lblMsgGriego.AutoSize = true;
            this.lblMsgGriego.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblMsgGriego, AnimatorNS.DecorationType.None);
            this.lblMsgGriego.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgGriego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMsgGriego.Location = new System.Drawing.Point(456, 350);
            this.lblMsgGriego.Name = "lblMsgGriego";
            this.lblMsgGriego.Size = new System.Drawing.Size(93, 22);
            this.lblMsgGriego.TabIndex = 24;
            this.lblMsgGriego.Text = "msgGriego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Noto Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(103, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Troyano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Noto Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(498, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Griego:";
            // 
            // btnIniciarBatalla
            // 
            this.btnIniciarBatalla.AutoSize = true;
            this.btnIniciarBatalla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.animator1.SetDecoration(this.btnIniciarBatalla, AnimatorNS.DecorationType.None);
            this.btnIniciarBatalla.Depth = 0;
            this.btnIniciarBatalla.Icon = null;
            this.btnIniciarBatalla.Location = new System.Drawing.Point(271, 63);
            this.btnIniciarBatalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarBatalla.Name = "btnIniciarBatalla";
            this.btnIniciarBatalla.Primary = true;
            this.btnIniciarBatalla.Size = new System.Drawing.Size(132, 36);
            this.btnIniciarBatalla.TabIndex = 21;
            this.btnIniciarBatalla.Text = "Iniciar batalla";
            this.btnIniciarBatalla.UseVisualStyleBackColor = true;
            this.btnIniciarBatalla.Click += new System.EventHandler(this.btnIniciarBatalla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "CAMPO DE BATALLA";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.animator1.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.btnMenu.Depth = 0;
            this.btnMenu.Icon = null;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = true;
            this.btnMenu.Size = new System.Drawing.Size(59, 36);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // picxClose
            // 
            this.picxClose.BackColor = System.Drawing.Color.Transparent;
            this.picxClose.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.buttonClose;
            this.picxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.picxClose, AnimatorNS.DecorationType.None);
            this.picxClose.Location = new System.Drawing.Point(688, 1);
            this.picxClose.Name = "picxClose";
            this.picxClose.Size = new System.Drawing.Size(45, 30);
            this.picxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picxClose.TabIndex = 1;
            this.picxClose.TabStop = false;
            this.picxClose.Click += new System.EventHandler(this.picxClose_Click);
            // 
            // CampoBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMP_Actividad20_Guerra.Properties.Resources.BatallaPrevia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 574);
            this.Controls.Add(this.picxClose);
            this.Controls.Add(this.panel1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CampoBatalla";
            this.Text = "Campo de batalla";
            this.Load += new System.EventHandler(this.CampoBatalla_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxTrojan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxGreek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMenu;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnIniciarBatalla;
        private System.Windows.Forms.Label lblMsgTroyano;
        private System.Windows.Forms.Label lblMsgGriego;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.PictureBox picxClose;
        private System.Windows.Forms.ProgressBar progressBarFuerzaGriego;
        private System.Windows.Forms.Label lblFuerzaGriego;
        private System.Windows.Forms.Label lblFuerzaTroyano;
        private System.Windows.Forms.ProgressBar progressBarFuerzaTroyano;
        private System.Windows.Forms.Label lblNumFuerzaT;
        private System.Windows.Forms.Label lblNumFuerzaG;
        private System.Windows.Forms.Label lblMsgStatus;
        private System.Windows.Forms.PictureBox picxGreek;
        private System.Windows.Forms.PictureBox picxTrojan;
    }
}