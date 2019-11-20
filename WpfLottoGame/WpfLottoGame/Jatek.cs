using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfLottoGame
{
    public class Jatek
    {
        private MainWindow mainwindow;
        private int[] tippek;
        private int[] nyeroSzamok;
        private int talalat = 0;
        private int sorSzam;
        private int oszlopSzam;
        private int hanySzam;
        private int szamlalo;
        Random rand = new Random();

        public Jatek(MainWindow mainwindow,int hanyszam,int sorszam,int oszlopszam)
        {
            this.mainwindow = mainwindow;
            mainwindow.buttonSorsolas.Click += sorsolasClick;
            mainwindow.buttonUj.Click += ujClick;
            sorSzam = sorszam;
            oszlopSzam = oszlopszam;
            hanySzam = hanyszam;
            tippek = new int[hanySzam];
            nyeroSzamok = new int[hanySzam];
            Gombok();
            szamlalo = 0;
        }

        public void UJjatek()
        {
            talalat = 0;
            szamlalo = 0;
            mainwindow.buttonSorsolas.IsEnabled = false;
            mainwindow.buttonUj.IsEnabled = false;
            mainwindow.szelvenyGrid.Children.Clear();
            Gombok();
            tippek = new int[hanySzam];
            nyeroSzamok = new int[hanySzam];


        }

        public void gombClick(object sender, EventArgs e)
        {
            Button gomb = (Button)sender;
            if (szamlalo<hanySzam)
            {
                if (!tippek.Contains(Convert.ToInt32(gomb.Content)))
                {
                    gomb.Foreground = Brushes.Red;
                    gomb.Background = Brushes.Yellow;
                    tippek[szamlalo] = Convert.ToInt32(gomb.Content);
                    Debug.WriteLine(szamlalo+";"+tippek[szamlalo]);
                    szamlalo++;
                }      
            }
            if (szamlalo>=hanySzam)
            {
                mainwindow.buttonSorsolas.IsEnabled = true;
                
            }
                
            
        }

        public void sorsolasClick(object sender,EventArgs e)
        {
            Sorsolas();
            Kiemeles();
            mainwindow.buttonSorsolas.IsEnabled = false;
            mainwindow.buttonUj.IsEnabled = true;

        }

        public void ujClick(object sender,EventArgs e)
        {
            UJjatek();
        }


        public void Sorsolas()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                var temp = rand.Next(1,(sorSzam*oszlopSzam)+1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, (sorSzam * oszlopSzam) + 1);
                }
                nyeroSzamok[i] = temp;
                Debug.WriteLine(nyeroSzamok[i]);
            }
        }

        public void Gombok()
        {
            Grid gombGrid = new Grid();

            for (int i = 0; i < sorSzam; i++)
            {
                RowDefinition sordef = new RowDefinition();
                gombGrid.RowDefinitions.Add(sordef);
            }

            for (int i = 0; i < oszlopSzam; i++)
            {
                ColumnDefinition coldef = new ColumnDefinition();
                gombGrid.ColumnDefinitions.Add(coldef);
            }

            var gombNum = 1;
            for (int i = 0; i < sorSzam; i++)
            {
                for (int j = 0; j < oszlopSzam; j++)
                {
                    Button gomb = new Button();
                    gomb.Content = gombNum;
                    gombNum++;
                    gomb.MinWidth = 30;
                    gomb.MinHeight = 30;
                    gomb.Click += gombClick;
                    gomb.Margin = new System.Windows.Thickness(5);
                    //Később még lesznek beállítások
                    gombGrid.Children.Add(gomb);
                    Grid.SetRow(gomb, i);
                    Grid.SetColumn(gomb, j);
                   
                }
            }
            //Hozzá kellene adni a gridet az ablakunk
            //gridjéhez
            mainwindow.szelvenyGrid.Children.Add(gombGrid);
        }

        //Nyerőszámok kiemelése
        public void Kiemeles()
        {
            foreach (Grid gr in mainwindow.szelvenyGrid.Children)
            {
                foreach (Button gomb in gr.Children)
                {
                    if (nyeroSzamok.Contains(Convert.ToInt32(gomb.Content)))
                    {
                        gomb.Foreground = Brushes.Gold;
                        gomb.Background = Brushes.Red;
                    }

                    if (nyeroSzamok.Contains(Convert.ToInt32(gomb.Content)) && tippek.Contains(Convert.ToInt32(gomb.Content)))
                    {
                        gomb.Foreground = Brushes.Gold;
                        gomb.Background = Brushes.Green;
                    }

                }
            }
        }

    }
}
