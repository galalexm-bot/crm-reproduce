using System;

namespace EleWise.ELMA.CRM.Web.Models;

public class InpaymentPortletModel
{
	public long? FilterId { get; set; }

	public bool ShowOnlyMy { get; set; }

	public bool SplitByPeriods { get; set; }

	public Guid InstanceId { get; set; }
}
