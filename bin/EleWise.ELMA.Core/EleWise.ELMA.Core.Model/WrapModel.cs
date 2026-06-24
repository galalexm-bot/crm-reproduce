using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model;

public class WrapModel : IWrapModel
{
	private Guid _003CUid_003Ek__BackingField;

	private Guid _003CSubTypeUid_003Ek__BackingField;

	private System.Type _003CType_003Ek__BackingField;

	private string _003CTypeName_003Ek__BackingField;

	private string _003CCaption_003Ek__BackingField;

	private bool _003CIsContainer_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private string _003CSlotName_003Ek__BackingField;

	public Guid Uid
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

	public Guid SubTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSubTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSubTypeUid_003Ek__BackingField = value;
		}
	}

	public System.Type Type
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

	public string TypeName
	{
		get
		{
			return _003CTypeName_003Ek__BackingField;
		}
		set
		{
			_003CTypeName_003Ek__BackingField = value;
		}
	}

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

	public bool IsContainer
	{
		get
		{
			return _003CIsContainer_003Ek__BackingField;
		}
		set
		{
			_003CIsContainer_003Ek__BackingField = value;
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

	public string SlotName
	{
		get
		{
			return _003CSlotName_003Ek__BackingField;
		}
		set
		{
			_003CSlotName_003Ek__BackingField = value;
		}
	}

	public WrapModel()
	{
	}

	public WrapModel(IViewItem viewItem)
		: this(viewItem, "")
	{
	}

	public WrapModel(IViewItem viewItem, string slotName)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(viewItem, "viewItem");
		System.Type type = ((object)viewItem).GetType();
		Guid subTypeUid = (viewItem as ComponentViewItem)?.HeaderUid ?? Guid.Empty;
		Uid = viewItem.Uid;
		Type = type;
		TypeName = type.get_Name();
		SubTypeUid = subTypeUid;
		Caption = type.get_Name();
		IsContainer = type.IsAssignableFrom(typeof(RootViewItem));
		SlotName = slotName;
		if (viewItem is PropertyViewItem propertyViewItem)
		{
			PropertyParents = propertyViewItem.PropertyParents;
		}
	}

	public WrapModel(IViewItem viewItem, string slotName, string caption)
		: this(viewItem, slotName)
	{
		Caption = caption;
	}
}
