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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        string path = "C:\\Diseñologin1\\Diseñologin1\\imagenes\\";
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBotonesM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.White;
            //boton.Image = Image.FromFile(path);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.Cyan;
            boton.ImageIndex = 1;
            
        }

        
    }
}
