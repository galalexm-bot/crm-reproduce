using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views.Toolbar;

internal sealed class SeparatorViewItem : ViewItem
{
	[Component(Order = 450)]
	private class ToolboxItem : ToolbarViewItemToolboxItem<SeparatorViewItem>
	{
		public override Guid Uid => new Guid("{25E6B451-B5ED-4831-98AC-37C627838106}");

		public override string Name => SR.T("Разделитель (панель инструментов)");

		public override string Icon => "horizontal-line";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem is ButtonViewItem)
		{
			return parentViewItem.Root is ToolbarViewItem;
		}
		return false;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.Separator");
			raw.Value.SetAndCreatePlainPropertyValue("Visible", (!Hide).ToString());
		}
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		bool flag = default(bool);
		if (base.Root is ToolbarViewItem && bool.TryParse(raw.GetPlainPropertyValue("Visible")?.ToString(), ref flag))
		{
			Hide = !flag;
		}
	}
}
