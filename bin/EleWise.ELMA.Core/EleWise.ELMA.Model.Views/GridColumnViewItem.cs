using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class GridColumnViewItem : RootViewItem, IContainerViewItem, IGridColumnViewItem, IViewItem, IReactive
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<GridColumnViewItem>
	{
		public override Guid Uid => new Guid("{ACD4E5DB-4E30-4BA0-9ADE-5B632B3569B6}");

		public override string Name => SR.T("Колонка");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (ColumnCaptionSlotUid == uid)
			{
				result = SR.T("Заголовок колонки");
			}
			if (ColumnContentSlotUid == uid)
			{
				result = SR.T("Контент колонки");
			}
			return result;
		}
	}

	public static Guid ColumnCaptionSlotUid = new Guid("4DBDDD9B-4802-4008-8864-724112CBE295");

	public static Guid ColumnContentSlotUid = new Guid("4F4BF2FD-A2B4-4ED2-A301-3B3E07D98106");

	private WidthType _003CWidthType_003Ek__BackingField;

	private int? _003CWidth_003Ek__BackingField;

	[DynamicProperty(false)]
	public WidthType WidthType
	{
		get
		{
			return _003CWidthType_003Ek__BackingField;
		}
		set
		{
			_003CWidthType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null && !(parentViewItem is GridViewItem))
		{
			return parentViewItem is TableViewItem;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
