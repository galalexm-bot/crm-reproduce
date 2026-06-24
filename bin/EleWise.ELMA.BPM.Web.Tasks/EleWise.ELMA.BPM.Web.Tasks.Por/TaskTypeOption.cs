using System;
using System.Linq;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class TaskTypeOption
{
	public Guid TypeUid { get; set; }

	public bool QuickMode { get; set; }

	public string GetTaskTypeName()
	{
		ISolveTaskQuickMode solveTaskQuickMode = ComponentManager.Current.GetExtensionPoints<ISolveTaskQuickMode>().FirstOrDefault((ISolveTaskQuickMode s) => s.TypeUid == TypeUid);
		if (solveTaskQuickMode == null)
		{
			return string.Empty;
		}
		return solveTaskQuickMode.DisplayName;
	}
}
