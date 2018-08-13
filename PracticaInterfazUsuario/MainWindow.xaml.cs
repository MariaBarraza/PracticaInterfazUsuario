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

namespace PracticaInterfazUsuario
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

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            lblPorcentajePropina.Text = Math.Round(sldPorcentajePropina.Value).ToString() + " %"; //poner en la etiqueta el valor actual del slider convirtiendolo de double a string y redondenadola con math.round
            float total = float.Parse(txtTotal.Text); //transforma el valor de texto a float
            float porcentajePropina = (float) Math.Round(sldPorcentajePropina.Value); // (float) casteo sencillo para poder usar un double como float
            float propina = total * (porcentajePropina / 100); //calcular propina
            float totalConPropina = total + propina;
            lblResultadoPropina.Text = "$ " + propina.ToString(); //se muestra el resultado en las etiquetas volviendolos string
            lblResultadoTotalConPropina.Text = "$ " + totalConPropina.ToString();
        }
    }
}
