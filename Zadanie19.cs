using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;



namespace ConsoleApp29
{
    class Zadanie19
    {
        static void Main(string[] args)
        {
        List<Computer> listOfComputers = new List<Computer>();

        // Создать список, содержащий 6-10 записей с различным набором значений характеристик.
        new Computer() { processorName = "A0001", OZU = 256, price = 112, quantity=15};
        new Computer() { processorName = "A0002", OZU = 512, price = 122, quantity = 19 };
        new Computer() { processorName = "A0005", OZU = 128, price = 160, quantity = 104 };
        new Computer() { processorName = "A0009", OZU = 512, price = 305, quantity = 1 };
        new Computer() { processorName = "B0015", OZU = 1024, price = 755, quantity = 31 };
        new Computer() { processorName = "B0022", OZU = 512, price = 941, quantity = 29 };

        //Определить все компьютеры с указанным процессором.Название процессора запросить у пользователя.
        Console.WriteLine("Введите наименование искомого процессора");
        string processorfind = Convert.ToString((Console.ReadLine()));
        foreach (Computer element in listOfComputers)
            {
                if (element.processorName == processorfind)
                {
                    Console.WriteLine("Искомый процессор найден в компьютере №:{0}",element);
                }
            }

        // Определить все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя
        Console.WriteLine("Введите наименование искомой минимальной ОЗУ");
        int ozufind = Convert.ToInt32(Console.ReadLine());
        foreach (Computer element in listOfComputers)
            {
                if (element.OZU >= ozufind)
                {
                    Console.WriteLine("Искомая ОЗУ найден в компьютере №:{0}", element);
                }
            }


        // вывести весь список, отсортированный по увеличению стоимости;
        Console.WriteLine("Список, отсортированный по увеличению стоимости");
        var newList1 = Convert.ToString(listOfComputers.OrderByDescending(Computer => Computer.price));
        foreach (int Computer in newList1)
        { Console.WriteLine(Computer); }


        //вывести весь список, сгруппированный по типу процессора;
        Console.WriteLine("Список, сгруппированный по типу процессора");
        var newList2 = listOfComputers.GroupBy(Computer => Computer.processorName);
        foreach (int Computer in newList1)
            { Console.WriteLine(Computer); }

        //найти самый дорогой и самый бюджетный компьютер;
        var newList3 = listOfComputers.Max(Computer => Computer.price);
        Console.WriteLine("Самый дорогой компьютер:{0}",newList3);
        var newList4 = listOfComputers.Min(Computer => Computer.price);
        Console.WriteLine("Самый бюджетный компьютер:{0}", newList4);

        //есть ли хотя бы один компьютер в количестве не менее 30 штук
        Computer found = listOfComputers.Find(Computer => Computer.quantity >=30);
        Console.WriteLine("Кол-во компьютеров в количестве не менее 30 штук:{0}", found.quantity);

            Console.ReadKey();


        }
    }
    public class Computer
    {
        public string processorName { get; set; }
        public int OZU { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

    }
    
}
