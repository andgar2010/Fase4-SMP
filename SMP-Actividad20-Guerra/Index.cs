using System;
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
    public partial class Index : Form
    {
        Conexion Con = new Conexion();
        private PictureBox pb = new PictureBox();

        public Index()
        {
            InitializeComponent();
        }

        private async void Index_LoadAsync(object sender, EventArgs e)
        {
            btnHistoricoPartidos.Enabled = false;
            btnHistoricoPartidos.Visible = false;

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

        private void btnCrearGuerreros_Click(object sender, EventArgs e)
        {
            NuevoGuerrero newGuer = new NuevoGuerrero();
            newGuer.Show();
            this.Hide();
        }

        private void btnListaGuerreros_Click(object sender, EventArgs e)
        {
            ListaGuerreros listGue = new ListaGuerreros();
            listGue.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Andrés Garcia\nFicha 1320652 - 2\nADSI FASE 4\n(C) 2017 Bogotá");
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            CampoBatalla campBat = new CampoBatalla();
            this.Hide();
            campBat.Show();
        }

        private void btnHistoricoPartidos_Click(object sender, EventArgs e)
        {
            HistoricoPartidos hisPa = new HistoricoPartidos();
            this.Hide();
            hisPa.Show();
        }

        private void picxClose_Click(object sender, EventArgs e)
        {
            Con.CerrarConexionBD();
            Application.Exit();
        }
    }
}
