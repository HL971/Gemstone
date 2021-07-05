using System;
using System.Windows;

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

        public void OnlyWeapon_Click(Object sender, EventArgs e)
        {
            var window = new WeaponWindow();
            window.Show();
        }
    }
}
