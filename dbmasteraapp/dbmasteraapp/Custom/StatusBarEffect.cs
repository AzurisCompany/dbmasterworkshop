using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace dbmasteraapp.Custom
{
    public class StatusBarEffect : RoutingEffect
    {
        private static Color BackgroundColor;
        public static void SetBackgroundColor(Color color)
        {
            BackgroundColor = color;
        }
        public static Color GetBackgroundColor()
        {
            return BackgroundColor;
        }

        public StatusBarEffect() : base("Xamarin.StatusBarEffect")
        { }
    }
}
