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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            dgLibros.AutoGenerateColumns = false;

            using (var context = new EntidadesLibreria())
            {
                dgLibros.DataSource = null;
                dgLibros.DataSource = (from q in context.TBL_LIBRO.OrderBy(x => x.ID_LIBRO) select q).ToList();
                dgLibros.Refresh();
            }
        }
    }
}
