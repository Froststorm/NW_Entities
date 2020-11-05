using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class NorthWindController : ApiController
    {
        public IEnumerable<Employees> Get()
        {
            using (NorthwindEntities entities = new NorthwindEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employees Get(int empID)
        {
            using (NorthwindEntities entities = new NorthwindEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.EmployeeID == empID);
            }
        }

    }
}
