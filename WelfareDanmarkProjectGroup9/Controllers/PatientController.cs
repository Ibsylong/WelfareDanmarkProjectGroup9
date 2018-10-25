using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDanmarkProjectGroup9.Models;

namespace WelfareDanmarkProjectGroup9.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientDataContext _db;

        public PatientController(PatientDataContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var db = _db.Patients.ToArray();

            var count = _db.Patients.Count();

            return View(db);
        }

    }
}
