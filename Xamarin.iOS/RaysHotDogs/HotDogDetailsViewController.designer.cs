// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RaysHotDogs
{
	[Register ("HotDogDetailsViewController")]
	partial class HotDogDetailsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField amountText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonAddToCart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CancelButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView HotDogImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField LongDescriptionText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel NameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PriceLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel ShortDescriptionLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (amountText != null) {
				amountText.Dispose ();
				amountText = null;
			}
			if (ButtonAddToCart != null) {
				ButtonAddToCart.Dispose ();
				ButtonAddToCart = null;
			}
			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
			if (HotDogImageView != null) {
				HotDogImageView.Dispose ();
				HotDogImageView = null;
			}
			if (LongDescriptionText != null) {
				LongDescriptionText.Dispose ();
				LongDescriptionText = null;
			}
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
			if (PriceLabel != null) {
				PriceLabel.Dispose ();
				PriceLabel = null;
			}
			if (ShortDescriptionLabel != null) {
				ShortDescriptionLabel.Dispose ();
				ShortDescriptionLabel = null;
			}
		}
	}
}
