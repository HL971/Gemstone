using Gemstone.Classes.DTO;
using Gemstone.Classes.Saving;
using System;
using System.Windows;

namespace Gemstone.Views
{
    /// <summary>
    /// Interaction logic for GemWindow.xaml
    /// </summary>
    public partial class GemWindow : Window
    {
        public GemWindow()
        {
            InitializeComponent();
            _documentSaver = new DocumentSaver();
        }

        private readonly DocumentSaver _documentSaver;
        public Gem gem;

        private bool CanSaveGem => gem != null;

        public double ClarityGrade => gem != null
            ? gem.ClarityGrade
            : 0.0;

        public double ColorGrade => gem != null
            ? gem.ColorGrade
            : 0.0;

        public double CutGrade => gem != null
            ? gem.CutGrade
            : 0.0;

        public double Size => gem != null
            ? gem.Size
            : 0.0;

        public double Value => gem != null
            ? gem.Value
            : 0.0;

        public string Description => gem != null
            ? gem.ToString()
            : "-";

        public void GenerateBtn_Click(Object sender, EventArgs e)
        {
            gem = new Gem();

            SizeText.Text = Size.ToString();
            CutGradeText.Text = CutGrade.ToString();
            ColorGradeText.Text = ColorGrade.ToString();
            ClarityGradeText.Text = ClarityGrade.ToString();
            ValueText.Text = Value.ToString();
            DescriptionText.Content = Description;
        }

        public void Save_Click(Object sender, EventArgs e)
        {
            try
            {
                _documentSaver.SaveSingleGemstone(Filename.Text, gem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has occurred");
            }
        }
    }
}
