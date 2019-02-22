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

namespace dbmasteraapp.Droid
{
    public class Globals
    {
        private static Window window;
        public static Window Window
        {
            get
            {
                return window;
            }
            set
            {
                window = value;
            }
        }
    }
}