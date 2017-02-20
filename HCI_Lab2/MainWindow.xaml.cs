using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace HCI_Lab2
{
    /// <summary>
    /// Application, which is shown in Figure 2, has many different functions.
    /// At the top of the window - the edit field 
    /// "Enter a Message", in which the user can enter a message that is
    /// shown in the message box when the user presses the button
    ///  "Show Message". Below - two buttons that fill the text box by the
    ///  pecified default message or clear it. Below – the opening list that
    ///  contains the Windows standard applications list. When the user
    /// selects one of these programs, and then presses the "Run
    /// Program", then the chosen program is performed. Below – two
    /// groups of flags related to control elements that are located at the
    /// top.Left set of flags "Enable Actions" makes available or not
    /// each group of control elements that are located above.Right set
    /// of flags "Show Actions" hide or not each group of control
    /// elements.Button "Exit" of the dialog box is used to close the
    /// application.
    /// 1. Explore the main Windows control elements.
    /// 2. Create an interface as shown in Fig.. 2.
    /// 3. Add to the Default Message button the following code so that
    /// the text box value looks like "Enter a message here".
    /// 4. Add the following code to make available or unavailable(show
    /// or hide) the control elements that are associated with performing
    /// and choosing another application.
    /// 5. Expand the code so that the user can enter own names of
    /// programs that are needed to perform.
    /// 6. Add to created interface performing of functions according to
    /// the variant(Table 4)
    /// 14. Change the flags in the group Enable Actions to the switches so
    /// that control elements of groups Message or Program are
    /// available.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextBox.Text == "")
            {
                MessageBox.Show("Message Text Box is empty.","Error",MessageBoxButton.OK,MessageBoxImage.Exclamation);
                MessageTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                MessageBox.Show(MessageTextBox.Text);
                MessageTextBox.BorderBrush = Brushes.LightGray;
            }
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
                            MessageBox.Show("Combo Box is empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            ProgramProcessComboBox.BorderBrush = Brushes.Red;
                            break;
                        }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Combo Box is empty.","Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                ProgramProcessComboBox.BorderBrush = Brushes.Red;
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
