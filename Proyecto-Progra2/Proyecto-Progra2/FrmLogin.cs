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
    public partial class FrmLogin : Form
    {


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray; 


            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;


            }
        }
        //-----------------------------------------------------------------------------------//

        //LOGIN
        FerreteriaSlimEntities db = new FerreteriaSlimEntities();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Usuarios.Where(r => r.usuario == txtUsuario.Text && r.password == txtPassword.Text).Count()>0)
                {
                   
                    MessageBox.Show( "Usuario encontrado" , "Bienvenido", MessageBoxButtons.OK);
                    Form1 forMadre = new Form1();
                    forMadre.Show();

                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception f)
            {

                MessageBox.Show("Error" + f);
            }
        }


    }
}
