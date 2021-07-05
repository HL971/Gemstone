using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using Gemstone.Classes.Saving;
using System;
using System.Windows;

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
            Weapon = WeaponGenerator.GetCompletelyRandomWeapon();
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
