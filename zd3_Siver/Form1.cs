using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_Siver
{
    public partial class Form1 : Form
    {
        private List<Food> foodList = new List<Food>(); // список продуктов
        private Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>(); // словарь
        public Form1()
        {
            InitializeComponent();
        }

        public List<Food> FoodsForList() // получение всех продуктов из списка
        {
            return foodList;
        }
        public Dictionary<string, Food>FoodsForDictionary() // получение всех продуктов из словаря
        {
            return foodDictionary;
        }

        private void button1_Click(object sender, EventArgs e) // добавление продукта
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text)&& !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)
                && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                if(double.TryParse(textBox2.Text, out double protein) && protein>0 && double.TryParse(textBox3.Text, out double carbohydrates) && carbohydrates > 0
                    && double.TryParse(textBox4.Text, out double fats) && fats > 0 && double.TryParse(textBox5.Text, out double fiber) && fiber > 0)
                {
                    Food food = new Food(textBox1.Text, protein, carbohydrates, fats, fiber);
                    Food.AddItem(foodList, food);
                    Food.AddItem(foodDictionary, food.Name, food);
                    MessageBox.Show($"Продукт добавлен \n {food.Info()}");
                }
                else
                {
                    MessageBox.Show("Ошибка, введены некорректные числа");
                }
            }
            else
            {
                MessageBox.Show("Для добавления заполните все поля");
            }
        }

        private void button5_Click(object sender, EventArgs e) // добавление продукта перегрузка
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)
               && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                if (double.TryParse(textBox2.Text, out double protein) && protein > 0 && double.TryParse(textBox3.Text, out double carbohydrates) && carbohydrates > 0
                    && double.TryParse(textBox4.Text, out double fats) && fats > 0 && double.TryParse(textBox5.Text, out double fiber) && fiber > 0)
                {
                    Food.AddItem(foodList, textBox1.Text, protein, carbohydrates, fats, fiber);
                    Food.AddItem(foodDictionary, textBox1.Text, textBox1.Text, protein, carbohydrates, fats, fiber);
                    MessageBox.Show($"Продукт добавлен \n {Food.Info(textBox1.Text, protein, carbohydrates, fats, fiber)}");
                }
                else
                {
                    MessageBox.Show("Ошибка, введены некорректные числа");
                }
            }
            else
            {
                MessageBox.Show("Для добавления заполните все поля");
            }
        }

        private void button2_Click(object sender, EventArgs e) // добавление продукта класс-наследник
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)
                && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (double.TryParse(textBox2.Text, out double protein) && protein > 0 && double.TryParse(textBox3.Text, out double carbohydrates) && carbohydrates > 0
                    && double.TryParse(textBox4.Text, out double fats) && fats > 0 && double.TryParse(textBox5.Text, out double fiber) && fiber > 0 
                    && double.TryParse(textBox6.Text, out double calories) && calories > 0 && double.TryParse(textBox7.Text, out double grams) && grams > 0)
                {
                    ExtendedFood food = new ExtendedFood(textBox1.Text, protein, carbohydrates, fats, fiber,calories,grams);
                    Food.AddItem(foodList, food);
                    Food.AddItem(foodDictionary, food.Name, food);
                    MessageBox.Show($"Продукт добавлен \n {food.Info()}");
                }
                else
                {
                    MessageBox.Show("Ошибка, введены некорректные числа");
                }
            }
            else
            {
                MessageBox.Show("Для добавления заполните все поля");
            }
        }

        private void button6_Click(object sender, EventArgs e) // добавление продукта класс-наследник перегрузка
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)
                && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (double.TryParse(textBox2.Text, out double protein) && protein > 0 && double.TryParse(textBox3.Text, out double carbohydrates) && carbohydrates > 0
                    && double.TryParse(textBox4.Text, out double fats) && fats > 0 && double.TryParse(textBox5.Text, out double fiber) && fiber > 0
                    && double.TryParse(textBox6.Text, out double calories) && calories > 0 && double.TryParse(textBox7.Text, out double grams) && grams > 0)
                {
                    ExtendedFood.AddItem(foodList, textBox1.Text, protein, carbohydrates, fats, fiber, calories, grams);
                    ExtendedFood.AddItem(foodDictionary, textBox1.Text, textBox1.Text, protein, carbohydrates, fats, fiber, calories, grams);
                    MessageBox.Show($"Продукт добавлен \n {ExtendedFood.Info(textBox1.Text, protein, carbohydrates, fats, fiber, calories, grams)}");
                }
                else
                {
                    MessageBox.Show("Ошибка, введены некорректные числа");
                }
            }
            else
            {
                MessageBox.Show("Для добавления заполните все поля");
            }
        }

        private void button3_Click(object sender, EventArgs e) // удаление продукта
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem is Food)
                {
                    var food = listBox1.SelectedItem as Food;
                    Food.RemoveItem(foodList, food);
                    Food.RemoveItem(foodDictionary, food.Name, food);
                }
                else
                {
                    var food = listBox1.SelectedItem as ExtendedFood;
                    Food.RemoveItem(foodList, food);
                    Food.RemoveItem(foodDictionary, food.Name, food);
                }
            }
            else
            {
                MessageBox.Show("Ошибка, выберите продукт для удаления");
            }
        }

        private void button7_Click(object sender, EventArgs e) // удаление продукта перегрузка
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem is Food)
                {
                    var food = listBox1.SelectedItem as Food;
                    Food.RemoveItem(foodList, food.Name, food.Protein, food.Carbohydrates, food.Fats, food.Fiber);
                    Food.RemoveItem(foodDictionary, food.Name, food.Name, food.Protein, food.Carbohydrates, food.Fats, food.Fiber);
                }
                else
                {
                    var food = listBox1.SelectedItem as ExtendedFood;
                    ExtendedFood.RemoveItem(foodList, food.Name, food.Protein, food.Carbohydrates, food.Fats, food.Fiber,food.Calories,food.Grams);
                    ExtendedFood.RemoveItem(foodDictionary, food.Name, food.Name, food.Protein, food.Carbohydrates, food.Fats, food.Fiber, food.Calories, food.Grams);
                }
            }
            else
            {
                MessageBox.Show("Ошибка, выберите продукт для удаления");
            }
        }

        private void button4_Click(object sender, EventArgs e) // вывод данных из списка в listBox
        {
            listBox1.Items.Clear();
            foreach (var food in FoodsForList())
            {
                listBox1.Items.Add(food);
            }
        }

        private void button8_Click(object sender, EventArgs e) // вывод данных из словаря в listBox
        {
            listBox1.Items.Clear();
            foreach (var food in FoodsForDictionary())
            {
                listBox1.Items.Add(food);
            }
        }
    }
}
