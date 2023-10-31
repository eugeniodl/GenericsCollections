using PruebaLINQ.Datos;
using PruebaLINQ.Logica;
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
        private List<Empleado> listaEmpleados = null;
        public frmEmpleado()
        {
            InitializeComponent();
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            // Obtener empleados
            ControlEmpleadoEmpresa controlEmpleadoEmpresa =
                new ControlEmpleadoEmpresa();
            listaEmpleados =
                controlEmpleadoEmpresa.ObtenerEmpleados();

            // Mostrar la información en nuestro datagridview
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetFilterInformation(txtNameSearch.Text);
            }
        }

        private void SetFilterInformation(string name)
        {
            if(name == string.Empty)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = listaEmpleados;
            }
            else
            {
                var queryEmployees = (from empleado in listaEmpleados
                                     where empleado.Name.Contains(name)
                                     select empleado).ToList();
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = queryEmployees;
            }
        }
    }
}
