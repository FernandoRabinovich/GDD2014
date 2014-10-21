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
    public partial class frmAltaRol : Form
    {
        public frmAltaRol()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            chkEstado.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerFuncionalidades";

                reader = cmd.ExecuteReader();

                while(reader.Read())
                    lstFuncionalidades.Items.Add(new Funcionalidad(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                reader.Close();
                if (cmd != null)
                    cmd.Dispose();
            }    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Tengo que insertar el rol, obtener el id que genero y luego hacer tantos insert como funcionalidades haya seleccionado.
             Si falla algo tengo que rollbackear todo.*/

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            cn.Open();
            SqlTransaction sqlTran = cn.BeginTransaction();
            cmd = cn.CreateCommand();
            cmd.Transaction = sqlTran;

            try
            {   
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.IngresarRol";
                SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 20;
                cmd.Parameters.Add(nombre);
                SqlParameter estado = new SqlParameter("@estado", chkEstado.Checked);
                estado.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(estado);

                Int32 idRol = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = "GRAFO_LOCO.IngresarFuncionalidadPorRol";
                cmd.Parameters.Clear();
                SqlParameter rol = new SqlParameter("@idRol", idRol);
                rol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(rol);
                 
                foreach(Funcionalidad f in lstFuncionalidades.CheckedItems)
                {
                    SqlParameter funcionalidad = new SqlParameter("@idFuncionalidad", f.Id);
                    funcionalidad.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(funcionalidad);

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("@idFuncionalidad");
                }
                
                sqlTran.Commit();

                MessageBox.Show("La operación se realizó correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    sqlTran.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }                
        }
    }
}
