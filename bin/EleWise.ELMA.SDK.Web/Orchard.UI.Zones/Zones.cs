using System;
using System.Dynamic;
using System.Linq;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.UI.Zones;

public class Zones : Composite
{
	private readonly Func<dynamic> _zoneFactory;

	private readonly object _parent;

	public Zones(Func<dynamic> zoneFactory, object parent)
	{
		_zoneFactory = zoneFactory;
		_parent = parent;
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		return TryGetMemberImpl(binder.Name, out result);
	}

	protected override bool TryGetMemberImpl(string name, out object result)
	{
		dynamic val = ((dynamic)_parent)[name];
		if (val == null)
		{
			result = new ZoneOnDemand(_zoneFactory, _parent, name);
			return true;
		}
		result = val;
		return true;
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		if (indexes.Count() == 1)
		{
			string name = Convert.ToString(indexes.Single());
			return TryGetMemberImpl(name, out result);
		}
		return base.TryGetIndex(binder, indexes, out result);
	}
}
