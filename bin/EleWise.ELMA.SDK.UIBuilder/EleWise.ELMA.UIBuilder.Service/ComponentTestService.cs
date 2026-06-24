using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ComponentTestService : IComponentTestService
{
	private readonly IFeatureFlagService featureFlagService;

	public ComponentTestService(IFeatureFlagService featureFlagService)
	{
		this.featureFlagService = featureFlagService;
	}

	public int GetTestMode()
	{
		if (!featureFlagService.Enabled("Exp_AutoTestEnabled", defaultEnabled: false))
		{
			return 0;
		}
		return 1;
	}
}
