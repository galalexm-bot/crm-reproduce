namespace EleWise.ELMA.FeatureFlags.Models;

public interface IFeatureFlag
{
	string Name { get; }

	bool Enabled();
}
