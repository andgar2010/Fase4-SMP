using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlurBackground;
using BLL_Guerrero;
using SMP_Actividad20_Guerra.Model;

namespace SMP_Actividad20_Guerra
{
    public partial class CampoBatalla : Form
    {
        private PictureBox pb = new PictureBox();
        private Conexion Con = new Conexion();
        public List<Troyano> troyanos = new List<Troyano>();
        public List<Griego> griegos = new List<Griego>();
        private static bool cargada = false;
        private static int posicionTroyano = -1;
        private static int posicionGriego = -1;


        public CampoBatalla()
        {
            InitializeComponent();
        }

        private async void CampoBatalla_LoadAsync(object sender, EventArgs e)
        {
            picxClose.BackgroundImageLayout = ImageLayout.Stretch;

            panel1.BackColor = Color.FromArgb(100, 44, 62, 80);

            await Task.Delay(500);

            Bitmap bmp = Screenshot.TakeSnapshot(panel1);
            BitmapFilter.GaussianBlur(bmp, 4);

            pb.Image = bmp;
            pb.Dock = DockStyle.Fill;
            pb.BringToFront();
            panel1.Controls.Add(pb);

            troyanos = Con.CargarListaTroyanos();
            griegos = Con.CargarListaGriego();

            Troyano troyano1 = troyanos[1];
            Griego griego1 = griegos[1];

            progressBarFuerzaGriego.Maximum = griego1.Fuerza;
            progressBarFuerzaGriego.Value = griego1.Fuerza;

            progressBarFuerzaTroyano.Maximum = troyano1.Fuerza;
            progressBarFuerzaTroyano.Value = troyano1.Fuerza;

            lblNumFuerzaG.Text = Convert.ToString(griego1.Fuerza);
            lblNumFuerzaT.Text = Convert.ToString(troyano1.Fuerza);

            string msgGriego =
                "IdGuerrero: " + griego1.IdGuerrero +
                "\nNombre: " + griego1.Nombre +
                "\nEdad: " + griego1.Edad +
                "\nFuerza: " + griego1.Fuerza +
                "\nAtaque: " + griego1.Ataque +
                "\nHerido: " + griego1.Herido +
                "\nMuerto: " + griego1.Muerto;

            string msgTroyano =
                "IdGuerrero: " + troyano1.IdGuerrero +
                "\nNombre: " + troyano1.Nombre +
                "\nEdad: " + troyano1.Edad +
                "\nFuerza: " + troyano1.Fuerza +
                "\nAtaque: " + troyano1.Ataque +
                "\nHerido: " + troyano1.Herido +
                "\nMuerto: " + troyano1.Muerto;



            lblMsgGriego.Text = msgGriego;
            lblMsgTroyano.Text = msgTroyano;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Index menu = new Index();
            this.Hide();
            menu.Show();
        }

        private int AleatorioNumAtaque()
        {
            int num = 0;

            Random r = new Random();

            return num = r.Next(1, 10);
        }

        private int AleatorioIniciaGuerrero()
        {
            int num = 0;

            Random r = new Random();

            return num = r.Next(1, 3);
        }

        private void btnIniciarBatalla_Click(object sender, EventArgs e)
        {
            CalcularDanioUnSoldadoAsync();
            //CalcularDanioSoldadosAsync();
        }

        private Troyano ExtraerTroyanosAUnTroyano()
        {
            List<Troyano> troyanos;
            CargarTroyanos(out troyanos);
            Troyano troyano1 = null;

            try
            {
                troyano1 = troyanos[posicionTroyano];
            }
            catch (Exception)
            {
                lblMsgStatus.Text = "Limite posición que griego ";
            }

            return troyano1;

        }
        private Griego ExtraerGriegosAGriego()
        {
            List<Griego> griegos;
            CargarGriegos(out griegos);
            Griego griego1 = null;

            try
            {
                griego1 = griegos[posicionGriego];
            }
            catch (Exception)
            {
                lblMsgStatus.Text = "Limite posición que troyano ";
            }

            return griego1;
        }


