using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class ContactWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{686345F1-1671-48EF-962A-654B94FD9ABA}");

	public override Type BaseObjectType => typeof(IContact);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}
}
