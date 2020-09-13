using System;

namespace OOP__lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();

        }

        static void ex1()
        {
            // Задание №1a
            Console.WriteLine("\t\tЗадание №1a");


            Console.Write("bool = ");
            bool boolVar = Convert.ToBoolean(Console.ReadLine());
            Console.Write("byte = ");
            byte byteVar = Convert.ToByte(Console.ReadLine());
            Console.Write("sbyte = ");
            sbyte sbyteVar = Convert.ToSByte(Console.ReadLine());
            Console.Write("char = ");
            char charVar = Convert.ToChar(Console.ReadLine());
            Console.Write("decimal = ");
            decimal decimalVar = Convert.ToDecimal(Console.ReadLine());
            Console.Write("double = ");
            double doubleVar = Convert.ToDouble(Console.ReadLine());
            Console.Write("float = ");
            float floatVar = Convert.ToSingle(Console.ReadLine());
            Console.Write("int = ");
            int intVar = Convert.ToInt32(Console.ReadLine());
            Console.Write("uint = ");
            uint uintVar = Convert.ToUInt32(Console.ReadLine());
            Console.Write("long = ");
            long longVar = Convert.ToInt64(Console.ReadLine());
            Console.Write("ulong = ");
            ulong ulongVar = Convert.ToUInt64(Console.ReadLine());
            Console.Write("short = ");
            short shortVar = Convert.ToInt16(Console.ReadLine());
            Console.Write("ushort = ");
            ushort ushortVar = Convert.ToUInt16(Console.ReadLine());
            Console.Write("string = ");
            string stringVar = Console.ReadLine();
            Console.Write("dynamic = ");
            dynamic dynamicVar = Console.ReadLine();


            Console.WriteLine($"\n\nbool = {boolVar} \nbyte = {byteVar} \nsbyte = {sbyteVar}  \ndecimal = {decimalVar}" +
                $"\ndouble = {doubleVar} \nfloat = {floatVar} \nint = {intVar} \nuint = {uintVar} \nlong = {longVar} " +
                $"\nulong = {ulongVar} \nshort = {shortVar} \nushort = {ushortVar} \nstring = {stringVar}" +
                $"\ndynamic = {dynamicVar}");



            // Задание №1b
            long explicitVar1 = (long)(intVar + shortVar);
            int explicitVar2 = (int)doubleVar;
            ushort explicitVar3 = (ushort)byteVar;
            double explicitVar4 = (double)floatVar;
            uint explicitVar5 = (uint)ushortVar;

            double implicitVar1 = floatVar;
            int implicitVar2 = ushortVar;
            long implicitVar3 = intVar;
            short implicitVar4 = byteVar;
            ulong implicitVar5 = ushortVar;



            // Задание №1с
            int i1 = 150;
            object o1 = i1;   // упаковка
            int i2 = (int)o1; // распаковка

            double f1 = 1.123;
            object o2 = f1;
            double f2 = (double)o2;



            // Задание №1d
            Console.WriteLine("\n\n\t\tЗадание №1d");

            var var1 = 150.99;
            Console.WriteLine($"\nпеременная var = {var1}");



            // Задание №1e
            Console.WriteLine("\n\n\t\tЗадание №1e");

            System.Nullable<int> nullVar1 = null;
            int? nullVar2 = null;

            Console.WriteLine($"\nпеременная nullable = {nullVar1}");
            Console.WriteLine($"переменная nullable = {nullVar2}");
        }

        static void ex2()
        {
            // Задание №1a

        }
    }
}
