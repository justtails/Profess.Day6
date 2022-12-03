using Newtonsoft.Json;
using Profess.Day6.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Profess.Day6
{
    /// <summary>
    /// Логика взаимодействия для WindowWeather.xaml
    /// </summary>
    public partial class WindowWeather : Window
    {
        public WindowWeather()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Response\\response.json");
            DataModel data = JsonConvert.DeserializeObject<DataModel>(sr.ReadToEnd());

            DataContext = data;
        }
    }
}
