using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;


        public int Codigo { get { return this._codigo; } }

        public bool EsIndustrial { get { return this._esIndustrial; } }

        public double Precio { get { return this._precio; } }



        public Cocina(int codigo, double precio,bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Cocina)
            {
                if ((Cocina)obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return (a.Codigo == b.Codigo);

        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo.ToString() + " - Precio: " + this._precio + " - Es industrial? " + this._esIndustrial.ToString();
        }



    }
}
