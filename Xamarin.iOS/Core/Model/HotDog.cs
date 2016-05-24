using System.Collections.Generic;

namespace Core.Model
{
    public class HotDog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public int Price { get; set; }

        public bool IsAvailable { get; set; }

        public int PrepTime { get; set; }

        public IList<string> Ingredients { get; set; }

        public bool IsFavorite { get; set; }

        public string GroupName { get; set; }
    }
}
