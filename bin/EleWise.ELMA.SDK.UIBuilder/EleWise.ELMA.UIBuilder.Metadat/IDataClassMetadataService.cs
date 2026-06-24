using System;
using EleWise.ELMA.Model;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

public interface IDataClassMetadataService
{
	IExecutionResult<DataClassMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel);

	IExecutionResult<DataClassMetadataItemHeaderDTO> Create(IUIItemModel iuiModel);

	void Delete(IUIHeadedModel iuiModel);

	IExecutionResult<DataClassMetadataItemHeaderDTO> Edit(IUIItemModel iuiModel);

	IExecutionResult<DataClassMetadataItemDTO> Load(Guid uid);

	IExecutionResult<DataClassMetadataItemHeaderDTO[]> LoadHeaderAll();

	IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel);

	void Save(DataClassMetadataItemDTO metadata);
}
