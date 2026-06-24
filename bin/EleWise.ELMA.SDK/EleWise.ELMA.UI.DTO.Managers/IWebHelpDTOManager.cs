using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IWebHelpDTOManager : IConfigurationService
{
	string GetHelpUrl(string pagePath);
}
