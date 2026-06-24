using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class CategoryIndexModel
{
	public GridData<ICategory> GridData { get; set; }

	public IUser CurrentUser { get; set; }

	public bool ShowAccess { get; set; }

	public bool CheckUpdatePermission { get; set; }

	public bool LockEditPermission { get; set; }

	public string LastRecalculatePermissionsError { get; set; }
}
