using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Android.Content;

namespace Cheap_drink_nearby
{
    [Activity(Label = "Cheap_drink_nearby", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button homeButtonViewPromos = FindViewById<Button>(Resource.Id.homeButtonViewPromos);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            homeButtonViewPromos.Click += HomeButtonViewPromos_Click;
        }

        private void HomeButtonViewPromos_Click(object sender, System.EventArgs e)
        {
            var toPromos = new Intent(this, typeof(ViewPromosActivity));
            StartActivity(toPromos);
        }
    }
}

