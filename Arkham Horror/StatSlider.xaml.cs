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
    public sealed partial class StatSlider : UserControl
    {
        public StatSlider()
        {
            this.InitializeComponent();
            Offset = 0;
            statsLeft.Click += statsLeft_Click;
            statsRight.Click += statsRight_Click;
            UpdateValues();
        }

        void UpdateValues()
        {
            if (Offset < MinOffset())
            {
                Offset = MinOffset();
            }
            if (Offset > MaxOffset())
            {
                Offset = MaxOffset();
            }
            topValueText.Text = (FirstValue + Offset).ToString();
            bottomValueText.Text = (SecondValue - Offset).ToString();
        }
        int MinOffset()
        {
            return Math.Min(0, SecondValue - FirstValue);
        }
        int MaxOffset()
        {
            return Math.Max(0, SecondValue - FirstValue);
        }

        void statsLeft_Click(object sender, RoutedEventArgs e)
        {
            Offset--;
            UpdateValues();
        }

        void statsRight_Click(object sender, RoutedEventArgs e)
        {
            Offset++;
            UpdateValues();
        }

        public static readonly DependencyProperty FirstLabelProperty = DependencyProperty.Register("FirstLabel", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public string FirstLabel
        {
            get { return (string)GetValue(FirstLabelProperty); }
            set { SetValue(FirstLabelProperty, value); }
        }

        public static readonly DependencyProperty SecondLabelProperty = DependencyProperty.Register("SecondLabel", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public string SecondLabel
        {
            get { return (string)GetValue(SecondLabelProperty); }
            set { SetValue(SecondLabelProperty, value); }
        }

        public static readonly DependencyProperty FirstValueProperty = DependencyProperty.Register("FirstValue", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public int FirstValue
        {
            get { return int.Parse(GetValue(FirstValueProperty).ToString()); }
            set { SetValue(FirstValueProperty, value); UpdateValues(); }
        }

        public static readonly DependencyProperty SecondValueProperty = DependencyProperty.Register("SecondValue", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public int SecondValue
        {
            get { return int.Parse(GetValue(SecondValueProperty).ToString()); }
            set { SetValue(SecondValueProperty, value); UpdateValues(); }
        }

        public static readonly DependencyProperty OffsetProperty = DependencyProperty.Register("Offset", typeof(int), typeof(PlusMinusControl), new PropertyMetadata(0));
        public int Offset
        {
            get { return int.Parse(GetValue(OffsetProperty).ToString()); }
            set { SetValue(OffsetProperty, value); UpdateValues(); }
        }
    }
}
