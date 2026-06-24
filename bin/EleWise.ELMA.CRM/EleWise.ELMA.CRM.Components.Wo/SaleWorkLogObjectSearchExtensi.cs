using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class SaleWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{667701C1-774D-46FB-92D1-FF7A8EAEA5E7}");

	public override Type BaseObjectType => typeof(ISale);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}

	public override bool HasPermission(Guid typeUid)
	{
		if (base.HasPermission(typeUid))
		{
			return base.SecurityService.HasPermission(CRMPermissionProvider.SalesAccessPermission);
		}
		return false;
	}
}
