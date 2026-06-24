using System;

namespace EleWise.ELMA.CRM.Web.Models;

[Serializable]
public class InpaymentStatusFilterModel
{
	public bool IsOverdue { get; set; }

	public bool InPlan { get; set; }

	public bool Received { get; set; }

	public bool Cancelled { get; set; }

	public InpaymentStatusFilterModel()
	{
		IsOverdue = true;
		InPlan = true;
		Received = true;
		Cancelled = true;
	}
}
