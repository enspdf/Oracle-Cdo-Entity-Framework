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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();

            using ( var context = new EntidadesLibreria() )
            {
                var libros = (from q in context.TBL_LIBRO select q).ToList();
                cbLibroSeleccionado.DataSource = libros;
                cbLibroSeleccionado.DisplayMember = "NOMBRE_LIBRO";
                cbLibroSeleccionado.ValueMember = "ID_LIBRO";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using ( var context = new EntidadesLibreria() )
            {
                try
                {
                    if (txtCedulaUsuario.Text != string.Empty && txtNombreUsuario.Text != string.Empty && txtApellidoUsuario.Text != string.Empty && txtDireccionUsuario.Text != string.Empty && txtCelularUsuario.Text != string.Empty && cbLibroSeleccionado.Text != string.Empty)
                    {
                        context.INSERTAR_USUARIO(txtCedulaUsuario.Text, txtNombreUsuario.Text, txtApellidoUsuario.Text, txtDireccionUsuario.Text, Convert.ToDecimal(txtCelularUsuario.Text), Convert.ToDecimal(cbLibroSeleccionado.SelectedValue));
                        context.SaveChanges();
                        txtCedulaUsuario.Text = string.Empty;
                        txtNombreUsuario.Text = string.Empty;
                        txtApellidoUsuario.Text = string.Empty;
                        txtDireccionUsuario.Text = string.Empty;
                        txtCelularUsuario.Text = string.Empty;
                        cbLibroSeleccionado.SelectedIndex = 0;

                        MessageBox.Show(this, "Usuario registrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show(this, "No pueden existir campos vacios");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message);
                }
            }
        }

        private void txtCedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                
            }
            else
            {
                MessageBox.Show(this, "Solo puede ingresar numeros");
                e.Handled = true;
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCelularUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

            }
            else
            {
                MessageBox.Show(this, "Solo puede ingresar numeros");
                e.Handled = true;
            }
        }
    }
}
