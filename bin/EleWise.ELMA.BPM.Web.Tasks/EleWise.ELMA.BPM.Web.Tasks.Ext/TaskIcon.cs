using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 10)]
public class TaskIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return InterfaceActivator.UID(type) == InterfaceActivator.UID<ITask>();
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		string result = "#task.svg";
		ITask task = (ITask)obj;
		if (task.Status == TaskBaseStatus.OnApproval || task.Status == TaskBaseStatus.OnApprovalExecutor)
		{
			result = "#question.svg";
		}
		else if (task.Status == TaskBaseStatus.RefuseApproval || task.Status == TaskBaseStatus.RefuseApprovalExecutor)
		{
			result = "#project_base.svg";
		}
		else if (task.Period != 0)
		{
			result = "#change.svg";
		}
		return result;
	}
}
