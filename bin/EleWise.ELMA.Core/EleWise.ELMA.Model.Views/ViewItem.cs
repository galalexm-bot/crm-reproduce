using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

[Component(CreateInstancePerResolve = true)]
public abstract class ViewItem : IViewItem, IReactive
{
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public ViewItem thisViewItem;

		internal bool _003CGetOtherItemNames_003Eb__0(ViewItem i)
		{
			return i != thisViewItem;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ViewItem, string> _003C_003E9__69_1;

		internal string _003CGetOtherItemNames_003Eb__69_1(ViewItem i)
		{
			if (i.Name == null)
			{
				return "";
			}
			return i.Name.ToLower();
		}
	}

	internal const string ViewItemPostfix = "ViewItem";

	private string _003CName_003Ek__BackingField;

	private Guid _003CUid_003Ek__BackingField;

	private bool _003CHide_003Ek__BackingField;

	private ViewItemHideMode _003CHideMode_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ComputedValue> _003CDynamicProperties_003Ek__BackingField;

	private string _003CTestId_003Ek__BackingField;

	private DefaultAction _003COnMouseEnter_003Ek__BackingField;

	private DefaultAction _003COnMouseLeave_003Ek__BackingField;

	private DefaultAction _003COnEnter_003Ek__BackingField;

	private DefaultAction _003COnEscape_003Ek__BackingField;

	private RootViewItem _003CParent_003Ek__BackingField;

	private ViewItem _003CTransformatedViewItem_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public virtual Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public virtual bool Hide
	{
		get
		{
			return _003CHide_003Ek__BackingField;
		}
		set
		{
			_003CHide_003Ek__BackingField = value;
		}
	}

	public ViewItemHideMode HideMode
	{
		get
		{
			return _003CHideMode_003Ek__BackingField;
		}
		set
		{
			_003CHideMode_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	public System.Collections.Generic.ICollection<ComputedValue> DynamicProperties
	{
		get
		{
			return _003CDynamicProperties_003Ek__BackingField;
		}
		set
		{
			_003CDynamicProperties_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string TestId
	{
		get
		{
			return _003CTestId_003Ek__BackingField;
		}
		set
		{
			_003CTestId_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public DefaultAction OnMouseEnter
	{
		get
		{
			return _003COnMouseEnter_003Ek__BackingField;
		}
		set
		{
			_003COnMouseEnter_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnMouseLeave
	{
		get
		{
			return _003COnMouseLeave_003Ek__BackingField;
		}
		set
		{
			_003COnMouseLeave_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnEnter
	{
		get
		{
			return _003COnEnter_003Ek__BackingField;
		}
		set
		{
			_003COnEnter_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnEscape
	{
		get
		{
			return _003COnEscape_003Ek__BackingField;
		}
		set
		{
			_003COnEscape_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[NotResettable]
	public RootViewItem Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		internal set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	[JsonIgnore]
	public FormViewItem FormViewItem => FindParent<FormViewItem>(this);

	[NotResettable]
	[JsonIgnore]
	public ViewItem Root
	{
		get
		{
			ViewItem viewItem = this;
			while (viewItem.Parent != null)
			{
				viewItem = viewItem.Parent;
			}
			return viewItem;
		}
	}

	[JsonIgnore]
	[NotResettable]
	public ViewItem TransformatedViewItem
	{
		get
		{
			return _003CTransformatedViewItem_003Ek__BackingField;
		}
		private set
		{
			_003CTransformatedViewItem_003Ek__BackingField = value;
		}
	}

	public bool IsUid(Guid uid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (!(Uid == uid))
		{
			if (TransformatedViewItem != null)
			{
				return TransformatedViewItem.IsUid(uid);
			}
			return false;
		}
		return true;
	}

	public virtual bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public virtual bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public virtual void OnAdding(RootViewItem parent)
	{
	}

	public virtual void OnAdded(RootViewItem parent)
	{
	}

	public virtual void OnRemoving(RootViewItem parent)
	{
	}

	public virtual void OnRemoved(RootViewItem parent)
	{
	}

	public ViewItem Clone()
	{
		ViewItem viewItem = SerializationHelper.CloneObject(this);
		viewItem.Parent = Parent;
		return viewItem;
	}

	IViewItem IViewItem.Clone()
	{
		return Clone();
	}

	public virtual void InitNew(ViewItem parent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(Name))
		{
			return;
		}
		if (Uid == Guid.Empty)
		{
			Uid = Guid.NewGuid();
		}
		if (parent == null)
		{
			return;
		}
		List<string> otherItemNames = GetOtherItemNames(this, parent.Root);
		string defaultName = GetDefaultName();
		for (int i = 1; i <= 1000000; i++)
		{
			string text = string.Concat((object)defaultName, (object)i);
			if (!otherItemNames.Contains(text.ToLower()))
			{
				Name = text;
				return;
			}
		}
		Guid uid = Uid;
		Name = "Item_" + ((Guid)(ref uid)).ToString("n");
	}

	public virtual bool IsEmpty()
	{
		return false;
	}

	public override string ToString()
	{
		return Name ?? "";
	}

	protected ViewItem()
	{
		DynamicProperties = new ReactiveCollection<ComputedValue>();
	}

	protected internal virtual void SetReadOnly()
	{
	}

	protected virtual string GetDefaultName()
	{
		string name = base.GetType().get_Name();
		if (base.GetType() == typeof(ViewItem) || !name.EndsWith("ViewItem"))
		{
			return name;
		}
		return name.Substring(0, name.get_Length() - "ViewItem".get_Length());
	}

	private T FindParent<T>(ViewItem startItem) where T : class
	{
		ViewItem viewItem = startItem;
		while (viewItem != null && !(viewItem is T))
		{
			viewItem = viewItem.Parent;
		}
		return viewItem as T;
	}

	private static List<string> GetOtherItemNames(ViewItem thisViewItem, ViewItem root)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass69_0();
		CS_0024_003C_003E8__locals0.thisViewItem = thisViewItem;
		return Enumerable.Select<ViewItem, string>((System.Collections.Generic.IEnumerable<ViewItem>)((root is RootViewItem rootViewItem) ? Enumerable.Where<ViewItem>(rootViewItem.GetAllItems(ignoreHide: false), (Func<ViewItem, bool>)((ViewItem i) => i != CS_0024_003C_003E8__locals0.thisViewItem)).ToArray() : new ViewItem[0]), (Func<ViewItem, string>)((ViewItem i) => (i.Name == null) ? "" : i.Name.ToLower())).ToList();
	}
}
