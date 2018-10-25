using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WelfareDanmarkProjectGroup9.Models;

namespace WelfareDanmarkProjectGroup9.Controllers
{
    public class CounterController : Controller
    {
        private readonly PatientDataContext _db;

        public CounterController(PatientDataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            var count = _db.Patients.Count();

            return View(count);
        }
    }
}
