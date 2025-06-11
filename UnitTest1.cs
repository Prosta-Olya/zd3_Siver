using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

using zd3_Siver;

namespace TestFood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateQ() // ���� ��� �������� �������� �������� ��������
        {
            // ������� ������
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            double value1 = food.CalculateQ();
            // ��������� ���������
            double value2 = 12;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestCalculateExtendedQ() // ���� ��� �������� �������� �������� �������� ��� ������-����������
        {
            // ������� ������
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            double value1 = food.CalculateExtendedQ();
            // ��������� ���������
            double value2 = 21.4;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestInfoFood1() // ���� ��� �������� ������ ��� ������ ����������
        {
            // ������� ������
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            string str1 = food.Info();
            // ��������� ���������
            string str2 = $"�������: ��������, �����: 1 �, ��������: 2 �, ����: 3 �, ��������� 4 �, Q: 12";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoFood2() // ���� ��� �������� ������ ��� ������ ���������� ����������
        {
            // ������� ������
            string name = "��������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // ��������� �������� � ������� ������������ ������
            string str1 = Food.Info(name, protein, carbohydrates, fats, fiber);
            // ��������� ���������
            string str2 = $"�������: ��������, �����: 1 �, ��������: 2 �, ����: 3 �, ��������� 4 �, Q: 12";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoExtendedFood1() // ���� ��� �������� ������ ��� ������ ���������� ��� ������-����������
        {
            // ������� ������
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            string str1 = food.Info();
            // ��������� ���������
            string str2 = $"�������: ������, �����: 1 �, ��������: 2 �, ����: 1 �, ��������� 2 �, Q: 12 \n" +
                $"������������: 1, ���: 2 �, Qp: 21,4";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestInfoExtendedFood2() // ���� ��� �������� ������ ��� ������ ���������� ��� ������-���������� ����������
        {
            // ������� ������
            string name = "������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // ��������� �������� � ������� ������������ ������
            string str1 = ExtendedFood.Info(name, protein, carbohydrates, fats, fiber, calories, grams);
            // ��������� ���������
            string str2 = $"�������: ������, �����: 1 �, ��������: 2 �, ����: 1 �, ��������� 2 �, Q: 12 \n" +
                $"������������: 1, ���: 2 �, Qp: 21,4";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestAddFood1() // ���� ��� �������� ���������� �������� � ������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodList, food);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood2() // ���� ��� �������� ���������� �������� � ������ ����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            string name = "�������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodList, name, protein, carbohydrates, fats, fiber);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood1() // ���� ��� �������� ���������� �������� ��� ������ ��� ������-����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodList, food);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood2() // ���� ��� �������� ���������� �������� ��� ������ ��� ������-���������� ����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            string name = "��������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // ��������� �������� � ������� ������������ ������
            ExtendedFood.AddItem(foodList, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood3() // ���� ��� �������� ���������� �������� � �������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
        Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddFood4() // ���� ��� �������� ���������� �������� � ������� ����������
        {
            // ������� ������
           Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
    string name = "�������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood3() // ���� ��� �������� ���������� �������� ��� ������� ��� ������-����������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            Food.AddItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestAddExtendedFood4() // ���� ��� �������� ���������� �������� ��� ������� ��� ������-���������� ����������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "��������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // ��������� �������� � ������� ������������ ������
            ExtendedFood.AddItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 1;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood1() // ���� ��� �������� �������� �������� �� �������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodList, food);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood2() // ���� ��� �������� �������� �������� �� ������� ����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            string name = "�������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodList, name, protein, carbohydrates, fats, fiber);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood1() // ���� ��� �������� �������� �������� �� ������� ��� ������-����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodList, food);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood2() // ���� ��� �������� �������� �������� �� ������� ��� ������-���������� ����������
        {
            // ������� ������
            List<Food> foodList = new List<Food>();
            string name = "��������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // ��������� �������� � ������� ������������ ������
            ExtendedFood.RemoveItem(foodList, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodList.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood3() // ���� ��� �������� �������� �������� �� �������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveFood4() // ���� ��� �������� �������� �������� �� ������� ����������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "�������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 3;
            double fiber = 4;
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood3() // ���� ��� �������� �������� �������� �� ������� ��� ������-����������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            Food.RemoveItem(foodDictionary, food.Name, food);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestRemoveExtendedFood4() // ���� ��� �������� �������� �������� �� ������� ��� ������-���������� ����������
        {
            // ������� ������
            Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
            string name = "��������";
            double protein = 1;
            double carbohydrates = 2;
            double fats = 1;
            double fiber = 2;
            double calories = 1;
            double grams = 2;
            // ��������� �������� � ������� ������������ ������
            ExtendedFood.RemoveItem(foodDictionary, name, name, protein, carbohydrates, fats, fiber, calories, grams);
            int value1 = foodDictionary.Count;
            // ��������� ���������
            double value2 = 0;
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(value1, value2);
        }
        [TestMethod]
        public void TestToString1() // ���� ��� �������� ����������� �������� ��� �������� ������
        {
            // ������� ������
            Food food = new Food("��������", 1, 2, 3, 4);
            // ��������� �������� � ������� ������������ ������
            string str1 = food.ToString();
            // ��������� ���������
           string str2 = "�������� 1 2 3 4";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TestToString2() // ���� ��� �������� ����������� �������� ��� ������-����������
        {
            // ������� ������
            ExtendedFood food = new ExtendedFood("������", 1, 2, 1, 2, 1, 2);
            // ��������� �������� � ������� ������������ ������
            string str1 = food.ToString();
            // ��������� ���������
            string str2 = "������ 1 2 1 2 1 2";
            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(str1, str2);
        }
    }
}
