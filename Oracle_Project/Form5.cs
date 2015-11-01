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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dgUsuarios.AutoGenerateColumns = false;

            using (var context = new EntidadesLibreria())
            {
                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = (from q in context.TBL_USUARIO.OrderBy(x => x.ID_USUARIO) select q).ToList();
                dgUsuarios.Refresh();
            }
        }
    }
}
