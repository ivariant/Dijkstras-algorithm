using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    class DijkstraAlgorithm
    {
        private const int infinity = 65535;

        private string str = "";
        private string[] path = new string[18]; 

        private int[] flag = new int[8];
        private int[] lenght = new int[8]; 
        private int countNodes = 0;

        public DijkstraAlgorithm(int countNodes)
        {
            this.countNodes = countNodes;
        }


        public string find(int[,] matrix, int xStart, int xEnd)
        {

            string buf = "";

            for (int i = 0; i < countNodes; i++)
            { 
                for (int j = 0; j < countNodes; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = infinity; //бесконечность
                    }
                }
            }

            for (int i = 0; i < countNodes; i++)
            {
                flag[i] = 0; // все флаги не посещены
                lenght[i] = infinity; // все длины равны бесконечности
            }


            lenght[xStart] = 0;
            flag[xStart] = 1;

            int point = xStart;

            ConvertCityNumber convertCityNumber = new ConvertCityNumber();
            str = Convert.ToString(convertCityNumber.toCity(xStart));

            for (int i = 1; i <= countNodes; i++)
            {
                path[i] = str;
            }

            do
            {
                for (int i = 0; i < countNodes; i++)
                {
                    if ((matrix[point, i] != infinity) && (flag[i] != 1) && (i != point))
                    {
                        if (lenght[i] > lenght[point] + matrix[point, i]) path[i] = path[point] + " -> " + convertCityNumber.toCity(i);

                        lenght[i] = minim(lenght[i], lenght[point] + matrix[point, i]);
                    }
                }

                point = min(countNodes);
                flag[point] = 1;
            } while (point != xEnd);


            return buf = "Найденый путь: " + path[point] + " " + lenght[point];
        }

        private int minim(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
            
        }

        private int min(int countNodes)
        {
            int result = 0;

            for (int i = 0; i < countNodes; i++)
            {
                if (flag[i] != 1)
                {
                    result = i;
                }
            }

            for (int i = 0; i < countNodes; i++)
            {
                if ((lenght[result] > lenght[i]) && (flag[i] != 1))
                {
                    result = i;
                }
            }

            return result;
        }

    }
}
