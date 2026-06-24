using System.Collections.Generic;

namespace Orchard.UI;

internal class ZoneCollection : IZoneCollection
{
	private readonly IDictionary<string, IZone> _zones = new Dictionary<string, IZone>();

	public IZone this[string key]
	{
		get
		{
			if (!_zones.ContainsKey(key))
			{
				_zones[key] = new Zone();
			}
			return _zones[key];
		}
	}
}
