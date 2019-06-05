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
using AndroidFundoo.Droid;
using AndroidFundoo.NativeFloder;
using Xamarin.Forms;

[assembly: Dependency(typeof(xamarinnative))]

namespace AndroidFundoo.Droid
{
   public class xamarinnative :Inative
    {
        public void superexp()
        {
            var intent = new Intent(Forms.Context, typeof(Sample));
            Forms.Context.StartActivity(intent);
        }
    }
}