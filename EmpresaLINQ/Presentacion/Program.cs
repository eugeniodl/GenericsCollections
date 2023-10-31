using PruebaLINQ.Datos;

ControlEmpleadoEmpresa controlEmpleadoEmpresa = 
    new ControlEmpleadoEmpresa();

Console.WriteLine("Obteniendo empleados con cargo CEO");
controlEmpleadoEmpresa.ObtenerCargo("CEO");
Console.WriteLine("Obteniendo empleados con salario > 1000");
controlEmpleadoEmpresa.ObtenerSalario(1000);
Console.WriteLine("Obteniendo empleados de CONDOR COMUNICACIONES, S.A.");
controlEmpleadoEmpresa
    .ObtenerEmpleadosEmpresa("CONDOR COMUNICACIONES, S.A.");