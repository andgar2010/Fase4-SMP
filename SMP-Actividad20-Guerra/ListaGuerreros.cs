using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Guerrero;
using SMP_Actividad20_Guerra.Model;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using BlurBackground;

namespace SMP_Actividad20_Guerra
{
    public partial class ListaGuerreros : Form
    {
        Conexion Con = new Conexion();
        private PictureBox pb = new PictureBox();


        public ListaGuerreros()
        {
            InitializeComponent();
        }

        private async void ListaGuerreros_LoadAsync(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index menu = new Index();
            menu.Show();
        }

        private void btnListaGuerreros_Click(object sender, EventArgs e)
        {
            Con.CargarDatosGuerrerosToBD(dgvGuerreros);
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Index menu = new Index();
            menu.Show();
        }

        private void picxClose_Click(object sender, EventArgs e)
        {
            Con.CerrarConexionBD();
            Application.Exit();
        }
    }
}
