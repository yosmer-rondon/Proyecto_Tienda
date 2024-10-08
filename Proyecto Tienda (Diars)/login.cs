using Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda__Diars_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string contraseña = txtcontraseña.Text;

            bool loginExitoso = logLogin.Instancia.VerificarLogin(dni, contraseña);

            if (loginExitoso)
            {
                MessageBox.Show("Login exitoso");
                // Redirigir al siguiente formulario o pantalla principal
                Administrador ad = new Administrador();
                this.Hide();
                ad.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("DNI o contraseña incorrectos");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
