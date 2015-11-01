using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            using ( var context = new EntidadesLibreria() )
            {
                var libro = context.INSERTAR_LIBRO(txtNombreLibro.Text, txtNombreAutor.Text);
                try
                {
                    if (txtNombreAutor.Text != string.Empty && txtNombreLibro.Text != string.Empty)
                    {
                        context.SaveChanges();
                        txtNombreAutor.Text = string.Empty;
                        txtNombreLibro.Text = string.Empty;
                        MessageBox.Show(this, "El libro ha sido guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show(this, "No puede dejar los campos vacios");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message);
                }   
            }
        }

        private void txtNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsNumber(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

            }
            else
            {
                MessageBox.Show(this, "Solo puede ingresar letras");
                e.Handled = true;
            }
        }

        private void txtNombreAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsNumber(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

            }
            else
            {
                MessageBox.Show(this, "Solo puede ingresar letras");
                e.Handled = true;
            }
        }
    }
}
