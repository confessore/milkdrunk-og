using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;

namespace milkdrunk.views
{
	public class DefaultShellContent : ShellContent
	{
		public DefaultShellContent()
		{
		}

		new public SvgCachedImage Icon { get; set; }
	}
}
