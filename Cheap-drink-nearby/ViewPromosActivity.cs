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
using Android.Support.V7.App;
using Com.Gigamole.Infinitecycleviewpager;

namespace Cheap_drink_nearby
{
    [Activity(Label = "ViewPromosActivity", Icon = "@drawable/icon", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class ViewPromosActivity : AppCompatActivity
    {
        List<int> lstImages = new List<int>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ViewPromos);
            // Create your application here

            InitData();
            HorizontalInfiniteCycleViewPager viewPager = FindViewById<HorizontalInfiniteCycleViewPager>(Resource.Id.horizontal_viewpager);
            MyAdapter adapter = new MyAdapter(lstImages, BaseContext);
            viewPager.Adapter = adapter;
        }

        private void InitData()
        {
            lstImages.Add(Resource.Drawable.promo1);
            lstImages.Add(Resource.Drawable.promo2);
            lstImages.Add(Resource.Drawable.promo3);
        }
    }
}