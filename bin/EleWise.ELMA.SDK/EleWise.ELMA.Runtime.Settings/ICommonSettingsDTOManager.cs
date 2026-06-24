using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Runtime.Settings.DTO;

public interface ICommonSettingsDTOManager : IConfigurationService
{
	string GetApplicationBaseUrl();
}
