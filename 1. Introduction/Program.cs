using System.ComponentModel.Design;

namespace _1._Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //            İstifadəçi klaviaturadan 1 ilə 100 arasında bir ədəd daxil edir.
            //Əgər ədəd 3 - ə bölünürsə, ekrana Fizz sözü çıxarılmalıdır. Əgər
            //ədəd 5 - ə bölünürsə , ekrana Buzz sözü çıxarılmalıdır. Əgər ədəd
            //həm 3 - ə bölünürsə, həm də 5 - ə bölünürsə, ekrana Fizz və Buzz
            //çıxarılmalıdır.Əgər ədəd nə 3 - ə, nə də 5 - ə bölünürsə, ədədin özü
            //çıxarılmalıdır.

            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number<1 || number > 100)
            //{
            //    Console.WriteLine("Number doesn't meet the conditions");
            //}
            //if (number % 3 == 0 && number %5 ==0)
            //{
            //        Console.WriteLine("Fizz and Buzz");
            //}
            //else if (number % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if (number % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}
            Console.WriteLine();
            //Task 2
            //            İstifadəçi klaviaturadan iki ədəd daxil edir. Birinci ədəd dəyər,
            //ikinci ədəd isə
            //hesablanması tələb olunan faizdir.Məsələn, klaviaturadan 90 və 10
            //daxil edilib. 90 - ın 10 faizini göstərmək lazımdır.Nəticə 9 - dur.
            //Console.Write("Enter a number: ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a percentage: ");
            //int percentage = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{percentage} percentage of {number2} is: {number2*percentage/100}");

            Console.WriteLine();
            //Task 3
            //            İstifadəçi klaviaturadan temperatur göstəricilərini daxil edir.
            //İstifadəçinin seçiminə əsasən proqram temperaturu Fahrenheit-dən
            //Celsius - a və ya əksinə çevirməlidir.
            Console.WriteLine("1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Degree: ");
            double degree = double.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"{degree}C is {1.8 * degree + 32}F");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"{degree}F is {(degree - 32)/1.8}C");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
