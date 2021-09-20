using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExamQ1
{
    class WeeklyExamQ1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Random rnd = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 3);
            }

            Array.Sort(arr);

            Console.WriteLine();
            foreach(int x in arr)
            {
                Console.Write(x + "");
            }
            
            Console.ReadLine();
        }
    }
}
