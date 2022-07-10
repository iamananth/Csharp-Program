using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class ReadandSearch
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the no of elements :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Elements are: ");
            for(int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Enter the number you want to search :");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("Element is in the position " + (i+1));
                }
            }
        }
    }
}
