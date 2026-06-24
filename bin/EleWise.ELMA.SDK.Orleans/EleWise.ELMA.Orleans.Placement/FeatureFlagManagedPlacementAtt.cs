using System;
using Orleans.Placement;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Placements;

[AttributeUsage(AttributeTargets.Class)]
public sealed class FeatureFlagManagedPlacementAttribute : PlacementAttribute
{
	public FeatureFlagManagedPlacementAttribute(string featureFlagName, bool defaultEnabled)
		: base((PlacementStrategy)(object)new FeatureFlagManagedPlacement(featureFlagName, defaultEnabled))
	{
	}
}
