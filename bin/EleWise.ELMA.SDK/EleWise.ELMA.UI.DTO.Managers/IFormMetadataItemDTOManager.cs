using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.UI.DTO.Models;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IFormMetadataItemDTOManager : IConfigurationService
{
	FormMetadataItemDTO Load(long id);

	FormMetadataItemDTO Save(FormMetadataItemDTO objDto);

	void Publish(long headerId, string comment, bool forEmulation);

	void Publish(long[] headerIds, string comment);
}
