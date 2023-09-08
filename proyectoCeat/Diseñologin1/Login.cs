using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diseñologin1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
       

        private void btnCerrar_Click(object sender, EventArgs e)//cierra el programa
        {
            this.Close();
        }

        private void pBMostrarOcultar_Click(object sender, EventArgs e)
        {
           Diseño.verOcultar(pBMostrarOcultar, iLVerOculartar, txtIngresarClave, e);
          
        }

        private void pbImagEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresarUsuario_Click(object sender, EventArgs e)
        {
            if(txtIngresarUsuario.Text=="Usuario")
            {
            txtIngresarUsuario.Clear();
            txtIngresarUsuario.ForeColor=Color.Black;
            txtIngresarUsuario.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
        } 

      
       

        

       
       
    }
}
