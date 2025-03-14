using System;
using System.Transactions;

namespace StatisticLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            try{
                // code that may rise an error or exception
                Console.WriteLine("Enter a number 1: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second number: ");
                double number2 = double.Parse(Console.ReadLine());

                if(number2 == 0){
                    throw new DivideByZeroException("You can not divide by 0!");
                }

                if(number1 < 5)
                {
                    throw new ArgumentOutOfRangeException("The number 1 must be greater than 5");
                }
                double solution = number1 / number2;

                Console.WriteLine($"The solution of {number1} / {number2} is {solution}");

            } catch(FormatException e)
            {
                // handle the error if it happens. Display a meesage
                Console.WriteLine($"Error: {e.Message}");
            } catch(DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            } catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally{
                Console.WriteLine("This code always run");
            }
            
            Console.WriteLine("Program finished!");
        
            Console.WriteLine("===== Debug ======");
            Console.WriteLine("Enter a number: ");

            int value = int.Parse(Console.ReadLine());

            // where are going to calculate the mean of number from 1 to value
            // if you introduce 5 -> the mean of 1, 2, 3, 4, 5

            int count = 0;
            int sum = 0;
            for(int i =1; i<= value; i++)
            {
                sum += i;
                count++;
            }

            Console.WriteLine($"The mean of first {value} numbers is: {sum} / {count} = {sum/count}");
        
        
        }
    }
}