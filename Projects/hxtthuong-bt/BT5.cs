using System;
using System.Collections.Generic;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap kich thuoc mang:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int i;
            int max = a[0];
            int ViTriMax = 0;
            for (i = 0; i < n; i++)
            {
                Console.Write(" Nhap phan tu thu {0}:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" Mang a vua nhap la ");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i]);
            }
            for (i = 0; i <= n; i++)
                if (max > a[i])
                {
                    max = a[i];
                    ViTriMax = i;
                }
            Console.Write("Vi tri so nho nhat cua mang la: {1}", ViTriMax);
            Console.ReadKey();
        }
    }
}
