using Android.Content;
using Android.Gms.Ads;
using Android.Widget;
using milkdrunk.Droid.renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(milkdrunk.views.AdView), typeof(AdViewRenderer))]
namespace milkdrunk.Droid.renderers
{
    public class AdViewRenderer : ViewRenderer<views.AdView, AdView>
    {
        public AdViewRenderer(Context context) : base(context) { }
#if DEBUG
        readonly string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#else
        readonly string adUnitId = "ca-app-pub-1561048054448608/7067769362";
#endif
        readonly AdSize adSize = AdSize.Banner;
        AdView adView;

        AdView CreateAdView()
        {
            if (adView != null)
                return adView;
            adView = new AdView(Context)
            {
                AdSize = adSize,
                AdUnitId = adUnitId,
                LayoutParameters = new LinearLayout.LayoutParams(
                    LayoutParams.WrapContent, LayoutParams.WrapContent)
            };

//#if DEBUG
            //adView.LoadAd(new AdRequest.Builder().AddTestDevice("04DB1A4AC8F198E3ABC7232881E7DE56").Build());
//#else
            adView.LoadAd(new AdRequest.Builder().Build());
//#endif
            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<views.AdView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                CreateAdView();
                SetNativeControl(adView);
            }
        }
    }
}