using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views;

internal sealed class DynamicListViewItem : RootViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component(Order = 210)]
	private class ToolboxItem : CommonViewItemToolboxItem<DynamicListViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{BE465ECF-85A4-4552-9C1C-D33564B64946}");

		public override string Name => SR.T("Динамический список");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "run-test";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}

		public override string GetSlotName(Guid uid)
		{
			return SR.T("Контент динамического списка");
		}
	}

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private int? _003CHeightPercentage_003Ek__BackingField;

	public Guid PropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyUid_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<Guid> PropertyParents
	{
		get
		{
			return _003CPropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CPropertyParents_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? HeightPercentage
	{
		get
		{
			return _003CHeightPercentage_003Ek__BackingField;
		}
		set
		{
			_003CHeightPercentage_003Ek__BackingField = value;
		}
	}

	public DynamicListViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is DynamicSlotViewItem;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.DynamicListToolbarItem");
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
