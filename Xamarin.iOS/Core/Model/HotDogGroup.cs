using System.Collections.Generic;

namespace Core.Model
{
    public class HotDogGroup
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public IList<HotDog> HotDogs { get; set; }
    }
}
