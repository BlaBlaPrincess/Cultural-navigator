using System.ComponentModel;
using Android.Content;
using Android.Graphics;
using Android.Widget;
using Navigator.Droid.Renderers;
using Navigator.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FilledImage), typeof(FilledImageRenderer))]
namespace Navigator.Droid.Renderers
{
    public class FilledImageRenderer : ViewRenderer<FilledImage, ImageView>
    {
        private bool _isDisposed;

        public FilledImageRenderer(Context context) : base(context)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }
            _isDisposed = true;
            base.Dispose(disposing);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FilledImage> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                SetNativeControl(new ImageView(Context));
            }
            UpdateBitmap();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == FilledImage.ForegroundProperty.PropertyName)
            {
                UpdateBitmap();
            }
        }

        private void UpdateBitmap()
        {
            if (_isDisposed || string.IsNullOrWhiteSpace(Element.Source)) return;
            var d = Context?.GetDrawable(Element.Source).Mutate();
            if (d != null)
            {
                d.SetColorFilter(new LightingColorFilter(Element.Foreground.ToAndroid(), Element.Foreground.ToAndroid()));
                d.Alpha = Element.Foreground.ToAndroid().A;
                Control.SetImageDrawable(d);
            }
            ((IVisualElementController)Element).NativeSizeChanged();
        }
    }
}