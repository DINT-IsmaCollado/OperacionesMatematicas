﻿using System;
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

namespace OperacionesMatematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Calculos por si cambia los operadores
        private void Operando_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RadioSuma.IsChecked == true)
                ResultadoOperando.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) + Convert.ToInt32(Operando2.Text));
            if (RadioResta.IsChecked == true)
                ResultadoOperando.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) - Convert.ToInt32(Operando2.Text));
            if (RadioMultiplicacion.IsChecked == true)
                ResultadoOperando.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) * Convert.ToInt32(Operando2.Text));
            if (RadioDivision.IsChecked == true)
                ResultadoOperando.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) / Convert.ToInt32(Operando2.Text));
        }

        // Calculos por si cambia las operacioens
        private void RadioSuma_Checked(object sender, RoutedEventArgs e)
        {
            int operando1 = Convert.ToInt32(Operando1.Text);
            int operando2 = Convert.ToInt32(Operando2.Text);
            ResultadoOperando.Text = Convert.ToString(operando1 + operando2);
        }

        private void RadioResta_Checked(object sender, RoutedEventArgs e)
        {
            int operando1 = Convert.ToInt32(Operando1.Text);
            int operando2 = Convert.ToInt32(Operando2.Text);
            ResultadoOperando.Text = Convert.ToString(operando1 - operando2);
        }

        private void RadioMultiplicacion_Checked(object sender, RoutedEventArgs e)
        {
            int operando1 = Convert.ToInt32(Operando1.Text);
            int operando2 = Convert.ToInt32(Operando2.Text);
            ResultadoOperando.Text = Convert.ToString(operando1 * operando2);
        }

        private void RadioDivision_Checked(object sender, RoutedEventArgs e)
        {
            int operando1 = Convert.ToInt32(Operando1.Text);
            int operando2 = Convert.ToInt32(Operando2.Text);
            ResultadoOperando.Text = Convert.ToString(operando1 / operando2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioSuma.IsChecked = false;
            RadioResta.IsChecked = false;
            RadioMultiplicacion.IsChecked = false;
            RadioDivision.IsChecked = false;
            Operando1.Text = "0";
            Operando2.Text = "0";
            ResultadoOperando.Text = "0";

        }
    }
}
