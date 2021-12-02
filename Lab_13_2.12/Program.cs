using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_2._12
{
    using static System.Console;
    public class Building
    {
        protected string address;
        protected int lenght;
        protected int widht;
        protected int height;
        // 2. Конструктор класса с 4 параметрами

        public Building(string address, int lenght, int widht, int height)
        {
            this.address = address;
            this.lenght = lenght;
            this.widht = widht;
            this.height = height;
        }

        // 3. Свойства доступа к полям класса
        public string Address
        {
            get { return address; }
            set { address = value; }

        }

        public int lehght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int Wight
        {
            get { return widht; }
            set { widht = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        // 4. Метод Print() - вывести значения полей на экран
        public void Print()
        {
            WriteLine($"{address}");
            Console.WriteLine($"{lenght}");
            Console.WriteLine($"{widht}");
            Console.WriteLine($"{height}");

        }
    }
    // Класс MultiBuilding - наследует возможности класса Building
    sealed class MultiBuilding : Building
    {
        // 1. Внутреннее поле класса
        protected int floors;


        public MultiBuilding(string address, int lenght, int widht, int height, int floors) :
            base(address, lenght, widht, height)
        {
            // Можно изменять protected-члены базового класса
            base.address = address;
            this.lenght = lenght;
            this.widht = widht;
            this.height = height;
            this.floors = floors;
        }

        // 3. Свойство для доступа к полю floors
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public new void Print() // new - переопределение метода базового класса
        {
            base.Print(); // вызвать метод Print() базового класса
            WriteLine($"{floors}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация работы с классами Building и MultiBuilding

            // 1. Объявить экземпляр класса Building
            Building st1 = new Building("sovetskaya 5", 10, 20, 30);

            // 2. Вывести поля класса Building
            WriteLine("Вывести поля класса Building");
            st1.Print();

            // 3. Объявить экземпляр класса MultiBuilding
            // При объявлении используется свойство get экземпляра st1
            MultiBuilding asp1 = new MultiBuilding(st1.Address, st1.lehght, st1.Wight, st1.Height, 12);

            // 4. Вызвать метод Print() экземпляра asp1
            WriteLine("Вывести поля класса MultiBuilding");
            WriteLine();

            asp1.Print();
            _ = Console.ReadKey();

        }

    }
}