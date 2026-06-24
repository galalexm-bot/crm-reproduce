using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Globalization;

public interface ITranslateDTOManager : IConfigurationService
{
	bool IsTranslationMode();

	string[] GetServerLocals();

	bool IsTranslationChanged(LocalizationHash[] designerLocalizationHash);

	byte[] GetTranslations(LocalizationHash[] designerLocalizationHash);

	CultureInfoSimple GetDefaultLocal();
}
