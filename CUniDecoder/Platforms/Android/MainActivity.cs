﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CUniDecoder
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnPostCreate(Bundle? savedInstanceState)
        {
            try
            {

                base.OnPostCreate(savedInstanceState);
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
