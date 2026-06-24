using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class LeadContactWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{8C49C244-66D8-4AEA-81F8-CB7D4CE05EB1}");

	public override Type BaseObjectType => typeof(ILeadContact);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}
}
