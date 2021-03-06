﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1003_Relaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;

            //Operadores de relación
            Console.WriteLine("{0} == {1} es {2}", a, b, a==b);
            Console.WriteLine("{0} == {0} es {1}", a, a == a);

            Console.WriteLine("{0} != {1} es {2}", a, b, a != b);
            Console.WriteLine("{0} != {0} es {1}", a, a != a);

            Console.WriteLine("{0} < {1} es {2}", a, b, a < b);
            Console.WriteLine("{0} < {1} es {2}", c, a, c < a);

            Console.WriteLine("{0} > {1} es {2}", a, b, a > b);
            Console.WriteLine("{0} > {1} es {2}", d, b, d > b);

            Console.WriteLine("{0} is int es {1}",a, a is int);
            Console.WriteLine("{0} is string es {1}", a, a is string);


            //Operadores lógicos

            var booleano = true;
            Console.WriteLine("Operación negación: !{0} = {1}", booleano, !booleano);

            Console.WriteLine("Conjunción");
            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);

            Console.WriteLine();
            Console.WriteLine("Disyunción exclusiva");
            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^ {0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);

            Console.WriteLine();
            Console.WriteLine("Disyunción exclusiva");
            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("{0} | {1} = {2}", false, false, false | false);

            Console.Read();
        }
    }
}
