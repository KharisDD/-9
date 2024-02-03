using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    public class PokemonArray
    {
        static Random rnd = new Random();
        public static int countArr;

        Pokemon[] arr;

        // Длина массива
        public int Length
        {
            get => arr.Length;
        }
        // Конструктор без параметра
        public PokemonArray()
        {
            int sup = rnd.Next(1, 10);
            arr = new Pokemon[sup];
            for (int i = 0; i < sup; i++)
            {
                arr[i] = new Pokemon(rnd.Next(17, 414), rnd.Next(32, 396), rnd.Next(1, 496));
            }
            countArr++;
        }
        // Конструктор с параметром
        public PokemonArray(int length, int question)
        {
            arr = new Pokemon[length];
            switch (question)
            {
                case 1:
                    for (int i = 0; i < length; i++)
                    {
                        arr[i] = new Pokemon(rnd.Next(17, 414), rnd.Next(32, 396), rnd.Next(1, 496));
                    }
                    countArr++;
                    break;
                case 2:
                    
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine("Введите атк, деф и стамину");
                        arr[i] = new Pokemon(Program.Input(Console.ReadLine()), Program.Input(Console.ReadLine()), Program.Input(Console.ReadLine()));
                    }
                    countArr++;
                    break;
                default:
                    Console.WriteLine("Incorrect number input");
                    break;
            }
        }
        // Глубокое копирование
        public PokemonArray(PokemonArray other)
        {
            arr = new Pokemon[other.Length];
            for (int i = 0;i < other.Length; i++)
            {
                arr[i] = new Pokemon(other[i]);
            }
            countArr++;
        }
        // Вывод коллекции
        public static void ArrShow(PokemonArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i+1} Покемон: Атк - {arr[i].Attack} Деф - {arr[i].Defense} Стамина - {arr[i].Stamina}");
            }
            Console.WriteLine();
        }
        // Индексация
        public Pokemon this[int index]
        {
            get 
            { 
                if (index >=0 && index < arr.Length)
                    return arr[index];
                throw new IndexOutOfRangeException();
            }
            set 
            { 
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else Console.WriteLine("Выход за границу массива");
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PokemonArray))
            {
                return false;
            }
            PokemonArray p = obj as PokemonArray;
            bool isTrue = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(p[i])) isTrue = true;
                else
                {
                    isTrue = false;
                    break;
                }
            }
            return isTrue;
        }
    }
}