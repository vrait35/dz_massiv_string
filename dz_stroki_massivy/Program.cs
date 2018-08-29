using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_stroki_massivy
{
    class Program
    {
        /*
         1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.
2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
		3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.

             */
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
        }
        static private void FirstTask()
        {
            Console.WriteLine("1.Написать программу, которая считывает символы с клавиатуры," +
                "\nпока не будет введена точка. " +
                "\nПрограмма должна сосчитать количество введенных пользователем пробелов.");
            char c = '1';
            int count = 0;
            while (c!='.')
            {
                c = (char)Console.Read();
                if (c == ' ') count++;                
            }
            Console.Write("количество пробелов: "+count);
        }
        static private void SecondTask()
        {
            Console.WriteLine("2.Ввести с клавиатуры номер трамвайного билета (6-значное число) и " +
                "\nпро-верить является ли данный билет счастливым " +
                "\n(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна " +
                "\nсумме последних трёх, то этот билет считается счастливым).");
            Console.Write("введите номер трамвая: ");
            Console.ReadLine();
            string number = "";
            while (number.Length!=6)
            {
                number = Console.ReadLine();
            }
            int size = 6;
            char[] mas = new char[size];
            for(int i = 0; i < size; i++)
            {
                mas[i] = number[i];               
            }
            int sum1 = 0, sum2 = 0 ;
            for (int i1 = 0, i2 = 3; i2 < size; i1++, i2++)
            {
                sum1 += mas[i1];
                sum2 += mas[i2];
            }
            Console.WriteLine("sum1="+sum1+" sum2="+sum2);
            if (sum1 == sum2) Console.WriteLine("У трамвая счастливый номер");
            else Console.WriteLine("у трамвая несчастливый номер");
        }
        static private void FourthTask()
        {
            Console.WriteLine("Даны целые положительные числа A и B (A < B). " +
                "\nВывести все целые числа от A до B включительно; каждое число должно " +
                "\nвыводиться на новой строке; при этом каждое число должно выводиться количество раз," +
                "\n равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать" +
                "\n в консоли как показано в домашнем задании  вывод:");
            Console.WriteLine("для страховки нажмите чтонибудь, или не нажмайте...");
            Console.ReadLine();
            Console.WriteLine("введите А: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("введите В: ");
            int B = int.Parse(Console.ReadLine());
            for(int i = A; i <= B; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
        static private void ThirdTask()
        {
            Console.WriteLine("для страховки нажмите чтонибудь, или не нажмайте...");
            Console.ReadLine();
            Console.WriteLine("Числовые значения символов нижнего регистра в коде ASCII " +
                "\nотличаются от значений символов верхнего регистра на величину 32. " +
                "\nИспользуя эту информацию, написать программу, которая считывает с " +
                "\nклавиатуры и конвертирует все символы нижнего регистра в символы " +
                "\nверхнего регистра и наоборот.");
            Console.Write("введите текст(на ангилийском): ");
            string text = Console.ReadLine();
            char[] buffUp = text.ToCharArray();
            char[] buffDown = text.ToCharArray();
            for (int i = 0; i < buffUp.Length; i++)
            {
                if (buffUp[i] >= 97 && buffUp[i] <= 122) buffUp[i] -= ' ';
                if (buffDown[i] >= 65 && buffDown[i] <= 90) buffDown[i] += ' ';
            }
            text = new string(buffUp);
            Console.WriteLine("в верхнем регистре:"+text);
            text = new string(buffDown);
            Console.WriteLine("в нижнем регистре: "+text);
        }
        static private void FifthTask()
        {
            Console.WriteLine("для страховки нажмите чтонибудь, или не нажмайте...");
            Console.ReadLine();
            Console.WriteLine("5.Дано целое число N (> 0), найти число, " +
                "\nполученное при прочтении числа N справа налево. Например," +
                "\n если было введено число 345, то программа должна вывести " +
                "\nчисло 543.");
            Console.WriteLine("введите число");
            string numbers = "-1";

            while (numbers[0] == '-')
            {
                numbers = Console.ReadLine();
            }
            char[] buff = numbers.ToCharArray();
            Array.Reverse(buff);
            numbers = new string(buff);
            Console.WriteLine("перевернутая строка: "+numbers);
        }
    }
}
