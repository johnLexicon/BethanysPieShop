using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {

        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            //Checks first if the pies have already been loaded, otherwise it retrieves the pies from the database.
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int id)
        {
            return _appDbContext.Pies.FirstOrDefault<Pie>(p => p.Id == id);
        }
    }
}
