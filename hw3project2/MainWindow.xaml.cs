/// Homework 3 Project 2
///
/// @author: Julian Trupe
/// Date:  September 20, 2021
///
/// Problem Statement: Write a GUI using WPF to calculate vending machine change based on user input
/// 
/// Overall Plan:
/// 1) Draw instruction messages
/// 2) Get input into text box
/// 3) use a series of if statements to determine change
/// 4) Append message for each coin to be dispensed
/// 5) Display change to user in a message box
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

namespace hw3project2
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
            int quartersChange, quartersRemainder, dimesChange, dimesRemainder, nickelsChange, nickelsRemainder, penniesChange = 0;
            String message = "Your change will be ";
            int myDolla = 100;
            int itemCost = Int32.Parse(itemCostBox.Text);
            int totalChange = myDolla - itemCost;
            quartersChange = totalChange / 25;
            quartersRemainder = totalChange % 25;
            message += quartersChange + " quarters";
            if(quartersRemainder > 0)
            {
                dimesChange = quartersRemainder / 10;
                dimesRemainder = quartersRemainder % 10;
                Console.WriteLine(dimesChange);
                if (dimesChange > 0) {
                    message += ", " + dimesChange + " dimes";
                }
                if(dimesRemainder > 0)
                {
                    nickelsChange = dimesRemainder / 5;
                    nickelsRemainder = dimesRemainder % 5;
                    
                    if(nickelsChange > 0)
                    {
                        message += ", " + nickelsChange + " nickels";
                    }
                    if(nickelsRemainder > 0)
                    {
                        penniesChange = nickelsRemainder;
                        if(penniesChange > 0)
                        {
                            message += ", and " + penniesChange + " pennies";
                        }
                    }
                }
                MessageBox.Show(message);
            }
        }
    }
}
