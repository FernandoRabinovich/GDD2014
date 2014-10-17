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
    public partial class frmModifRol : Form
    {
        Rol rol;
        public frmModifRol()
        {
            InitializeComponent();
        }

        public frmModifRol(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            txtNombre.Text = rol.Descripcion;
            chkEstado.Checked = rol.Estado;
        }

        private void frmModifRol_Load(object sender, EventArgs e)
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

                /*Primero cargo las funcionalidades*/
                cmd.CommandText = "GRAFO_LOCO.ObtenerFuncionalidades";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstFuncionalidades.Items.Add(new Funcionalidad(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
                cn.Close();
                cn.Open();
                /*Tengo que cargar las funcionalidades actuales*/                
                cmd.CommandText = "GRAFO_LOCO.ObtenerFuncionalidadesPorRol";

                SqlParameter idRol = new SqlParameter("@rol", rol.Id);
                idRol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(idRol);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for(int i = 0; i < lstFuncionalidades.Items.Count; i++)
                    {
                        if(((Funcionalidad)lstFuncionalidades.Items[i]).Id == Int32.Parse(reader["id"].ToString()))
                            lstFuncionalidades.SetItemChecked(i, true);
                    }
                }                
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            cn.Open();
            SqlTransaction sqlTran = cn.BeginTransaction();
            cmd = cn.CreateCommand();
            cmd.Transaction = sqlTran;

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                /*ACTUALIZO EL ROL*/
                cmd.CommandText = "GRAFO_LOCO.ActualizarRol";
                SqlParameter idRol = new SqlParameter("@rol", rol.Id);
                idRol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(idRol);
                SqlParameter nombreRol = new SqlParameter("@nombre", txtNombre.Text);
                nombreRol.SqlDbType = SqlDbType.VarChar;
                nombreRol.Size = 20;
                cmd.Parameters.Add(nombreRol);
                SqlParameter estadoRol = new SqlParameter("estado", chkEstado.Checked);
                estadoRol.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(estadoRol);

                cmd.ExecuteNonQuery();

                /*ELIMINO LAS FUNCIOANLIDADES ACTUALES PARA RECREARLAS*/
                cmd.Parameters.Clear();
                cmd.CommandText = "GRAFO_LOCO.EliminarFuncionalidadesPorRol";
                idRol = new SqlParameter("@rol", rol.Id);
                idRol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(idRol);

                cmd.ExecuteNonQuery();

                /*RECREO LAS FUNCIONALIDADES CON LAS SELECCIONADAS*/
                cmd.CommandText = "GRAFO_LOCO.IngresarFuncionalidadPorRol";

                foreach (Funcionalidad f in lstFuncionalidades.CheckedItems)
                {
                    SqlParameter funcionalidad = new SqlParameter("idFuncionalidad", f.Id);
                    funcionalidad.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(funcionalidad);

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("idFuncionalidad");
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
