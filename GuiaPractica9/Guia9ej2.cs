using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaPractica9
{
    class Guia9ej2
    {
        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;


            public void setCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }
                }
            }

            public double getCum()
            {
                return cum;
            }


        }




        static void Main(string[] args)
        {

            Dictionary<string, Alumnos> datosA = new Dictionary<string, Alumnos>();


            int opc;
            Console.WriteLine("  Menu.");
            Console.WriteLine("  [1].Agregar Alumno ");
            Console.WriteLine("  [2].Mostrar Alumnos ");
            Console.WriteLine("  [3].Eliminar Alumno ");
            Console.WriteLine("  [4].Buscar Alumno ");
            Console.WriteLine("  [5].Vaciar Diccionario ");
            Console.WriteLine("  [6].Salir ");
            opc = int.Parse(Console.ReadLine());
            int cant;

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Cuantos alumnos desea ingresar: ");
                    cant = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < cant; i++)
                    {
                        Alumnos alumno = new Alumnos();
                        Console.WriteLine("Alumno #{0}", i + 1);
                        do
                        {
                            Console.Write("Ingrese el carnet del alumno: ");
                            alumno.carnet = Console.ReadLine();
                            if (datosA.ContainsKey(alumno.carnet))
                            {
                                Console.WriteLine("El carnet: {0} ya existe...", alumno.carnet);
                            }

                        } while (datosA.ContainsKey(alumno.carnet));
                        Console.Write("Ingrese el nombre del Alumno: ");
                        alumno.nombre = Console.ReadLine();
                        Console.Write("Ingrese la carrera del Alumno: ");
                        alumno.carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese el CUM del Alumno: ");
                        alumno.setCum(Convert.ToDouble(Console.ReadLine()));
                        datosA.Add(alumno.carnet, alumno);





                    }
                    break;
                case 2:
                    Console.Clear();
                    foreach (KeyValuePair<string, Alumnos> dato in datosA)
                    {
                        Console.WriteLine(dato);
                    }
                    break;
                case 3:
                    Console.Clear();
                    string y;
                    Console.WriteLine("Ingrese el carnet del alumno que desea eliminar");
                    y = Console.ReadLine();
                    datosA.Remove(y);
                    foreach (KeyValuePair<string, Alumnos> dato in datosA)
                    {
                        Console.WriteLine(dato);
                    }

                    break;
                case 4:
                    Console.Clear();
                    string x;
                    Console.WriteLine("Ingrese el alumno que desea buscar");
                    x = Console.ReadLine();

                    do
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("El alumno si esta");


                    } while ((datosA.ContainsKey(x)));
                    break;
                case 5:
                    Console.Clear();
                    datosA.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Presione una tecla para salir");
                    break;
            }
            Console.ReadKey();
        }
    }
}
