using System;
namespace ClassLib_Calc_50114
{
    public class Calculator
    {
        public static string Or(ref short first_num, short second_num)
        {
            string str_ret = "Результат вычисления операции или: ";
            str_ret += String.Format("\n1й параметр:        {0,-10}", first_num);
            str_ret += String.Format("\n2й параметр:        {0,-10}", second_num);

            if (first_num > 90)
                str_ret += "\nОшибка #201! Первый параметр должен быть меньше 90.";
            else
            {
                str_ret += String.Format("\nточный результат:   {0,-10}", first_num | second_num);
                str_ret += String.Format("\nизмененное значение 1го параметра по ссылке (ref):");
                first_num = (sbyte)(first_num | second_num);
                str_ret += String.Format("\n                    {0,-10}", first_num);

            }
            return str_ret;
        }
        public static string And(ref short first_num, short second_num)
        {
            string str_ret = "Результат вычисления операции и: ";
            str_ret += String.Format("\n1й параметр:        {0,-10}", first_num);
            str_ret += String.Format("\n2й параметр:        {0,-10}", second_num);

            if (first_num < 40)
                str_ret += "\nОшибка #201! Первый параметр должен быть больше 40.";
            else
            {
                str_ret += String.Format("\nточный результат:   {0,-10}", first_num &= second_num);
                str_ret += String.Format("\nизмененное значение 1го параметра по ссылке (ref):");
                first_num = first_num &= second_num;
                str_ret += String.Format("\n                    {0,-10}", first_num);
                //str_ret += (first_num / second_num).ToString();
            }
            return str_ret;
        }
        public static string Subtract(ref short first_num, short second_num)
        {
            string str_ret = "Результат вычисления вычитания: ";
            str_ret += String.Format("\n1й параметр:        {0,-10}", first_num);
            str_ret += String.Format("\n2й параметр:        {0,-10}", second_num);

            if (second_num > 80)
                str_ret += "\nОшибка #201! Второй параметр должен быть меньше 80.";
            else
            {
                str_ret += String.Format("\nточный результат:   {0,-10}", 1.0 * first_num - second_num);
                str_ret += String.Format("\nизмененное значение 1го параметра по ссылке (ref):");
                first_num -= second_num;
                str_ret += String.Format("\n                    {0,-10}", first_num);
                //str_ret += (first_num / second_num).ToString();
            }
            return str_ret;
        }
        public static string Div(ref short first_num, short second_num)
        {
            string str_ret = "Результат вычисления деления: ";
            str_ret += String.Format("\n1й параметр:        {0,-10}", first_num);
            str_ret += String.Format("\n2й параметр:        {0,-10}", second_num);

            if (second_num < 30)
                str_ret += "\nОшибка #201! Второй параметр должен быть больше 30.";
            else
            {
                str_ret += String.Format("\nточный результат:   {0,-10}", first_num /= second_num);
                str_ret += String.Format("\nизмененное значение 1го параметра по ссылке (ref):");
                first_num = first_num /= second_num;
                str_ret += String.Format("\n                    {0,-10}", first_num);
                //str_ret += (first_num / second_num).ToString();
            }
            return str_ret;
        }
    }
}
// program.cs
//using calc = ClassLib_Calc_58133.Calculator;
namespace Program_50114
{
    class Program
    {
        static void Main()
        {
            int num = 50114;
            // исходные данные для вычислений
            string[] op_sign_simple = { "^", "*", "|", "&", "-", "/", "<<", "~", ">>", "!" };
            string[] op_sign_overload = { "^=", "*=", "|=", "&=", "-=", "/=", "<<=", "~=", ">>=", "!=" };
            string[] op_description = {"передаваемых значений - не более 100",
                                        "передаваемых значений - не менее 50",
                                        "первого параметра значением - не более 90",
                                        "первого параметра значением - не менее 40",
                                        "второго параметра значением - не более 80",
                                        "второго параметра значением - не менее 30",
                                        "результата вычисления - не более 300",
                                        "первого передаваемого значения - не менее -4000",
                                        "результата вычисления - не более 150 по модулю",
                                        "первого передаваемого значения - не менее 50 по модулю"};
            // операции, которые нужно реализовать для своего варианта
            for (int i = 0; i < 4; i += 2)
            {
                int n_simple = (((num / 100) + num % 100) % 9 + i);
                int n_overload = (n_simple + 10) % 9;
                Console.WriteLine("Операция " + i + ": {0} (разрешить числа {1})",
                    op_sign_simple[n_simple], op_description[n_simple]);
                Console.WriteLine("Операция " + i + 1 + ": {0} (разрешить числа {1})",
                    op_sign_overload[n_overload], op_description[n_overload]);
            }

            // пример работы функции '+' для значений в интервале -127..128
            string str_out = "";
            short first = 80;
            Console.WriteLine("\n###Работа функции Or(): параметры передаются в виде копии и по ссылке");
            Console.WriteLine("\n###Выполнение функции деления по ссылке без ошибок: Div(ref first, 60);");
            str_out = ClassLib_Calc_50114.Calculator.Or( ref first, 60);
            Console.WriteLine(str_out);

            Console.WriteLine("\n###Работа функции And(): параметры передаются в виде копии и по ссылке");
            Console.WriteLine("\n###Выполнение функции деления по ссылке без ошибок: Div(ref first, 60);");
            str_out = ClassLib_Calc_50114.Calculator.And(ref first, 60);
            Console.WriteLine(str_out);

            Console.WriteLine("\n###Работа функции Subtract(): параметры передаются в виде копии и по ссылке");
            Console.WriteLine("\n###Выполнение функции деления по ссылке без ошибок: Div(ref first, 60);");
            str_out = ClassLib_Calc_50114.Calculator.Subtract(ref first, 60);
            Console.WriteLine(str_out);

            Console.WriteLine("\n###Работа функции Div(): параметры передаются в виде копии и по ссылке");
            Console.WriteLine("\n###Выполнение функции деления по ссылке без ошибок: Div(ref first, 60);");
            str_out = ClassLib_Calc_50114.Calculator.Div(ref first, 60);
            Console.WriteLine(str_out);
        }
    }
}
