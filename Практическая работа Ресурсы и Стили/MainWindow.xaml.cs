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

namespace Практическая_работа_Ресурсы_и_Стили
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double chislo;
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            chislo = Convert.ToDouble(txtBx1.Text);
            if (chislo == 1) 
            {
                lb2.Content = "Стекло не разбилось";           
            }
            if (chislo == 2)
            {
                lb2.Content = "Новое стекло вставлял папа Вовочки";
            }
            if (chislo == 3)
            {
                lb2.Content = "Стекло не разбилось";
            }
            if (chislo == 4)
            {
                lb2.Content = "Милиционеры вставляли новое стекло";
            }
            if (chislo == 5)
            {
                lb2.Content = "Новое стекло вставлял папа Вовочки";
            }
            if (chislo == 6)
            {
                lb2.Content = "Милиционеры вставляли новое стекло";
            }
            if (chislo == 7)
            {
                lb2.Content = "Милиционеры вставляли новое стекло";
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
