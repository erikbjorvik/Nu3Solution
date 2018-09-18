using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nu3Core.Models;

namespace Nu3.Client.Models
{
    public class ConsumableViewModel
    {
        public IEnumerable<Consumable> Consumables { get; set; }
        public Consumable Consumable { get; set; }
        public List<SelectListItem> TypeEnums { get; set; }
		public List<SelectListItem> CategoryEnums { get; set; }

	}
}
