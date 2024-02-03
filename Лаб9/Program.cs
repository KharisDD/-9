using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Лаб9
{
    internal class Program
    {
        public static int Input(string number)
        {
            bool resultIsCorrect = false; int result;
            do
            {
                resultIsCorrect = int.TryParse(number, out result);
                if (resultIsCorrect)
                {
                    if (result < 1)
                        resultIsCorrect = false;
                }
                if (!resultIsCorrect)
                {
                    Console.WriteLine("Некорректный ввод, введите натуральное число");
                    number = Console.ReadLine();
                }
            } while (!resultIsCorrect);
            return result;
        }

        public static int GiveModa(PokemonArray pokemon)
        {
            int[] supArr = new int[pokemon.Length];
            for (int i = 0; i < supArr.Length; i++)
            {
                supArr[i] = pokemon[i].Stamina;
            }
            
            int number = supArr[0], k1 = 0, k2 = 0;
            Array.Sort(supArr);

            for (int i = 0; i < supArr.Length - 1; i++) 
            {
                if (supArr[i] == supArr[i+1]) 
                {
                    k1++;
                }
                else
                {
                    if (k1 > k2)
                    {
                        k2 = k1;
                        number = supArr[i];
                    }
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            // Создание объектов класса различными методами
            Pokemon squirtl = new Pokemon();
            Pokemon magicarp = new Pokemon(squirtl);
            Pokemon pika = new Pokemon(100, 100, 100);

            // Задание 1 
            pika.PokemonUp(12, 12, 12); // Метод класса
            pika.Show();
            Pokemon.PokemonUp(pika, 12, 12, 12); // Статическая функция
            pika.Show();

            Console.WriteLine(Pokemon.count); // Статическая комп. класса
            Console.WriteLine();

            // Задание 2
            Console.WriteLine(~pika); // Унарные операции
            (--pika).Show();
            Console.WriteLine((int)pika); // Операции приведения типа
            Console.WriteLine(pika);
            (pika >> 10).Show(); // Бинарные операции
            (pika > 10).Show();
            (pika < 10).Show();

            Console.WriteLine(pika.Equals(magicarp));
            Console.WriteLine(squirtl.Equals(magicarp));
            Console.WriteLine(Pokemon.count);

            // Задание 3
            PokemonArray zoo = new PokemonArray(10, 1);
            PokemonArray.ArrShow(zoo);
            Console.WriteLine(GiveModa(zoo));
            //PokemonArray zoopark = new PokemonArray(3, 2);
            //PokemonArray.ArrShow(zoopark);
            Console.WriteLine(PokemonArray.countArr);
        }
    }
}
