using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_WorkLogTabViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ITaskBase))]
[Obsolete("Use TabViewItem instead", false)]
public class WorkLogTabViewItem : TabViewItem
{
	[Component(Order = 70)]
	private class ToolboxItem : WorkLogViewItemToolboxItem<WorkLogTabViewItem>
	{
	}

	public WorkLogTabViewItem()
	{
		Caption = SR.T("Трудозатраты");
	}
}
