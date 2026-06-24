using System;
using System.Dynamic;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.UI.Zones;

public class ZoneHolding : Shape
{
	private readonly Func<dynamic> _zoneFactory;

	private Zones _zones;

	public Zones Zones
	{
		get
		{
			if (_zones == null)
			{
				return _zones = new Zones(_zoneFactory, this);
			}
			return _zones;
		}
	}

	public ZoneHolding(Func<dynamic> zoneFactory)
	{
		_zoneFactory = zoneFactory;
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		string name = binder.Name;
		if (!base.TryGetMember(binder, out result) || result == null)
		{
			result = new ZoneOnDemand(_zoneFactory, this, name);
			TrySetMemberImpl(name, result);
		}
		return true;
	}
}
