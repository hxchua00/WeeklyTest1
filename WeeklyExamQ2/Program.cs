using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExamQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "I love programming very much";

            char[] arr = new char[message.Length];

            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = message[message.Length - 1];
            }

        }
    }
}
