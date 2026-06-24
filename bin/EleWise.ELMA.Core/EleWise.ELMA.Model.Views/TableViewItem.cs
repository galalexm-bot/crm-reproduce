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

internal sealed class TableViewItem : RootViewItem, ISelectionItemViewItem
{
	[Component(Order = 510)]
	private class ToolboxItem : CommonViewItemToolboxItem<TableViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("B9EF1B97-F1B7-4858-BDCF-32BFDFD52FFD");

		public override string Name => SR.T("Таблица");

		public override string Icon => "table";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private TableView _003CTableView_003Ek__BackingField;

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private Guid _003CSelectablePropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CSelectablePropertyParents_003Ek__BackingField;

	private bool _003CEnableSelection_003Ek__BackingField;

	private ActionWithParam<bool> _003COnSelect_003Ek__BackingField;

	public override bool IsHideable => true;

	public TableView TableView
	{
		get
		{
			return _003CTableView_003Ek__BackingField;
		}
		set
		{
			_003CTableView_003Ek__BackingField = value;
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

	[JsonIgnore]
	[DynamicProperty(true)]
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

	public TableViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (!(childViewItem is IGridColumnViewItem))
		{
			return childViewItem is SlotViewItem;
		}
		return true;
	}
}
