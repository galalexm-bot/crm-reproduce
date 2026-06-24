using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Environment.Features;

public interface IFeatureManager : IDependency
{
	IEnumerable<FeatureDescriptor> GetAvailableFeatures();

	IEnumerable<FeatureDescriptor> GetEnabledFeatures();
}
