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
                if (Operador.Text.Equals("+"))
                {
                    Resultado.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) + Convert.ToInt32(Operando2.Text));
                }
                else if (Operador.Text.Equals("-"))
                {
                    Resultado.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) - Convert.ToInt32(Operando2.Text));
                }

                else if (Operador.Text.Equals("*"))
                {
                    Resultado.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) * Convert.ToInt32(Operando2.Text));
                }
                else if (Operador.Text.Equals("/"))
                {
                    Resultado.Text = Convert.ToString(Convert.ToInt32(Operando1.Text) / Convert.ToInt32(Operando2.Text));
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Button_Limpiar(object sender, RoutedEventArgs e)
        {
            Operando1.Clear();
            Operando2.Clear();
            Operador.Clear();
            Resultado.Clear();
        }

        private void EntradaTexto (object sender, RoutedEventArgs e)
        {
            ComprobarOperador();
        }

        private void ComprobarOperador()
        {
            try { 
            if (Operador.Text.Equals("+") || Operador.Text.Equals("-")
                || Operador.Text.Equals("*") || Operador.Text.Equals("/"))
            {
                Calcular.IsEnabled = true;
            }
            else
            {
                Calcular.IsEnabled = false;
            }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
