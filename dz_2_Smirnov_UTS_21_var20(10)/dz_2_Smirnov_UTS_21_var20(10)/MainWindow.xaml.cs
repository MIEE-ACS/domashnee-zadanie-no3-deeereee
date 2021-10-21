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

namespace dz_2_Smirnov_UTS_21_var20_10_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb_output.Clear();
            string d = tb_input.Text;
            string[] words = d.Split(' ');


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0)
                {
                    // words[i] = new string(words[i].ToArray());
                    char a = words[i][words[i].Length - 1];
                    if (Char.IsLetterOrDigit(a))
                    {
                        words[i] = new string(words[i].Reverse().ToArray());
                        tb_output.Text += words[i] + " ";
                    }
                    else
                    {
                        words[i] = words[i].Remove(words[i].Length - 1);
                        words[i] = new string(words[i].Reverse().ToArray());
                        tb_output.Text += words[i] + a + " ";
                    }
                }
            }
            
          
        }

       
    }
}
