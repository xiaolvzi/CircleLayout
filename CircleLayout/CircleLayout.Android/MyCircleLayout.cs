using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace CircleLayout.Droid
{
    public class MyCircleLayout : View
    {
        private Context mContext;
        private int screenHeight, screenWidth;
        private Paint mPaint;
        public MyCircleLayout(Context context) : base(context)
        {
            this.mContext = context;
            IWindowManager wm = Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            DisplayMetrics dm = new DisplayMetrics();
            wm.DefaultDisplay.GetMetrics(dm);
            screenHeight = dm.HeightPixels;
            screenWidth = dm.WidthPixels;
            initPaint();
        }

        private void initPaint()
        {
            mPaint = new Paint();
            mPaint.AntiAlias = true;
            mPaint.Color = Android.Graphics.Color.Red;
            mPaint.StrokeWidth = 2;
            mPaint.SetStyle(Paint.Style.Stroke);

        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            canvas.DrawCircle(screenWidth / 2, screenHeight / 2, screenWidth / 6, mPaint);
            
            canvas.Save();
            canvas.Rotate(-60, screenWidth / 2, screenHeight / 2);
            for (int i=1;i<6; i++) {
            canvas.DrawCircle(screenWidth / 2, screenHeight / 2 - screenWidth / 6- screenWidth / 8, screenWidth / 12, mPaint);
            canvas.Rotate(360/5, screenWidth / 2, screenHeight / 2);

            }
            canvas.Restore();
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
           
        }
    }
}