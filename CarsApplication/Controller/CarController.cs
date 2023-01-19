using CarsApplication.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarsApplication.Controller
{
    public class CarController
    {
        public List<Car> GetAll()
        {
            using (ApplicationDbEntities db = new ApplicationDbEntities())
            {
                return db.Cars.ToList();
            }
        }
    }
}
