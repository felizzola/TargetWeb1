using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetWeb1.Database;
using TargetWeb1.Models;

namespace TargetWeb1.Controllers
{
    public class ArticulosController1 : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UserGroupController : ControllerBase
        {
            private PortalTargetDbContext PortalTargetDbContext;

            public UserGroupController(PortalTargetDbContext context)
            {
                PortalTargetDbContext = context;
            }

            [HttpGet]
            public IList<Articulo> Get()
            {
                return (this.PortalTargetDbContext.Articulos.ToList());
            }
    }
    }
}