using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ViewItems;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_WorkLogSummaryTableViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
[ViewItemMetadata(Type = typeof(ITaskBase))]
public class WorkLogSummaryTableViewItem : RootViewItem, IHideEmptyViewItem, ICountViewItem
{
	public new class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly WorkLogSummaryTableViewItem viewItem;

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

		public DebugView(WorkLogSummaryTableViewItem viewItem)
		{
			_viewItemDebugView = new ViewItem.DebugView(viewItem);
			this.viewItem = viewItem;
		}
	}

	[Component(Order = 72)]
	private class ToolboxItem : WorkLogViewItemToolboxItem<WorkLogSummaryTableViewItem>
	{
	}

	[DefaultValue(false)]
	public virtual bool ShowCount { get; set; }

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(HideEmptyEnum.Inherit)]
	[XmlElement("HideEmpty")]
	public new HideEmptyEnum HideEmptySettings { get; set; }

	public WorkLogSummaryTableViewItem()
	{
		ShowCount = false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public new bool IsHideEmpty(RootViewItem parent = null)
	{
		if (HideEmptySettings != 0)
		{
			return HideEmptySettings == HideEmptyEnum.HideEmpty;
		}
		if ((parent ?? base.Parent) != null)
		{
			return (parent ?? base.Parent).IsHideEmpty();
		}
		return false;
	}
}
