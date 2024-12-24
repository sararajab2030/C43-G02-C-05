using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass5
{
    internal class Program
    {

        #region Q1
        //public static void swapByValue(int x, int y)    // passing by value
        //{


        //    int temp = x;
        //    x=y;
        //    y = temp;

        //    Console.WriteLine($"x= {x},y= {y}");
        //}

        //public static void swap(ref int x, ref int y)   // passing by reference
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x= {x},y= {y}");
        //}
        #endregion

        #region Q2
        //public static int sumArray(int[] arr)   //passing by value
        //{
        //    int sum = 0;
        //    if (arr != null)

        //    {
        //        arr[0] = 100;    
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }
        //    return sum;
        //}

        //public static int sumarray(ref int[] arr)   //passing by reference
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        arr = [100, 200, 300, 400, 500];  //new array

        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];

        //    }
        //    return sum;
        //}
        #endregion

        #region Q3
        //public static void sumsub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}
        #endregion

        #region Q4
        //public static int SumDigits(int number)
        //{
        //    int sum = 0;

        //    while (number != 0)
        //    {
        //        sum += number % 10; 
        //        number /= 10;        
        //    }

        //    return sum;
        //}
        #endregion

        #region Q5
        //public static bool IsPrime(int number)
        //{
        //    if (number < 1)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        for (int i = 2; i <= Math.Sqrt(number); i++)
        //        {
        //            if (number % i == 0)
        //            {
        //                return false;
        //            }
        //        }

        //        return true;
        //    }
        //}
        #endregion

        #region Q6
        //public static void MinMaxArray(int[] arr)
        //{
        //    arr = new int[] { 1, 2, 3, 4, 5, 6 };
        //    int min = arr[0];
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        else if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }

        //}
        #endregion

        #region Q7
        //public static long Factorial(int number)
        //{
        //    if (number == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return number * Factorial(number - 1);
        //    }  
        //}
        #endregion

        #region Q8
        //public static string ModifyLetterAtPosition(string letter, int arr, char newLetter)
        //{
          

        //    char[] charArray = letter.ToCharArray();

        //    charArray[arr] = newLetter;

        //    return new string(charArray);
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Q1
            /* value types parameters passing by value VS passing by reference
             passing by value : the value of the variable is copied to the parameter
             passing by reference : the address of the variable is copied to the parameter
             so if the value of the variable is changed in the method, it will be changed in the main method if it's passed by reference
             but if it's passed by value, the value of the variable in the main method will not be changed
            */
            // example
            // passing by value

            //int b = 6;
            //int c = 7;
            //swapByValue(b, c);
            //Console.WriteLine($"b= {b},c= {c}");

            // passing by reference
            //swap(ref b, ref c);
            //Console.WriteLine($"b= {b},c= {c}");
            #endregion

            #region Q2
            /*reference types parameters passing by value VS passing by reference
             passing by value :1- Passes a copy of the  reference to the array.
                               2-Modifying elements will affect the original array.

             passing by reference : 1-Passes the original reference of array
                                    2-Modifying elements will affect the original array.
            */
            // example
            // passing by value
            //int[] number = [10, 20, 30, 40, 50]; 
            //Console.WriteLine(number);
            //int result = sumArray(number);
            //Console.WriteLine(result);

            //passing by reference
            //int[] number = [10, 20, 30, 40, 50];
            //Console.WriteLine(number);
            //int result = sumarray(ref number);
            //Console.WriteLine(result);
            //Console.WriteLine(number[0]);

            #endregion

            #region Q3
            // int a=int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //sumsub(a, b, out int sum, out int sub);
            //Console.WriteLine($"sum= {sum},sub= {sub}");

            #endregion

            #region Q4
            //int number = int.Parse(Console.ReadLine());
            //int result = SumDigits(number);
            //Console.WriteLine($"sum of the individual digits= {result}");
            #endregion

            #region Q5
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}

            #endregion

            #region Q6
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            //MinMaxArray(arr);
            //Console.WriteLine($"Min: {arr[0]}");
            //Console.WriteLine($"Max: {arr[arr.Length - 1]}");
            #endregion

            #region Q7

            //int number=int.Parse(Console.ReadLine());
            //   long result = Factorial(number);
            //   Console.WriteLine($"Factorial of {number} = {result}");

            #endregion

            #region Q8
            //Console.WriteLine("Enter a string: ");
            //string original = Console.ReadLine();
            //Console.WriteLine("Enter the position of the letter you want to modify: ");
            //int position = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the new letter: ");
            //char newLetter =char.Parse( Console.ReadLine());

            //string modifyString = ModifyLetterAtPosition(original, position, newLetter);

            //Console.WriteLine($"Original letter:{original}");
            //Console.WriteLine($"Modified letter: {modifyString}");


            #endregion

        }
        }
}
