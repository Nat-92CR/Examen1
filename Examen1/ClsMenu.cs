using System;
namespace Examen1
{
	internal class ClsMenu
	{
		ClsEmpleado Empleado = new ClsEmpleado();//Se instancio
												 //Atributo
		private int opcion = 0; //Este atributo es Privado: solo lo ve la clase menu.

		//Metod0s

		public void Mostrar()// Esta variable esta publica, ya que se utlizara en program
		{

			int opcion; //Opcion local

			ClsMenu op = new ClsMenu();
			op.opcion = 0;

			while (op.opcion != 8)
			{
				Console.WriteLine("MENU PRINCIPAL");
				Console.WriteLine("1- Inicializar");
				Console.WriteLine("2- Agregar empleados");
				Console.WriteLine("3- Consultar empleados");
				Console.WriteLine("4- Modificar empleados");
				Console.WriteLine("5- Borrar empleados");
				Console.WriteLine("6- Reportes");
				
				int.TryParse(Console.ReadLine(), out opcion);//Qu no se caiga cuando se digita algo
				switch (opcion)
				{
					case 1: Empleado.Inicializar(); break;
					case 2: Empleado.AgregarEmpleados(); break;
					case 3: Empleado.ConsultarEmpleado(); break;
					case 4: Empleado.ModificarEmpleado(); break;
					case 5: Empleado.BorrarEmpleado();  break;
					case 6: ClsSubmenureportes.submenu(); break;
					default:
						Console.WriteLine("Ingreso una opcion incorrecta");
						break;
				}

			}

		}
	}
}
