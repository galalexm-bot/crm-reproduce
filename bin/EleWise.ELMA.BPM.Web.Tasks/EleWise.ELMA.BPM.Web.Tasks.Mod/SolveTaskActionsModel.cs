using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SolveTaskActionsModel
{
	public List<ISolveTaskAction> Actions { get; set; }

	public ITaskBase Task { get; set; }

	public SolveTaskPortletPersonalization Settings { get; set; }
}
