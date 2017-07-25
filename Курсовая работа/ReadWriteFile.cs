using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public class ReadWriteFile
    {
        
        public int[,] readFile(string nameFile, int countNodes)
        {
          
            StreamReader f = new StreamReader(nameFile);
            string buffer = f.ReadToEnd();
            buffer = buffer.Replace("\r\n", " "); //Заменить символы
            buffer = buffer.Replace("\n", " ");
            string[] masCharPrice = buffer.Split(' ');

            int[,] masPrice = new int[countNodes, countNodes];
            int count = 0;

            for (int i = 0; i < countNodes; i++) // Запись в массив
            {
                for (int j = 0; j < countNodes; j++)
                {
                    masPrice[i, j] = Convert.ToInt32(masCharPrice[count]);
                    count++;
                }

            }

            f.Close();
            return masPrice;
        }

        public void writeFile(string nameFile, int[,] mas, int countNodes)
        {
            string buf = "";
            for (int i = 0; i < countNodes; i++) // Запись строки
            {
                for (int j = 0; j < countNodes; j++)
                {
                    if (j == (countNodes-1)) buf = buf + mas[i, j] + "\n";
                    else buf = buf + mas[i, j] + " ";
                }
            }

            StreamWriter f = new StreamWriter(nameFile);
            f.Write(buf);
            f.Close();
            MessageBox.Show("Изменения внесены!");
        }

    }
}
