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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Arkham_Horror
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            sanityAdd.Click += sanityAdd_Click;
            sanitySub.Click += sanitySub_Click;

            moneyAdd.Click += moneyAdd_Click;
            moneySub.Click += moneySub_Click;

            stamAdd.Click += stamAdd_Click;
            stamSub.Click += stamSub_Click;

            cluesAdd.Click += cluesAdd_Click;
            cluesSub.Click += cluesSub_Click;

            doomAdd.Click += doomAdd_Click;
            doomSub.Click += doomSub_Click;

            Application.Current.Suspending += Current_Suspending;

        }

        void Current_Suspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["sanity"] = sanityValue.Text;
            localSettings.Values["doom"] = doomValue.Text;
            localSettings.Values["stam"] = stamValue.Text;
            localSettings.Values["money"] = moneyValue.Text;
            localSettings.Values["clues"] = cluesValue.Text;
        }
        void loadSave()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            sanityValue.Text = (localSettings.Values["sanity"] != null ? localSettings.Values["sanity"] : 0).ToString();
            doomValue.Text = (localSettings.Values["doom"] != null ? localSettings.Values["doom"] : 0).ToString();
            stamValue.Text = (localSettings.Values["stam"] != null ? localSettings.Values["stam"] : 0).ToString();
            moneyValue.Text = (localSettings.Values["money"] != null ? localSettings.Values["money"] : 0).ToString();
            cluesValue.Text = (localSettings.Values["clues"] != null ? localSettings.Values["clues"] : 0).ToString();
        }

        void sanitySub_Click(object sender, RoutedEventArgs e)
        {
            sanityValue.Text = (int.Parse(sanityValue.Text) - 1).ToString();
        }

        void sanityAdd_Click(object sender, RoutedEventArgs e)
        {
            sanityValue.Text = (int.Parse(sanityValue.Text) + 1).ToString();
        }

        void moneySub_Click(object sender, RoutedEventArgs e)
        {
            moneyValue.Text = (int.Parse(moneyValue.Text) - 1).ToString();
        }

        void moneyAdd_Click(object sender, RoutedEventArgs e)
        {
            moneyValue.Text = (int.Parse(moneyValue.Text) + 1).ToString();
        }

        void cluesSub_Click(object sender, RoutedEventArgs e)
        {
            cluesValue.Text = (int.Parse(cluesValue.Text) - 1).ToString();
        }

        void cluesAdd_Click(object sender, RoutedEventArgs e)
        {
            cluesValue.Text = (int.Parse(cluesValue.Text) + 1).ToString();
        }

        void doomSub_Click(object sender, RoutedEventArgs e)
        {
            doomValue.Text = (int.Parse(doomValue.Text) - 1).ToString();
        }

        void doomAdd_Click(object sender, RoutedEventArgs e)
        {
            doomValue.Text = (int.Parse(doomValue.Text) + 1).ToString();
        }


        void stamSub_Click(object sender, RoutedEventArgs e)
        {
            stamValue.Text = (int.Parse(stamValue.Text) - 1).ToString();
        }

        void stamAdd_Click(object sender, RoutedEventArgs e)
        {
            stamValue.Text = (int.Parse(stamValue.Text) + 1).ToString();
        }

    }
}
