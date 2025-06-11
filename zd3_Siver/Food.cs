using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Siver
{
    public class Food
    {
        public string Name { get; set; } // название продукта 
        public double Protein { get; set; } // белки
        public double Carbohydrates { get; set; } // углеводы

        // два своих поля
        public double Fats { get; set; } // жиры
        public double Fiber { get; set; } // клетчатка

        public Food(string name, double protein, double carbohydrates, double fats, double fiber) // конструктор класса
        {
            Name = name;
            Protein = protein;
            Carbohydrates = carbohydrates;
            Fats = fats;
            Fiber = fiber;
        }

        public override string ToString() // для отображения в listBox
        {
            return $"{Name} {Protein} {Carbohydrates} {Fats} {Fiber}";
        }

        public double CalculateQ() // метод для расчета Q
        {
            return (Carbohydrates * 4) + (Protein * 4);
        }

        public string Info() // вывод информации
        {
            return $"Продукт: {Name}, белок: {Protein} г, углеводы: {Carbohydrates} г, жиры: {Fats} г, клетчатка {Fiber} г, Q: {CalculateQ()}";
        }
        public static string Info(string name, double protein, double carbohydrates, double fats, double fiber) // вывод информации перегрузка
        {
            Food food = new Food(name, protein, carbohydrates, fats, fiber);
            return $"Продукт: {food.Name}, белок: {food.Protein} г, углеводы: {food.Carbohydrates} г, жиры: {food.Fats} г, клетчатка {food.Fiber} г, Q: {food.CalculateQ()}";
        }

        public static void AddItem(List<Food> items, Food item) // добавление объекта в коллекцию для списка
        {
            if (!items.Any(i => i.Equals(item)))
            {
                items.Add(item);
            }
        }
        public static void AddItem(List<Food> items, string name, double protein, double carbohydrates, double fats, double fiber) // добавление объекта в коллекцию перегрузка для списка
        {
            Food item = new Food(name, protein, carbohydrates, fats, fiber);
            if (!items.Any(i => i.Equals(item)))
            {
                items.Add(item);
            }
        }

        public static void RemoveItem(List<Food> items, Food item) // удаление объекта из коллекции для списка
        {
            items.Remove(item);
        }
        public static void RemoveItem(List<Food> items, string name, double protein, double carbohydrates, double fats, double fiber) // удаление объекта из коллекции перегрузка для списка
        {
            Food item = new Food(name, protein, carbohydrates, fats, fiber);
            items.Remove(item);
        }

        public static void AddItem(Dictionary<string, Food> items, string key, Food item) // добавление объекта в коллекцию для словаря
        {
            if (!items.TryGetValue(key, out _))
            {
                items[key] = item;
            }
        }
        public static void AddItem(Dictionary<string, Food> items, string key, string name, double protein, double carbohydrates, double fats, double fiber) // добавление объекта в коллекцию перегрузка для словаря
        {
            Food item = new Food(name, protein, carbohydrates, fats, fiber);
            if (!items.TryGetValue(key, out _))
            {
                items[key] = item;
            }
        }

        public static void RemoveItem(Dictionary<string, Food> items, string key, Food item) // удаление объекта из коллекции для словаря
        {
            items.Remove(key);
        }
        public static void RemoveItem(Dictionary<string, Food> items, string key, string name, double protein, double carbohydrates, double fats, double fiber) // удаление объекта из коллекции перегрузка для словаря
        {
            Food item = new Food(name, protein, carbohydrates, fats, fiber);
            items.Remove(key);
        }
    }
}
