using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HCI_Lab2
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextBox.Text == "") MessageBox.Show("Message Text Box is empry.");
            else MessageBox.Show(MessageTextBox.Text);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBox.Text = "Please, enter a message here...";
        }

        private void clButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBox.Text = "";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ProgramProcessComboBox.Items.Add("Calculator");
            ProgramProcessComboBox.Items.Add("Paint");
            ProgramProcessComboBox.Items.Add("Notepad");
            ProgramProcessComboBox.Items.Add("Internet Explorer");
            ProgramProcessComboBox.Items.Add("Wordpad");
        }

        private void progExecuterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (ProgramProcessComboBox.SelectedValue.ToString())
                {
                    case "Notepad":
                        {
                            Process.Start("notepad.exe");
                            break;
                        }
                    case "Calculator":
                        {
                            Process.Start("calc.exe");
                            break;
                        }
                    case "Paint":
                        {
                            Process.Start("mspaint.exe");
                            break;
                        }
                    case "Internet Explorer":
                        {
                            Process.Start("IExplore.exe");
                            break;
                        }
                    case "Wordpad":
                        {
                            Process.Start("wordpad.exe");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Combo Box is empty.");
                            break;
                        }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Combo Box is empty.");
            }
            

        }

        private void messageActions_Click(object sender, RoutedEventArgs e)
        {
            if (MessageActionsCheckBox.IsChecked == true)
            {
                EnterMessageGroupBox.IsEnabled = true;
            }
            else if (MessageActionsCheckBox.IsChecked == false)
            {
                EnterMessageGroupBox.IsEnabled = false;
            }
        }

        private void enableProgActions_Click(object sender, RoutedEventArgs e)
        {
            if (EnableProgActionsCheckBox.IsChecked == true)
            {
                ProgramGroupBox.IsEnabled = true;
            }
            else if (EnableProgActionsCheckBox.IsChecked == false)
            {
                ProgramGroupBox.IsEnabled = false;
            }
        }

        private void ShowMessAction_Click(object sender, RoutedEventArgs e)
        {
            if (MessageGrid.Visibility == System.Windows.Visibility.Hidden)
            {
                MessageGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else if (MessageGrid.Visibility == System.Windows.Visibility.Visible)
            {
                MessageGrid.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void ShowProgActions_Click(object sender, RoutedEventArgs e)
        {
            if (ProgramGrid.Visibility == System.Windows.Visibility.Hidden)
            {
                ProgramGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else if (ProgramGrid.Visibility == System.Windows.Visibility.Visible)
            {
                ProgramGrid.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Enable_groups_actions_Click(object sender, RoutedEventArgs e)
        {
            if (EnableGroupsActions.IsChecked == true)
            {
                ActionsGroupBox.IsEnabled = true;
                ShowActionsGroupBox.IsEnabled = true;
            }
            else if (EnableGroupsActions.IsChecked == false)
            {
                ActionsGroupBox.IsEnabled = false;
                ShowActionsGroupBox.IsEnabled = false;
            }
        }
    }
}
