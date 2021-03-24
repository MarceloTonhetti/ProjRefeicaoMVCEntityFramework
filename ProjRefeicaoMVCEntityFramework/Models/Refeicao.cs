using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjRefeicaoMVCEntityFramework.Models
{
	public abstract class Refeicao
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Value { get; set; }
	}
}