using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.Repositories;

namespace Core.Services
{
    public class HotDogDataService
    {
        private static HotDogRepository repository = new HotDogRepository();

        public List<HotDog> GetAllHotDogs()
        {
            return repository.GetAll();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return repository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsFromGroup(int hotDogGroupId)
        {
            return repository.GetHotDogsForGroup(hotDogGroupId);
        }

        public HotDog GetHotDogById(int id)
        {
            return repository.GetHotDogById(id);
        }
    }
}
