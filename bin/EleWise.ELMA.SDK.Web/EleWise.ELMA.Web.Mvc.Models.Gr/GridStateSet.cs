using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class GridStateSet : SortedSet<ColumnState>, ICloneable
{
	[NonSerialized]
	[XmlIgnore]
	private Dictionary<string, ColumnState> _columnStatesByUniqueName;

	[NonSerialized]
	[XmlIgnore]
	private bool _hasChangesInStates = true;

	private static FieldInfo siInfoBaseField;

	private static FieldInfo setField;

	private static FieldInfo siInfoField;

	private static FieldInfo keyComparerField;

	public ColumnState this[string uniqueName]
	{
		get
		{
			if (!GetColumnStatesWithUnique().TryGetValue(uniqueName, out var value))
			{
				return null;
			}
			return value;
		}
	}

	public GridStateSet()
	{
	}

	public GridStateSet(ICollection<ColumnState> initialValues)
		: base((IEnumerable<ColumnState>)initialValues)
	{
	}

	protected GridStateSet(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	protected override void OnDeserialization(object sender)
	{
		siInfoBaseField = siInfoBaseField ?? typeof(SortedSet<ColumnState>).GetField("siInfo", BindingFlags.Instance | BindingFlags.NonPublic);
		setField = setField ?? typeof(SortedDictionary<ColumnState, object>).GetField("_set", BindingFlags.Instance | BindingFlags.NonPublic);
		siInfoField = siInfoField ?? typeof(SortedSet<KeyValuePair<ColumnState, object>>).GetField("siInfo", BindingFlags.Instance | BindingFlags.NonPublic);
		keyComparerField = keyComparerField ?? typeof(SortedDictionary<, >).GetNestedType("KeyValuePairComparer", BindingFlags.NonPublic).MakeGenericType(typeof(ColumnState), typeof(object)).GetField("keyComparer", BindingFlags.Instance | BindingFlags.NonPublic);
		object obj = null;
		SerializationInfo serializationInfo = (SerializationInfo)siInfoBaseField.GetValue(this);
		SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SerializationEntry current = enumerator.Current;
			if (current.Name == "Comparer" || current.Name == "Count" || current.Name == "Version" || current.Name == "Items")
			{
				break;
			}
			if (current.Name == "InternalDictionary")
			{
				obj = current.Value;
				break;
			}
		}
		if (obj != null)
		{
			object value = setField.GetValue(obj);
			SerializationInfo serializationInfo2 = (SerializationInfo)siInfoField.GetValue(value);
			KeyValuePair<ColumnState, object>[] source = (KeyValuePair<ColumnState, object>[])serializationInfo2.GetValue("Items", typeof(KeyValuePair<ColumnState, object>[]));
			serializationInfo.AddValue("Count", serializationInfo2.GetValue("Count", typeof(object)));
			serializationInfo.AddValue("Version", serializationInfo2.GetValue("Version", typeof(object)));
			serializationInfo.AddValue("Comparer", keyComparerField.GetValue(serializationInfo2.GetValue("Comparer", typeof(object))));
			serializationInfo.AddValue("Items", source.Select((KeyValuePair<ColumnState, object> i) => i.Key).ToArray());
		}
		base.OnDeserialization(sender);
	}

	public new bool Add(ColumnState o)
	{
		bool num = base.Add(o);
		if (num)
		{
			_hasChangesInStates = true;
		}
		return num;
	}

	public bool AddAll(ICollection<ColumnState> c)
	{
		bool flag = false;
		foreach (ColumnState item in c)
		{
			flag |= Add(item);
		}
		if (flag)
		{
			_hasChangesInStates = true;
		}
		return flag;
	}

	public object Clone()
	{
		return new GridStateSet(this.Select((ColumnState s) => (ColumnState)s.Clone()).ToList());
	}

	internal IDictionary<string, ColumnState> GetColumnStatesWithUnique()
	{
		if (_hasChangesInStates || _columnStatesByUniqueName == null)
		{
			_columnStatesByUniqueName = this.ToDictionary((ColumnState m) => m.UniqueName);
			_hasChangesInStates = false;
		}
		return _columnStatesByUniqueName;
	}
}
