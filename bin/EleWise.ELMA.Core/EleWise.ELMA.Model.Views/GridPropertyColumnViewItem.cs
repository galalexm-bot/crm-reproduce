using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class GridPropertyColumnViewItem : PropertyViewItem, IGridColumnViewItem, IViewItem, IReactive
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<GridPropertyColumnViewItem>
	{
		public override Guid Uid => new Guid("{876A15A4-F81F-420E-997A-5B2812F4A4F9}");

		public override string Name => SR.T("Колонка, отображающая свойство объекта");

		public override bool Visible => false;

		public ToolboxItem(IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (uid == ContentSlotUid)
			{
				result = SR.T("Контент колонки, отображающая свойство объекта");
			}
			return result;
		}
	}

	public static Guid ContentSlotUid = new Guid("BE716308-2985-40B5-A322-59282C1AFEBB");

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

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (!(childViewItem is PropertyCaptionViewItem))
		{
			return childViewItem is DynamicSlotViewItem;
		}
		return true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null && !(parentViewItem is GridViewItem))
		{
			return parentViewItem is TableViewItem;
		}
		return true;
	}
}
