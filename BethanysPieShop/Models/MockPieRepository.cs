using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {

        private List<Pie> _pies;

        public MockPieRepository()
        {
            InitializePies();
        }

        private void InitializePies()
        {
            _pies = new List<Pie>()
            {
                new Pie(){ ID = 1, Name = "Apple Pie", Price = 64.99M, ShortDescription = "Very good", ImageUrl = string.Empty, ImageThumbnailUrl = string.Empty },
                new Pie(){ ID = 1, Name = "Blueberry Pie", Price = 110.99M, ShortDescription = "Even better", ImageUrl = string.Empty, ImageThumbnailUrl = string.Empty },
                new Pie(){ ID = 1, Name = "Cheese Cake", Price = 55.99M, ShortDescription = "Cheesy delicious", ImageUrl = string.Empty, ImageThumbnailUrl = string.Empty },
                new Pie(){ ID = 1, Name = "Cherry Pie", Price = 78.99M, ShortDescription = "Cherrylicious", ImageUrl = string.Empty, ImageThumbnailUrl = string.Empty }
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int id)
        {
            return _pies.FirstOrDefault(p => p.ID == id);
        }
    }
}
