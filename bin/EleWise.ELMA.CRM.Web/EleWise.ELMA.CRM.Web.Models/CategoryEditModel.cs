using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class CategoryEditModel
{
	public ICategory Category { get; set; }

	public bool CheckUpdatePermission { get; set; }

	public bool LockEditPermission { get; set; }

	public EntityPermissionRoleTypeSelectorModel ContractorPermissionsModel { get; set; }

	public EntityPermissionRoleTypeSelectorModel LeadPermissionsModel { get; set; }

	public bool NoCategory
	{
		get
		{
			if (Category != null)
			{
				return Category.Uid == CategoryManager.NoCategoryUid;
			}
			return false;
		}
	}
}
