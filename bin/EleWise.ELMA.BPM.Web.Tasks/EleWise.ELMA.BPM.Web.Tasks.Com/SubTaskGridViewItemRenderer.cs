using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Tasks.ViewItems;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal class SubTaskGridViewItemRenderer : ViewItemRendererBase<SubTaskGridViewItem>
{
	public override bool IsHideEmpty(ViewItem viewItem)
	{
		ITaskBase taskBase = (ITaskBase)ViewItemRenderer.Entity;
		if (base.IsHideEmpty(viewItem))
		{
			return ((ICollection<ITaskBase>)taskBase.ChildTasks).Count == 0;
		}
		return false;
	}
}
