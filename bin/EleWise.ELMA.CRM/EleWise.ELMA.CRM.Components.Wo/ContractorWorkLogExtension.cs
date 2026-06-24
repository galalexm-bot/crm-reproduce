using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class ContractorWorkLogExtension : WorkLogExtensionBase<IContractor>
{
	public static readonly Guid uid = new Guid("{B609C2D1-B025-4B15-97BA-FAB94A1FC5EB}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is IContractor contractor))
		{
			return null;
		}
		return contractor.CreationAuthor;
	}
}
