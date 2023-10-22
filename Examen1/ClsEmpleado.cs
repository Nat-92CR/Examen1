using System;
namespace Examen1
{
	internal class ClsEmpleado
	{
        // ATRIBUTO
        // Van hacer privadas porque solo las voy a utilzar en ClsEmpleado y static para no tener que instanciar

           private static byte cant = 15;
           private static string[] cedula = new string[cant];
           private static string[] nombre = new string[cant];
           private static string[] direccion = new string[cant];
           private static string[] telefono = new string[cant];
           private static float[] salario = new float[cant];
           private static byte indice;
           private static int cont ;




        // CONSTRUCTOR
        //public ClsEmpleado(string cedula, string nombre, string direccion, string telefono, float salario)
        //   {
        //        Cedula = cedula;
        //        Nombre = nombre;
        //        Direccion = direccion;
        //        Telefono = telefono;
        //        Salario = salario;
        //    }

        public ClsEmpleado()
        {
            cont = 0;
            indice = 0;
        }


        // METOD0S

        //Menu Inicializar
        public void Inicializar()
        {
            //indice = 0;
            //cont = 1;
            cedula = Enumerable.Repeat("", cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            Console.WriteLine("Los arreglos han sido inicializados");
        }

        //Menu Consultar Empleados

        public void ConsultarEmpleado()
        {
            Console.WriteLine("Digite el número de cédula del empleado que desea consultar: ");
            string cedulaConsulta = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedulaConsulta == cedula[i])
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Dirección: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El empleado no se encontró.");
            }
        }


        //SubMenu ConsultarEmpleados

        public static void ConsultarEmpleados()
  
        {
            Console.WriteLine("Digite un numero de cedula: ");
            string cedulaConsulta = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedulaConsulta == cedula[i])
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Dirección: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron empleados con la cédula proporcionada.");
            }
        }

        //Submenu ListarEmpleados

        public static void ListarEmpleadosOrdenadosPorNombre()
        {
            Console.WriteLine("**********Listar todos los Empleados 2023***********");

            // Crear un array de índices ordenados alfabéticamente por nombre
            int[] indicesOrdenados = Enumerable.Range(0, cant).OrderBy(i => nombre[i]).ToArray();

            // Iterar sobre los índices ordenados y mostrar los empleados
            foreach (int i in indicesOrdenados)
            {
                if (!string.IsNullOrEmpty(nombre[i]))
                {
                    Console.WriteLine($"Cedula:{cedula[i]} Nombre: {nombre[i]} Dirección: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]} ");
                }
            }

            Console.WriteLine("********** ultima linea ***********");
        }


        //Submenu Calcular promedio salario

        public static void CalcularPromedioSalarios()
        {
            if (cont == 0)
            {
                Console.WriteLine("No hay empleados registrados para calcular el promedio de salarios.");
            }
            else
            {
                float sumaSalarios = 0;
                for (int i = 0; i < cont; i++)
                {
                    sumaSalarios += salario[i];
                }
                float promedioSalarios = sumaSalarios / cont;
                Console.WriteLine($"El promedio de salarios de {cont} empleados es: ₡{promedioSalarios:N0}");
            }
        }


        //Submenu Calcular Salario +alto y +bajo

        public static void CalcularSalarioMasBajoYMasAlto()
        {
            if (cont == 0)
            {
                Console.WriteLine("No hay empleados registrados para calcular el salario más bajo y más alto.");
            }
            else
            {
                float salarioMasBajo = salario[0];
                float salarioMasAlto = salario[0];

                for (int i = 0; i < cont; i++)
                {
                    if (salario[i] < salarioMasBajo)
                    {
                        salarioMasBajo = salario[i];
                    }
                    if (salario[i] > salarioMasAlto)
                    {
                        salarioMasAlto = salario[i];
                    }
                }

                Console.WriteLine($"Salario más bajo: ₡{salarioMasBajo:N0}");
                Console.WriteLine($"Salario más alto: ₡{salarioMasAlto:N0}");
            }
        }

        //Menu ModificarEmpleados

        public void ModificarEmpleado()
        {
            Console.WriteLine("Digite el número de cédula del empleado que desea modificar: ");
            string cedulaBuscada = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedula[i] == cedulaBuscada)
                {
                    Console.WriteLine($"Empleado encontrado. Puede realizar las modificaciones.");

                    // Solicitar las modificaciones necesarias
                    Console.WriteLine($"Nuevo nombre ({nombre[i]}): ");
                    string nuevoNombre = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nuevoNombre))
                    {
                        nombre[i] = nuevoNombre;
                    }

                    Console.WriteLine($"Nueva dirección ({direccion[i]}): ");
                    string nuevaDireccion = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nuevaDireccion))
                    {
                        direccion[i] = nuevaDireccion;
                    }

                    Console.WriteLine($"Nuevo número telefónico ({telefono[i]}): ");
                    string nuevoTelefono = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nuevoTelefono))
                    {
                        telefono[i] = nuevoTelefono;
                    }

                    Console.WriteLine($"Nuevo salario ({salario[i]}): ");
                    float nuevoSalario;
                    if (float.TryParse(Console.ReadLine(), out nuevoSalario))
                    {
                        salario[i] = nuevoSalario;
                    }

                    Console.WriteLine("Empleado modificado correctamente.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El empleado no se encontró, no se pueden realizar modificaciones.");
            }
        }

        //Menu BorrarEmpleados
        public void BorrarEmpleado()
        {
            Console.WriteLine("Digite el número de cédula del empleado que desea borrar: ");
            string cedulaBorrar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedula[i] == cedulaBorrar)
                {
                    // Realizar el borrado
                    cedula[i] = string.Empty;
                    nombre[i] = string.Empty;
                    direccion[i] = string.Empty;
                    telefono[i] = string.Empty;
                    salario[i] = 0;
                    cont--;

                    Console.WriteLine("Empleado borrado correctamente.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El empleado no se encontró, no se puede realizar el borrado.");
            }
        }


        //Menu AgregarEmpleados

        public void AgregarEmpleados()
        {
            char respuesta = 'N';
           
            
            do
            {
                //Solicitud de los datos
                Console.Clear();
                if (indice <=15) //Para no pasarse del numero, nunca me va a ingresar un empleado menor a (#)
                {
                    Console.WriteLine($"Ingrese el numero de cedula ({indice}): ");
                    cedula[indice] = Console.ReadLine();


                    Console.WriteLine($"Ingrese el nombre del Empleado ({indice}):  ");
                    nombre[indice] = Console.ReadLine();


                    Console.WriteLine($"Ingrese la dirección ({indice}):  ");
                    direccion[indice] = Console.ReadLine();


                    Console.WriteLine($"Ingrese el numero telefónico ({indice}):  ");
                    telefono[indice] = Console.ReadLine();


                    Console.WriteLine($"Ingrese el salario ({indice}):  ");
                    float.TryParse(Console.ReadLine(), out salario[indice]);
                    indice++;
                    cont++;
                    Console.WriteLine("Desea Ingresar otro Empleado (S/N)");

                    respuesta = char.Parse(Console.ReadLine().ToString().ToUpper()); // Convertir tod en MaYUSC
                }
                else {
                    Console.WriteLine("El arreglo esta lleno");
                    break; };
                
            } while (respuesta!= 'N');

        }
    }   
}

