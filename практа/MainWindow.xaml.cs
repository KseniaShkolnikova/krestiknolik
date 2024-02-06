using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace практа
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        Button[] buttons;
        int i = 0;
        int knopka;
        MessageBoxResult result;
        int qwe = 0;
        int xor0 = 0;
        public MainWindow()
        {
            InitializeComponent();
            buttons= new Button[9] {_1,_2,_3,_4,_5,_6,_7,_8,_9};
        }
        private void proverkX(object sender, int i)
        {
            if ((_1 as Button).Content=="X" && (_2 as Button).Content == "X" && (_3 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?","X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_4 as Button).Content == "X" && (_5 as Button).Content == "X" && (_6 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_7 as Button).Content == "X" && (_8 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_1 as Button).Content == "X" && (_5 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_3 as Button).Content == "X" && (_5 as Button).Content == "X" && (_7 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_1 as Button).Content == "X" && (_4 as Button).Content == "X" && (_7 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                povtor();
            }
            else if ((_2 as Button).Content == "X" && (_5 as Button).Content == "X" && (_8 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?", "X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if ((_3 as Button).Content == "X" && (_6 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                result = MessageBox.Show("Повторить?","X выиграли!", MessageBoxButton.YesNo);
                qwe = 1;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[0].Content == "0" && buttons[1].Content == "0" && buttons[2].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[3].Content == "0" && buttons[4].Content == "0" && buttons[5].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[6].Content == "0" && buttons[7].Content == "0" && buttons[8].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[0].Content == "0" && buttons[3].Content == "0" && buttons[6].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[1].Content == "0" && buttons[4].Content == "0" && buttons[7].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[2].Content == "0" && buttons[5].Content == "0" && buttons[8].Content == "0")
            {

                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[0].Content == "0" && buttons[4].Content == "0" && buttons[8].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (buttons[2].Content == "0" && buttons[4].Content == "0" && buttons[6].Content == "0")
            {
                result = MessageBox.Show("Повторить?", "0 выиграли!", MessageBoxButton.YesNo);
                qwe = 2;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
            else if (i==9)
            {
                result = MessageBox.Show("Повторить?", "ничья", MessageBoxButton.YesNo);
                qwe = 3;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                povtor();
            }
        }
        private void robot(object sender)
        {
            if (i==9)
            {
                return;
            }
            else
            {
                knopka = rand.Next(0, 9);
                while (buttons[knopka].IsEnabled == false && i != 9)
                {
                    knopka = rand.Next(0, 9);
                }
                if (xor0 % 2==0)
                {
                    buttons[knopka].Content = "0";
                    buttons[knopka].IsEnabled = false;
                }
                else
                {
                    buttons[knopka].Content = "X";
                    buttons[knopka].IsEnabled = false;
                }
               
                i++;
            }
        }
        private void igrok(object sender)
        {
            if (xor0 % 2 == 0)
            {
                (sender as Button).Content = "X";
                (sender as Button).IsEnabled = false;
            }
            else
            {
                (sender as Button).Content = "0";
                (sender as Button).IsEnabled = false;
            }
        }
        private void prostoClick(object sender, RoutedEventArgs e)
        {       
            igrok(sender);         
            robot(sender);
            i++;
            proverkX(sender,i);
        }
        private void povtor()
        {
            xor0 = xor0 + 1;
            pobeda();
            if (result == MessageBoxResult.Yes)
            {
                i = 0;
                for (int k = 0; k != 9; k++)
                {
                    buttons[k].Content = null;
                    buttons[k].IsEnabled = false;
                }
                start.IsEnabled = true;
            }
            else if (result == MessageBoxResult.No)
            {
                Environment.Exit(0);
            }
        }
        private void pobeda()
        {
            string text ="";
            if (qwe == 1)
            {
                 text = pobed.Text + "\nПобедили Крестики !!!!";
            }
            else if (qwe == 2)
            {
                text = pobed.Text + "\nПобедили Нолики !!!!";
            }
            else if (qwe == 3)
            {
                text = pobed.Text + "\nНичья";
            }
            pobed.Text = text;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            for (int k = 0; k != 9; k++)
            {
                buttons[k].Content = null;
                buttons[k].IsEnabled = true;
            }
            start.IsEnabled = false;
            if (xor0 % 2 !=0)
            {
                robot(sender);
            }
        }
    }
}
