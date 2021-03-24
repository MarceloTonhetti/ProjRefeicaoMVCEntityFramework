using ProjRefeicaoMVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjRefeicaoMVCEntityFramework.Dal
{
	public class PizzaInitializer : DropCreateDatabaseIfModelChanges<SnackBarContext>
	{
		protected override void Seed(SnackBarContext context)
		{
			Pizza[] pizzas = new Pizza[]
			{
				new Pizza{Id = 1, Description = "Atum", Value = 28.56m},
				new Pizza{Id = 2, Description = "Lombo Canadense", Value = 30.50m},
				new Pizza{Id = 1, Description = "Filé ao alho", Value = 55.99m}
			};

			foreach (var p in pizzas)
				context.Pizzas.Add(p);

			context.SaveChanges();
		}
	}
}