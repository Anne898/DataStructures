using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            //LISTA
            //Generic <>
            List<string> NombrePeliculas = new List<string>(); //lista

            NombrePeliculas.Add("Cadaver de la novia");
            NombrePeliculas.Add("Pulp Fiction");
            NombrePeliculas.Add("Pacific Rim");

            Console.WriteLine(NombrePeliculas[1]);

            //No permite elementos duplicados
            HashSet<string> NombrePeliculas2 = new HashSet<string>();

            NombrePeliculas2.Add("Cadaver de la novia");
            NombrePeliculas2.Add("Cadaver de la novia");
            Console.WriteLine(NombrePeliculas2.Count);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();

            peliculasSet.Add(new Pelicula("bad boys", 1983));
            peliculasSet.Add(new Pelicula("bad boys", 1995));
            peliculasSet.Add(new Pelicula("bad boys", 1995));

            Console.WriteLine(peliculasSet.Count); //marca 3 porque son objetos

            //Dictionary
            Dictionary<string, string> colorFavorito = new Dictionary<string, string>();

            colorFavorito.Add("Johnny", "Azul");
            colorFavorito.Add("Jack", "Negro");
            colorFavorito.Add("Ruperto", "gris");

            string colorFavoritoJack = colorFavorito.GetValueOrDefault("Jack");

            Console.WriteLine($"color Favorito de Jack = {colorFavoritoJack}");
            // Console.WriteLine(colorFavorito.Keys);
            //Console.WriteLine(colorFavorito.Values);

            int[]numeros = new int[3]{1,2,3};

                for (int i = 0; i < numeros.Length; i++)
                {
                    System.Console.WriteLine(numeros[i]);
                }
                foreach (var numero in numeros)
                {
                 System.Console.WriteLine(numero);   
                }

                foreach (var Key in colorFavorito.Keys)
                {
                    System.Console.WriteLine(Key);
                } 

                foreach (var valor in colorFavorito.Values)
                {
                    System.Console.WriteLine(valor);
                }




            }
        }
    }

