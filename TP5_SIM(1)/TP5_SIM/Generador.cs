﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM
{
    public class Generador
    {
        /// </summary>
        /// <param name="a_Unif">Es el parámetro a que ingresa el usuario</param>
        /// <param name="b">Es el parámetro b que ingresa el usuario</param>
        /// <param name="r">Es el número aleatorio</param>
        /// <returns></returns>
        public double generarUniforme(double a_Unif, double b, double r)
        {
            return Math.Round(r * (b - a_Unif) + a_Unif, 4);
        }


        /// </summary>
        /// <param name="lambda">Es el valor que ingresa el usuario. Debe ser mayor a cero</param>
        /// <param name="r">Es el número aleatorio</param>
        /// <returns></returns>
        public double generarExponencial(double media, double r)
        {
            return Math.Round((- media) * Math.Log(1 - r), 4);

        }
    }
}
