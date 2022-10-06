using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Progra2.Models; 
namespace Proyecto_Progra2
{
    public partial class FrmAñadirProd : Form
    {
        public FrmAñadirProd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            FerreteriaSlimEntities db = new FerreteriaSlimEntities();

            Productos sProductos = new Productos();

            sProductos.prodProveedorId = int.Parse(txtProveedorProd.Text);
            sProductos.prodNombre = txtNombreProd.Text;
            sProductos.prodPrecio = Convert.ToDecimal(txtPrecioProd.Text);
            sProductos.prodCantidad = int.Parse(txtCantidadProd.Text);
            db.Productos.Add(sProductos);
            db.SaveChanges();
            this.Hide();
        }

        private void FrmAñadirProd_Load(object sender, EventArgs e)
        {

        }
    }
}
