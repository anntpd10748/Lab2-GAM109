// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> numberList = new List<int>();

        numberList.Add(13);
        numberList.Add(7);
        numberList.Add(39);
        numberList.Add(4);
        numberList.Add(2);
        numberList.Add(6);


        Console.Write("danh sach cac so nguyen la: ");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.Write(" " + numberList[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        int tong = 0;
        for (int i = 0; i < numberList.Count; i++)
        {
            tong += numberList[i];
        }
        Console.WriteLine("tong cac so nguyen la: " + tong);

        Console.WriteLine();
        int tongnt = 0;
        for (int i = 0; i < numberList.Count; i++)
        {
            if (songuyento(numberList[i]))
                tongnt += numberList[i];
        }
        Console.WriteLine("tong cac so nuyen to la: " + tongnt);

        Console.WriteLine();
        int tongchan = 0;
        for (int i = 0; i < numberList.Count; i += 2)
        {
            if (numberList[i] % 2 == 0)
            {
                tongchan += numberList[i];
            }
        }
        Console.WriteLine("tong cac so chan o vi tri le la: " + tongchan);

        Console.ReadLine();
    }
    public static Boolean songuyento(int n)
    {
        bool check = true;
        if (n == 2) return true;
        for (int i = 2; i < n; i++)
            if (n % i == 0) check = false;
        if (check) return true;
        else return false;
    }
}

