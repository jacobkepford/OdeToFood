using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
<<<<<<< HEAD
        Restaurant Delete(int id);
=======
        Restaurant Add(Restaurant newRestaurant);
>>>>>>> 632598f3ca5b33ba2ab9e989426133dd6c0d031b
        int Commit();

    }
}
