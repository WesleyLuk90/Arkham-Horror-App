using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Arkham_Horror
{
    public sealed partial class PlusMinusControl : UserControl
    {

        public PlusMinusControl()
        {
            this.InitializeComponent();
            controlAdd.Click += controlAdd_Click;
            controlSub.Click += controlSub_Click;
        }

        void controlSub_Click(object sender, RoutedEventArgs e)
        {
            Value = Math.Max(0, Value - 1);
        }

        void controlAdd_Click(object sender, RoutedEventArgs e)
        {
            Value = Math.Min(Value + 1, MaxValue);
        }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public int Value
        {
            get { return int.Parse(GetValue(ValueProperty).ToString()); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public int MaxValue
        {
            get { return int.Parse(GetValue(MaxValueProperty).ToString()); }
            set { SetValue(MaxValueProperty, value); }
        }
    }
}
