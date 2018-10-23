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

            for (int i = 0; i < 16; i++)
            {
                if (i == 0)
                {
                    TextBlock t = new TextBlock();
                    row1Blocks.Add(t);
                    t.Text = "Tændstik";
                    WindowGrid.Children.Add(t);
                    t.SetValue(Grid.RowProperty, 0);
                    t.SetValue(Grid.ColumnProperty, i + 3);
                }
                else if (i <= 3)
                {
                    TextBlock t = new TextBlock();
                    row2Blocks.Add(t);
                    t.Text = "Tændstik";
                    WindowGrid.Children.Add(t);
                    t.SetValue(Grid.RowProperty, 1);
                    t.SetValue(Grid.ColumnProperty, i + 1);
                }
                else if (i <= 8)
                {
                    TextBlock t = new TextBlock();
                    row3Blocks.Add(t);
                    t.Text = "Tændstik";
                    WindowGrid.Children.Add(t);
                    t.SetValue(Grid.RowProperty, 2);
                    t.SetValue(Grid.ColumnProperty, i - 3);
                }
                else
                {
                    TextBlock t = new TextBlock();
                    row4Blocks.Add(t);
                    t.Text = "Tændstik";
                    WindowGrid.Children.Add(t);
                    t.SetValue(Grid.RowProperty, 3);
                    t.SetValue(Grid.ColumnProperty, i - 9);
                }
            }
        }

        private void Row1Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (row1Blocks.Count > 0)
            {
                WindowGrid.Children.Remove(row1Blocks[0]);
                row1Blocks.RemoveAt(0);
            }
        }

        private void Row2Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (row2Blocks.Count > 0)
            {
                WindowGrid.Children.Remove(row2Blocks[0]);
                row2Blocks.RemoveAt(0);
            }
        }

        private void Row3Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (row3Blocks.Count > 0)
            {
                WindowGrid.Children.Remove(row3Blocks[0]);
                row3Blocks.RemoveAt(0);
            }
        }

        private void Row4Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (row4Blocks.Count > 0)
            {
                WindowGrid.Children.Remove(row4Blocks[0]);
                row4Blocks.RemoveAt(0);
            }
        }

        private void NextTurnButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
