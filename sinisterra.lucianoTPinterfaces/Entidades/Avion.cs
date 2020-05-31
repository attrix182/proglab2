using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA  
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }


        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.33;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.27;
        }

    }
}