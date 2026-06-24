using System;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class AllStatusesInfo
{
	public StatesInfo StatesInfo { get; set; }

	public StatusesInfo StatusesInfo { get; set; }

	public string UniquePostfix { get; set; }

	public AllStatusesInfo()
	{
		UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
	}
}
