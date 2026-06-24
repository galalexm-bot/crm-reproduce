using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views;

internal sealed class DynamicSlotViewItem : SlotViewItem
{
	[Component(Order = 2000)]
	private class ToolboxItem : CommonViewItemToolboxItem<DynamicSlotViewItem>
	{
		public override Guid Uid => new Guid("{A87CAF80-CABE-491D-BA8E-C95556DC087A}");

		public override string Name => SR.T("Динамический контейнер");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (base.Parent is DynamicListViewItem)
		{
			if (base.Parent?.Root is ToolbarViewItem)
			{
				return childViewItem is ButtonViewItem;
			}
			if (base.Parent?.Parent is ButtonViewItem)
			{
				if (!(childViewItem is ButtonViewItem))
				{
					return childViewItem is ComponentViewItem;
				}
				return true;
			}
		}
		return true;
	}

	[OnSerialized]
	public new void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.DynamicSlotToolbarItem");
			raw.Value.SetAndCreatePlainPropertyValue("Visible", (!Hide).ToString());
		}
	}

	[OnDeserialized]
	public new void OnDeserializedMethod(object raw)
	{
		bool flag = default(bool);
		if (base.Root is ToolbarViewItem && bool.TryParse(raw.GetPlainPropertyValue("Visible")?.ToString(), ref flag))
		{
			Hide = !flag;
		}
	}
}
