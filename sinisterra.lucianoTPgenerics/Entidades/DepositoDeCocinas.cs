using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        private int GetIndice(Cocina c)
        {
            int index = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == c)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            int i = d.GetIndice(c);
            if (i != -1)
            {
                d._lista.RemoveAt(i);
            }
            return retorno;
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }
        public bool Agregar(Cocina c)
        {
            return (this + c);
        }
        public bool Remover(Cocina a)
        {
            return (this - a);
        }
        public override string ToString()
        {
            Console.WriteLine("");
            string cadena = "";
            cadena = "Capacidad maxima: " + this._capacidadMaxima.ToString();
            Console.WriteLine("Listado de Cocinas: ");
            foreach (Cocina a in this._lista)
            {
                cadena += "\n" + a.ToString();
            }

            return cadena;
        }



    }
}
