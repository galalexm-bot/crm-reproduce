using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class TabLayoutViewItem : RootViewItem, IViewItemWithActiveKey, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component(Order = 300)]
	private class ToolboxItem : CommonViewItemToolboxItem<TabLayoutViewItem>
	{
		public override Guid Uid => new Guid("{0665F8FA-8FF6-419A-B0DA-5767AEEEAC51}");

		public override string Name => SR.T("Вкладки");

		public override string Icon => "tabs";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private Guid _003CActiveKeyProperty_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private ActionWithParam<string> _003COnChange_003Ek__BackingField;

	private bool _003CUseTabProvider_003Ek__BackingField;

	private bool _003CTabProviderUseOriginalModel_003Ek__BackingField;

	public Guid ActiveKeyProperty
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CActiveKeyProperty_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CActiveKeyProperty_003Ek__BackingField = value;
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<string> OnChange
	{
		get
		{
			return _003COnChange_003Ek__BackingField;
		}
		set
		{
			_003COnChange_003Ek__BackingField = value;
		}
	}

	public bool UseTabProvider
	{
		get
		{
			return _003CUseTabProvider_003Ek__BackingField;
		}
		set
		{
			_003CUseTabProvider_003Ek__BackingField = value;
		}
	}

	public bool TabProviderUseOriginalModel
	{
		get
		{
			return _003CTabProviderUseOriginalModel_003Ek__BackingField;
		}
		set
		{
			_003CTabProviderUseOriginalModel_003Ek__BackingField = value;
		}
	}

	public TabLayoutViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
		TabProviderUseOriginalModel = true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is TabViewItem;
	}
}
