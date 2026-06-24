using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views;

internal class SlotViewItem : RootViewItem
{
	[Component(Order = 1000)]
	private class ToolboxItem : CommonViewItemToolboxItem<SlotViewItem>
	{
		public override Guid Uid => new Guid("{BB85D5C4-7893-474C-906A-254788B14843}");

		public override string Name => SR.T("Контейнер");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private Guid _003CPlaceholderUid_003Ek__BackingField;

	[NotResettable]
	public Guid PlaceholderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPlaceholderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPlaceholderUid_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.SlotToolbarItem");
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
