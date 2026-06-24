using System;
using Orleans.Placement;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Placements;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class SiloPlacementAttribute : PlacementAttribute
{
	public SiloPlacementAttribute()
		: base((PlacementStrategy)(object)SiloPlacement.Singleton)
	{
	}
}
