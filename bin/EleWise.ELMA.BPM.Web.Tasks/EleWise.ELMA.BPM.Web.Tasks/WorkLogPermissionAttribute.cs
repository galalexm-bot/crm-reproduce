using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Tasks;

public class WorkLogPermissionAttribute : BasePermissionAttribute
{
	public override bool HasPermission()
	{
		return WorkLogSettingsHelper.WorkLogEnabled();
	}
}
