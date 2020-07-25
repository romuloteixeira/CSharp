using System;

namespace Essentials1
{
    public static class StructVsClass
    {
        public static void Run()
        {
            var teste1 = new TesteStruct(1, 2);
            var teste12 = teste1;
            teste12.Valor1 = 12;
            teste12.Valor2 = 22;

            Console.WriteLine(teste1.ToString());
            Console.WriteLine(teste12.ToString());


            var class1 = new TesteClass(1, 2);
            var class12 = class1;
            class12.Valor1 = 12;
            class12.Valor2 = 22;

            Console.WriteLine(class1.ToString());
            Console.WriteLine(class12.ToString());
            //Console.ReadLine();
        }
    }

    struct TesteStruct
    {
        //public int Valor1 = 0;
        public int Valor1;
        public int Valor2;

        //public TesteStruct()
        //{

        //}

        //public TesteStruct(int valor1)
        //{
        //    Valor1 = valor1;
        //}

        public TesteStruct(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public override string ToString() => $"TesteStruct - Valor1: {Valor1}, Valor2: {Valor2}";
    }

    class TesteClass
    {
        public int Valor1;
        public int Valor2;

        public TesteClass()
        {

        }

        public TesteClass(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public override string ToString() => $"TesteClass - Valor1: {Valor1}, Valor2: {Valor2}";
    }
}
