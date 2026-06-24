namespace EleWise.ELMA.FeatureFlags.Services;

public interface IFeatureFlagService
{
	bool Enabled(string name, bool defaultEnabled);
}
