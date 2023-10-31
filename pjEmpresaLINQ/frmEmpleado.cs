using EmpresaLINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEmpresaLINQ
{
    public partial class frmEmpleado : Form
    {
        List<Empleado> listaEmpleados = null;
        public frmEmpleado()
        {
            InitializeComponent();
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            ControlEmpresasEmpleados cee = 
                new ControlEmpresasEmpleados();


            listaEmpleados = cee.ObtenerEmpleados();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SetFilterInformation(txtNameSearch.Text);
            }
        }

        private void SetFilterInformation(string name)
        {
            if (name == String.Empty)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = listaEmpleados;
            }
            else
            {
                var queryNameEmployees = (from emp in listaEmpleados
                                         where emp.Nombre.Contains(name)
                                         select emp).ToList();
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = queryNameEmployees;
            }
        }
    }
}
