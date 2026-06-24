using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class MarketingActivityWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{DFCF2A77-2092-4A49-A25F-33203B8E722B}");

	public override Type BaseObjectType => typeof(IMarketingActivity);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}
}
