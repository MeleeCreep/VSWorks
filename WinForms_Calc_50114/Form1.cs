using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc = ClassLib_Cacl_50114_1_.Calculator;

namespace WinForms_Calc_50114
{
    public partial class Form1 : Form
    {
        private int _first_value = 0;
        private int _second_value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_first_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_first.Text, out value))
            {// обновляем переменную класса, если парсинг выполнен 
                _first_value = value;
            }
            else
            {
                _first_value = 0; // преобразование не было выполнено 
            }
        }
        private void textBox_second_TextChanged(object sender, EventArgs e)
        {
            int value1;
            if (Int32.TryParse(textBox_second.Text, out value1))
            {// обновляем переменную класса, если парсинг выполнен 
                _second_value = value1;
            }
            else
            {
                _second_value = 0; // преобразование не было выполнено 
            }
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            if (_second_value <= 80)
            {
                string str_message = Calc.Sub(_first_value, _second_value);
                label_Result.Text = str_message;
            }
            else
                MessageBox.Show("Второе число должно быть не более 80","Ошибка");
        }

        private void button_Or_Click(object sender, EventArgs e)
        {
            if (_first_value <= 90)
            {
                string str_message = Calc.Or((sbyte)_first_value, (sbyte)_second_value);
                label_Result.Text = str_message;
            }
            else
                MessageBox.Show("Первое число должно быть не более 90", "Ошибка");
        }

        private void button_DivAssig_Click(object sender, EventArgs e)
        {
            if (_second_value >= 30)
            {
                string str_message = Calc.DivAssig(_first_value, _second_value);
                label_Result.Text = str_message;
            }
            else
                MessageBox.Show("Второе число должно быть не менее 30", "Ошибка");
        }

        private void button_AndAssig_Click(object sender, EventArgs e)
        {
            if (_first_value >= 40)
            {
                string str_message = Calc.AndAssig(_first_value, _second_value);
                label_Result.Text = str_message;
                _first_value = Int32.Parse(str_message);
                textBox_first.Text = str_message;
            }
            else
                MessageBox.Show("Первое число должно быть не менее 40", "Ошибка");
        }
    }
}
