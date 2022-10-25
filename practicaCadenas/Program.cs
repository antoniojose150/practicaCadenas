using System;

namespace PracticaCadenas
{

    public class Ejercicio1
    {

       

        public static void Main()
        {

            string cadena;
            string[] listapalabras;
            string menu;
            string sustituto;
            string palabra;

            do
            {
                Console.WriteLine("Por favor introduzca una cadena de 40 caracteres");
                cadena = Console.ReadLine();

                if (cadena == null)
                {

                }
                else if (cadena.Length < 40)
                {
                    Console.WriteLine("la cadena introducida solo tiene "+cadena.Length );
                }
                else
                {


                    

                    Console.WriteLine("menu de opciones, para susttituir una palabra por otra seleccione 1, para buscar una palabra seleccione 2, para buscar palabra de inicio seleccione 3. ");

                    menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            Console.WriteLine("introduzca la palabra que quiere sustituir.");

                            palabra = Console.ReadLine();

                            Console.WriteLine("introduzca la palabra por la que va a sustituir.");

                            sustituto = Console.ReadLine();
                            
                            cadena = cadena.Replace(palabra,sustituto);

                            Console.WriteLine(cadena);

                            break;
                        case "2":

                            Console.WriteLine("introduzca la palabra que quiere buscar.");

                            palabra = Console.ReadLine();
                            

                            bool contiene = cadena.Contains(palabra);

                            if (contiene)
                            {
                                Console.WriteLine("la palabra existe.");
                            }
                            else
                            {
                                Console.WriteLine("la no palabra existe.");
                            }

                            break;
                        case "3":

                            Console.WriteLine("introduzca la palabra que quiere buscar al inicio.");

                            palabra = Console.ReadLine();


                            bool empieza = cadena.StartsWith(palabra);

                            if (empieza)
                            {
                                Console.WriteLine("la cadena empieza por la palabra.");
                            }
                            else
                            {
                                Console.WriteLine("la cadena no empieza por la  palabra.");
                            }


                            break;

                        default:

                            Console.WriteLine("opcion no valida en el menu");

                            break;
                    }

                    

                   

                }
                




            }while (true);



        }

    }




}