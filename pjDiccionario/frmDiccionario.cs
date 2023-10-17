using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjDiccionario
{
    public partial class frmDiccionario : Form
    {
        public frmDiccionario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = 
                Diccionario.GetSignificado(txtBusqueda.Text);
        }
    }
}
