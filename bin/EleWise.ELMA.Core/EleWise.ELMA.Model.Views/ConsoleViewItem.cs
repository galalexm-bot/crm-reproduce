using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class ConsoleViewItem : RootViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component(Order = 650)]
	private class ToolboxItem : CommonViewItemToolboxItem<ConsoleViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{8AC966E3-BEC5-4B32-8B6F-8360A6486DCF}");

		public override string Name => SR.T("Информационная консоль");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "command";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}

		public override string GetSlotName(Guid uid)
		{
			return SR.T("Информационная консоль");
		}
	}

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private ConsoleSort _003CConsoleSort_003Ek__BackingField;

	private DefaultAction _003COnClose_003Ek__BackingField;

	private DefaultAction _003COnClear_003Ek__BackingField;

	private ConsoleItemType _003CConsoleItemType_003Ek__BackingField;

	private string _003CConsoleContent_003Ek__BackingField;

	private DefaultAction _003COnClick_003Ek__BackingField;

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
	public ConsoleSort ConsoleSort
	{
		get
		{
			return _003CConsoleSort_003Ek__BackingField;
		}
		set
		{
			_003CConsoleSort_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public DefaultAction OnClear
	{
		get
		{
			return _003COnClear_003Ek__BackingField;
		}
		set
		{
			_003COnClear_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	public ConsoleItemType ConsoleItemType
	{
		get
		{
			return _003CConsoleItemType_003Ek__BackingField;
		}
		set
		{
			_003CConsoleItemType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	public string ConsoleContent
	{
		get
		{
			return _003CConsoleContent_003Ek__BackingField;
		}
		set
		{
			_003CConsoleContent_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	[JsonIgnore]
	public DefaultAction OnClick
	{
		get
		{
			return _003COnClick_003Ek__BackingField;
		}
		set
		{
			_003COnClick_003Ek__BackingField = value;
		}
	}

	public ConsoleViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
