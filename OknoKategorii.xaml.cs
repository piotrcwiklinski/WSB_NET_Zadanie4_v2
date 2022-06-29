using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WSB_NET_Zadanie4_v2
{
    public partial class OknoKategorii : Window
    {
        public OknoKategorii(System.Xml.XmlElement kategoria)
        {
            DataContext = kategoria;
            Console.WriteLine(kategoria);
            InitializeComponent();
        }

        private void WyswietlPodkategorie(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Podkategorie");
            new OknoPodkategorii((System.Xml.XmlElement)lista.SelectedItem).Show();
        }
    }
}
