using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan;

public class Week
{
	public int Number { get; set; }

	public DateTime FirstDay { get; set; }

	public DateTime LastDay { get; set; }

	public List<IPayment> Payments { get; set; }

	public Week()
	{
		Payments = new List<IPayment>();
	}
}
