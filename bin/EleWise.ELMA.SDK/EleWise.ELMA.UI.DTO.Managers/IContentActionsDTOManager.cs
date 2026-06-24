using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IContentActionsDTOManager : IConfigurationService
{
	IEnumerable<ContentActionDTO> ContentActions();

	ContentActionDTO GetContentAction(string typeProviderId, string id);
}
