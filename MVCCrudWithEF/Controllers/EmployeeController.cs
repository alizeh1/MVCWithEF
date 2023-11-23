using MVCCrudWithEF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudWithEF.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly EmployeeEntities _dbContext = new EmployeeEntities();
        
        public ActionResult Index()
        {
            List<tblemp> emp = new List<tblemp>(); 
              emp  = _dbContext.tblemps.ToList();
            return View(emp);
        } 

    }
}
