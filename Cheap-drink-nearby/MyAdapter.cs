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
using Java.Lang;

namespace Cheap_drink_nearby
{
    public class MyAdapter : Android.Support.V4.View.PagerAdapter
    {
        List<int> listImages;
        Context context;
        LayoutInflater layoutInflater;

        public MyAdapter(List<int> listImages, Context context)
        {
            this.listImages = listImages;
            this.context = context;
            layoutInflater = LayoutInflater.From(context);
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            View view = layoutInflater.Inflate(Resource.Layout.Card_Layout, container, false);
            ImageView imgView = view.FindViewById<ImageView>(Resource.Id.imageView);
            imgView.SetImageResource(listImages[position]);

            container.AddView(view);
            return view;
        }

        public override int Count => listImages.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view.Equals(@object);
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
        {
            container.RemoveView((View)@object);
        }

        //public override void DestroyItem(ViewGroup container, int position, Object objectValue)
        //{
        //    base.DestroyItem(container, position, objectValue);
        //
        //    var viewPager = container.JavaCast<ViewPager>();
        //    viewPager.RemoveView(objectValue as View);
        //}
    }
}