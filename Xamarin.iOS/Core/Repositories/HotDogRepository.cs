using System;
using System.Collections.Generic;
using System.Linq;
using Core.Model;

namespace Core.Repositories
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>
        {
            new HotDogGroup
            {
                Id = 1,
                Title = "Meat Lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        Id = 1,
                        Name = "Regular Hot Dog",
                        ShortDescription = "The best there is on planet",
                        Description =
                            "bla bla bla8490 4132  fas   fasd f adsjfasdk jöwqfj ac<sdk hjbpo<hernpö<oviuoweu i ",
                        IsAvailable = true,
                        PrepTime = 10,
                        ImagePath = "hotdog1",
                        Price = 7
                    }
                }
                
            },
            new HotDogGroup
            {
                Id = 2,
                Title = "Veggie Lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        Id = 2, 
                        Name = "Veggie Deluxe",
                        ShortDescription = "For all you plant eaters",
                        Description =
                            "bla bla bla8490 4132  fas   fasd f adsjfasdk jöwqfj ac<sdk hjbpo<hernpö<oviuoweu i ",
                        IsAvailable = true,
                        PrepTime = 15,
                        ImagePath = "hotdog1",
                        Price = 9
                    }
                }
            }
        };

        public List<HotDog> GetAll()
        {
            var hotDogs = new List<HotDog>();
            foreach (var hotDogGroup in hotDogGroups)
            {
                hotDogs.AddRange(hotDogGroup.HotDogs);
            }
            return hotDogs;
        }

        public HotDog GetHotDogById(int id)
        {
            foreach (var hotDogGroup in hotDogGroups.Where(hotDogGroup => hotDogGroup.HotDogs.Any(hd => hd.Id == id)))
            {
                return hotDogGroup.HotDogs.Single(hd => hd.Id == id);
            }
            throw new ArgumentException();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return hotDogGroups.Single(hg => hg.Id == hotDogGroupId).HotDogs;
        }
    }
}
