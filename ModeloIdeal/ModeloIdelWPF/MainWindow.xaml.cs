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
using ModeloIdeal.Application.Interface;
using ModeloIdeal.Domain.Entidade;
using Ninject;

namespace ModeloIdelWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IContContContabilApplication _contContContabilApplication;
        
        public MainWindow(IContContContabilApplication contContContabilApplication)
        {
            _contContContabilApplication = contContContabilApplication;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(_contContContabilApplication.IsValid(new ContContabil(){CoCo_Codigo = 10, CoCo_Nome = "thiago"}).ToString());
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_contContContabilApplication.IsValid(new ContContabil() { CoCo_Codigo = 10, CoCo_Nome = "" }).ToString());
        }
    }
}
