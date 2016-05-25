using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;
using Foundation;
using RaysHotDogs.Cells;
using UIKit;

namespace RaysHotDogs.DataSources
{
    public class HotDogDataSource : UITableViewSource
    {
        private List<HotDog> hotDogs;

        NSString cellIdentifier = new NSString("HotDogCell");

        public HotDogDataSource(List<HotDog> hotDogs, UITableViewController callingController)
        {
            this.hotDogs = hotDogs;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HotDogListCell cell = tableView.DequeueReusableCell(cellIdentifier) as HotDogListCell;

            if (cell == null)
            {
                cell = new HotDogListCell(cellIdentifier);
            }

            var hotDog = hotDogs[indexPath.Row];
            cell.UpdateCell(hotDog.Name,
                hotDog.Price.ToString(),
                UIImage.FromFile("Images/hotdog" + hotDog.Id + ".jpg"));

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
        }
    }
}
