// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ThreadedCoreData
{
	partial class APLEarthquakeTableViewCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel dateLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel locationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView magnitudeImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel magnitudeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (locationLabel != null) {
				locationLabel.Dispose ();
				locationLabel = null;
			}

			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}

			if (magnitudeLabel != null) {
				magnitudeLabel.Dispose ();
				magnitudeLabel = null;
			}

			if (magnitudeImage != null) {
				magnitudeImage.Dispose ();
				magnitudeImage = null;
			}
		}
	}
}
