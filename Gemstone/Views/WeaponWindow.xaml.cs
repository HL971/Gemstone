using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using Gemstone.Classes.Saving;
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
    /// Interaction logic for WeaponWindow.xaml
    /// </summary>
    public partial class WeaponWindow : Window
    {
        public WeaponWindow()
        {
            InitializeComponent();
            _documentSaver = new DocumentSaver();
        }

        private void GenerateWeapon_Click(object sender, RoutedEventArgs e)
        {
            Weapon = WeaponGenerator.GetRandomBasicWeapon();
            UpdateDisplay();
        }

        private void SaveWeapon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _documentSaver.SaveSingleWeapon(Filename.Text, Weapon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has occurred");
            }
        }

        private void UpdateDisplay()
        {
            var text = Weapon.PlayerDocumentStrings();
            var textString = string.Empty;

            foreach (var line in text)
            {
                textString += line + '\n';
            }

            Display.Text = textString;
        }

        private Weapon Weapon { get; set; }
        private readonly DocumentSaver _documentSaver;
    }
}
