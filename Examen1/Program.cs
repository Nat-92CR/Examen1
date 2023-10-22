namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre del programa
            Console.WriteLine("SISTEMA DE RECURSOS HUMANOS");

            //Colocando fecha y hora al programa
            DateTime fecha = DateTime.Now; //Instancia == copia de un objeto
            Console.WriteLine($"FECHA: {fecha.Day}/{fecha.Month}/{fecha.Year} HORA: {fecha.Hour}:{fecha.Minute}:{fecha.Second}");


            //Llamando a la clase MOSTRAR
            
            ClsMenu menu = new ClsMenu(); //Instancia de la clase menu
            menu.Mostrar();
            Console.WriteLine();


        }
    }
}
