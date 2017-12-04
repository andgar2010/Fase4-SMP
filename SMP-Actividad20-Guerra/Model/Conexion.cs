using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL_Guerrero;
using System.Collections;

namespace SMP_Actividad20_Guerra.Model
{
    public class Conexion
    {
        private SqlConnection sqlCn;
        private SqlCommand sqlCom;
        private SqlDataReader sqlDr;
        SqlDataAdapter da;
        DataTable dt;


        #region Método establecer conexión SQL

        public Conexion()
        {
            try
            {
                sqlCn = new SqlConnection("Data Source=.;Initial Catalog=SMP_ACT20WAR;Integrated Security=True");
                sqlCn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos porque estuve un error:\n" + ex.Message);
            }
        }

        #endregion


        #region Ingresar nuevo guerrero

        public bool IngresarNuevoGuerrero(Guerrero guerrero)
        {
            bool correctaIngreso = false;
            int herido = (guerrero.Herido) ? 1 : 0;
            int muerto = (guerrero.Muerto) ? 1 : 0;


            string sqlInsert = "INSERT INTO dbo.Guerrero " +
                "( nombre, edad, fuerza, cod_ejercito, herido, muerto) VALUES " +
                    "('"
                    + guerrero.Nombre + "',"
                    + guerrero.Edad + ","
                    + guerrero.Fuerza + ","
                    + guerrero.TipoGuerrero + ","
                    + herido + ","
                    + muerto +
                    ")";
            try
            {
                sqlCom = new SqlCommand(sqlInsert, sqlCn);
                sqlCom.ExecuteNonQuery();
                correctaIngreso = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Estuve un error por\n" + ex.Message);
            }

            return correctaIngreso;
        }

        #endregion


        #region Extraer datos del guerrero desde BD

        //public DataGridView ExtraerDatosGuerreros(DataGridView dgv)
        //{
        //    DataGridView dgvGuerreros;

        //    string sqlQuery = "SELECT [id_guerrero] " +
        //        ", gue.nombre" +
        //        ",eje.nombre" +
        //        ",[edad]" +
        //        ",[fuerza]" +
        //        ",[muerto]" +
        //        ",[herido]" +
        //        "FROM[SMP_ACT20WAR].[dbo].[Guerrero] as gue" +
        //        "join Ejercito as eje on gue.cod_ejercito = eje.id_ejercito";


        //    sqlCom = new SqlCommand(sqlQuery, sqlCn);
        //    sqlDr = sqlCom.ExecuteReader();

        //    while (sqlDr.Read())
        //    {
        //        dgvGuerreros = sqlDr.;
        //    }

        //    try
        //    {
        //        da = new SqlDataAdapter(sqlQuery, sqlCn);
        //        da.Fill(dt);
        //        dgv.DataSource = dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo consultar ni extraer los datos de la tabla de guerreros, Estuve error\n" + ex.Message);
        //    }


        //    return dgvGuerreros;
        //}

        #endregion


        #region Cargar lista al BD
        public DataGridView CargarDatosGuerrerosToBD(DataGridView dgvGuerreros)
        {

            string sqlQuery = "SELECT [id_guerrero], gue.nombre,eje.nombre,[edad] ,[fuerza] ,[muerto] ,[herido] FROM[SMP_ACT20WAR].[dbo].[Guerrero] as gue join Ejercito as eje on gue.cod_ejercito = eje.id_ejercito order by id_guerrero";

            try
            {
                da = new SqlDataAdapter(sqlQuery, sqlCn);
                dt = new DataTable();
                da.Fill(dt);
                dgvGuerreros.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView al tabla de guerreros, Estuve error\n" + ex.Message);
            }


            return dgvGuerreros;
        }
        #endregion

        #region Cargar lista griegos -> ListGriegos

