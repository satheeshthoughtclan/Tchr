using System;
using System.Web.Http;
using Tchr.Models;

namespace Tchr.Controllers
{
    public class EmployeeController : ApiController
    {
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = new Employee
            {
                Id = 1,
                FirstName = "Satheesh",
                LastName = "Ramasamy"
            };
            return Ok(employee);
        }
    }
}
