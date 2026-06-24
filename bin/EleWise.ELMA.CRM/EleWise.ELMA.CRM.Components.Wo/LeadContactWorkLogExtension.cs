using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class LeadContactWorkLogExtension : WorkLogExtensionBase<ILeadContact>
{
	public static readonly Guid uid = new Guid("{6B3AC1FD-ADAA-455C-904C-6409B12B0238}");

	public override Guid Uid => uid;
}
