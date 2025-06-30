namespace Programa3_2
{
    using System;

    namespace ConsoleApp1
    {

        // Clase padre Vectores con las funciones que se piden en cada uno de los casos
        abstract class Vectores
        {

            public abstract void ImprimirPorPantalla(double[] vector);
            public abstract double CalcularParametros(double[] vector1, double[] vector2, out double ang);
            public abstract double[] LeerVector(ref double[] vector);

        }

        // Clase hija que pide los vectores cartesianos de dimensión 2
        class Vec2DC : Vectores
        {
            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("\nIngrese las coordenadas cartesianas del vector de dimensión 2: ");

                for (int i = 0; i < 2; i++)
                {
                    vector[i] = Convert.ToDouble(Console.ReadLine());
                }

                return vector;

            }

            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("\nSus vectores son: (" + vector[0] + "," + vector[1] + ")");
                Console.ReadKey();
            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {
                double resultado_par, resultado_impar, modulo_v1, modulo_v2, prod_modulos;

                if (vector1[0] % 2 == 0)
                {
                    // Cálculo de la operación1 en caso de ser par
                    resultado_par = (vector1[1]) * (vector2[0]) * (vector2[1]) - (vector1[0]);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_par);
                }
                else
                {
                    // Cálculo de la operación1 en caso de ser impar
                    resultado_impar = ((vector1[1]) + (vector2[0]) + (vector2[1])) * (vector1[0]);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_impar);
                }

                // Cálculo de los módulos
                modulo_v1 = Math.Sqrt((Math.Pow(vector1[0], 2)) + (Math.Pow(vector1[1], 2)));
                modulo_v2 = Math.Sqrt((Math.Pow(vector2[0], 2)) + (Math.Pow(vector2[1], 2)));
                // Cálculo del producto de módulos
                prod_modulos = (modulo_v1) * (modulo_v2);
                Console.WriteLine("\nEl producto de módulos es: " + prod_modulos);

                // Cálculo del ángulo
                ang = Math.Acos((((vector1[0]) * (vector2[0])) + ((vector1[1]) * (vector2[1]))) / (prod_modulos));
                Console.WriteLine("\nEl ángulo que generan los vectores es: " + ang);


                Console.ReadKey();
                return 0;
            }
        }

        // Clase hija que pide los vectores polares de dimensión 2
        class Vec2DP : Vectores
        {


            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("\nIngrese las coordenadas polares del vector de dimensión 2: ");

                for (int i = 0; i < 2; i++)
                {
                    vector[i] = Convert.ToDouble(Console.ReadLine());
                }

                return vector;
            }
            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("\nSus vectores son: (" + vector[0] + "," + vector[1] + ")");
                Console.ReadKey();

            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {

                double resultado_par, resultado_impar, modulo_v1, modulo_v2, prod_modulos, coordenada1_v1, coordenada2_v1, coordenada1_v2, coordenada2_v2;

                // Cálculo del paso de cada una de las coordenadas de los vectores de polares a cartesianas, para poder operar de manera correcta con ellos
                coordenada1_v1 = (vector1[0]) * (Math.Cos(vector1[1]));
                coordenada2_v1 = (vector1[0]) * (Math.Sin(vector1[1]));
                coordenada1_v2 = (vector2[0]) * (Math.Cos(vector2[1]));
                coordenada2_v2 = (vector2[0]) * (Math.Sin(vector2[1]));


                if (vector1[0] % 2 == 0)
                {
                    // Cálculo de la operación1 en caso de ser par
                    resultado_par = (coordenada2_v1) * (coordenada1_v2) * (coordenada2_v2) - (coordenada1_v1);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_par);
                }
                else
                {
                    // Cálculo de la operación1 en caso de ser impar
                    resultado_impar = ((coordenada2_v1) + (coordenada1_v2) + (coordenada2_v2)) * (coordenada1_v1);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_impar);
                }

                // Cálculo de los módulos
                modulo_v1 = Math.Sqrt((Math.Pow(coordenada1_v1, 2)) + (Math.Pow(coordenada2_v1, 2)));
                modulo_v2 = Math.Sqrt((Math.Pow(coordenada1_v2, 2)) + (Math.Pow(coordenada2_v2, 2)));
                // Cálculo del producto de módulos
                prod_modulos = (modulo_v1) * (modulo_v2);
                Console.WriteLine("\nEl producto de módulos es: " + prod_modulos);

                // Cálculo del ángulo
                ang = Math.Acos((((coordenada1_v1) * (coordenada1_v2)) + ((coordenada2_v1) * (coordenada2_v2))) / (prod_modulos));
                Console.WriteLine("\nEl ángulo que generan los vectores es: " + ang);


                Console.ReadKey();
                return 0;
            }
        }

        // Clase hija que pide los vectores cartesianos de dimensión 3
        class Vec3DC : Vectores
        {
            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("\nSus vectores son: (" + vector[0] + "," + vector[1] + "," + vector[2] + ")");
                Console.ReadKey();

            }



            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("\nIngrese las coordenadas cartesianas del vector de dimensión 3: ");

                for (int i = 0; i < 3; i++)
                {
                    vector[i] = Convert.ToDouble(Console.ReadLine());
                }

                return vector;
            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {

                double resultado_par, resultado_impar, modulo_v1, modulo_v2, prod_modulos;

                if (vector1[0] % 2 == 0)
                {
                    // Cálculo de la operación1 en caso de ser par
                    resultado_par = (vector1[1]) * (vector1[2]) * (vector2[0]) * (vector2[1]) * (vector2[2]) - (vector1[0]);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_par);
                }
                else
                {
                    // Cálculo de la operación1 en caso de ser impar
                    resultado_impar = ((vector1[1]) + (vector1[2]) + (vector2[0]) + (vector2[1]) + (vector2[2])) * (vector1[0]);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_impar);
                }

                // Cálculo de los módulos
                modulo_v1 = Math.Sqrt((Math.Pow(vector1[0], 2)) + (Math.Pow(vector1[1], 2) + (Math.Pow(vector1[2], 2))));
                modulo_v2 = Math.Sqrt((Math.Pow(vector2[0], 2)) + (Math.Pow(vector2[1], 2) + (Math.Pow(vector2[2], 2))));
                // Cálculo del producto de módulos
                prod_modulos = (modulo_v1) * (modulo_v2);
                Console.WriteLine("\nEl producto de módulos es: " + prod_modulos);

                // Cálculo del ángulo
                ang = Math.Acos((((vector1[0]) * (vector2[0])) + ((vector1[1]) * (vector2[1])) + ((vector1[2]) * (vector2[2]))) / (prod_modulos));
                Console.WriteLine("\nEl ángulo que generan los vectores es: " + ang);


                Console.ReadKey();
                return 0;
            }

        }

        // Clase hija que pide los vectores esféricos de dimensión 3
        class Vec3DE : Vectores
        {



            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("\nSus vectores son: (" + vector[0] + "," + vector[1] + "," + vector[2] + ")");
                Console.ReadKey();

            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {
                double resultado_par, resultado_impar, modulo_v1, modulo_v2, prod_modulos, coordenada1_v1, coordenada2_v1, coordenada3_v1, coordenada1_v2, coordenada2_v2, coordenada3_v2;

                // Cálculo del paso de cada una de las coordenadas de los vectores de esféricos a cartesianos, para poder operar de manera correcta con ellos
                coordenada1_v1 = (vector1[0]) * (Math.Sin(vector1[2]) * (Math.Cos(vector1[1])));
                coordenada2_v1 = (vector1[0]) * (Math.Sin(vector1[2]) * (Math.Sin(vector1[1])));
                coordenada3_v1 = (vector1[0]) * Math.Cos(vector1[2]);

                coordenada1_v2 = (vector2[0]) * (Math.Sin(vector2[2]) * (Math.Cos(vector2[1])));
                coordenada2_v2 = (vector2[0]) * (Math.Sin(vector2[2]) * (Math.Sin(vector2[1])));
                coordenada3_v2 = (vector2[0]) * Math.Cos(vector2[2]);


                if (vector1[0] % 2 == 0)
                {
                    // Cálculo de la operación1 en caso de ser par
                    resultado_par = (coordenada2_v1) * (coordenada3_v1) * (coordenada1_v2) * (coordenada2_v2) * (coordenada3_v2) - (coordenada1_v1);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_par);
                }
                else
                {
                    // Cálculo de la operación1 en caso de ser impar
                    resultado_impar = ((coordenada2_v1) + (coordenada3_v1) + (coordenada1_v2) + (coordenada2_v2) + (coordenada3_v2)) * (coordenada1_v1);
                    Console.WriteLine("\nEl resultado de la operación 1 es: " + resultado_impar);
                }

                // Cálculo de los módulos
                modulo_v1 = Math.Sqrt((Math.Pow(coordenada1_v1, 2)) + (Math.Pow(coordenada2_v1, 2) + (Math.Pow(coordenada3_v1, 2))));
                modulo_v2 = Math.Sqrt((Math.Pow(coordenada1_v2, 2)) + (Math.Pow(coordenada2_v2, 2) + (Math.Pow(coordenada3_v2, 2))));
                // Cálculo del producto de módulos
                prod_modulos = (modulo_v1) * (modulo_v2);
                Console.WriteLine("\nEl producto de módulos es: " + prod_modulos);

                // Cálculo del ángulo
                ang = Math.Acos((((coordenada1_v1) * (coordenada1_v2)) + ((coordenada2_v1) * (coordenada2_v2)) + ((coordenada3_v1) * (coordenada3_v2))) / (prod_modulos));
                Console.WriteLine("\nEl ángulo que generan los vectores es: " + ang);


                Console.ReadKey();
                return 0;
            }

            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("\nIngrese las coordenadas esféricas del vector de dimensión 3: ");

                for (int i = 0; i < 3; i++)
                {
                    vector[i] = Convert.ToDouble(Console.ReadLine());
                }

                return vector;
            }
        }

