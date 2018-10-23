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

namespace NimGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        List<TextBlock> row1Blocks = new List<TextBlock>();
        List<TextBlock> row2Blocks = new List<TextBlock>();
        List<TextBlock> row3Blocks = new List<TextBlock>();
        List<TextBlock> row4Blocks = new List<TextBlock>();

        public MainWindow()
        {
            InitializeComponent();
            TextBlock t = new TextBlock();
            row1Blocks.Add(t);
            t.Text = "bob";
            WindowGrid.Children.Add(t);
            t.SetValue(Grid.RowProperty, 0);
            t.SetValue(Grid.ColumnProperty, 3);

        }

        int[] myArray = new int[4] {1, 3, 5, 7};

        private void Row1Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (row1Blocks.Count > 0)
            {
                WindowGrid.Children.Remove(row1Blocks[0]);
                row1Blocks.RemoveAt(0);
            }
        }
    }
}
