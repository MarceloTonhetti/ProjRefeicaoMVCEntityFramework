using ProjRefeicaoMVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjRefeicaoMVCEntityFramework.Dal
{
	public class SnackBarContext : DbContext
	{
		public SnackBarContext() : base ("SnackBarContext")
		{

		}

		public DbSet<Pizza> Pizzas { get; set; }
	}
}