using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SplashScreen.Droid
{
    [Activity(Label = "SplashScreenActivity", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash", ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation)]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var main = new Intent(this, typeof(MainActivity));
            StartActivity(main);
            Finish();
        }
    }
}