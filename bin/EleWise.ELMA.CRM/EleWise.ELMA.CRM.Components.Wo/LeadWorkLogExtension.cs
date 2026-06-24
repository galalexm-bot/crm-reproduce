using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class LeadWorkLogExtension : WorkLogExtensionBase<ILead>
{
	public static readonly Guid uid = new Guid("{746576DD-0A34-4EBE-97FE-A47CACFC31CF}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is ILead lead))
		{
			return null;
		}
		return lead.CreationAuthor;
	}
}
