using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nu3Admin.Controllers
{
    public class BeaconsController : Controller
    {
        // GET: Beacons
        public ActionResult Index()
        {
            return View();
        }
    }
}