using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Services;

public interface IMetadataEditorService : IMetadataService
{
	string ProjectName { get; }

	string CurrentProjectName { get; set; }

	AssemblyInfoMetadata GetAssemblyInfoMetadata(string projectName);

	IEnumerable<IMetadata> GetMetadataList(bool inherited);

	IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited);

	IMetadata GetMetadata(string projectName, Guid metadataUid);

	void SaveMetadata(IMetadata metadata);

	void SaveMetadata(IEnumerable<IMetadata> metadataList);

	void PublishMetadata(IMetadata metadata, string comment);

	void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment);

	void RemoveMetadata(IMetadata metadata);

	ICodeGenerator CreateCodeGenerator(IMetadata metadata);

	void BuildDocumentation();

	MetadataItemDTO GetMetadataItemDTO(IMetadata metadata);

	IEnumerable<MetadataItemDTO> GetMetadataItemDTOList();
}
