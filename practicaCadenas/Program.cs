using System;

namespace PracticaCadenas
{

    public class Ejercicio1
    {

       

        public static void Main()
        {
            //variables creadas para la practica
            string cadena;
            string[] listapalabras;
            string menu;
            string sustituto;
            string palabra;

            do
            {
                //muestro por pantalla el texto e introduzco la cadena de caracteres
                Console.WriteLine("Por favor introduzca una cadena de 40 caracteres");

                cadena = Console.ReadLine();

                //compruebo el tamaño de esta cadena
                if (cadena.Length <= 40)
                {

                    //al ser menor a 40 que vuelva a intentarlo
                    Console.WriteLine("la cadena introducida solo tiene "+cadena.Length );
                }

                //entra si tiene mas de 40 caracteres
                else if (cadena.Length > 40)
                {

                    //enseño el menu con las opciones 1,2,3
                    Console.WriteLine("menu de opciones, para susttituir una palabra por otra seleccione 1, para buscar una palabra seleccione 2, para buscar palabra de inicio seleccione 3. ");
                    
                    //tomo la variable de menu
                    menu = Console.ReadLine();
                    
                    //compruebo si a sido 1, 2, 3 el menu
                    switch (menu)
                    {
                        case "1":
                            //caso 1 sustitulle una palabra por otra a eleccion ambas
                            Console.WriteLine("introduzca la palabra que quiere sustituir.");
                            
                            //leo la palbra a buscar
                            palabra = Console.ReadLine();

                            Console.WriteLine("introduzca la palabra por la que va a sustituir.");
                            
                            //leo la palabra que sustituye
                            sustituto = Console.ReadLine();
                            
                            //hago el cambio
                            cadena = cadena.Replace(palabra,sustituto);
                            
                            //muestro por pantalla
                            Console.WriteLine(cadena);

                            break;
                        case "2":
                            //caso 2 buscar si una palarba existe en la cadena
                            Console.WriteLine("introduzca la palabra que quiere buscar.");
                            
                            //leo la palabra a buscar
                            palabra = Console.ReadLine();
                            
                            //busco la palabra y guardo el resultado
                            bool contiene = cadena.Contains(palabra);

                            //segun el resultado anterior digo si existe o no
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

                            //caso 3 buscar si empieza por una palabra
                            Console.WriteLine("introduzca la palabra que quiere buscar al inicio.");
                            
                            //leo la palabra a buscar
                            palabra = Console.ReadLine();

                            //guardo si empieza o no por esa palabra
                            bool empieza = cadena.StartsWith(palabra);

                            //muestro resultado si empieza o no por ella
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
                            //caso en el que no haga selecionado 1 ,2 o 3
                            Console.WriteLine("opcion no valida en el menu");

                            break;
                    }

                }
                else
                {

                }
                




            }while (true);



        }

    }




}