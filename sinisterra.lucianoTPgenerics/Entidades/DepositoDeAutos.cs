using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;


        public bool Agregar(Auto a)
        {

            return (this + a);
        }

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();

        }

        private int GetIndice(Auto a)
        {

            int index = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    index = i;
                    break;
                }

            }

            return index;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;

        }


        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int i = d.GetIndice(a);

            if (i != -1)
            {
                d._lista.RemoveAt(i);
            }

            return retorno;


        }


        public bool Remover(Auto a)
        {
            return (this - a);

        }

        public override string ToString()
        {
            string cadena = "";


            cadena = "Capacidad maxima: " + this._capacidadMaxima.ToString();

            Console.WriteLine("Listado de Autos: ");

            foreach (Auto a in this._lista)
            {
                cadena += "\n" + a.ToString();
            }

            return cadena;
        }

    }
}
