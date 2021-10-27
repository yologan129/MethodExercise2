using System;

namespace MethodsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                //Name: Michael
                // Favorite Color: Blue
                //Favorite Animal: Walrus
                //Favorite Band: The Beatles
                Console.WriteLine("Hello - What is your first name?");
                var userName = Console.ReadLine();

                Console.WriteLine($"Hello, {userName}. What is your favorite color.");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
                var animal = Console.ReadLine();

                Console.WriteLine("Great now what is your favorite{band}.");
                var band = Console.ReadLine();

                Console.WriteLine("Thanks, {userName}! here is your profile.");

                Console.WriteLine($"Name {userName}");
                Console.WriteLine($"Favorite color {color}");
                Console.WriteLine($"Favorite Animal {animal}");
                Console.WriteLine($"Favorite Band {band}");


                Subtract(1, 2);
                Sum(2, 2);
                Multiply(5, 5, 5);
                Divide(3, 3);
                Modulus(3, 5);
                Add(7, 8);

            }

            static int Sum(int num1, int num2)
            {
                var answer = num1 + num2;
                return answer;
            }

            static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Multiply(int num1, int num2, int num3)
            {
                return num1 * num2 * num3;
            }

            static double Divide(int num1, int num2)
            {
                return num1 / num2;
            }

            static int Modulus(int num1, int num2)
            {
                return num1 % num2;
            }




            static int Add(params int[] nums)
            {
                var sum = 0;
                foreach (var num in nums)
                {
                    sum += num;
                }
                return sum;
            }
        }
    }
}

