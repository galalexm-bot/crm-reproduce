using System.Collections.Generic;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class TreeSelectViewItem : ViewItem, IFocusable
{
	private string _003CPlaceholder_003Ek__BackingField;

	private bool _003CSelectableParentNode_003Ek__BackingField;

	private ActionWithParam<TreeSelectSearchEventArgs> _003COnSearch_003Ek__BackingField;

	private ActionWithParam<TreeSelectFilterEventArgs> _003COnFilter_003Ek__BackingField;

	private ActionWithParam<TreeSelectEventArgs> _003COnSelect_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ITreeModel> _003CGetSource_003Ek__BackingField;

	private DropDownItem _003CValue_003Ek__BackingField;

	private FocusableType _003CFocusableType_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Placeholder
	{
		get
		{
			return _003CPlaceholder_003Ek__BackingField;
		}
		set
		{
			_003CPlaceholder_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool SelectableParentNode
	{
		get
		{
			return _003CSelectableParentNode_003Ek__BackingField;
		}
		set
		{
			_003CSelectableParentNode_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<TreeSelectSearchEventArgs> OnSearch
	{
		get
		{
			return _003COnSearch_003Ek__BackingField;
		}
		set
		{
			_003COnSearch_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<TreeSelectFilterEventArgs> OnFilter
	{
		get
		{
			return _003COnFilter_003Ek__BackingField;
		}
		set
		{
			_003COnFilter_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<TreeSelectEventArgs> OnSelect
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public System.Collections.Generic.ICollection<ITreeModel> GetSource
	{
		get
		{
			return _003CGetSource_003Ek__BackingField;
		}
		set
		{
			_003CGetSource_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public DropDownItem Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public FocusableType FocusableType
	{
		get
		{
			return _003CFocusableType_003Ek__BackingField;
		}
		set
		{
			_003CFocusableType_003Ek__BackingField = value;
		}
	}

	public bool FocusableEnabled => true;
}
