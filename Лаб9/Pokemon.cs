using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб9
{
    public class Pokemon
    {
        public static int count;
        private int attack, defense, stamina;
        // Конструктор без параметра
        public Pokemon() 
        {
            this.attack = 17;
            this.defense = 32;
            this.stamina = 1;
            count++;
        }
        // Конструктор с параметром
        public Pokemon(int attack, int defense, int stamina)
        {
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
            count++;
        }
        // Конструктор копирования
        public Pokemon(Pokemon pokemon)
        {
            this.Attack = pokemon.attack;
            this.Defense = pokemon.defense;
            this.Stamina = pokemon.stamina;
            count++;
        }
        // Свойства
        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if (value < 17)
                {
                    this.attack = 17;
                }
                else
                {
                    if (value > 414)
                    {
                        this.attack = 414;
                    }
                    else this.attack = value;
                }
            }
        }
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if (value < 32)
                {
                    this.defense = 32;
                }
                else
                {
                    if (value > 396)
                    {
                        this.defense = 396;
                    }
                    else this.defense = value;
                }
            }
        }
        public int Stamina
        {
            get
            {
                return this.stamina;
            }
            set
            {
                if (value < 1)
                {
                    this.stamina = 1;
                }
                else
                {
                    if (value > 496)
                    {
                        this.stamina = 496;
                    }
                    else this.stamina = value;
                }
            }
        }
        // Статическая функция увеличения характеристик
        public static Pokemon PokemonUp(Pokemon pokemon, int attack, int defense, int stamina)
        {
            pokemon.Attack += attack;
            pokemon.Defense += defense;
            pokemon.Stamina += stamina;
            return pokemon;
        }
        // Метод класса для увеличения характеристик
        public Pokemon PokemonUp(int attack, int defense, int stamina)
        {
            Attack += attack;
            Defense += defense;
            Stamina += stamina;
            return this;
        }
        // Метод вывода объекта класса
        public void Show()
        {
            Console.WriteLine($"Покемон: Атака - {attack} Защита - {defense} Выносливость - {stamina}");
        }
        // Унарные операции
        public static double operator ~(Pokemon pokemon)
        {
            return Math.Round(Math.Sqrt(pokemon.Stamina) * Math.Sqrt(pokemon.Defense) * pokemon.Attack / 10, 2);
        }
        public static Pokemon operator --(Pokemon pokemon)
        {
            pokemon.Stamina--; 
            return pokemon;
        }
        // Операции приведения типа
        public static explicit operator int(Pokemon pokemon) 
        { 
            return pokemon.Attack + pokemon.Defense + pokemon.Stamina;
        }
        public static implicit operator double(Pokemon pokemon)
        {
            return Math.Round((pokemon.Attack + pokemon.Defense + pokemon.Stamina) / 3.0, 2);
        }
        // Бинарные операции
        public static Pokemon operator >>(Pokemon pokemon, int p)
        {
            pokemon.Stamina += p;
            return pokemon;
        }
        public static Pokemon operator >(Pokemon pokemon, int p)
        {
            pokemon.Defense += p;
            return pokemon;
        }
        public static Pokemon operator <(Pokemon pokemon, int p)
        {
            pokemon.Attack += p;
            return pokemon;
        }
        // Метод для сравнения двух объектов
        public override bool Equals(object obj)
        {
            if (!(obj is Pokemon))
            {
                return false;
            }
            Pokemon p = obj as Pokemon;
            return this.Attack == p.Attack && this.Defense == p.Defense && this.Stamina == p.Stamina;
        }
    }
}