// Clase Program
        class Program

        {

            static void Main(string[] args)
            {
                int opc;
                double[] vector1 = new double[3];
                double[] vector2 = new double[3];
                double ang;

                do
                {
                    // Menú con las diferentes opciones
                    Console.Clear();
                    Console.WriteLine("Selecciona una opción: \n");
                    Console.WriteLine("1. Operación con 2 vectores de coordenadas cartesianes de dimensión 2.");
                    Console.WriteLine("2. Operación con 2 vectores de coordenadas cartesianes de dimensión 3.");
                    Console.WriteLine("3. Operación con 1 vector de coordenadas polares.");
                    Console.WriteLine("4. Operación con 1 vector de coordenadas esféricas.");
                    Console.WriteLine("5. Salir del programa. \n");

                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Vectores miVec2DC = new Vec2DC();
                            miVec2DC.LeerVector(ref vector1);
                            miVec2DC.LeerVector(ref vector2);
                            miVec2DC.ImprimirPorPantalla(vector1);
                            miVec2DC.ImprimirPorPantalla(vector2);
                            miVec2DC.CalcularParametros(vector1, vector2, out ang);

                            break;

                        case 2:
                            Console.Clear();
                            Vec3DC miVec3DC = new Vec3DC();
                            miVec3DC.LeerVector(ref vector1);
                            miVec3DC.LeerVector(ref vector2);
                            miVec3DC.ImprimirPorPantalla(vector1);
                            miVec3DC.ImprimirPorPantalla(vector2);
                            miVec3DC.CalcularParametros(vector1, vector2, out ang);
                            break;

                        case 3:
                            Console.Clear();
                            Vec2DP miVec2DP = new Vec2DP();
                            miVec2DP.LeerVector(ref vector1);
                            miVec2DP.LeerVector(ref vector2);
                            miVec2DP.ImprimirPorPantalla(vector1);
                            miVec2DP.ImprimirPorPantalla(vector2);
                            miVec2DP.CalcularParametros(vector1, vector2, out ang);
                            break;

                        case 4:
                            Console.Clear();
                            Vec3DE miVec3DE = new Vec3DE();
                            miVec3DE.LeerVector(ref vector1);
                            miVec3DE.LeerVector(ref vector2);
                            miVec3DE.ImprimirPorPantalla(vector1);
                            miVec3DE.ImprimirPorPantalla(vector2);
                            miVec3DE.CalcularParametros(vector1, vector2, out ang);
                            break;

                        case 5:
                            return;

                    }


                } while (opc <= 5 && opc > 0);

            }


        }



    }


}
