using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using Gemstone.Classes.Saving;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Gemstone.Views
{
    /// <summary>
    /// Interaction logic for CurrencyGeneratorView.xaml
    /// </summary>
    public partial class CurrencyGeneratorView : Window
    {
        public string PreviewString => Coinpurses.Count + " Coinpurses valued at " + PurseValue + " Gp";

        private readonly DocumentSaver _documentSaver;
        private List<Currency> Coinpurses;

        private double PurseValue
        {
            get
            {
                double value = 0.0;
                foreach (var purse in Coinpurses)
                {
                    value += purse.Value;
                }
                return value;
            }
        }

        public CurrencyGeneratorView()
        {
            InitializeComponent();
            Coinpurses = new List<Currency>();
            _documentSaver = new DocumentSaver();
            UpdateLabel();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var isInt = int.TryParse(e.Text, out _);

            e.Handled = !(isInt || e.Text.Equals(string.Empty));
        }

        private void UpdateLabel()
        {
            DisplayText.Content = PreviewString;
        }

        public void GenerateCurrency_Click(Object sender, EventArgs e)
        {
            if (QuantityText.Text.Equals(string.Empty))
            {
                MessageBox.Show("Quantity Cannot Be Blank", "An Error has occurred");
                return;
            }

            if (LevelText.Text.Equals(string.Empty))
            {
                MessageBox.Show("Level Cannot Be Blank", "An Error has occurred");
                return;
            }

            var qty = int.Parse(QuantityText.Text);
            var lvl = int.Parse(LevelText.Text);

            if (qty < 0)
            {
                MessageBox.Show("Quantity Cannot Be Less Than Zero", "An Error has occurred");
                return;
            }

            if (lvl < 0)
            {
                MessageBox.Show("Level Cannot Be Less Than Zero", "An Error has occurred");
                return;
            }

            for (int x = 0; x < qty; x++)
            {
                Coinpurses.Add(CurrencyGenerator.GenerateForLevel(lvl));
            }

            UpdateLabel();
        }

        public void MergeCurrency_Click(Object sender, EventArgs e)
        {
            if (Coinpurses.Count < 2)
                return;

            var newPurse = new Currency();

            foreach (var purse in Coinpurses)
            {
                newPurse.Merge(purse);
            }

            Coinpurses.Clear();
            Coinpurses.Add(newPurse);

            UpdateLabel();
        }

        public void SaveCurrency_Click(Object sender, EventArgs e)
        {
            try
            {
                _documentSaver.SaveCoinpurses(FilenameTxt.Text, Coinpurses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has occurred");
            }
        }

        public void ClearCurrency_Click(Object sender, EventArgs e)
        {
            Coinpurses.Clear();

            UpdateLabel();
        }
    }
}
