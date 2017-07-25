using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

       int[,] fileValue = new int[8,8];

       private void radioButtonTime_Click(object sender, EventArgs e)
       {
           ReadWriteFile f = new ReadWriteFile();
           fileValue = f.readFile("time.txt",8);
           showArray();
           buttonEdit.Visible = true;
       }

       private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
       {
           ReadWriteFile f = new ReadWriteFile();
           fileValue = f.readFile("price.txt",8);
           showArray();
           buttonEdit.Visible = true;
       }

       public void showArray()
       {
           string buf = "";
           ConvertCityNumber convertCityNumber = new ConvertCityNumber();
 
        for(int i =0 ; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i != j && fileValue[i, j] != 0) buf = buf + "Из города " + convertCityNumber.toCity(i) + " в город " + convertCityNumber.toCity(j)
                    + " = " + fileValue[i, j] + "\n";
            }
        }
        richTextBoxInfo.Text = buf;
       }

       private void buttonEdit_Click(object sender, EventArgs e)
       {
           try
           {
               ConvertCityNumber convertCityNumber = new ConvertCityNumber();
               int startPath = convertCityNumber.toNumber(comboBoxStartPath.Text);
               int endPath = convertCityNumber.toNumber(comboBoxEndPath.Text);
               int value = Convert.ToInt32(textBoxValue.Text);

               if (startPath != endPath)
               {
                   fileValue[startPath, endPath] = value;
                   fileValue[endPath, startPath] = value;

                   if (radioButtonTime.Checked)
                   {
                       ReadWriteFile WriteFile = new ReadWriteFile();
                       WriteFile.writeFile("time.txt", fileValue, 8);
                   }
                    else if (radioButtonPrice.Checked)
                    {
                        ReadWriteFile WriteFile = new ReadWriteFile();
                        WriteFile.writeFile("price.txt", fileValue, 8);
                    }
               }
                else
                {
                    MessageBox.Show("Пути совпадают!");
                }
           }
           catch
            {
                MessageBox.Show("Вы не заполнели поле значения или ввели неправильное значение!");
            }
       }

    }


}
