﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    /// <summary>
    /// Ejemplo de lista y clase static.
    /// </summary>
    public static class Lista
    {
        public static string[] ListaArray() 
        {
            string[] miArrayDeNombresDePerros = new string[4];
            miArrayDeNombresDePerros[0] = "Laika";
            miArrayDeNombresDePerros[1] = "Coco";
            miArrayDeNombresDePerros[2] = "Thor";
            miArrayDeNombresDePerros[3] = "Tobi";

            return miArrayDeNombresDePerros;
        }

        public static List<string> ListaList()
        {
            List<string> personaNombres = new List<string>() 
            {
                "Danilo","Luis","Josué","Juan"
            };
            //personaNombres.Add("Danilo");
            //personaNombres.Add("Luis");
            return personaNombres;
        }

        public static LinkedList<int> EjemploLinkedList() 
        {
            LinkedList<int> numerosLinkedList = new LinkedList<int>();
            LinkedList<int> numerosLinkedListLast = new LinkedList<int>();
            int[] arreglo = new int[6] {10,7,4,2,0,6 };
            foreach (var itemNumero in arreglo)
            {
                //numerosLinkedList.AddFirst(itemNumero);
                numerosLinkedListLast.AddLast(itemNumero);
            }
            numerosLinkedListLast.Remove(7);
            return numerosLinkedListLast;
        }

        public static Queue<int> Cola() 
        {
            Queue<int> numerosCola = new Queue<int>();
            int[] arreglo = new int[6] { 10, 7, 4, 2, 0, 6 };
            foreach (var itemNumero in arreglo)
            {
                numerosCola.Enqueue(itemNumero);
            }
            numerosCola.Dequeue();
            return numerosCola;
        }

        public static Stack<int> Pila() 
        {
            Stack<int> numerosPila = new Stack<int>();
            int[] arreglo = new int[6] { 10, 7, 4, 2, 0, 6 };
            foreach (var item in arreglo)
            {
                numerosPila.Push(item);
            }
            if (numerosPila.Count > 0)
            {
                numerosPila.Pop();
            }            
            return numerosPila;
        }

        public static Dictionary<string, int> Diccionario() 
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Danilo",38);
            edades.Add("Josué", 32);
            edades["Rebeca"] = 33;
            edades["Mirna"] = 43;
            foreach (var item in edades)
            {

            }
            return edades;
        }
    }
}
  