        private async void CalcularDanioSoldadosAsync()
        {
            List<Griego> griegos;
            List<Troyano> troyanos;
            CargarGuerreros(out troyanos, out griegos);
            int cantGriegos = griegos.Count;
            int cantTroyanos = troyanos.Count;

            do
            {
                posicionGriego++;
                posicionTroyano++;

                Troyano troyano1 = ExtraerTroyanosAUnTroyano();
                Griego griego1 = ExtraerGriegosAGriego();

                if (troyano1 == null)
                {
                    break;
                }
                if (griego1 == null)
                {
                    break;
                }

                troyano1.Ataque = AleatorioNumAtaque();
                griego1.Ataque = AleatorioNumAtaque();

                int iniciaGuerrero = AleatorioIniciaGuerrero();

                if (iniciaGuerrero == 1) // Troyano ->> Griego
                {
                    if (troyano1.Muerto == false)
                    {
                        lblMsgStatus.Text = "Troyano " + troyano1.Nombre + " , " + troyano1.Ataque + " nivel de ataque para daño al griego";
                    }

                }
                else if (iniciaGuerrero == 2) // Griego ->> Troyano   
                {
                    if (griego1.Muerto == false)
                    {
                        lblMsgStatus.Text = "Griego " + griego1.Nombre + " , " + griego1.Ataque + " nivel de ataque para daño al troyano";
                    }
                }

                await Task.Delay(100);

                switch (iniciaGuerrero)
                {
                    case 1:// Troyano ->> Griego

                        if (troyano1.Muerto == false)
                        {
                            if (griego1.Muerto == false)
                            {
                                griego1.Fuerza -= troyano1.Ataque;

                                if (griego1.Fuerza >= 1 && griego1.Fuerza <= 4)
                                {
                                    griego1.Herido = true;
                                }
                                else if (griego1.Fuerza <= 0)
                                {
                                    griego1.Muerto = true;
                                }

                                if (griego1.Muerto)
                                {
                                    lblMsgStatus.Text += "\nEl guerrero " + griego1.Nombre + " (griego) esta muerto";
                                    picxGreek.Image = Properties.Resources.rip;
                                    picxGreek.BackgroundImageLayout = ImageLayout.Stretch;
                                    picxGreek.Refresh();
                                }
                                else
                                {
                                    lblMsgStatus.Text += "\n" + griego1.Nombre + " (griego) debilita su fuerza " + griego1.Fuerza;
                                }


                                if (progressBarFuerzaGriego.Value >= 0)
                                {
                                    progressBarFuerzaGriego.Increment(-(troyano1.Ataque));
                                }

                            }
                            else if (griego1.Muerto)
                            {
                                lblMsgStatus.Text = "El guerrero " + griego1.Nombre + " (griego) esta muerto";
                                picxGreek.Image = picxGreek.Image = Properties.Resources.rip;
                                picxGreek.BackgroundImageLayout = ImageLayout.Stretch;
                                picxGreek.Refresh();
                            }

                        }
                        else
                        {
                            lblMsgStatus.Text = "Troyano no puede ataque al griego porque esta muerto.";
                        }

                        break;

                    case 2:// Griego ->> Troyano                   

                        if (griego1.Muerto == false)
                        {

                            if (troyano1.Muerto == false)
                            {
                                troyano1.Fuerza -= griego1.Ataque;

                                if (troyano1.Fuerza >= 1 && troyano1.Fuerza <= 4)
                                {
                                    troyano1.Herido = true;
                                }
                                else if (griego1.Fuerza <= 0)
                                {
                                    troyano1.Muerto = true;
                                }

                                if (troyano1.Muerto)
                                {
                                    lblMsgStatus.Text += "\nEl guerrero " + troyano1.Nombre + " (troyano) esta muerto.";
                                    picxTrojan.Image = new Bitmap(@"C:\Users\AndGar\source\repos\FASE4-SMP\SMP-Actividad20-Guerra\SMP-Actividad20-Guerra\Resources\rip.png");
                                    picxTrojan.BackgroundImageLayout = ImageLayout.Stretch;
                                    picxTrojan.Refresh();
                                }
                                else
                                {
                                    lblMsgStatus.Text += "\n" + troyano1.Nombre + " (troyano) debilita su fuerza " + troyano1.Fuerza;
                                }

                                if (progressBarFuerzaTroyano.Value >= 0)
                                {
                                    progressBarFuerzaTroyano.Increment(-(griego1.Ataque));
                                }

                            }
                            else if (troyano1.Muerto)
                            {
                                lblMsgStatus.Text = "El guerrero " + griego1.Nombre + " (griego) esta muerto.";
                                picxTrojan.Image = new Bitmap(@"C:\Users\AndGar\source\repos\FASE4-SMP\SMP-Actividad20-Guerra\SMP-Actividad20-Guerra\Resources\rip.png");
                                picxTrojan.BackgroundImageLayout = ImageLayout.Stretch;
                                picxTrojan.Refresh();
                            }

                        }
                        else
                        {
                            lblMsgStatus.Text = "Griego no puede ataque al troyano porque esta muerto.";
                        }
                        break;
                }

                lblNumFuerzaG.Text = Convert.ToString(griego1.Fuerza);
                lblNumFuerzaT.Text = Convert.ToString(troyano1.Fuerza);

                string msgGriego =
                    "IdGuerrero: " + griego1.IdGuerrero +
                    "\nNombre: " + griego1.Nombre +
                    "\nEdad: " + griego1.Edad +
                    "\nFuerza: " + griego1.Fuerza +
                    "\nAtaque: " + griego1.Ataque +
                    "\nHerido: " + griego1.Herido +
                    "\nMuerto: " + griego1.Muerto;

                string msgTroyano =
                    "IdGuerrero: " + troyano1.IdGuerrero +
                    "\nNombre: " + troyano1.Nombre +
                    "\nEdad: " + troyano1.Edad +
                    "\nFuerza: " + troyano1.Fuerza +
                    "\nAtaque: " + troyano1.Ataque +
                    "\nHerido: " + troyano1.Herido +
                    "\nMuerto: " + troyano1.Muerto;


                lblMsgGriego.Text = msgGriego;
                lblMsgTroyano.Text = msgTroyano;

            } while (cantGriegos != posicionGriego || cantTroyanos != posicionTroyano);
        }

