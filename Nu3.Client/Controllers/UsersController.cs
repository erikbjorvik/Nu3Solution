using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;
using Nu3.Api.Services.Interfaces;
using Nu3.Client.Models;
using Nu3.Services.Interfaces;

namespace Nu3Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserHelper _userHelper;
        private readonly IConsumableHelper _consumableHelper;
        private readonly IIntakeHelper _intakeHelper;

        public UsersController(IUserHelper userHelper, IConsumableHelper consumableHelper, IIntakeHelper intakeHelper) {
            _userHelper = userHelper;
            _consumableHelper = consumableHelper;
            _intakeHelper = intakeHelper;
        }
        // GET: Users
        public ActionResult Index()
        {
            return View(_userHelper.GetUsers());
        }
		public ActionResult Edit(string id)
		{
            var consumables = _consumableHelper.GetAll();
            List<SelectListItem> consumableList = new List<SelectListItem>();

            foreach(var consumable in consumables) {
                consumableList.Add(new SelectListItem{ Text = consumable.Name, Value = consumable.Id });
            }

            return View(new IntakeInputModel{ 
                    UserId = id,
                    User = _userHelper.GetUserById(id),
                    ConsumableList = consumableList,
                    MealList = GetMealList(),
                    AmountList = GetAmountList()
                });
		}

        public ActionResult AppIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(IntakeInputModel model, string id) {
            
            model.Intake.UserId = id;
            model.Intake.RegisteredAt = DateTime.Now;
            model.Intake.Unit = Nu3.Enums.Unit.Portion;

            _intakeHelper.Add(model.Intake);

			return RedirectToAction("Edit", new {id = model.User.Id});
        }

        public ActionResult Report(string id) {
            return View();
        }

		List<SelectListItem> GetMealList()
		{
			return new List<SelectListItem> {
				new SelectListItem
			{
				Text = "Breakfast",
				Value = "0"
			},new SelectListItem
			{
				Text = "Lunch",
				Value = "1",
			},new SelectListItem
			{
				Text = "Dinner",
				Value = "2",
			},new SelectListItem
			{
				Text = "Supper",
				Value = "3",
			},new SelectListItem
			{
				Text = "Snack",
				Value = "4",
			},new SelectListItem
			{
				Text = "General",
				Value = "5",
			}};
		}

		List<SelectListItem> GetAmountList()
		{
            var list = new List<SelectListItem>();
            for (var i = 0.0f; i < 5; i += 0.25f) {
                var value = i.ToString("0.00");
                list.Add(new SelectListItem{ Text = value, Value = value});
            }
            return list;
		}

    }


}