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

internal sealed class TreeViewItem : RootViewItem, ITreeViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive, ISelectionItemViewItem
{
	[Component(Order = 920)]
	private class ToolboxItem : CommonViewItemToolboxItem<TreeViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{6060622F-A4E0-4E52-9921-C7DBB7263CF5}");

		public override string Name => SR.T("Дерево");

		public override string Icon => "tree";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (uid == MainContentSlotUid)
			{
				result = SR.T("Основной контент элемента дерева");
			}
			if (uid == HoverContentSlotUid)
			{
				result = SR.T("Дополнительный контент элемента дерева");
			}
			return result;
		}
	}

	public static Guid MainContentSlotUid = new Guid("E3B5D4D4-0B22-4C55-B75A-FBEA2C1D370A");

	public static Guid HoverContentSlotUid = new Guid("26DC67F5-9F62-4081-9729-D61412C55348");

	private ViewItemTreeType _003CType_003Ek__BackingField;

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private Guid _003CKeyUid_003Ek__BackingField;

	private Guid _003CParentKeyUid_003Ek__BackingField;

	private Guid _003CSelectablePropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CSelectablePropertyParents_003Ek__BackingField;

	private bool _003CEnableSelection_003Ek__BackingField;

	private ActionWithParam<bool> _003COnSelect_003Ek__BackingField;

	private bool _003CShowTreeButtons_003Ek__BackingField;

	private bool _003CIsExpanded_003Ek__BackingField;

	private ActionWithParam<bool> _003COnExpand_003Ek__BackingField;

	[DynamicProperty(false)]
	public ViewItemTreeType Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

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

	public Guid KeyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CKeyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CKeyUid_003Ek__BackingField = value;
		}
	}

	public Guid ParentKeyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CParentKeyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CParentKeyUid_003Ek__BackingField = value;
		}
	}

	public Guid SelectablePropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSelectablePropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSelectablePropertyUid_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<Guid> SelectablePropertyParents
	{
		get
		{
			return _003CSelectablePropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CSelectablePropertyParents_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool EnableSelection
	{
		get
		{
			return _003CEnableSelection_003Ek__BackingField;
		}
		set
		{
			_003CEnableSelection_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	[JsonIgnore]
	public ActionWithParam<bool> OnSelect
	{
		get
		{
			return _003COnSelect_003Ek__BackingField;
		}
		set
		{
			_003COnSelect_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool ShowTreeButtons
	{
		get
		{
			return _003CShowTreeButtons_003Ek__BackingField;
		}
		set
		{
			_003CShowTreeButtons_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	public bool IsExpanded
	{
		get
		{
			return _003CIsExpanded_003Ek__BackingField;
		}
		set
		{
			_003CIsExpanded_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(true)]
	[JsonIgnore]
	public ActionWithParam<bool> OnExpand
	{
		get
		{
			return _003COnExpand_003Ek__BackingField;
		}
		set
		{
			_003COnExpand_003Ek__BackingField = value;
		}
	}

	public TreeViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is DynamicSlotViewItem;
	}
}
