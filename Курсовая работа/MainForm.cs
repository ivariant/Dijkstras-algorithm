using System;
using System.IO;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            helpProvider.HelpNamespace = "EU.chm";
            helpProvider.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider.SetShowHelp(this, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        
	      
        private void обАвтореToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Аксенчик Вадим\nГруппа: T-216\nПо предмету: КПиЯП\nКолледж Бизнеса и Права 2014 г.");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            labelMoscowCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void MoscowCity_MouseLeave(object sender, EventArgs e)
        {            
            labelMoscowCity.ForeColor = Color.Aqua;
           Info.Height = 0;
            Info.Width = 0;
 
        }

        private void kiewCity_MouseLeave(object sender, EventArgs e)
        {
            labelKiewCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void kiewCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelKiewCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            labelWarszawaCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            labelWarszawaCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void BerlinCity_MouseLeave(object sender, EventArgs e)
        {
            labelBerlinCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void BerlinCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelBerlinCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void rimCity_MouseLeave(object sender, EventArgs e)
        {
            labelRimCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void rimCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelRimCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            labelLondonCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0; 
        }

        private void londonCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelLondonCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void ParizCity_MouseLeave(object sender, EventArgs e)
        {
            labelParizCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void ParizCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelParizCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            labelMadridCity.ForeColor = Color.Aqua;
            Info.Height = 0;
            Info.Width = 0;
        }

        private void madridCity_MouseMove(object sender, MouseEventArgs e)
        {
            labelMadridCity.ForeColor = Color.Orange;
            Info.Location = new Point(401, 239);
            Info.Height = 217;
            Info.Width = 376;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm zxc = new AdminForm();
            zxc.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            if (radioButtonTime.Checked && comboBoxCities.Text == "")
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNum = new ConvertCityNumber();

                    int start = convertCityNum.toNumber(radioButtonCityOne.Text),
                        end = convertCityNum.toNumber(radioButtonCityTwo.Text);

                    if (start == end) MessageBox.Show("Пути не могут совпадать!");
                        else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                            else MessageBox.Show(dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.");               
            }
            else if (radioButtonPrice.Checked && comboBoxCities.Text == "")
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNum = new ConvertCityNumber();

                int start = convertCityNum.toNumber(radioButtonCityOne.Text),
                    end = convertCityNum.toNumber(radioButtonCityTwo.Text);

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                    else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                        else MessageBox.Show(dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.");
            }
            else if (radioButtonTime.Checked)
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(comboBoxCities.Text);

                string buffer = ""; 

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else
                {
                    buffer = dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.";
                    start = convertCityNumber.toNumber(comboBoxCities.Text);
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                    if (start == end) MessageBox.Show("Пути не могут совпадать!");
                        else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                            else MessageBox.Show(buffer + "\n" + dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.");                     
                }
               
            }
            else if (radioButtonPrice.Checked)
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(comboBoxCities.Text);

                string buffer = "";

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else
                {
                    buffer = dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.";
                    start = convertCityNumber.toNumber(comboBoxCities.Text);
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                    if (start == end) MessageBox.Show("Пути не могут совпадать!");
                    else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                    else MessageBox.Show(buffer + "\n" + dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.");
                }
            }

        }

        
        void checkCity(string name)
        {
            if(radioButtonCityOne.Checked)
            {
                radioButtonCityOne.Text = name;
            }

            else if (radioButtonCityTwo.Checked)
            {
                radioButtonCityTwo.Text = name;
            }
        }

        private void MoscowCity_Click(object sender, EventArgs e)
        {
            checkCity(labelMoscowCity.Text);
        }

        private void kiewCity_Click(object sender, EventArgs e)
        {
            checkCity(labelKiewCity.Text);
        }

        private void Warszawa_Click(object sender, EventArgs e)
        {
            checkCity(labelWarszawaCity.Text);
        }

        private void BerlinCity_Click(object sender, EventArgs e)
        {
            checkCity(labelBerlinCity.Text);
        }

        private void londonCity_Click(object sender, EventArgs e)
        {
            checkCity(labelLondonCity.Text);
        }

        private void ParizCity_Click(object sender, EventArgs e)
        {
            checkCity(labelParizCity.Text);
        }

        private void rimCity_Click(object sender, EventArgs e)
        {
            checkCity(labelRimCity.Text);
        }

        private void madridCity_Click(object sender, EventArgs e)
        {
            checkCity(labelMadridCity.Text);
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EU.chm");
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonTime.Checked && comboBoxCities.Text == "")
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else MessageBox.Show(dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.");
            }
            else if (radioButtonPrice.Checked && comboBoxCities.Text == "")
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else MessageBox.Show(dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.");
            }
            else if (radioButtonTime.Checked)
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(comboBoxCities.Text);

                string buffer = "";

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else
                {
                    buffer = dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.";
                    start = convertCityNumber.toNumber(comboBoxCities.Text);
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                    if (start == end) MessageBox.Show("Пути не могут совпадать!");
                    else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                    else MessageBox.Show(buffer + "\n" + dijkstraAlgorithm.find(readF.readFile("time.txt", 8), start, end) + " часов.");
                }

            }
            else if (radioButtonPrice.Checked)
            {
                ReadWriteFile readF = new ReadWriteFile();
                DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm(8);
                ConvertCityNumber convertCityNumber = new ConvertCityNumber();

                int start = convertCityNumber.toNumber(radioButtonCityOne.Text),
                    end = convertCityNumber.toNumber(comboBoxCities.Text);

                string buffer = "";

                if (start == end) MessageBox.Show("Пути не могут совпадать!");
                else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                else
                {
                    buffer = dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.";
                    start = convertCityNumber.toNumber(comboBoxCities.Text);
                    end = convertCityNumber.toNumber(radioButtonCityTwo.Text);

                    if (start == end) MessageBox.Show("Пути не могут совпадать!");
                    else if (start == -1 || end == -1) MessageBox.Show("Не верно выбраны пути!");
                    else MessageBox.Show(buffer + "\n" + dijkstraAlgorithm.find(readF.readFile("price.txt", 8), start, end) + " $.");
                }
            }
        }

        private void MoscowCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Столица Российской Федерации.\nТуристический центры Москвы:\n    Московский Кремль,\n    Красная площадь,\n    Новодевичий монастырь,\n    Церковь Вознесения. ";
            Land.Text = "Россия";
            time.Text = "Часовой пояс : +4:00";
            Climate.Text = "Климат: Зимой -20-25 С\n               Летом +19.2";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.rus;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.Moscow;
        }

        private void Warszawa_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Столица Польши.\nТуристический центры Варшавы:\n    Центр науки и культуры,\n    Дворец на воде,\n    Королевский замок,\n    костел Святой Анны. ";
            Land.Text = "Польша";
            time.Text = "Часовой пояс : +1:00,+2";
            Climate.Text = "Климат: Зимой -5 - +2 С\n              Летом +15-20 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.pl;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.vorshava;
        }

        private void kiewCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Столица и крупнейший город Украины.\nТуристический центры Киева:\n    Золотые ворота,\n    Софийский собор,\n    Музей Булгакова,\n    Майдан. ";
            Land.Text = "Украина";
            time.Text = "Часовой пояс : +2:00,+3";
            Climate.Text = "Климат: Зимой -4-5 С\n               Летом +19.0 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.uk;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.kiew;
        }

        private void BerlinCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Столица Германии.\nТуристический центры Берлина:\n     Церковь святой Марии,\n     Берлинский собор,\n    Оперный театр,\n    Бранденбургские ворота,\n    Рейхстаг,\n    Дворец Бельвю.";
            Land.Text = "Германия";
            time.Text = "Часовой пояс : +1:00,+2";
            Climate.Text = "Климат: Зимой +1.3 С\n              Летом +18.8 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.gr;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.berlin;
        }

        private void rimCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Город, столица Италии, административный центр провинции Рим.\nТуристический центры Рима:\n     Колизей,\n     Замок Святого Ангела,\n     Пантеон,\n     Римский Форум,\n     Пьяцца дель Пополо,\n     Вилла Боргезе.";
            Land.Text = "Италия";
            time.Text = "Часовой пояс : +1:00,+2";
            Climate.Text = "Климат: Зимой +5-10 С\n              Летом > +40 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.it;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.rim;
        }

        private void londonCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Город, столица Королевства Великобритании.\nТуристический центры Лондона:\n     Букингемский дворец,\n     Собор святого Павла,\n   Тройной купол собора,\n    Колесо обозрения,\n    Лондонский аквариум,\n    Подземелья Лондона.";
            Land.Text = "Великобритания";
            time.Text = "Часовой пояс : +0:00,+1";
            Climate.Text = "Климат: Зимой -5-3 С\n              Летом +22.5 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.vl;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.london;
        }

        private void ParizCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Город, столица Франции.\nТуристический центры Парижа:\n     Эйфелева башня,\n     Лувр,\n   Нотр-Дам,\n    Центр Помпиду,\n    Триумфальная арка,\n    Дом Инвалидов.";
            Land.Text = "Франция";
            time.Text = "Часовой пояс : +1:00,+2";
            Climate.Text = "Климат: Зимой -5-3 С\n              Летом +24.5 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources.pr;
            City.BackgroundImage = Курсовая_работа.Properties.Resources.paris;
        }

        private void madridCity_Paint(object sender, PaintEventArgs e)
        {
            CityInfo.Text = "Город, столица Испании.\nТуристический центры Мадрида:\n     Пласа-Майор,\n     Восточная площадь,\n   Гран-Виа,\n    Парк Ретиро,\n    Королевский дворец,\n    Восточная площадь.";
            Land.Text = "Испания";  //
            time.Text = "Часовой пояс : +1:00,+2"; //
            Climate.Text = "Климат: Зимой +20 С\n              Летом +35.5 С";
            Flag.BackgroundImage = Курсовая_работа.Properties.Resources._is; //
            City.BackgroundImage = Курсовая_работа.Properties.Resources.madrid; //
        }

    }

}