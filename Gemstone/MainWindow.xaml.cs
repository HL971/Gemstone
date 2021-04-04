using Gemstone.Classes.DTO;
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

namespace Gemstone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Gem gem;

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
    }
}
