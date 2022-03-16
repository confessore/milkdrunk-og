using System;
using Foundation;
using Google.MobileAds;
using milkdrunk.iOS.Renderers;
using milkdrunk.views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AdView), typeof(AdViewRenderer))]
namespace milkdrunk.iOS.Renderers
{
    [Protocol]
    public class AdViewRenderer : ViewRenderer<AdView, BannerView>
    {
#if DEBUG
        readonly string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#else
        readonly string adUnitId = "ca-app-pub-1561048054448608/7936630920";
#endif

        private BannerView CreateBannerView()
        {
            var bannerView = new BannerView(AdSizeCons.Banner)
            {
                AdUnitId = adUnitId,
                RootViewController = GetVisibleViewController()
            };

            bannerView.LoadRequest(GetRequest());

            Request GetRequest()
            {
                var request = Request.GetDefaultRequest();
                return request;
            }

            return bannerView;
        }

        UIViewController GetVisibleViewController()
        {
            foreach (var window in UIApplication.SharedApplication.Windows)
                if (window.RootViewController != null)
                    return window.RootViewController;
            return null;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
                SetNativeControl(CreateBannerView());
        }
    }
}
