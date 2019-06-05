using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace AndroidFundoo.Droid
{
    [Activity(Label = "Sample")]
    public class Sample : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Hellopage);
            // Create your application here

            var btn = FindViewById<Android.Widget.Button>(Resource.Id.sumbitbtn);

            btn.Click += (object o, EventArgs e) =>
             {
                  Toast.MakeText(this, "how are you", ToastLength.Short).Show();
                 //Intent intent = new Intent(this, typeof(MainActivity1));
               // StartActivity(intent);
             };
        }
    }
}