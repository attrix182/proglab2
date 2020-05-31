using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public bool Agregar(T a)
        {
            return (this + a);
        }

        public bool Remover(T a)
        {
            return (this - a);
        }

        private int GetIndice(T a)
        {
            int index = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (object.Equals(this._lista[i], a))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;

            int i = d.GetIndice(a);

            if (i != -1)
            {
                d._lista.RemoveAt(i);
            }

            return retorno;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }


        public override string ToString()
        {
            Console.WriteLine("");

            string cadena = "";
            cadena = "Capacidad maxima: " + this._capacidadMaxima.ToString();
            foreach (T a in this._lista)
            {
                cadena += "\n" + a.ToString();
            }

            return cadena;
        }

    }
}
