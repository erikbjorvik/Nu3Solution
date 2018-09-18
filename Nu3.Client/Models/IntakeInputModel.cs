using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nu3.Models;
using Nu3Core.Models;

namespace Nu3.Client.Models
{
    public class IntakeInputModel
    {
        public string UserId { get; set; }
        public User User { get; set; }
		public Intake Intake { get; set; }
        public List<SelectListItem> ConsumableList { get; set; }
        public List<SelectListItem> MealList { get; set; }
		public List<SelectListItem> AmountList { get; set; }

	}
}
