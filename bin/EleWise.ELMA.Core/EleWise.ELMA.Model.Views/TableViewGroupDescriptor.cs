using System;
using System.ComponentModel;
using Bridge;

namespace EleWise.ELMA.Model.Views;

public class TableViewGroupDescriptor : Reactive, IEquatable<TableViewGroupDescriptor>, IBridgeClass
{
	private Guid _003CPropertyUid_003Ek__BackingField;

	private ListSortDirection _003CDirection_003Ek__BackingField;

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

	public ListSortDirection Direction
	{
		get
		{
			return _003CDirection_003Ek__BackingField;
		}
		set
		{
			_003CDirection_003Ek__BackingField = value;
		}
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as TableViewGroupDescriptor);
	}

	public bool Equals(TableViewGroupDescriptor other)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (other != null && PropertyUid == other.PropertyUid)
		{
			return Direction == other.Direction;
		}
		return false;
	}
}
