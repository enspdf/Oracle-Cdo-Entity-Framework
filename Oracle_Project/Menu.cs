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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usuarios = new Form2();
            usuarios.MdiParent = this;
            usuarios.StartPosition = FormStartPosition.CenterScreen;
            usuarios.Show();
        }

        private void ingresarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var libros = new Form1();
            libros.MdiParent = this;
            libros.StartPosition = FormStartPosition.CenterScreen;
            libros.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var acerca = new Acerca();
            acerca.MdiParent = this;
            acerca.StartPosition = FormStartPosition.CenterScreen;
            acerca.Show();
        }

        private void verLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new Form3();
            log.MdiParent = this;
            log.StartPosition = FormStartPosition.CenterScreen;
            log.Show();
        }

        private void verLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var libro = new Form4();
            libro.MdiParent = this;
            libro.StartPosition = FormStartPosition.CenterScreen;
            libro.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usuario = new Form5();
            usuario.MdiParent = this;
            usuario.StartPosition = FormStartPosition.CenterScreen;
            usuario.Show();
        }
    }
}
