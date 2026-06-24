using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class WorkLogItemReportFilterPortletExcludedTypes : IFilterPortletExcludedTypes
{
	public Guid GetExcludedTypeUid()
	{
		return new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");
	}
}
