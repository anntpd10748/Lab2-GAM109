// See https://aka.ms/new-console-template for more information
using System;

public class userData
{
    public int? id;
    public string? username;
    public List<double> Scores;
    public userData()
    {
        id = null;
        username = null;
        Scores = new List<double>();
    }  
}
public class Program
{
     static void Main(string[] args)
    {
        userData data = new userData();

        Console.Write("nhap ten: ");
        data.username = Console.ReadLine();
        Console.WriteLine("userdata name: " + data.username);

        Console.Write("nhap id: ");
        string id = Console.ReadLine();
        data.id = Convert.ToInt32(id);
        Console.WriteLine("userdata id: " + data.id);

        Console.Write("nhap danh sach diem, so luong diem can nhap: ");
        int soluongdiem = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soluongdiem; i++)
        {
            Console.Write("nhap diem: ");
            data.Scores.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Danh sach vua nhap la: ");
        foreach(var i in data.Scores)
        {
            Console.Write(" " + i);
        }
        Console.ReadLine();
    }
}
