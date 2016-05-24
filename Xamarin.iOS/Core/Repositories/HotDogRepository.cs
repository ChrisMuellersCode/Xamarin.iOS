using System;
using System.Collections.Generic;
using Core.Model;

namespace Core.Repositories
{
    public class HotDogRepository
    {
        public List<HotDog> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<HotDog> GetHotDogById(int id)
        {
            throw new NotImplementedException();
        }

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
                        PrepTime = 10

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
                        PrepTime = 15
                    }
                }
            }
        };

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            throw new NotImplementedException();
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            throw new NotImplementedException();
        }
    }
}
