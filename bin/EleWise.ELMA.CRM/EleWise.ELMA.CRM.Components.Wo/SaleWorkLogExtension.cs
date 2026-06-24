using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class SaleWorkLogExtension : WorkLogExtensionBase<ISale>
{
	public static readonly Guid uid = new Guid("{EE34200D-8500-4DAD-8324-E39DC020EAAC}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is ISale sale))
		{
			return null;
		}
		return sale.Author;
	}
}
