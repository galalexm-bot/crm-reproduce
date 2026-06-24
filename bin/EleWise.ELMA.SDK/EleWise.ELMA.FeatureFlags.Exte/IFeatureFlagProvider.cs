using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.FeatureFlags.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IFeatureFlagProvider
{
	event EventHandler FlagsChanged;

	IEnumerable<(string featureFlagName, bool enabled)> GetFlags(IEnumerable<string> featureFlagNames);
}
