using System;
using System.Collections.Generic;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap kich thuoc mang:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int i;
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
            for (i = 0; i <= n-1; i++)
            {
                for(int j = i+1;j< n;j++)
                    if(a[i]<a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
            }
            Console.Write("Mang da duoc sap xep:{1}", a[i]);
            Console.ReadKey();
        }
    }
}
