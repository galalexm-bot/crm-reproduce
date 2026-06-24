using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class MarketingActivityWorkLogExtension : WorkLogExtensionBase<IMarketingActivity>
{
	public static readonly Guid uid = new Guid("{7F99A66C-5B23-4A75-95B1-88D5F59B33FD}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		return ((entity is IMarketingActivity marketingActivity) ? marketingActivity.Responsible : null) ?? DefaultHarmonizator();
	}
}
