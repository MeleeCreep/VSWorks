using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp_LogFiles_50114
{
    public partial class Form_Main : Form
    {
        LogData _logData = null;      // ссылка на экземляр класса данных лог‐файла
        bool _log_click = false;      // флаг записи в лог по событию "Click"
        bool _log_mouseclick = false; // флаг записи в лог по событию "MouseClick"
        bool _enabled_log = false;    // флаг разрешения записи в лог
        public Form_Main()
        {
            _logData = new LogData();
            InitializeComponent();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();// начальный каталог для открытия файлов
        }
        // ‐‐‐ BEGIN OF USER DEFINED METHODS ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
        //‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
        private void button_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string str_add = " Событие Click экземпляра компонента " + c.Name + " координаты не определены\n";
            _logData.AddToLog(str_add);
            toolStripStatusLabel.Text = str_add;
            richTextBox_ShowLog.AppendText(str_add);
        }

        //‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            string str_add = "Событие MouseClick экземпляра компонента " + c.Name + " координаты (" +
            e.X + "," + e.Y + ")" + "\n";
            _logData.AddToLog(str_add);
            toolStripStatusLabel.Text = str_add;
            richTextBox_ShowLog.AppendText(str_add);//добавляем в список 
        }
      
        //‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
        // ‐‐‐ END OF USER DEFINED METHODS ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐
        private void button_Close_Click(object sender, EventArgs e)
        {
            _logData.SaveLog();
            Close();
        }

        private void button_SwitchLog_Click(object sender, EventArgs e)
        {
            _enabled_log = !_enabled_log; // инвертируем флаг разрешения лога 
            if (_enabled_log) // если флаг теперь разрешен 
            {
                button_SwitchLog.Text = "Выключить лог";
            }
            else
            {
                button_SwitchLog.Text = "Включить лог";
            }
        }

        private void checkBox_Click_CheckedChanged(object sender, EventArgs e)
        {
            _log_click = checkBox_Click.Checked && _enabled_log; // получаем флаг о разрешении клика
            foreach (Control c in this.Controls) // для всех контролов
            {
                //if c.
                if (_log_click) // добавляем событие Click, если разрешено 
                {
                    c.Click += new EventHandler(button_Click);
                }
                else // иначе удаляем событие Click
                {
                    c.Click -= new EventHandler(button_Click);
                }
            }
        }

        private void checkBoxMouseClick_CheckedChanged(object sender, EventArgs e)
        {
            _log_mouseclick = checkBoxMouseClick.Checked && _enabled_log;
            // получаем флаг о разрешении клика
            foreach (Control c in this.Controls) // для всех контролов
            {
                //if c.
                if (_log_mouseclick) // добавляем событие Click, если разрешено
                {
                    c.MouseClick += new MouseEventHandler(button_MouseClick);
                }
            else // иначе удаляем событие Click
                {
                    c.MouseClick -= new MouseEventHandler(button_MouseClick);
                }
            }
        }

        private void button_OpenLog_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) // если выбран файл загрузки
            {
                richTextBox_ShowLog.Clear();//очищаем список 
                string str_file = openFileDialog.FileName; // имя выбранного пользователем файла
                string[] str_dat = LogData.ShowLogData(str_file); //загружаем данные файла
                richTextBox_ShowLog.Lines = str_dat;
            }
        }

        private void button_ClearList_Click(object sender, EventArgs e)
        {
            richTextBox_ShowLog.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _logData.SaveLog();
        }
    }
}
