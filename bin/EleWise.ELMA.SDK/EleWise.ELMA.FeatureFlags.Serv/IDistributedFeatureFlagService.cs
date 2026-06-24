using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.FeatureFlags.Services;

public interface IDistributedFeatureFlagService
{
	IEnumerable<Guid> AvailableServers { get; }

	Task<bool> Enabled(Guid serverUid, string name, bool defaultEnabled);
}
