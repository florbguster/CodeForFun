
using CodeForFun.Models;
using System.Collections.Generic;
namespace CodeForFun.Tasks
{
    public class InventoryTasks : IInventoryTasks
    {
        public bool SaveCars( IEnumerable<CarModel> cars )
        {

            foreach (CarModel car in cars)
            {
                string make = car.Make;
                string model = car.Model;
                string year = car.Year;
            }

            // use entity framework
            // save each item in the list to local db
            bool IsSaved = true;


            if (IsSaved)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}