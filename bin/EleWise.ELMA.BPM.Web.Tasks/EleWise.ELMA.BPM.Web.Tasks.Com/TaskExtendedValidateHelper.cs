using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public class TaskExtendedValidateHelper
{
	public static IEnumerable<IExtendedValidateProvider> GetExtendedValidate(ITaskBase task)
	{
		return (from p in ComponentManager.Current.GetExtensionPoints<IExtendedValidateProvider>()
			where p.CheckType(task.GetType().CastAsRealType())
			select p).ToList();
	}

	public static string GetOnSubmitScript(ITaskBase task, Guid actionUid, string form = null, string submitFunction = null)
	{
		List<string> values = (from p in GetExtendedValidate(task)
			select p.SubmitClick(actionUid, task, form, submitFunction) into s
			where !string.IsNullOrEmpty(s)
			select s).ToList();
		return string.Join(" ", values);
	}

	public static void RenderExtendedControls(HtmlHelper html, Guid actionUid, ITaskBase task)
	{
		foreach (IExtendedValidateProvider item in GetExtendedValidate(task))
		{
			item.RenderExtendedControl(html, actionUid, task);
		}
	}
}