        public List<Griego> CargarListaGriego()
        {
            Griego soldadoGriego = new Griego();
            List<Griego> griegos = new List<Griego>();

            string sqlQuery = "select * from Guerrero where cod_ejercito=1";

            try
            {
                sqlCom = new SqlCommand(sqlQuery, sqlCn);
                sqlDr = sqlCom.ExecuteReader();

                while (sqlDr.Read())
                {
                    soldadoGriego.IdGuerrero = Convert.ToInt32(sqlDr["id_guerrero"].ToString());
                    soldadoGriego.Nombre = sqlDr["nombre"].ToString();
                    soldadoGriego.Edad = Convert.ToInt32(sqlDr["edad"].ToString());
                    soldadoGriego.Fuerza = Convert.ToInt32(sqlDr["fuerza"].ToString());
                    soldadoGriego.Herido = Convert.ToBoolean(sqlDr["herido"].ToString());
                    soldadoGriego.Muerto = Convert.ToBoolean(sqlDr["muerto"].ToString());
                    griegos.Add(soldadoGriego);
                }

                sqlDr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Estuve un error por\n" + ex.Message);

            }

            return griegos;
        }

        #endregion

        #region Cargar lista Troyanos -> ListTroyanos

        public List<Troyano> CargarListaTroyanos()
        {
            Troyano soldadoTroyano = new Troyano();
            List<Troyano> troyanos = new List<Troyano>();

            string sqlQuery = "select * from Guerrero where cod_ejercito=2";

            try
            {
                sqlCom = new SqlCommand(sqlQuery, sqlCn);
                sqlDr = sqlCom.ExecuteReader();

                while (sqlDr.Read())
                {
                    soldadoTroyano.IdGuerrero = Convert.ToInt32(sqlDr["id_guerrero"].ToString());
                    soldadoTroyano.Nombre = sqlDr["nombre"].ToString();
                    soldadoTroyano.Edad = Convert.ToInt32(sqlDr["edad"].ToString());
                    soldadoTroyano.Fuerza = Convert.ToInt32(sqlDr["fuerza"].ToString());
                    soldadoTroyano.Herido = Convert.ToBoolean(sqlDr["herido"].ToString());
                    soldadoTroyano.Muerto = Convert.ToBoolean(sqlDr["muerto"].ToString());
                    troyanos.Add(soldadoTroyano);
                }
                sqlDr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Estuve un error por\n" + ex.Message);

            }

            return troyanos;
        }

        #endregion

        #region Insertar datos de partida

        public bool InsertarDatosPartido(int cod_ejercito)
        {
            bool correctaIngreso = false;
            string sqlInsert = "INSERT INTO dbo.Partidas(fecha, ganado_ejercito) values(getdate(), " + cod_ejercito + ")";

            try
            {
                sqlCom = new SqlCommand(sqlInsert, sqlCn);
                sqlCom.ExecuteNonQuery();
                correctaIngreso = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Estuve un error por\n" + ex.Message);
            }

            return correctaIngreso;
        }

        #endregion

        #region Actualizar datos de los guerreros por post-batalla
        public bool ActualizarDatosGuerreros(Guerrero guerrero)
        {
            bool correctaIngreso = false;
            int herido = (guerrero.Herido) ? 1 : 0;
            int muerto = (guerrero.Muerto) ? 1 : 0;
            
            string sqlUpdate = "UPDATE Guerrero SET " +
                "muerto = " + muerto + ", " +
                "herido = " + herido + 
                "WHERE id_guerrero = " + guerrero.IdGuerrero;




            return correctaIngreso;
        }

        #endregion



        #region Verificar conexión abierto o cerrar SQL

        public bool verificarConexionAbierto()
        {
            bool estado = false;

            if (sqlCn.State == ConnectionState.Closed)
            {
                //sqlCn.Open();
                estado = false;
            }
            else if (sqlCn.State == ConnectionState.Open)
            {
                //sqlCn.Close();
                estado = true;
            }

            return estado;
        }

        #endregion


        #region

        public void CerrarConexionBD()
        {
            sqlCn.Close();
        }

        #endregion

    }
}