        private async void CalcularDanioUnSoldadoAsync()
        {
            Troyano troyano1;
            Griego griego1;
            cargada = CargarUnGuerrero(out troyano1, out griego1);

            troyano1.Ataque = AleatorioNumAtaque();
            griego1.Ataque = AleatorioNumAtaque();

            int iniciaGuerrero = AleatorioIniciaGuerrero();

            if (iniciaGuerrero == 1) // Troyano ->> Griego
            {
                if (troyano1.Muerto == false)
                {
                    lblMsgStatus.Text = "Troyano " + troyano1.Nombre + " , " + troyano1.Ataque + " nivel de ataque para daño al griego";
                }

            }
            else if (iniciaGuerrero == 2) // Griego ->> Troyano   
            {
                if (griego1.Muerto == false)
                {
                    lblMsgStatus.Text = "Griego " + griego1.Nombre + " , " + griego1.Ataque + " nivel de ataque para daño al troyano";
                }
            }

            await Task.Delay(2500);

            switch (iniciaGuerrero)
            {
                case 1:// Troyano ->> Griego

                    if (troyano1.Muerto == false)
                    {
                        if (griego1.Muerto == false)
                        {
                            griego1.Fuerza -= troyano1.Ataque;

                            if (griego1.Fuerza >= 1 && griego1.Fuerza <= 4)
                            {
                                griego1.Herido = true;
                            }
                            else if (griego1.Fuerza <= 0)
                            {
                                griego1.Muerto = true;
                            }

                            if (griego1.Muerto)
                            {
                                lblMsgStatus.Text += "\nEl guerrero " + griego1.Nombre + " (griego) esta muerto";
                                picxGreek.Image = Properties.Resources.rip;
                                picxGreek.BackgroundImageLayout = ImageLayout.Stretch;
                                picxGreek.Refresh();
                            }
                            else
                            {
                                lblMsgStatus.Text += "\n" + griego1.Nombre + " (griego) debilita su fuerza " + griego1.Fuerza;
                            }


                            if (progressBarFuerzaGriego.Value >= 0)
                            {
                                progressBarFuerzaGriego.Increment(-(troyano1.Ataque));
                            }

                        }
                        else if (griego1.Muerto)
                        {
                            lblMsgStatus.Text = "El guerrero " + griego1.Nombre + " (griego) esta muerto";
                            picxGreek.Image = picxGreek.Image = Properties.Resources.rip;
                            picxGreek.BackgroundImageLayout = ImageLayout.Stretch;
                            picxGreek.Refresh();
                        }

                    }
                    else
                    {
                        lblMsgStatus.Text = "Troyano no puede ataque al griego porque esta muerto.";
                    }

                    break;

                case 2:// Griego ->> Troyano                   

                    if (griego1.Muerto == false)
                    {

                        if (troyano1.Muerto == false)
                        {
                            troyano1.Fuerza -= griego1.Ataque;

                            if (troyano1.Fuerza >= 1 && troyano1.Fuerza <= 4)
                            {
                                troyano1.Herido = true;
                            }
                            else if (griego1.Fuerza <= 0)
                            {
                                troyano1.Muerto = true;
                            }

                            if (troyano1.Muerto)
                            {
                                lblMsgStatus.Text += "\nEl guerrero " + troyano1.Nombre + " (troyano) esta muerto.";
                                picxTrojan.Image = new Bitmap(@"C:\Users\AndGar\source\repos\FASE4-SMP\SMP-Actividad20-Guerra\SMP-Actividad20-Guerra\Resources\rip.png");
                                picxTrojan.BackgroundImageLayout = ImageLayout.Stretch;
                                picxTrojan.Refresh();
                            }
                            else
                            {
                                lblMsgStatus.Text += "\n" + troyano1.Nombre + " (troyano) debilita su fuerza " + troyano1.Fuerza;
                            }

                            if (progressBarFuerzaTroyano.Value >= 0)
                            {
                                progressBarFuerzaTroyano.Increment(-(griego1.Ataque));
                            }

                        }
                        else if (troyano1.Muerto)
                        {
                            lblMsgStatus.Text = "El guerrero " + griego1.Nombre + " (griego) esta muerto.";
                            picxTrojan.Image = new Bitmap(@"C:\Users\AndGar\source\repos\FASE4-SMP\SMP-Actividad20-Guerra\SMP-Actividad20-Guerra\Resources\rip.png");
                            picxTrojan.BackgroundImageLayout = ImageLayout.Stretch;
                            picxTrojan.Refresh();
                        }

                    }
                    else
                    {
                        lblMsgStatus.Text = "Griego no puede ataque al troyano porque esta muerto.";
                    }
                    break;

                    
            }

            lblNumFuerzaG.Text = Convert.ToString(griego1.Fuerza);
            lblNumFuerzaT.Text = Convert.ToString(troyano1.Fuerza);

            string msgGriego =
                "IdGuerrero: " + griego1.IdGuerrero +
                "\nNombre: " + griego1.Nombre +
                "\nEdad: " + griego1.Edad +
                "\nFuerza: " + griego1.Fuerza +
                "\nAtaque: " + griego1.Ataque +
                "\nHerido: " + griego1.Herido +
                "\nMuerto: " + griego1.Muerto;

            string msgTroyano =
                "IdGuerrero: " + troyano1.IdGuerrero +
                "\nNombre: " + troyano1.Nombre +
                "\nEdad: " + troyano1.Edad +
                "\nFuerza: " + troyano1.Fuerza +
                "\nAtaque: " + troyano1.Ataque +
                "\nHerido: " + troyano1.Herido +
                "\nMuerto: " + troyano1.Muerto;


            lblMsgGriego.Text = msgGriego;
            lblMsgTroyano.Text = msgTroyano;

        }

        private bool CargarUnGuerrero(out Troyano troyano1, out Griego griego1)
        {
            if (cargada == false)
            {
                troyanos = Con.CargarListaTroyanos();
                griegos = Con.CargarListaGriego();
                troyano1 = troyanos[1];
                griego1 = griegos[1];
                cargada = true;
            }
            else
            {
                troyano1 = troyanos[1];
                griego1 = griegos[1];
                cargada = true;
            }

            return cargada;

        }

        private void CargarGuerreros(out List<Troyano> troyanos, out List<Griego> griegos)
        {
            troyanos = Con.CargarListaTroyanos();
            griegos = Con.CargarListaGriego();
        }

        private void CargarTroyanos(out List<Troyano> troyanos)
        {
            troyanos = Con.CargarListaTroyanos();
        }

        private void CargarGriegos(out List<Griego> griegos)
        {
            griegos = Con.CargarListaGriego();
        }

        private void picxClose_Click(object sender, EventArgs e)
        {
            Con.CerrarConexionBD();
            Application.Exit();
        }

    }
}
