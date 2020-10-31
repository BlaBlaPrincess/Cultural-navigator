﻿using Android.Content;
using Android.OS;
using AndroidX.Fragment.App;
using Navigator.Droid.Renderers;
using Navigator.Droid.Renderers.Elements;
using Navigator.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransitionShell), typeof(TransitionShellRenderer))]
namespace Navigator.Droid.Renderers
{
    public class TransitionShellRenderer : ShellRenderer
    {
        public TransitionShellRenderer(Context context) : base(context)
        {
            StatusBarColor = Color.Gray;
        }

        protected override void SetupPageTransition(FragmentTransaction transaction)
        {
        }
        
        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new BottomNavAppearance(this, shellItem, ((TransitionShell)Element).TabBarIconForeground);
        }
        
        protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection)
        {
            return new TabLayoutAppearance(this, ((TransitionShell)Element).TabTitleEmphasizerColor);
        }
    }
}