using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class ListadoDeConsumibles : Form
    {
        public ListadoDeConsumibles()
        {
            InitializeComponent();
        }

        private void ListadoDeConsumibles_Load(object sender, EventArgs e)
        {
         
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ObtenerConsumibles";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    

                    this.ConsumiblesParaUnCliente();
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

        private void ConsumiblesParaUnCliente()
        {
            gwListaConsumibles.Columns.Add("idCliente", "Cliente");
            gwListaConsumibles.Columns.Add("TipoDeServicio","Tipo");
            gwListaConsumibles.Columns.Add("idServicio","Consumible");
            gwListaConsumibles.Columns.Add("cantidadTotal","Cantidad");
            gwListaConsumibles.Columns.Add("total","Precio Total");
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            
        }
   }
}

