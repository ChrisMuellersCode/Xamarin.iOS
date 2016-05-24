using Foundation;
using System;
using System.CodeDom.Compiler;
using Core.Model;
using Core.Services;
using UIKit;

namespace RaysHotDogs
{
	partial class HotDogDetailsViewController : UIViewController
	{
	    public HotDog SelectedHotDog { get; set; }

		public HotDogDetailsViewController (IntPtr handle) : base (handle)
		{
            var service = new HotDogDataService();
		    SelectedHotDog = service.GetHotDogById(1);
		}

	    public override void ViewDidLoad()
	    {
	        base.ViewDidLoad();

	        DataBindUI();

	        ButtonAddToCart.TouchUpInside += (sender, args) =>
	        {
	            UIAlertView message = new UIAlertView("Ray's Hot Dogs", "That hot dog has been added to cart!", null,
	                "OK", null);
	            message.Show();
	        };
	    }

	    private void DataBindUI()
	    {
	        UIImage img = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
	        HotDogImageView.Image = img;
	        NameLabel.Text = SelectedHotDog.Name;
	        ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription;
	        LongDescriptionText.Text = SelectedHotDog.Description;
	        PriceLabel.Text = SelectedHotDog.Price + " €";
	    }
	}
}
