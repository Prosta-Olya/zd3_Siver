using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Siver
{
    public class ExtendedFood : Food // класс наследник 
    {
        public double Calories { get; set; } // калорийность
        public double Grams { get; set; } // вес в граммах

        public ExtendedFood(string name, double protein, double carbohydrates, double fats, double fiber, double calories,  double grams) // конструктор класса
            : base(name, protein, carbohydrates, fats, fiber)
        {
            Calories = calories;
            Grams = grams;
        }

        public override string ToString() // для отображения в listBox
        {
            return $"{Name} {Protein} {Carbohydrates} {Fats} {Fiber} {Calories} {Grams}";
        }

        public double CalculateExtendedQ() // метод для расчета Qp
        {
            double baseQ = CalculateQ();
            return (baseQ * 1.2) + (Calories * 7);
        }

        public new string Info() // вывод информации
        {
            return $"Продукт: {Name}, белок: {Protein} г, углеводы: {Carbohydrates} г, жиры: {Fats} г, клетчатка {Fiber} г, Q: {CalculateQ()} \n" +
                $"Калорийность: {Calories}, вес: {Grams} г, Qp: {CalculateExtendedQ()}";
        }
        public static string Info(string name, double protein, double carbohydrates, double fats, double fiber, double calories, double grams) // вывод информации перегрузка
        {
            ExtendedFood food = new ExtendedFood(name, protein, carbohydrates, fats, fiber, calories, grams);
            return $"Продукт: {food.Name}, белок: {food.Protein} г, углеводы: {food.Carbohydrates} г, жиры: {food.Fats} г, клетчатка {food.Fiber} г, Q: {food.CalculateQ()} \n" +
                $"Калорийность: {food.Calories}, вес: {food.Grams} г, Qp: {food.CalculateExtendedQ()}";
        }

        public static void RemoveItem(Dictionary<string, Food> items, string key, string name, double protein, double carbohydrates, double fats, double fiber, double calories, double grams) // удаление объекта из коллекции для словаря для класса-наследника
        {
            ExtendedFood item = new ExtendedFood(name, protein, carbohydrates, fats, fiber, calories, grams);
            items.Remove(key);
        }

        public static void AddItem(Dictionary<string, Food> items, string key, string name, double protein, double carbohydrates, double fats, double fiber, double calories, double grams) // добавление объекта в коллекцию для словаря для класса-наследника
        {
            ExtendedFood item = new ExtendedFood(name, protein, carbohydrates, fats, fiber, calories, grams);
            if (!items.TryGetValue(key, out _))
            {
                items[key] = item;
            }
        }

        public static void RemoveItem(List<Food> items, string name, double protein, double carbohydrates, double fats, double fiber, double calories, double grams) // удаление объекта из коллекции для списка для класса-наследника
        {
            ExtendedFood item = new ExtendedFood(name, protein, carbohydrates, fats, fiber, calories, grams);
            items.Remove(item);
        }

        public static void AddItem(List<Food> items, string name, double protein, double carbohydrates, double fats, double fiber, double calories, double grams) // добавление объекта в коллекцию для списка для класса-наследника
        {
            ExtendedFood item = new ExtendedFood(name, protein, carbohydrates, fats, fiber, calories, grams);
            if (!items.Any(i => i.Equals(item)))
            {
                items.Add(item);
            }
        }
    }
}
