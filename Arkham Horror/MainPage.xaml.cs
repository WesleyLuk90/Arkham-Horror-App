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

            Application.Current.Suspending += Current_Suspending;
            loadValues();

        }

        void Current_Suspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
            saveValues();
        }
        void loadValues()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (localSettings.Values["sanity_value"] != null) sanityControl.Value = int.Parse(localSettings.Values["sanity_value"].ToString());
            if (localSettings.Values["sanity_max"] != null) sanityControl.MaxValue = int.Parse(localSettings.Values["sanity_max"].ToString());
            if (localSettings.Values["stamina_value"] != null) staminaControl.Value = int.Parse(localSettings.Values["stamina_value"].ToString());
            if (localSettings.Values["stamina_max"] != null) staminaControl.MaxValue = int.Parse(localSettings.Values["stamina_max"].ToString());
            if (localSettings.Values["money_value"] != null) moneyControl.Value = int.Parse(localSettings.Values["money_value"].ToString());
            if (localSettings.Values["money_max"] != null) moneyControl.MaxValue = int.Parse(localSettings.Values["money_max"].ToString());
            if (localSettings.Values["clues_value"] != null) cluesControl.Value = int.Parse(localSettings.Values["clues_value"].ToString());
            if (localSettings.Values["clues_max"] != null) cluesControl.MaxValue = int.Parse(localSettings.Values["clues_max"].ToString());
            if (localSettings.Values["doom_value"] != null) doomControl.Value = int.Parse(localSettings.Values["doom_value"].ToString());
            if (localSettings.Values["doom_max"] != null) doomControl.MaxValue = int.Parse(localSettings.Values["doom_max"].ToString());

            if (localSettings.Values["ss_first"] != null) speedSneakSlider.FirstValue = int.Parse(localSettings.Values["ss_first"].ToString());
            if (localSettings.Values["ss_offset"] != null) speedSneakSlider.Offset = int.Parse(localSettings.Values["ss_offset"].ToString());
            if (localSettings.Values["ss_second"] != null) speedSneakSlider.SecondValue = int.Parse(localSettings.Values["ss_second"].ToString());
            if (localSettings.Values["fw_first"] != null) fightWillSlider.FirstValue = int.Parse(localSettings.Values["fw_first"].ToString());
            if (localSettings.Values["fw_offset"] != null) fightWillSlider.Offset = int.Parse(localSettings.Values["fw_offset"].ToString());
            if (localSettings.Values["fw_second"] != null) fightWillSlider.SecondValue = int.Parse(localSettings.Values["fw_second"].ToString());
            if (localSettings.Values["ll_first"] != null) loreLuckSlider.FirstValue = int.Parse(localSettings.Values["ll_first"].ToString());
            if (localSettings.Values["ll_offset"] != null) loreLuckSlider.Offset = int.Parse(localSettings.Values["ll_offset"].ToString());
            if (localSettings.Values["ll_second"] != null) loreLuckSlider.SecondValue = int.Parse(localSettings.Values["ll_second"].ToString());
        }
        void saveValues()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["sanity_value"] = sanityControl.Value;
            localSettings.Values["sanity_max"] = sanityControl.MaxValue;
            localSettings.Values["stamina_value"] = staminaControl.Value;
            localSettings.Values["stamina_max"] = staminaControl.MaxValue;
            localSettings.Values["money_value"] = moneyControl.Value;
            localSettings.Values["money_max"] = moneyControl.MaxValue;
            localSettings.Values["clues_value"] = cluesControl.Value;
            localSettings.Values["clues_max"] = cluesControl.MaxValue;
            localSettings.Values["doom_value"] = doomControl.Value;
            localSettings.Values["doom_max"] = doomControl.MaxValue;

            localSettings.Values["ss_first"] = speedSneakSlider.FirstValue;
            localSettings.Values["ss_offset"] = speedSneakSlider.Offset;
            localSettings.Values["ss_second"] = speedSneakSlider.SecondValue;
            localSettings.Values["fw_first"] = fightWillSlider.FirstValue;
            localSettings.Values["fw_offset"] = fightWillSlider.Offset;
            localSettings.Values["fw_second"] = fightWillSlider.SecondValue;
            localSettings.Values["ll_first"] = loreLuckSlider.FirstValue;
            localSettings.Values["ll_offset"] = loreLuckSlider.Offset;
            localSettings.Values["ll_second"] = loreLuckSlider.SecondValue;
        }

    }
}
