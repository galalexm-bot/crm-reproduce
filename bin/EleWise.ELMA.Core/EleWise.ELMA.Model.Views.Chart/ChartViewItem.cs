using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Charts;

internal abstract class ChartViewItem : ViewItem, IChartViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	private string _003CTitle_003Ek__BackingField;

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private Guid _003CValueUid_003Ek__BackingField;

	private Guid _003CNameUid_003Ek__BackingField;

	private ViewItemChartLegendViewType _003CLegendViewType_003Ek__BackingField;

	private ActionWithParam<object> _003COnMouseEnterElement_003Ek__BackingField;

	private ActionWithParam<object> _003COnMouseLeaveElement_003Ek__BackingField;

	private ActionWithParam<object> _003COnClickElement_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
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
	public Guid ValueUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CValueUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CValueUid_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public Guid NameUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CNameUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CNameUid_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemChartLegendViewType LegendViewType
	{
		get
		{
			return _003CLegendViewType_003Ek__BackingField;
		}
		set
		{
			_003CLegendViewType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<object> OnMouseEnterElement
	{
		get
		{
			return _003COnMouseEnterElement_003Ek__BackingField;
		}
		set
		{
			_003COnMouseEnterElement_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<object> OnMouseLeaveElement
	{
		get
		{
			return _003COnMouseLeaveElement_003Ek__BackingField;
		}
		set
		{
			_003COnMouseLeaveElement_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<object> OnClickElement
	{
		get
		{
			return _003COnClickElement_003Ek__BackingField;
		}
		set
		{
			_003COnClickElement_003Ek__BackingField = value;
		}
	}

	public ChartViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
