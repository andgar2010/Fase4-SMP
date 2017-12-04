﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Collections;
using BLL_Guerrero;
using BlurBackground;
using SMP_Actividad20_Guerra.Model;

namespace SMP_Actividad20_Guerra
{
    public partial class HistoricoPartidos : Form
    {
        private PictureBox pb = new PictureBox();
        Conexion Con = new Conexion();

        public HistoricoPartidos()
        {
            InitializeComponent();
        }

        private async void HistoricoPartidos_LoadAsync(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;

            panel1.BackColor = Color.FromArgb(100, 44, 62, 80);

            await Task.Delay(500);

            Bitmap bmp = Screenshot.TakeSnapshot(panel1);
            BitmapFilter.GaussianBlur(bmp, 4);

            pb.Image = bmp;
            pb.Dock = DockStyle.Fill;
            pb.BringToFront();
            panel1.Controls.Add(pb);
        }

        private void picxClose_Click(object sender, EventArgs e)
        {
            Con.CerrarConexionBD();
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Index menu = new Index();
            this.Hide();
            menu.Show();
        }
    }
}
