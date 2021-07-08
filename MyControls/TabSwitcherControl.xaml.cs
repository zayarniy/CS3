using System;
using System.Collections.Generic;

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyControls
{
    /// <summary>
    /// Interaction logic for TabSwitcherControl.xaml
    /// </summary>
    public partial class TabSwitcherControl : UserControl
    {

        public static readonly DependencyProperty PrevTextProperty = DependencyProperty.Register("PrevText", typeof(string), typeof(TabSwitcherControl));
        public static readonly DependencyProperty NextTextProperty = DependencyProperty.Register("NextText", typeof(string), typeof(TabSwitcherControl));


        public static readonly RoutedEvent btnPrevClickEvent = EventManager.RegisterRoutedEvent("btnPrevClick2", RoutingStrategy.Bubble, typeof(CanExecuteRoutedEventHandler), typeof(TabSwitcherControl));

        public event RoutedEventHandler btnPrevClick2
        {
            add { AddHandler(btnPrevClickEvent, value); }
            remove { RemoveHandler(btnPrevClickEvent, value); }
        }

        private string prevText = "Prev";

        public TabSwitcherControl()
        {
            InitializeComponent();
        }

        public string PrevText 
        {            
            get
            {
                return (string)GetValue(PrevTextProperty);
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("Try set PrevText:"+value);

                SetValue(PrevTextProperty, value);
            }
        }
        public string NextText { get; set; } = "Next";

        public event RoutedEventHandler btnNextClick;
        public event RoutedEventHandler btnPrevClick;

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Next");
            btnNextClick?.Invoke(sender, e);
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Prev");
            //btnPrevClick?.Invoke(sender, e);
            RoutedEventArgs args = new RoutedEventArgs(btnPrevClickEvent);
            RaiseEvent(args);

        }
    }
}
