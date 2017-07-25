using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class ConvertCityNumber
    {

        public int toNumber(string city_name)
        {
            int value = -1;

            switch (city_name)
            {
                case "Москва":
                    value = 0;
                    break;

                case "Варшава":
                    value = 1;
                    break;

                case "Киев":
                    value = 2;
                    break;

                case "Рим":
                    value = 3;
                    break;

                case "Париж":
                    value = 4;
                    break;

                case "Берлин":
                    value = 5;
                    break;

                case "Лондон":
                    value = 6;
                    break;

                case "Мадрид":
                    value = 7;
                    break;
            }

            return value;
        }

        public string toCity(int city_name)
        {
            string value = "";

            switch (city_name)
            {
                case 0:
                    value = "Москва";
                    break;

                case 1:
                    value = "Варшава";
                    break;

                case 2:
                    value = "Киев";
                    break;

                case 3:
                    value = "Рим";
                    break;

                case 4:
                    value = "Париж";
                    break;

                case 5:
                    value = "Берлин";
                    break;

                case 6:
                    value = "Лондон";
                    break;

                case 7:
                    value = "Мадрид";
                    break;
            }

            return value;
        }

    }
}
