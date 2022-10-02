using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Progra2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void RelaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        void MoverVentana()
        {
            RelaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
   
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
            
        }
        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }
    }
}
