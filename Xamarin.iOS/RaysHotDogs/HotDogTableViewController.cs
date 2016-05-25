using Foundation;
using System;
using System.CodeDom.Compiler;
using Core.Services;
using RaysHotDogs.DataSources;
using UIKit;

namespace RaysHotDogs
{
	partial class HotDogTableViewController : UITableViewController
	{
        HotDogDataService dataService = new HotDogDataService();

		public HotDogTableViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        var hotDogs = dataService.GetAllHotDogs();
            var dataSource = new HotDogDataSource(hotDogs, this);

	        TableView.Source = dataSource;

	        NavigationItem.Title = "Ray's Hot Dog menu";
	    }

	    public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
	    {
	        base.PrepareForSegue(segue, sender);

	        if (segue.Identifier == "HotDogDetailSegue")
	        {
	            var hotDogDetailsViewController = segue.DestinationViewController as HotDogDetailsViewController;
	            if (hotDogDetailsViewController != null)
	            {
	                var source = TableView.Source as HotDogDataSource;
	                var rowPath = TableView.IndexPathForSelectedRow;
	                var item = source.GetItem(rowPath.Row);
	                hotDogDetailsViewController.SelectedHotDog = item;
	            }
	        }
	    }
	}
}
