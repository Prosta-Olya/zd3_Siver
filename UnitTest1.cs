using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

using zd3_Siver;

namespace TestFood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateQ() // тест для проверки рассчета качества продукта
        {
            // Входные данные
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            double value1 = food.CalculateQ();
            // Ожидаемый результат
            double value2 = 12;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestCalculateExtendedQ() // тест для проверки рассчета качества продукта для класса-наследника
        {
            // Входные данные
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            double value1 = food.CalculateExtendedQ();
            // Ожидаемый результат
            double value2 = 21.4;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestInfoFood1() // тест для проверки метода для вывода информации
        {
            // Входные данные
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            string str1 = food.Info();
            // Ожидаемый результат
            string str2 = $"Продукт: картошка, белок: 1 г, углеводы: 2 г, жиры: 3 г, клетчатка 4 г, Q: 12";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoFood2() // тест для проверки метода для вывода информации перегрузка
        {
            // Входные данные
            string name = "картошка";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // Получение значения с помощью тестируемого метода
            string str1 = Food.Info(name, protein, carbohydrates, fats, fiber);
            // Ожидаемый результат
            string str2 = $"Продукт: картошка, белок: 1 г, углеводы: 2 г, жиры: 3 г, клетчатка 4 г, Q: 12";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoExtendedFood1() // тест для проверки метода для вывода информации для класса-наследника
        {
            // Входные данные
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            string str1 = food.Info();
            // Ожидаемый результат
            string str2 = $"Продукт: яблоко, белок: 1 г, углеводы: 2 г, жиры: 1 г, клетчатка 2 г, Q: 12 \n" +
                $"Калорийность: 1, вес: 2 г, Qp: 21,4";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoExtendedFood2() // тест для проверки метода для вывода информации для класса-наследника перегрузка
        {
            // Входные данные
            string name = "яблоко";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // Получение значения с помощью тестируемого метода
            string str1 = ExtendedFood.Info(name, protein, carbohydrates, fats, fiber, calories, grams);
            // Ожидаемый результат
            string str2 = $"Продукт: яблоко, белок: 1 г, углеводы: 2 г, жиры: 1 г, клетчатка 2 г, Q: 12 \n" +
                $"Калорийность: 1, вес: 2 г, Qp: 21,4";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestAddFood1() // тест для проверки добавления продукта в список
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodList, food);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood2() // тест для проверки добавления продукта в список перегрузка
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            string name = "морковь";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodList, name, protein, carbohydrates, fats, fiber);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood1() // тест для проверки добавления продукта для списка для класса-наследника
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodList, food);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood2() // тест для проверки добавления продукта для списка для класса-наследника перегрузка
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            string name = "апельсин";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // Получение значения с помощью тестируемого метода
            ExtendedFood.AddItem(foodList, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood3() // тест для проверки добавления продукта в словарь
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
        Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood4() // тест для проверки добавления продукта в словарь перегрузка
        {
            // Входные данные
           Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
    string name = "морковь";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood3() // тест для проверки добавления продукта для словаря для класса-наследника
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            Food.AddItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood4() // тест для проверки добавления продукта для словаря для класса-наследника перегрузка
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "апельсин";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // Получение значения с помощью тестируемого метода
            ExtendedFood.AddItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 1;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood1() // тест для проверки удаления продукта из списока
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodList, food);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood2() // тест для проверки удаления продукта из списока перегрузка
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            string name = "морковь";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodList, name, protein, carbohydrates, fats, fiber);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood1() // тест для проверки удаления продукта из списока для класса-наследника
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodList, food);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood2() // тест для проверки удаления продукта из списока для класса-наследника перегрузка
        {
            // Входные данные
            List<Food> foodList = new List<Food>();
            string name = "апельсин";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // Получение значения с помощью тестируемого метода
            ExtendedFood.RemoveItem(foodList, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodList.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood3() // тест для проверки удаления продукта из словаря
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood4() // тест для проверки удаления продукта из словаря перегрузка
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "морковь";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood3() // тест для проверки удаления продукта из словаря для класса-наследника
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            Food.RemoveItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood4() // тест для проверки удаления продукта из словаря для класса-наследника перегрузка
        {
            // Входные данные
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "апельсин";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // Получение значения с помощью тестируемого метода
            ExtendedFood.RemoveItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodDictionary.Count;
            // Ожидаемый результат
            double value2 = 0;
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestToString1() // тест для проверки отображения продукта для базового класса
        {
            // Входные данные
            Food food = new Food("картошка", 1, 2, 3, 4);
            // Получение значения с помощью тестируемого метода
            string str1 = food.ToString();
            // Ожидаемый результат
           string str2 = "картошка 1 2 3 4";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestToString2() // тест для проверки отображения продукта для класса-наследника
        {
            // Входные данные
            ExtendedFood food = new ExtendedFood("яблоко", 1, 2, 1, 2, 1, 2);
            // Получение значения с помощью тестируемого метода
            string str1 = food.ToString();
            // Ожидаемый результат
            string str2 = "яблоко 1 2 1 2 1 2";
            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(str1, str2);
        }
    }
}
