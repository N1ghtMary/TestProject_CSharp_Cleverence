using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_project_C__250325_Cleverence
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        //Пример:
        //Исходная строка: aaabbcccdde
        //Сжатая строка: a3b2c3d2e

        const string EMPTY_STRING_ERROR = "Строка не должна быть пустой";
        const string START_FROM_NUMBER_ERROR = "Некорректный формат строки: число без предшествующей буквы";
        const string ZERO_ERROR = "Число не может быть равно нулю";

        const string EMPTY_DECOMPRESS_ERROR = "Не найдены цифры для декомпрессии";
        const string WRONG_STRING_DECOMPRESS_ERROR = "Неверная входная строка для декомпрессии"; 
        
        const string EMPTY_COMPRESS_ERROR = "Не найдены буквы для компрессии";
        const string WRONG_STRING_COMPRESS_ERROR = "Неверная входная строка для компрессии";

        // Алгоритм компрессии
        private string Compress(string input)
        {
            if (string.IsNullOrEmpty(input)) return EMPTY_STRING_ERROR;
            if (input.All(c => char.IsDigit(c))) return WRONG_STRING_COMPRESS_ERROR;

            try
            {
                var compressed = string.Empty;
                int count = 1;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        compressed += input[i - 1] + (count > 1 ? count.ToString() : "");
                        count = 1;
                    }
                }
                compressed += input[input.Length - 1] + (count > 1 ? count.ToString() : "");

                if (compressed == input) return EMPTY_COMPRESS_ERROR;

                return compressed;
            }
            catch
            {
                return WRONG_STRING_COMPRESS_ERROR;
            }
        }

        // Алгоритм декомпрессии
        private string Decompress(string input)
        {
            if (string.IsNullOrEmpty(input)) return EMPTY_STRING_ERROR;
            if (!input.All(c => char.IsLetter(c) || char.IsDigit(c))) return WRONG_STRING_DECOMPRESS_ERROR;
            if (input.All(c => char.IsDigit(c))) return WRONG_STRING_DECOMPRESS_ERROR;

            try
            {
                var decompressed = string.Empty;
                for (int i = 0; i < input.Length;)
                {
                    if (char.IsLetter(input[i]))
                    {
                        decompressed += input[i];
                        i++;
                    }
                    else if (char.IsDigit(input[i]))
                    {
                        if (i == 0 || !char.IsLetter(input[i - 1])) return START_FROM_NUMBER_ERROR;

                        int count = 0;

                        /* 
                         * Считываем все подряд идущие цифры для ситуации, когда
                         * вводится число больше 9 для дублирования
                         */
                        while (i < input.Length && char.IsDigit(input[i]))
                        {
                            count = count * 10 + (input[i] - '0');
                            i++;
                        }

                        if (count == 0) return ZERO_ERROR;

                        // Добавляем символ 'count - 1' раз
                        for (int j = 1; j < count; j++)
                        {
                            decompressed += input[i - count.ToString().Length - 1];
                        }
                    }
                    else
                    {
                        return WRONG_STRING_DECOMPRESS_ERROR;
                    }
                }

                if (decompressed == input) return EMPTY_DECOMPRESS_ERROR;

                return decompressed;
            }
            catch 
            {
                return WRONG_STRING_DECOMPRESS_ERROR;
            }
        }

        private void buttonCompress_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            textBoxResult.Text = Compress(input.ToLower());
        }

        private void buttonDecompress_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            textBoxResult.Text = Decompress(input.ToLower());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxResult.Text = "";
        }
    }
}
