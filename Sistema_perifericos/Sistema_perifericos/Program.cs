using Sistema_perifericos.clases;
using Sistema_perifericos.Servicios;

namespace Sistema_perifericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerifericoService servicio = new PerifericoService();

            while (true)
            {
                Console.WriteLine("1. Crear periférico");
                Console.WriteLine("2. Listar periféricos");
                Console.WriteLine("3. Eliminar periférico");
                Console.WriteLine("4. Salir");

                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Periferico p = new Periferico();

                    Console.Write("Id: ");
                    p.Id = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    p.Nombre = Console.ReadLine();

                    Console.Write("Marca: ");
                    p.Marca = Console.ReadLine();

                    Console.Write("Precio: ");
                    p.Precio = double.Parse(Console.ReadLine());

                    servicio.Crear(p);
                }

                else if (op == 2)
                {
                    foreach (var p in servicio.Leer())
                        p.MostrarInfo();
                }

                else if (op == 3)
                {
                    Console.Write("Id a eliminar: ");
                    int id = int.Parse(Console.ReadLine());

                    servicio.Eliminar(id);
                }

                else
                    break;
            }
        }
    }
}
