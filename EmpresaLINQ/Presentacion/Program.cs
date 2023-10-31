using EmpresaLINQ;

ControlEmpresasEmpleados controlEmpresasEmpleados 
    = new ControlEmpresasEmpleados();

Console.WriteLine("Obteniendo los empleados que son CEO");
controlEmpresasEmpleados.ObtenerCargo("CEO");

Console.WriteLine("Obteniendo los empleados con salario mayor " +
    "a 1000");
controlEmpresasEmpleados.ObtenerSalario(1000);

Console.WriteLine("Obteniendo los empleados de la empresa " +
    "GBM Nicaragua");
controlEmpresasEmpleados.ObtenerEmpresa("GBM Nicaragua");