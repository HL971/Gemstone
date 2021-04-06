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
using System.Windows.Shapes;

namespace Gemstone.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        public void SingleGemstone_Click(Object sender, EventArgs e)
        {
            var window = new GemWindow();
            window.Show();
        }

        public void OnlyCurrency_Click(Object sender, EventArgs e)
        {
            var window = new CurrencyGeneratorView();
            window.Show();
        }
    }
}
