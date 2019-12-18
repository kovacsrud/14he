using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfIp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JObject response;
        JObject weather;
        String apiKey = "57e7f2daa88da7119dc6c575f1232c0f";
        String weatherApiKey = "cee47ae14c4e2b23dd70220929479c28";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public JObject GetIP(string ip)
        {
            JObject ipdata = JObject.Parse(new WebClient().DownloadString($"http://api.ipstack.com/{ip}?access_key={apiKey}"));

            return ipdata;
        }

        public JObject GetWeather(string city)
        {
            JObject weatherData = JObject.Parse(new WebClient().DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={weatherApiKey}&units=metric"));
            return weatherData;
        }

        public Label DataLabel(string data,int meret=20)
        {
            Label label = new Label();
            label.Content = data;
            label.FontSize = meret;

            return label;
        }

        private void buttonIp_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxIp.Text.Length>=7)
            {
                stackData.Children.Clear();
                try
                {
                    response = GetIP(textBoxIp.Text);
                    weather = GetWeather((string)response["city"]);
                    Debug.WriteLine(response);
                    Debug.WriteLine(weather);
                    stackData.Children.Add(DataLabel((string)response["continent_name"]));
                    stackData.Children.Add(DataLabel((string)response["country_name"]));
                    stackData.Children.Add(DataLabel((string)response["region_name"]));
                    stackData.Children.Add(DataLabel((string)response["city"]));
                    stackData.Children.Add(DataLabel((string)weather["main"]["temp"]));
                    stackData.Children.Add(DataLabel((string)weather["main"]["temp_min"]));
                    stackData.Children.Add(DataLabel((string)weather["main"]["temp_max"]));
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Hiba!");
                }

            } else
            {
                MessageBox.Show("Hibás IP-cím!");
            }
        }
    }
}
