using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Globalization;

public interface IServerLocalizationService : IConfigurationService
{
	string GetDefaultCultureName();
}
