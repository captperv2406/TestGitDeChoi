using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[14];
            Random rand = new Random();
            bool[] check = new bool[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(14) + 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
