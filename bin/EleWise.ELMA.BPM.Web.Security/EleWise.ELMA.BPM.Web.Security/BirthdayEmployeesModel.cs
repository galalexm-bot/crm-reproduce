using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class BirthdayEmployeesModel
{
	public IList<IUser> Employees { get; set; }

	public bool NotDataView { get; set; }
}
