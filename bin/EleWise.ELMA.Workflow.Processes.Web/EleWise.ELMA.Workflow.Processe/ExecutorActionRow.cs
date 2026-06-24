using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ExecutorActionRow
{
	public Guid SwimlaneUid { get; set; }

	public IUser CurrentExecutor { get; set; }

	public ChangeActionTypes ActionId { get; set; }

	public IList<DropDownItem> ActionItems { get; set; }

	public IUser Executor { get; set; }

	public ExecutorActionRow()
	{
		ActionItems = new List<DropDownItem>();
	}
}
