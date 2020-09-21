using System;
using System.Text;
using System.Collections.Generic;

namespace OOP__lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();

            // Задание №5
            Console.WriteLine("\n\n\t\tЗадание №5\n");

            Tuple<int, int, int, char> tupleEx5 = Ex5(new int[] { 4, -3, 10, -18, 22 }, "строка-путешественник");
            Console.WriteLine("Минимальный элемент: " + tupleEx5.Item1);
            Console.WriteLine("Максимальный элемент: " + tupleEx5.Item2);
            Console.WriteLine("Сумма всех элементов: " + tupleEx5.Item3);
            Console.WriteLine("Первый элемент в строке: " + tupleEx5.Item4);

            // Задание №6
            Console.WriteLine("\n\n\t\tЗадание №6\n");

            //Console.WriteLine(Ex6_1());
            Console.WriteLine(Ex6_2());
        }

        static void Ex1()
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

        static void Ex2()
        {
            // Задание №1a
            Console.WriteLine("\n\n\t\tЗадание №2a\n");

            string str1 = "Привет";
            string str2 = "мир!";

            int result = String.Compare(str1, str2);
            if(result < 0)
            {
                Console.WriteLine("Строка str1 стоит перед str2");
            }
            else if(result > 0)
            {
                Console.WriteLine("Строка str1 стоит после str2");
            }
            else if(result == 0)
            {
                Console.WriteLine("Строки равны");
            }



            // Задание №2b
            Console.WriteLine("\n\n\t\tЗадание №2b\n");

            int s0 = 10;
            string s1 = "строка 1 ";
            string s2 = "строка 2 ";
            string s3 = "строка 3 ";
            string s4 = "Вот такие вот дела";
            

            Console.WriteLine(String.Concat(s1, s2) + "\n");

            Console.WriteLine(s2.Insert(7, s3) + "\n");

            string[] wordsS4 = s4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in wordsS4)
            {
                Console.Write($"{ s }, ");
            }

            Console.WriteLine("\n\n" + s4.Substring(4, 9) + "\n");

            Console.WriteLine(s4.Remove(0, 4) + "\n");


            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y' };
            Console.WriteLine(destination);

            strSource.CopyTo(0, destination, 4, strSource.Length);
            Console.WriteLine(destination);


            Console.WriteLine($"\n{ s0 } и { s1 }");



            // Задание №2c
            Console.WriteLine("\n\n\t\tЗадание №2c\n");

            string freeStr = "";
            string nullStr = null;
            string dopStr = "qwer";

            Console.Write(String.IsNullOrEmpty(freeStr) + "\n");
            Console.Write(String.IsNullOrEmpty(nullStr) + "\n");

            dopStr = dopStr.Remove(0, dopStr.Length);
            Console.Write(String.IsNullOrEmpty(dopStr) + "\n");



            // Задание №2d
            Console.WriteLine("\n\n\t\tЗадание №2d\n");

            StringBuilder strBuild = new StringBuilder("Привет мир");
            strBuild.Append("!!");
            strBuild.Insert(7, "компьютерный ");
            strBuild.Remove(0, 7);
            Console.WriteLine(strBuild);
        }

        static void Ex3()
        {
            // Задание №3a
            Console.WriteLine("\n\n\t\tЗадание №3a\n");

            int[,] array1 = new int[4, 4];

            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    array1[i, j] = rnd.Next(0, 10);
                    Console.Write($"  { array1[i, j] }  ");
                }
                Console.WriteLine();
            }



            // Задание №3b
            Console.WriteLine("\n\n\t\tЗадание №3b\n");

            string[] strArray = new string[] { "First", "Second", "Third" };

            Console.WriteLine($"Длина массива: { strArray.Length }");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }


            Console.Write("\nКакой элемент заменить: ");
            int elemChange = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nНа что заменить ? ");
            string strChange = Console.ReadLine();

            strArray[elemChange - 1] = strChange;

            Console.WriteLine("Массив после изменения:\n");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }



            // Задание №3с
            Console.WriteLine("\n\n\t\tЗадание №3с\n");

            int[][] steppedArray = new int[3][];

            steppedArray[0] = new int[2];
            steppedArray[1] = new int[3];
            steppedArray[2] = new int[4];

            Console.WriteLine("Введите первую строку:");
            for (int i = 0; i < 2; i++)
            {
                steppedArray[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите вторую строку:");
            for (int i = 0; i < 3; i++)
            {
                steppedArray[1][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите третью строку:");
            for (int i = 0; i < 4; i++)
            {
                steppedArray[2][i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 2; i++)
            {
                Console.Write($"  { steppedArray[0][i] }  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"  { steppedArray[1][i] }  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"  { steppedArray[2][i] }  ");
            }



            // Задание №3d
            Console.WriteLine("\n\n\t\tЗадание №3d\n");

            string[] array2 = new string[] { "строка 1", "строка 2", "string 3" };

            var array2Var = array2;

            for(int i = 0; i < array2Var.Length; i++)
            {
                Console.WriteLine(array2Var[i]);
            }
        }

        static void Ex4()
        {
            // Задание №4a, b, c
            Console.WriteLine("\n\n\t\tЗадание №4a\n");

            (int a, string b, char c, string d, ulong e) = (18, "металл", '#', "лоджия", 19999);
            var tuple1 = (19, true, "дом");

            Console.WriteLine(tuple1.ToString());

            Console.WriteLine($"\n{ a }");
            Console.WriteLine(c);
            Console.WriteLine(d);



            // Задание №4d
            Console.WriteLine("\n\n\t\tЗадание №4d\n");
            var firstTuple = Tuple.Create(9, 3);
            var secondTuple = Tuple.Create(9, 3);
            var check = EqualityComparer<Tuple<int, int>>.Default;

            if (check.Equals(firstTuple, secondTuple))
            {
                Console.WriteLine("Первый кортеж равен второму");
            }
            else
            {
                Console.WriteLine("Первый кортеж не равен второму");
            }
        }

        static Tuple<int, int, int, char> Ex5(int[] numbers, string str)
        {
            int minNum = 1000, maxNum = -1000, sumNum = 0;
            
            for(int i = 0; i < numbers.Length; i++)
            {
                sumNum = sumNum + numbers[i];

                if(numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
                if(numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }
            char firstLetter = str[0];
            
            return new Tuple<int, int, int, char>(minNum, maxNum, sumNum, firstLetter);
        }

        static int Ex6_1()
        {
            int ten = 10;
            checked
            {
                int intVar = 2147483647 + ten;
                return intVar + ten;
            }
        }
        static int Ex6_2()
        {
            int ten = 10;
            unchecked
            {
                int intVar = 2147483647 + ten;
                return intVar + ten;
            }
        }
    }
}
