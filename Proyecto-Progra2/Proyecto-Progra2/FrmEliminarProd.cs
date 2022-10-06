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
    public partial class FrmEliminarProd : Form
    {
        public FrmEliminarProd()
        {
            InitializeComponent();
        }

        private void FrmEliminarProd_Load(object sender, EventArgs e)
        {


        }



        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            int EliminarProducto;
            EliminarProducto = Convert.ToInt32(txtDelete.Text);
            using (FerreteriaSlimEntities db = new FerreteriaSlimEntities())
            {

                var st = (from Productos in db.Productos where Productos.idProducto == (EliminarProducto) select Productos).First();
                


                db.Productos.Remove(st);
                db.SaveChanges();
                this.Hide();

            }
        }

    }

}
