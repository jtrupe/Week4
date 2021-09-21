/// Week 4 Lab 1
///
/// @author: Julian Trupe
/// Date:  September 13, 2021
///
/// Problem Statement: Write a GUI using WPF which takes a first and last name and translates to pig latin
/// 
/// Overall Plan:
/// 1) Make two text boxes and a button
/// 2) get names from text boxes
/// 3) click button to translate names to pig latin
/// 4) Display translated name to user in a message box
/// 


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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string pigFirst = PigTranslator(firstName);
            string pigLast = PigTranslator(lastName);

            MessageBox.Show("Your name in Pig Latin is " + pigFirst + " " + pigLast);
        }

        static string PigTranslator(string str)
        {
            str = str.ToLower();
            string pig, temp;
            temp = str[0].ToString();
            pig = str.Substring(1) + temp + "ay";
            temp = pig[0].ToString().ToUpper();
            pig = temp + pig.Substring(1);
            return pig;
        }
    }
}
