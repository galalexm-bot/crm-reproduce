using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SolveTasksPortletModel : MyTasksPortletModel
{
	public SolveTaskPortletPersonalization Settings { get; set; }

	public List<ISolveTaskAction> GetActions()
	{
		if (!Settings.HideActions)
		{
			return ComponentManager.Current.GetExtensionPoints<ISolveTaskAction>().ToList();
		}
		return new List<ISolveTaskAction>();
	}
}
