using System;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class CurrentInstancesInfo : ProcessHeaderInfo
{
	public SwimlaneGroupInfo SwimlaniesInfo { get; set; }

	public ExecutorsInfo ExecutorsInfo { get; set; }

	public string UniquePostfix { get; set; }

	public string ApplyFunctionName { get; set; }

	public CurrentInstancesInfo()
	{
		UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		SwimlaniesInfo = new SwimlaneGroupInfo
		{
			UniquePostfix = UniquePostfix
		};
		ExecutorsInfo = new ExecutorsInfo
		{
			UniquePostfix = UniquePostfix
		};
		ApplyFunctionName = "applyAllFilters";
	}

	public CurrentInstancesInfo(ProcessHeaderInfo headerInfo)
		: this()
	{
		base.AssignToMeCount = headerInfo.AssignToMeCount;
		base.AvailableCount = headerInfo.AvailableCount;
		base.CompleteCount = headerInfo.CompleteCount;
		base.Id = headerInfo.Id;
		base.InstanceFilter = headerInfo.InstanceFilter;
		base.InterruptedCount = headerInfo.InterruptedCount;
		base.Name = headerInfo.Name;
		base.SelectedTab = headerInfo.SelectedTab;
		base.CallbackFunction = headerInfo.CallbackFunction;
	}
}
