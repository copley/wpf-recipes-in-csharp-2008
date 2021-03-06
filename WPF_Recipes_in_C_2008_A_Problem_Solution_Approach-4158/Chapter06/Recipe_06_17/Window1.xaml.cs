﻿using System.Windows;
using System.Windows.Controls;

namespace Recipe_06_17
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Finding the border that is generated by the 
            // ControlTemplate of the Button
            //
            Border borderInTemplate = (Border)
                button.Template.FindName("border", button);

            // Do something to the ControlTemplate-generated border
            //
            MessageBox.Show(
              "The actual width of the border in the ControlTemplate: "
              + borderInTemplate.GetValue(Border.ActualWidthProperty));
        }
    }
}
