﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoNormal
    {
        //readonly significa que esta variable solo
        //se puede inicializar en el constructor
        private readonly Object[] _datosElemento;
        private int _contador = 0;
        //Constructor
        /// <summary>
        /// Constructor que recibe por parámetro el tamaño del arreglo
        /// </summary>
        /// <param name="tamanno">Entero para inicializar el arreglo</param>
        public AlmacenaObjetoNormal(int tamanno)
        {
            //Inicializar el arreglo
            _datosElemento = new Object[tamanno];
        }
        //Métodos
        public void Agregar(Object obj) 
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }
        public Object ObtenerElemento(int posicion) 
        {
            return _datosElemento[posicion];
        }
    }    
}
