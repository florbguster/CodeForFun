using CodeForFun.Models;
using System.Collections.Generic;

namespace CodeForFun.Tasks
{
    public interface IInventoryTasks
    {
        bool SaveCars( IEnumerable<CarModel> cars );
    }
}
