using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia
using MiTienda.View.Dialogs;

namespace MiTienda.View.UserControls
{
    public partial class UC_Items : UserControl
    {
        public UC_Items()
        {
            InitializeComponent();
        }

        private void btnVerTipos_Click(object sender, EventArgs e)
        {
            Tipos m = new Tipos();
            m.ShowDialog();
        }
    }
}
