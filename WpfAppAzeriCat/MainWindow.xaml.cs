using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAzeriCat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Yazisma> ?yazismaq { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            yazismaq = new List<Yazisma>() {
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.30",
                    Text="Salam necesen"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                },
                new Yazisma(){
                    Date="12.32",
                    Text="Aleykum Salam"
                }
            };
            DataContext = this;
        }
    }
}
