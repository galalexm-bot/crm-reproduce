using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

public interface IUIMetadataService
{
	IExecutionResult<IEnumerable<INamespaceInfo>> GetNamespaceInfo();

	IExecutionResult<IEnumerable<NamespaceMetadata>> GetNamespaceMetadata();

	IExecutionResult<IEnumerable<MetadataItemGroupDTO>> GetMetadataItemGroups();

	IExecutionResult<IEnumerable<VisibleGroupInfoDTO>> FindVisibleGroupsAndViewItems(NamedMetadata metadata);

	IExecutionResult<IEnumerable<MetadataHeaderDTO>> GetMetadataHeaders(MetadataHeadersModel metadataHeadersModel);

	IExecutionResult<IMetadata> LoadDraftMetadataByTypeUid(Guid type);

	IExecutionResult<IEnumerable<MetadataHeaderDTO>> LoadMetadataHeaders(IEnumerable<LoadMetadataHeaders> updateRequests);
}
