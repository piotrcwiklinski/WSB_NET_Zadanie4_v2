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
    public partial class OknoElementu : Window
    {
        public OknoElementu(System.Xml.XmlElement element)
        {
            DataContext = element;
            InitializeComponent();
        }
    }
}
