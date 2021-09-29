using System;
using System.Windows;

namespace CalculadoraBasica
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

        private void Button_Calcular(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OperadorTextBox.Text.Equals("+"))
                {
                    ResultadoTextBox.Text = Convert.ToString(Convert.ToInt32(Operando1TextBox.Text) + Convert.ToInt32(Operando2TextBox.Text));
                }
                else if (OperadorTextBox.Text.Equals("-"))
                {
                    ResultadoTextBox.Text = Convert.ToString(Convert.ToInt32(Operando1TextBox.Text) - Convert.ToInt32(Operando2TextBox.Text));
                }

                else if (OperadorTextBox.Text.Equals("*"))
                {
                    ResultadoTextBox.Text = Convert.ToString(Convert.ToInt32(Operando1TextBox.Text) * Convert.ToInt32(Operando2TextBox.Text));
                }
                else if (OperadorTextBox.Text.Equals("/"))
                {
                    ResultadoTextBox.Text = Convert.ToString(Convert.ToInt32(Operando1TextBox.Text) / Convert.ToInt32(Operando2TextBox.Text));
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Button_Limpiar(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }

        private void EntradaTexto (object sender, RoutedEventArgs e)
        {
            ComprobarOperador();
        }

        private void ComprobarOperador()
        {
            if (OperadorTextBox.Text.Equals("+") || OperadorTextBox.Text.Equals("-")
                || OperadorTextBox.Text.Equals("*") || OperadorTextBox.Text.Equals("/"))
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}
