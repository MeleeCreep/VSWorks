using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace WinFormsApp_LogFiles_50114
{
    public class LogData // класс для работы с отладочными данными 
    {
        private StringBuilder _sb; // "построитель" строки 
        private string _log_file; // путь к лог файлу
        public LogData(string log_file = null) // общедоступный конструктор
        {
            _sb = new StringBuilder(); // инициализируем объект "построителя" строки
           if (log_file == null) // если задан пустой лог, формируем его имя 
            {
                DateTime current_time = DateTime.Now; // текущее время
                string current_dir = Directory.GetCurrentDirectory(); // текущий каталог
                  _log_file = current_dir +"501_14_"+ current_time.Year.ToString() + "_" +
                   current_time.Month.ToString() + "_" +
                   current_time.Day.ToString() + "_" +
                   current_time.Hour.ToString() + "_" +
                   current_time.Minute.ToString() + ".log"; // имя лог‐файла 
            }
            else // иначе запоминаем текущее имя 
            {
                _log_file = log_file;
            }
        }
        public void AddToLog(string str_add) // добавление строки в лог‐файл 
        {
            _sb.Append(str_add);
        }
        public void SaveLog() // сохранение лога в файл 
        { // добавляем данные в файл 
            File.AppendAllText(_log_file, _sb.ToString(), Encoding.Default);
            _sb.Clear(); // очищаем уже добавленные строки лог‐файла 
        }
        public static string[] ShowLogData(string log_file)
        { // загрузка одного из лог файлов во внешние переменные 
            string[] str_ret = File.ReadAllLines(log_file, Encoding.Default);
            return str_ret; // возвращаем все считанные строки 
        }
    }
}
