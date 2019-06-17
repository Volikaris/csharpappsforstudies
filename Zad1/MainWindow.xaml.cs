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

namespace Zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        myStack ms = new myStack();
        public MainWindow()
        {
            ms.myStackMain();
            InitializeComponent();
            print1.Click += Print1_Click;
            push1.Click += Push1_Click;
            pop1.Click += Pop1_Click;
            clear1.Click += Clear1_Click;
            top1.Click += Top1_Click;
            total1.Click += Total1_Click;
            empty1.Click += Empty1_Click;
        }
        private void Empty1_Click(object sender, RoutedEventArgs e)
        {
            if (ms.isEmpty())
            {
                print2a.Text = "Stack is empty.";
            }
            else
            {
                print2a.Text = "Stack is not empty.";
            }
        }
        private void Total1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Total number of items created: " + ms.getTotalCount());
            print2a.Text = "Total number of items created: " + ms.getTotalCount() + " / " + "Number of existing stack items: " + ms.getCount();
            Console.WriteLine("Number of existing stack items: " + ms.getCount());
        }
        private void Clear1_Click(object sender, RoutedEventArgs e)
        {
            print2a.Text = ms.NClear();
        }
        private void Top1_Click(object sender, RoutedEventArgs e)
        {
            print2a.Text = ms.Top();
        }
        private void Pop1_Click(object sender, RoutedEventArgs e)
        {
            print2a.Text = ms.NPop();
        }
        private void Push1_Click(object sender, RoutedEventArgs e)
        {
            ms.NPush(ms.getCount() + ". " + push2.Text);
            print2a.Text = "Stack pushed with item: " + (ms.getCount() -1) + ". " + push2.Text;
        }
        private void Print1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Stack values:");
            print2a.Text = ms.PrintValues(ms.getStack());
        }
    }
}
