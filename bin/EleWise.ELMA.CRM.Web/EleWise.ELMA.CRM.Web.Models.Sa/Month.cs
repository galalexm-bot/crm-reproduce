using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan;

public class Month
{
	public string Name { get; set; }

	public List<Week> Weeks { get; set; }

	public Month()
	{
		Weeks = new List<Week>();
	}
}
