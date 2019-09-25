using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
       
    class Principal
    {
        Valores V = new Valores();
        

        public void PedirValor()
        {
           
            Console.WriteLine("Dame valor A");
            V.VALORa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame valor B");
            V.VALORb = Convert.ToDouble(Console.ReadLine());

            Menu();
            
        }


        Operacion rt = new Operacion();

        public void Menu()
        {
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Salir");
            double Res;

            Console.WriteLine("Dame opcion: ");
            Operacion OP2 = new Operacion();
            int Op = Convert.ToInt32(Console.ReadLine());

            switch (Op)
            {
                case 1:
                    Res = OP2.suma(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Res = OP2.restar(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Res = OP2.multiplicar(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    Res = OP2.dividir(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

            }
        }



    }
}
