using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLdatabase;

namespace SQLrepository.EFCore
{
    public class EFCoreCityRepository : EfCoreRepository<City, ApplicationDBContext>
    {
        public EFCoreCityRepository(ApplicationDBContext dbContext) : base(dbContext)
        {

        }

        //TODO: Add more methods here that relate to the cities
    }
}
