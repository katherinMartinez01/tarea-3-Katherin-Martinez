using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Entidades;

namespace Tarea_3.Negocio
{
    public class ClsNumero
    {
        public void ImprimirPares(Numero numero)
        {
            for (int i = numero.NumeroMinimo; i < numero.NumeroMaximo; i++)
            {
             if(i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }




















}
