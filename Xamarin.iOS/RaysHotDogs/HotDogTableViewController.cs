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
	    }
	}
}
