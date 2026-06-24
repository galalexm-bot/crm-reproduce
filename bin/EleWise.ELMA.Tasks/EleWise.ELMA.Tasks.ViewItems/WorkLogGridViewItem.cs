using System;
using System.ComponentModel;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ViewItems;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_WorkLogGridViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
[ViewItemMetadata(Type = typeof(ITaskBase))]
public class WorkLogGridViewItem : RootViewItem, ICountViewItem
{
	public new class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly WorkLogGridViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly ViewItem.DebugView _viewItemDebugView;

		public bool ShowCount
		{
			get
			{
				return viewItem.ShowCount;
			}
			set
			{
				viewItem.ShowCount = value;
			}
		}

		public DebugView(WorkLogGridViewItem viewItem)
		{
			_viewItemDebugView = new ViewItem.DebugView(viewItem);
			this.viewItem = viewItem;
		}
	}

	[Component(Order = 71)]
	private class ToolboxItem : WorkLogViewItemToolboxItem<WorkLogGridViewItem>
	{
	}

	[DefaultValue(false)]
	public virtual bool ShowCount { get; set; }

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
