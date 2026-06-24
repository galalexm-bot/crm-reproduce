using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.DTO.Managers;

public interface IWebApplicationDTOManager : IConfigurationService
{
	IEnumerable<string> GetViewsTree(string prefix, bool isProperty);

	IEnumerable<WebFileDTO> GetFilePlaces(string partialViewName, IPropertyMetadata propertyMetadata);

	void SaveFiles(IEnumerable<ConfigurationFileDTO> filePlace);

	void CopyFiles(string oldPartialViewName, string newPartialViewName, bool isProperty);

	IEnumerable<string> GetExportViewsTree();

	bool CheckViewExists(string partialViewName, bool isProperty);
}
