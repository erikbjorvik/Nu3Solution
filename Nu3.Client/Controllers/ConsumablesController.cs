using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;
using Nu3.Api.Services.Interfaces;
using Nu3.Client.Models;
using Nu3.Enums;
using Nu3Core.Models;

namespace Nu3Admin.Controllers
{
    public class ConsumablesController : Controller
    {
        private readonly IConsumableHelper _consumableHelper;
        public ConsumablesController(IConsumableHelper consumableHelper) {
            _consumableHelper = consumableHelper;
        }
        // GET: Consumables
        public ActionResult Index()
        {
            var consumables = _consumableHelper.GetAll();
            var viewModel = new ConsumableViewModel();
            viewModel.Consumables = consumables;
            return View(viewModel);
        }

		public ActionResult Edit(string id)
		{
            var consumable = _consumableHelper.Get(id);
            return View(consumable);
		}

		public ActionResult Add()
		{
            return View();
		}

        [HttpPost]
		public ActionResult Add(Consumable consumable)
		{
            _consumableHelper.Add(consumable);
			return View();
		}
    }
}