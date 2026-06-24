using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface IDocumentMetadataHeadDTOManager : IConfigurationService
{
	DocumentMetadataHeadDTO Save(DocumentMetadataHeadDTO head);

	DocumentMetadataHeadDTO Create(EntityMetadata metadata, DocumentMetadataGroupDTO group, Guid metadataType);

	void Move(DocumentMetadataHeadDTO head, DocumentMetadataGroupDTO group);

	void Delete(DocumentMetadataHeadDTO head);

	void Restore(DocumentMetadataHeadDTO head);

	List<Guid> ActiveUids(Guid metadataUid);

	void SaveControlOnSendingChanges(ControlOnSendingItem item);

	List<DocumentMetadataHeadDTO> FindAll(Guid metadataType);
}
