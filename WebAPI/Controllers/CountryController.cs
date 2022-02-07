using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Common;
using SQLrepository;
using SQLrepository.EFCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseDBController<Country, EFCoreCountryRepository>
    {
        public CountryController(EFCoreCountryRepository repository) : base(repository)
        {

        }
    }
}
