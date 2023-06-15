using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1._0
{
    internal class clsmenu
    {
        clsmenu() { }

        public static void Principal()
        {
            int opcion = 0;
            Console.WriteLine("Deseas ingresar al Menú? si/no ");
            string respuesta = Console.ReadLine();

            while (respuesta == "si")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*******Opciones del menu*******");
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Inicializar vectores");
                Console.WriteLine("2. Ingresar paso vehicular");
                Console.WriteLine("3. Consulta de vehiculos por Número de Placa ");
                Console.WriteLine("4. Modificar Datos de Vehiculos por Número de placa ");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Facturación");
                Console.WriteLine("7. Salir");
                Console.WriteLine("*******************************");
                opcion = int.Parse(Console.ReadLine());


                if (opcion == 1)
                {
                    clsTransacciones.Inicializarvectores();
                }
                if (opcion == 2)
                {
                    clsTransacciones.IngresarDatos();
                }
                if (opcion == 3)
                {
                    clsTransacciones.consultaVehiculo();
                }
                if (opcion == 4)
                {
                    clsTransacciones.ModificarDatos();
                }
                if (opcion == 5)
                {
                    clsTransacciones.Reporte();
                }
                if (opcion == 6)
                {
                    clsTransacciones.Facturacion();
                }
                else Console.WriteLine("Presione enter para volver al Menú");
                Console.ReadLine();
            }
        }
    }
}
