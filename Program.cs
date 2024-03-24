using System;

class Program
{
    static void Main()
    {
        string[] students = { "John", "Jane", "Alice", "Bob", "David" };

        Console.WriteLine("Nhập tên sinh viên cần tìm:");
        string name = Console.ReadLine();

        int position = Array.IndexOf(students, name);

        if (position != -1)
        {
            Console.WriteLine("Vị trí của sinh viên " + name + " trong danh sách là " + (position + 1));
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên " + name + " trong danh sách");
        }
    }
}