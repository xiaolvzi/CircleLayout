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
using CircleLayout.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CircleLayout.MyView), typeof(MyViewRender))]
namespace CircleLayout.Droid
{
    class MyViewRender : ViewRenderer<CircleLayout.MyView, CircleLayout.Droid.MyCircleLayout>
    {
        MyCircleLayout myCircleLayout;
        public MyViewRender(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<CircleLayout.MyView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                myCircleLayout = new MyCircleLayout(Context);
                SetNativeControl(myCircleLayout);
            }
        }
    }
}