using Deportivo.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportivo.GUILayer.Ventas
{
    public partial class frmDetalleProducto : Form
    {
        private ProductoService productoService;
        
        public frmDetalleProducto()
        {
            InitializeComponent();
            productoService = new ProductoService();
           
        }

        internal void InicializarDetalleProducto(int idProducto)
        {


            var resultado = productoService.ConsultarProductosPorId(idProducto);

            if (resultado != null)
            {
                txtIdProducto.Text = resultado.IdProducto.ToString();
                txtNombre.Text = resultado.Nombre.ToString();
                txtMarca.Text = resultado.Marca.ToString();
                txtCantidad.Text = resultado.Cantidad.ToString();
                txtPrecioVenta.Text = resultado.Precio_Venta.ToString();
                txtFechaAlta.Text = resultado.Fecha_Alta.ToString();
                               
            }
                     
        }

     

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
