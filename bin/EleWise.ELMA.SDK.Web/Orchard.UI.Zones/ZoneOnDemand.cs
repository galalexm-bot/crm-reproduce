using System;
using System.Dynamic;
using System.Linq;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.UI.Zones;

public class ZoneOnDemand : Shape
{
	private readonly Func<dynamic> _zoneFactory;

	private readonly object _parent;

	private readonly string _potentialZoneName;

	public ZoneOnDemand(Func<dynamic> zoneFactory, object parent, string potentialZoneName)
	{
		_zoneFactory = zoneFactory;
		_parent = parent;
		_potentialZoneName = potentialZoneName;
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		result = Nil.Instance;
		return true;
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		result = Nil.Instance;
		return true;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		string name = binder.Name;
		if (!args.Any() && name != "ToString")
		{
			result = Nil.Instance;
			return true;
		}
		return base.TryInvokeMember(binder, args, out result);
	}

	public override string ToString()
	{
		return string.Empty;
	}

	public override bool TryConvert(ConvertBinder binder, out object result)
	{
		if (binder.ReturnType == typeof(string))
		{
			result = null;
		}
		else if (binder.ReturnType.IsValueType)
		{
			result = Activator.CreateInstance(binder.ReturnType);
		}
		else
		{
			result = null;
		}
		return true;
	}

	public static bool operator ==(ZoneOnDemand a, object b)
	{
		if (b != null)
		{
			return b == Nil.Instance;
		}
		return true;
	}

	public static bool operator !=(ZoneOnDemand a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return true;
		}
		if ((object)this == obj)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((_parent != null) ? _parent.GetHashCode() : 0) * 397) ^ ((_potentialZoneName != null) ? _potentialZoneName.GetHashCode() : 0);
	}

	public override Shape Add(object item, string position = null)
	{
		if (item == null)
		{
			return (Shape)_parent;
		}
		dynamic parent = _parent;
		dynamic val = _zoneFactory();
		val.Parent = _parent;
		val.ZoneName = _potentialZoneName;
		parent[_potentialZoneName] = val;
		if (position != null)
		{
			return val.Add(item, position);
		}
		return val.Add(item);
	}
}
