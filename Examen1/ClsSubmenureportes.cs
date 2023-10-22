using System;
namespace Examen1
{
	internal class ClsSubmenureportes
	{
		//Atributos

		private static byte opcion = 0;

		public static void submenu()
		{
			do
			{
                Console.WriteLine("MENU DE REPORTES");
                Console.WriteLine("1- Consultar empleados");
                Console.WriteLine("2- Listar todos los empleados");
                Console.WriteLine("3- Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4- Calcular y mostrar el salario mas alto y mas bajo de todos los empleados");
                Console.WriteLine("5- Salir");
				byte.TryParse(Console.ReadLine(), out opcion );
				switch (opcion)
				{
					case 1: ClsEmpleado.ConsultarEmpleados(); break;
                    case 2: ClsEmpleado.ListarEmpleadosOrdenadosPorNombre(); break;
                    case 3: ClsEmpleado.CalcularPromedioSalarios(); break;
                    case 4: ClsEmpleado.CalcularSalarioMasBajoYMasAlto();  break;
					default:
						break;

                }

            } while (opcion != 5);
		}
	}
}

