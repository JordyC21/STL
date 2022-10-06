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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        public void FrmProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelectProducto();

        }


        private List<Productos> SelectProducto()
        {
            using(FerreteriaSlimEntities db = new FerreteriaSlimEntities())
            {
                return db.Productos.ToList();
            }
        }

        public void Mostrarproductos()
        {
            dataGridView1.DataSource = SelectProducto();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mostrarproductos();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mostrarproductos();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmAñadirProd frmprod = new FrmAñadirProd();

            frmprod.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            FrmEliminarProd frmEliminarProd = new FrmEliminarProd();

            frmEliminarProd.ShowDialog();

          
            
        }
    }
}
