using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 100)]
internal class TaskBaseFormCreator : FormCreator
{
	public override bool HideCreator => true;

	public override bool CheckType(Type type)
	{
		if (type != null && typeof(ITaskBase).IsAssignableFrom(type))
		{
			return base.CheckType(type);
		}
		return false;
	}
}
