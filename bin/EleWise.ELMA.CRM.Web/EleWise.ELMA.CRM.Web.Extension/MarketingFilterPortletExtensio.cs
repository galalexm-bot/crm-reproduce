using System;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Extensions;

[Component(Order = 1200)]
public class MarketingFilterPortletExtensions : FilterPortletExtensions
{
	protected override bool AddColumnTypeIcon => true;

	public override bool AvailableFilterType(Guid filterTypeUid)
	{
		return filterTypeUid == InterfaceActivator.UID<IMarketingBase>();
	}
}
