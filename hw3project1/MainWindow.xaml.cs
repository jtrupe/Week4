/// Homework 3 Project 1 
///
/// @author: Julian Trupe
/// Date:  September 20, 2021
///
/// Problem Statement: Write a GUI using WPF which makes mortgage calculations based on user input
//
/// Overall Plan:
/// 1) Make two text boxes and a button
/// 2) Get numbers from text boxes
/// 3) Calculate the amount of payment for interest and for reducing the principal
/// 4) Display these payment amounts to user in a message box
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

namespace hw3project1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float principal = float.Parse(principalTextBox.Text);
            float monthlyPayment = float.Parse(paymentTextBox.Text);
            double interestRate = (6.39/12)/100;
            double principalInterest = Math.Round(principal * (1 + interestRate) - principal, 2);
            double paymentToPrincipal = Math.Round(monthlyPayment - principalInterest, 2);

            MessageBox.Show("You paid $" + String.Format("{0:0.00}", principalInterest) + " for interest and $" + String.Format("{0:0.00}", paymentToPrincipal) + " to reduce your principal");
        }
    }
}
