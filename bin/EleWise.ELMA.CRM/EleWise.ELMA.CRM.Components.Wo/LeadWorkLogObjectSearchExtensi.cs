using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class LeadWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{2C4B55CA-F4D0-49E2-A744-2ECF27439AE8}");

	public override Type BaseObjectType => typeof(ILead);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}
}
