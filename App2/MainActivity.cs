using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            //Button v = FindViewById<Button>(Resource.Id.button1);
            //Button v2 = FindViewById<Button>(Resource.Id.button2);
            var button = FindViewById<ImageButton>(Resource.Id.myButton);
        }
    }
}

