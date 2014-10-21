using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel

{
    public partial class frmAltaHabitacion : Form
    {
        int idHotel;
        #region variables
        string pisoHabitacion;
        string numeroDeHabitacion;
        string ubicacion;
        string comodidadesHabitacion;
        string tipoDeHabitacion;
        
        
        
    #endregion

        public frmAltaHabitacion(int idDeHotel)
        {
            InitializeComponent();
            idHotel = idDeHotel;

            
        }

        private void LimpiarPantalla()
        {
            piso.Text = "";
            habitacionNumero.Text = " ";
            VistaExterior.SelectedIndex = -1;
            TipoHabitacion.SelectedIndex = -1;
            Comodidades.Text = "";
        }
        
        

        private void botonGuardar_Click(object sender, EventArgs e)
        {
           /* #region validacion
            pisoHabitacion = piso.Text;
            numeroDeHabitacion = habitacionNumero.Text;//deberia validarse con la base de datos, para que no haya  dos iguales, por ahora esta validado como campo obligatorio
            ubicacion = VistaAlExterior.Text;
            comodidadesHabitacion = Comodidades.Text;
            tipoDeHabitacion = TipoHabitacion.Text;           
         
            #endregion

            //grabar los datos en la base de datos
             
*/
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.IngresarHabitacionNueva";
                SqlParameter nroHabitacion = new SqlParameter("@nroHabitacion", Convert.ToInt16(habitacionNumero.Text));
                cmd.Parameters.Add(nroHabitacion);
                SqlParameter idHot = new SqlParameter("@idHotel", idHotel);
                cmd.Parameters.Add(idHot);
                SqlParameter pisoHabitacion = new SqlParameter("@piso", Convert.ToInt16(piso.Text));
                cmd.Parameters.Add(pisoHabitacion);
                SqlParameter ubicaciones = new SqlParameter("@frente", VistaExterior.Text);
                cmd.Parameters.Add(ubicaciones);
                SqlParameter tipoHab = new SqlParameter("@idTipoHabitacion", Convert.ToInt16(TipoHabitacion.SelectedValue));
                cmd.Parameters.Add(tipoHab);
                SqlParameter desc = new SqlParameter("@descripcion", Comodidades.Text);
                cmd.Parameters.Add(desc);
                SqlDataReader reader = cmd.ExecuteReader();
                            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
                LimpiarPantalla();
                
            }

        }

        private void validar(string pisoHabitacion, string numeroDeHabitacion, string ubicacion, string comodidadesHabitacion, string tipoDeHabitacion)
        {
                if(pisoHabitacion == null) throw new Exception("Piso de la habitación no ingresado");
                if (numeroDeHabitacion == null) throw new Exception("Numero de la habitación no ingresado");
                if (ubicacion == null) throw new Exception("Ubicacion de la habitación no ingresado");
                if (comodidadesHabitacion == null) throw new Exception("Comodidades no especificadas");
                if (tipoDeHabitacion == null) throw new Exception("Ingrese tipo de habitación");
                
            
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

       

       

          

       

        private void frmAltaHabitacion_leave(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;            

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ExistenciaDeHabitacion";
                /* Me conviene hacer una funcion que me retorne lo que sucedió:
                 * idUsuario - OK
                 * -1 - Existe la Habitacion
                 * -2 - No existe
                 */
                SqlParameter nroHabitacion = new SqlParameter("@nroHabitacion", habitacionNumero.Text);
                cmd.Parameters.Add(nroHabitacion);
                SqlParameter idHot = new SqlParameter("@idHotel", idHotel);
                cmd.Parameters.Add(idHot);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                if ((reader["Existencia"].ToString()) == "-1")
                {
                    MessageBox.Show("Número de Habitación ya existente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    habitacionNumero.Focus();                    
                }

                // Si todo estuvo OK debo verificar si ese usuario pertenece a mas de un hotel para que lo seleccione y si
                // posee mas de un rol para que tambien lo seleccione.
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
                
            }
        }

        private void frmAltaHabitacion_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;            

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtencionTipoHabitacion";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TipoHabitacion");
            da.Fill(dt);
            TipoHabitacion.DataSource = dt;
            TipoHabitacion.DisplayMember = "DESCRIPCION";
            TipoHabitacion.ValueMember = "IDTIPO";
            TipoHabitacion.SelectedIndex = -1;
            VistaExterior.SelectedIndex = -1;

            

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        private void Piso_Leave(object sender, EventArgs e)
        {
            try{
            int valor;
            valor = Convert.ToInt16(piso.Text);
                }
            
            catch (Exception )
            {
                MessageBox.Show("Solo puede ingresar datos numericos");
                piso.Focus();

            }
            finally 
            {
                
            }
        }

        private void habitacionNumero_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        }
        }

        
   
