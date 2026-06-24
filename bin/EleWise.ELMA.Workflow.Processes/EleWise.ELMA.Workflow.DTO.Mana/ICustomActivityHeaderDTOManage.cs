using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface ICustomActivityHeaderDTOManager : IConfigurationService
{
	CustomActivityHeaderDTO Save(CustomActivityHeaderDTO activity);

	CustomActivityHeaderDTO LoadOrNull(long id);

	CustomActivityHeaderDTO LoadOrNull(Guid uid);

	bool CheckCustomActivityName(long id, string name, out string errorMessage);

	bool CheckCustomActivityClassName(long id, string name, out string errorMessage);

	bool CheckCustomActivityTableName(long id, string name, out string errorMessage);

	IEnumerable<CustomActivityHeaderDTO> LoadCustomActivityHeadersByName(string headerName);

	IEnumerable<CustomActivityHeaderDTO> LoadPublishedCustomActivityHeaders();

	IEnumerable<CustomActivityHeaderDTO> LoadPublishedCustomActivityHeaders(bool deletedIncluded);

	void Delete(CustomActivityHeaderDTO header);

	CustomActivityCommonStatistics GetCommonStatistics();

	List<CustomActivityHeaderDTO> FindDeleted();

	CustomActivityPublishingException[] Publish(CustomActivityHeaderDTO[] headers);
}
