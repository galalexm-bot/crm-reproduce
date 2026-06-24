using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbar;

namespace EleWise.ELMA.Model.Views;

public class FormViewItem : RootViewItem, IContainerViewItem, IThemeContainerViewItem
{
	[Component]
	private class ToolboxItem : AdditionalViewItemToolboxItem<FormViewItem>
	{
		public override Guid Uid => new Guid("{48CC9BAE-358A-4EE2-9EFC-3DCE670203C2}");

		public override string Name => SR.T("Форма");

		public override bool Visible => false;

		public ToolboxItem(IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
		}
	}

	private ViewType _003CViewType_003Ek__BackingField;

	private Guid _003CGroupUid_003Ek__BackingField;

	private Guid _003CTargetUid_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private Guid _003CMainPlaceholderUid_003Ek__BackingField;

	private string _003COnLoadScriptName_003Ek__BackingField;

	private RuntimeVersion _003CRuntimeVersion_003Ek__BackingField;

	private ViewItemTheme _003CTheme_003Ek__BackingField;

	private ToolbarViewItem _003CToolbar_003Ek__BackingField;

	[NotResettable]
	public ViewType ViewType
	{
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		set
		{
			_003CViewType_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public Guid GroupUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CGroupUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CGroupUid_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public Guid TargetUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTargetUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTargetUid_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public string DisplayName
	{
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		set
		{
			_003CDisplayName_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public Guid MainPlaceholderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CMainPlaceholderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CMainPlaceholderUid_003Ek__BackingField = value;
		}
	}

	public string OnLoadScriptName
	{
		get
		{
			return _003COnLoadScriptName_003Ek__BackingField;
		}
		set
		{
			_003COnLoadScriptName_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public RuntimeVersion RuntimeVersion
	{
		get
		{
			return _003CRuntimeVersion_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeVersion_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemTheme Theme
	{
		get
		{
			return _003CTheme_003Ek__BackingField;
		}
		set
		{
			_003CTheme_003Ek__BackingField = value;
		}
	}

	public ToolbarViewItem Toolbar
	{
		get
		{
			return _003CToolbar_003Ek__BackingField;
		}
		set
		{
			_003CToolbar_003Ek__BackingField = value;
		}
	}

	public FormViewItem CloneAsReadOnly()
	{
		SetReadOnly();
		return this;
	}

	public bool IsReadOnly()
	{
		if (ReadOnly.get_HasValue())
		{
			return ReadOnly.get_Value();
		}
		if (base.FormViewItem?.Parent != null)
		{
			return base.FormViewItem.IsReadOnly();
		}
		return false;
	}

	protected internal override void SetReadOnly()
	{
		base.SetReadOnly();
		ReadOnly = true;
	}

	public bool IsValid()
	{
		ViewItem invalidItem;
		return IsValid(out invalidItem);
	}

	public bool IsValid(out ViewItem invalidItem)
	{
		invalidItem = null;
		return true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem == null;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
