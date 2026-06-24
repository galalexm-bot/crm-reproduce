using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views.Toolbar;

internal sealed class GroupViewItem : RootViewItem
{
	[Component(Order = 450)]
	private class ToolboxItem : ToolbarViewItemToolboxItem<GroupViewItem>
	{
		public override Guid Uid => new Guid("{8DDF4717-91CE-41B1-813F-79805BEB1893}");

		public override string Name => SR.T("Группа");

		public override string Icon => "placeholder";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem is ToolbarViewItem;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (!(childViewItem is ButtonViewItem))
		{
			return childViewItem is DynamicListViewItem;
		}
		return true;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.Group");
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
