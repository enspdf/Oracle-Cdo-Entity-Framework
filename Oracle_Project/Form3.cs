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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CenterToParent();
            CenterToScreen();
            dgLogs.AutoGenerateColumns = false;

            using ( var context = new EntidadesLibreria() )
            {
                dgLogs.DataSource = null;
                dgLogs.DataSource = (from q in context.TBL_LOG.OrderBy(x => x.ID_LOG) select q).ToList();
                dgLogs.Refresh();
            }
        }
    }
}
