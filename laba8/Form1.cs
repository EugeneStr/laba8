using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();
            if (domainUpDown.Text == String.Empty)
            {
                MessageBox.Show("Не введен символ для фильтрации", "Ошибка");
            }
            else
            {
                Read_File();   
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // выбор набора символов, по которым можно фильтровать
        {
            domainUpDown.Items.Clear();
            char[] alpha = { };
            if (checkedListBox.GetItemChecked(0))
            {
                alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            }
            if (checkedListBox.GetItemChecked(1))
            {
                alpha = "0123456789".ToCharArray();
            }
            if (checkedListBox.GetItemChecked(2))
            {
                alpha = "%&$#".ToCharArray();
            }
            domainUpDown.Items.AddRange(alpha);
            domainUpDown.SelectedIndex = -1;
            domainUpDown.Text = "";
        }

        void Read_File() // считывание массива данных в двумерный массив
        {
            string path = @"data.txt";
            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                string row = file.ReadLine();
                int N = System.IO.File.ReadAllLines(path).Length;
                int M = row.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                string[,] DataArray = new string[N, M];
                for (int i = 0; i < N; i++)
                {
                    string[] line = row.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < M; j++)
                    {
                        DataArray[i, j] = line[j];
                    }
                    row = file.ReadLine();
                }
                Writer_TextBox(N, M, DataArray); // вызов функции для записи в textBox
            }
        }

        void Writer_TextBox(int N, int M, string[,] DataArray) // запись в textBox тех элементов, которые подходят под фильтр
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    string str = DataArray[i, j].ToString().ToUpper();
                    if (str.StartsWith(Convert.ToChar(domainUpDown.SelectedItem)))
                    {
                        if (radioButton_begin.Checked) // добавление & в начало слова
                        {
                            ResultTextBox.Text += "&" + DataArray[i, j] + " ";
                        }
                        else if (radioButton_end.Checked) // добавление & в конец слова
                        {
                            ResultTextBox.Text += DataArray[i, j] + "& ";
                        }
                        else 
                        {
                            ResultTextBox.Text += DataArray[i, j] + " ";
                        }
                    }
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
