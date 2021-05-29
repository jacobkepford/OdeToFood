using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            throw new System.NotImplementedException();
        }
    }
}