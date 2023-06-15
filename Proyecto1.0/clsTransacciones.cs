using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1._0
{
    internal class clsTransacciones
    {
        public static int[] factura = { 1, 2, 3, 4, 5,6 };
        public static int[] Placa = { 123, 345, 567, 789, 901, 569 };
        public static string[] fecha = { "12/23", "12/23", "12/23", "12/23", "12/23","12/23" };
        public static string[] hora = { "12:10", "12:10", "12:10", "12:10", "12:10","12:10" };
        public static int[] caseta = { 1, 2, 1, 2, 3, 2 };
        public static int[] tipo_vehiculo = { 2, 3, 4, 1, 2,2 };
        public static int[] precio ={700, 2700, 3700, 500, 700, 700 };

        public clsTransacciones() { }

        public static void Inicializarvectores()
        {
            int largo = Placa.Length;
            while (largo > 0)
            {
                //Console.WriteLine(largo);
                //Placa = Placa.Where(n => n != Placa[largo - 1]).ToArray();
                //factura = factura.Where(n => n != factura[largo - 1]).ToArray();
                //fecha = fecha.Where(n => n != fecha[largo - 1]).ToArray();
                //caseta = caseta.Where(n => n != caseta[largo - 1]).ToArray();
                //hora = hora.Where(n => n != hora[largo - 1]).ToArray();
                //tipo_vehiculo = tipo_vehiculo.Where(n => n != tipo_vehiculo[largo - 1]).ToArray();

                Placa = Placa.Where((source, index) => index != largo - 1).ToArray();
                factura = factura.Where((source, index) => index != largo - 1).ToArray();
                fecha = fecha.Where((source, index) => index != largo - 1).ToArray();
                caseta = caseta.Where((source, index) => index != largo - 1).ToArray();
                hora = hora.Where((source, index) => index != largo - 1).ToArray();
                tipo_vehiculo = tipo_vehiculo.Where((source, index) => index != largo - 1).ToArray();

                largo = largo - 1;
                //largo =Placa.Length;
            }
            Console.WriteLine("Vectores inicializados con éxito.");
            //Console.WriteLine("Presione enter para volver al menu");
            //Console.ReadLine();
        }
        public static void IngresarDatos()
        {
            int largo = Placa.Length;
            Console.WriteLine("Digite el numero de Placa: ");
            int nuevaplaca = int.Parse(Console.ReadLine());
            Placa = Placa.Concat(new int[] { nuevaplaca }).ToArray();
            Console.WriteLine("Digite el numero de Factura: ");
            int nuevafactura = int.Parse(Console.ReadLine());
            factura = factura.Concat(new int[] { nuevafactura }).ToArray();
            Console.WriteLine("Digite el numero de Caseta: ");
            int nuevacaseta = int.Parse(Console.ReadLine());
            caseta = caseta.Concat(new int[] { nuevacaseta }).ToArray();
            Console.WriteLine("Digite la fecha que ingresó: ");
            string nuevafecha = (Console.ReadLine());
            fecha = fecha.Concat(new string[] { nuevafecha }).ToArray();
            Console.WriteLine("Digite la hora de entrada: ");
            string nuevahora = (Console.ReadLine());
            hora = hora.Concat(new string[] { nuevahora }).ToArray();
            Console.WriteLine("Ingrese el Tipo de Vehiculo: ");
            int nuevovehiculo = int.Parse(Console.ReadLine());
            tipo_vehiculo = tipo_vehiculo.Concat(new int[] { nuevovehiculo }).ToArray();
            //int largo = Placa.Length;

            //for (int i = 0; i < largo; i++)
            //{
            //    Console.WriteLine("Digite el numero de Placa: ");
            //    Placa[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite el numero de Factura: ");
            //    factura[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite el numero de Caseta: ");
            //    caseta[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite la fecha que ingresó: ");
            //    fecha[i] = Console.ReadLine();
            //    Console.WriteLine("Digite la hora de entrada: ");
            //    hora[i] = Console.ReadLine();
            //    Console.WriteLine("Ingrese el Tipo de Vehiculo: ");
            //    tipo_vehiculo[i] = int.Parse(Console.ReadLine());

            //}


        }
        public static void consultaVehiculo()
        {
            int numero_placa = new int();
            Boolean Existe = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite el numero de Placa: ");
            numero_placa = int.Parse(Console.ReadLine());
            int largo = Placa.Length;
            if (largo == 0)
            {
                Console.WriteLine("No existe el Dato ingresado");
            }
            else
            {
                for (int i = 0; i < largo; i++)
                {
                    if (Placa[i].Equals(numero_placa))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El numero de Placa es: " + Placa[i]);
                        Console.WriteLine("La Factura es la numero: " + factura[i]);
                        Console.WriteLine("La Fecha de entrada: " + fecha[i]);
                        Console.WriteLine("La Hora de entrada: " + hora[i]);
                        Console.WriteLine("El numero de caseta es: " + caseta[i]);
                        Console.WriteLine("El tipo de vehiculo es: " + tipo_vehiculo[i]);
                        Existe = true;
                        break;

                    }


                }
            }
        }
        public static void ModificarDatos()
        {
            int numero_placa = new int();
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de Placa: ");
            numero_placa = int.Parse(Console.ReadLine());
            int largo = Placa.Length;

            for (int i = 0; i < largo; i++)
            {
                if (Placa[i].Equals(numero_placa))
                {
                    Console.Clear();
                    Console.Write("Actualice el numero de Placa:");
                    Placa[i] = int.Parse(Console.ReadLine());
                    Console.Write("Actualice el numero de Factura :");
                    factura[i] = int.Parse(Console.ReadLine());
                    Console.Write("Actualice la Fecha :");
                    fecha[i] = (Console.ReadLine());
                    Console.Write("Actualice la Hora :");
                    hora[i] = (Console.ReadLine());
                    Console.WriteLine("Actualice numero de Caseta");
                    caseta[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Actualice el tipo de Vehiculo");
                    tipo_vehiculo[i] = int.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }
            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("La Placa no exite en el sistema");
            }
        }
        public static void Reporte()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------Reporte del Peaje Autopistas del sol --------------------");
            Console.WriteLine("N.Factura      Placa    Fecha    Hora      Caseta    Tipo de vehiculo    ");
            Console.WriteLine();
            for (int i = 0; i < Placa.Length; i++)
            {

                Console.WriteLine(factura[i] + "\t\t" + Placa[i] + "\t" + fecha[i] + "\t" + hora[i] + "\t\t" + caseta[i] + "\t" + tipo_vehiculo[i]);









            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------Fin del reporte-------------------------------");
            //Console.WriteLine("Presione enter para volver al menú");
            //Console.ReadLine();
        }
        public static void Facturacion()
        {
            int numero_placa = new int();
            Boolean Existe = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Digite el numero de Placa: ");
            numero_placa = int.Parse(Console.ReadLine());
            int largo = Placa.Length;
            if (largo == 0)
            {
                Console.WriteLine("No existe el Dato ingresado");
            }
            else
            {
                for (int i = 0; i < largo; i++)
                {
                    if (Placa[i].Equals(numero_placa))
                    {
                        Console.Clear();
                        Console.WriteLine("Fecha: " + fecha[i]);
                        Console.WriteLine("-------------------- Facturación Autopistas del sol --------------------");
                        Console.WriteLine("N.Factura      Placa     Tipo de vehiculo  Caseta   Total en Colones  ");
                        Console.WriteLine();

                        Console.WriteLine(+factura[i] + "\t\t" + Placa[i] + "\t\t" + tipo_vehiculo[i] + "\t\t" + caseta[i] + "\t" + precio[i]);

                        Console.WriteLine();
                        Console.WriteLine("Ingrese monto con el que pagó: ");
                        int pago =int.Parse(Console.ReadLine());
                        int su_vuelto = pago - precio[i];
                        Console.WriteLine("Su Pago:  "+pago);
                        Console.WriteLine("Su Vuelto>>  "+su_vuelto);
                        Existe = true;
                        break;

                    }


                }
                
                Console.WriteLine();
                Console.WriteLine("-------------------------------BUEN VIAJE-------------------------------");
                //Console.WriteLine("Presione enter para volver al menú");
                //Console.ReadLine();
            }
        }
    }
}
