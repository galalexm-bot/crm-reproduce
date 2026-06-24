using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;

namespace EleWise.ELMA.CRM.Web.Extensions;

[Component]
internal class FilterPortletExcludedTypesExtension : IFilterPortletExcludedTypes
{
	public Guid GetExcludedTypeUid()
	{
		return SaleFunnelManager.SaleFunnelReportUid;
	}
}
