using System;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface IDocumentMetadataGroupDTOManager : IConfigurationService
{
	DocumentMetadataGroupDTO LoadRootGroup(Guid metadataType);

	DocumentMetadataGroupDTO LoadRecycleGroup(Guid metadataType);

	DocumentMetadataGroupDTO Save(DocumentMetadataGroupDTO group);

	void SaveGroupName(long id, string name);

	DocumentMetadataGroupDTO Load(long id);

	void Delete(DocumentMetadataGroupDTO group);

	bool HasDocumentsTypesInGroup(DocumentMetadataGroupDTO group);

	bool ValidateMove(DocumentMetadataGroupDTO group, DocumentMetadataGroupDTO destGroup, out string error);

	void Move(DocumentMetadataGroupDTO group, DocumentMetadataGroupDTO destGroup);
}
