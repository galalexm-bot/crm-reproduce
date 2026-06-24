using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Globalization.DTO;

public interface ILocalizationLoader : IConfigurationService
{
	byte[] Execute(LocalizationLoadSettings settings);
}
