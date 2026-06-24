using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class ContentNavigationViewItem : RootViewItem, IViewItemWithActiveKey, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component(Order = 350)]
	private class ToolboxItem : CommonViewItemToolboxItem<ContentNavigationViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{A2299EF2-BEB3-4D3C-8925-B7604514D114}");

		public override string Name => SR.T("Меню с формой");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "content-navigation";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private string _003CCaption_003Ek__BackingField;

	private bool _003CDestroyOnClose_003Ek__BackingField;

	private DefaultAction _003COnClose_003Ek__BackingField;

	private Guid _003CActiveKeyProperty_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private ActionWithParam<string> _003COnChange_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Caption
	{
		get
		{
			return _003CCaption_003Ek__BackingField;
		}
		set
		{
			_003CCaption_003Ek__BackingField = value;
		}
	}

	public bool DestroyOnClose
	{
		get
		{
			return _003CDestroyOnClose_003Ek__BackingField;
		}
		set
		{
			_003CDestroyOnClose_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnClose
	{
		get
		{
			return _003COnClose_003Ek__BackingField;
		}
		set
		{
			_003COnClose_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	[JsonIgnore]
	public ViewItem Header
	{
		get
		{
			if (base.Items.Count <= 0)
			{
				return null;
			}
			return base.Items[0];
		}
	}

	[JsonIgnore]
	[NotResettable]
	public System.Collections.Generic.IEnumerable<ViewItem> Nodes
	{
		get
		{
			if (base.Items.Count <= 0)
			{
				return null;
			}
			return (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Skip<ViewItem>((System.Collections.Generic.IEnumerable<ViewItem>)base.Items, 1);
		}
	}

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

	[DynamicProperty(false)]
	[JsonIgnore]
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

	public ContentNavigationViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is ContentNavigationNodeViewItem;
	}
}
