using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Conto
    {
        public decimal Saldo { get; private set; }  // implicit defined property

        //private decimal _saldo;  // viene implicitamente inizializzata al valore di default
        //public decimal Saldo    // proprietà - property
        //{
        //    get
        //    {
        //        return _saldo;
        //    }
        //    private set
        //    {
        //        _saldo = value; // value identifica il valore da assegnare alla proprietà
        //    }
        //}

        // di norma si ricorre a una proprietà di sola lettura
        //public decimal GetSaldo()
        //{
        //    return _saldo;
        //}

        public void Versa(decimal importo)
        {
            Saldo += importo;
        }

        public void Preleva(decimal importo)
        {
            Saldo -= importo;
        }
    }
}
