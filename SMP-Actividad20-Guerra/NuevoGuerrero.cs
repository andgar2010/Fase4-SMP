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
using System.Collections;

namespace SMP_Actividad20_Guerra
{
    public partial class NuevoGuerrero : Form
    {
        Conexion Con = new Conexion();
        private PictureBox pb = new PictureBox();
        public ArrayList listGuerreros = new ArrayList();
        private string nombre = "";
        private int edad = 0;
        private int fuerza = 0;
        //DataGridView dgvGuerreros;


        public NuevoGuerrero()
        {
            InitializeComponent();
        }

        private async void NuevoGuerrero_LoadAsync(object sender, EventArgs e)
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

        private async void btnCrearGuerrero_ClickAsync(object sender, EventArgs e)
        {
            bool creado = false;

            try
            {
                if (txtNombre.Text == "") //Campo de texto 
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (txtEdad.Text == "")
                {
                    edad = 0;
                }
                else
                {
                    edad = Convert.ToInt32(txtEdad.Text);
                }

                if (txtFuerza.Text == "")
                {
                    fuerza = 0;
                }
                else
                {
                    fuerza = Convert.ToInt32(txtFuerza.Text);
                }

                int opcion = AleatorioConstructor();
                int tipoGuerrero = 0;

                if (rbGriego.Checked)
                {
                    tipoGuerrero = 1;
                    creado = IniciarConstructor(opcion, edad, fuerza, nombre, tipoGuerrero);
                }
                else if (rbTroyano.Checked)
                {
                    tipoGuerrero = 2;
                    creado = IniciarConstructor(opcion, edad, fuerza, nombre, tipoGuerrero);
                }

            }
            catch (Exception ex)
            {
                lblMsgStauts.Text = ex.Message;
            }

            if (creado)
            {
                if (rbGriego.Checked)
                {
                    lblMsgStauts.Text = "Creado guerrero griego con éxito";
                }
                else if (rbTroyano.Checked)
                {
                    lblMsgStauts.Text = "Creado guerrero troyano con éxito";
                }
            }
            else
            {
                lblMsgStauts.Text = "No creado guerrero";
            }

            await Task.Delay(2500);

            lblMsgStauts.Text = "";

        }


        public bool IniciarConstructor(int opcion, int edad, int fuerza, string nombre, int tipoGuerrero)
        {
            int objEdad = edad;
            int objFuerza = fuerza;
            bool creado = false;

            if (tipoGuerrero == 1) //Crear objeto Griego
            {
                switch (opcion)
                {
                    case 1: // defecto constructor
                        Griego GuerreroGriegoA = new Griego();
                        creado = Con.IngresarNuevoGuerrero(GuerreroGriegoA);
                        break;

                    case 2: // Constructor por parámetros 
                        Griego GuerreroGriegoB = new Griego(nombre, edad, fuerza);
                        creado = Con.IngresarNuevoGuerrero(GuerreroGriegoB);
                        break;

                    case 3: // Constructor por clon anterior (fuerza y edad)
                        Griego GuerreroGriegoC = new Griego(nombre, objEdad, objFuerza);
                        creado = Con.IngresarNuevoGuerrero(GuerreroGriegoC);
                        break;

                    default:
                        break;
                }
            }
            else if (tipoGuerrero == 2) // Crear objeto Troyano
            {
                switch (opcion)
                {
                    case 1: // defecto constructor
                        Troyano GuerreroTroyanoA = new Troyano();
                        creado = Con.IngresarNuevoGuerrero(GuerreroTroyanoA);
                        break;

                    case 2: // Constructor por parámetros 
                        Troyano GuerreroTroyanoB = new Troyano(nombre, edad, fuerza);
                        creado = Con.IngresarNuevoGuerrero(GuerreroTroyanoB);
                        break;

                    case 3: // Constructor por clon anterior (fuerza y edad) 
                        Troyano GuerreroTroyanoC = new Troyano(nombre, objEdad, objFuerza);
                        creado = Con.IngresarNuevoGuerrero(GuerreroTroyanoC);
                        break;

                    default:
                        break;
                }
            }

            return creado;
        }

        public int AleatorioConstructor()
        {
            int num = 0;
            Random r = new Random();

            return num = r.Next(1, 3);
        }

        private void btnMenu_Click(object sender, EventArgs e)
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
