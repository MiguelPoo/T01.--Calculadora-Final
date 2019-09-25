using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    

    class Operacion
    {
        

        Valores V = new Valores();
        Double Res;

        public Double suma(Valores V)
        {

            Principal rt = new Principal();
            Res = (V.VALORa + V.VALORb);
            return Res;
           
        }

        public Double restar(Valores V)
        {
            Principal rt = new Principal();
            Res = (V.VALORa - V.VALORb);
            return Res;

        }

        public Double multiplicar(Valores V)
        {
            Principal rt = new Principal();
            Res = (V.VALORa * V.VALORb);
            return Res;

        }

        public Double dividir(Valores V)
        {
            Principal rt = new Principal();
            Res = (V.VALORa / V.VALORb);
            return Res;

        }
    }
}
