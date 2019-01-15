using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int id);
    }
}
