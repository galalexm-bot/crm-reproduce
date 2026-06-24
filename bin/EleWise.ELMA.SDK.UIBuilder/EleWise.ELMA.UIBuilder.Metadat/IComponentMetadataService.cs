using System;
using System.Collections.Generic;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

public interface IComponentMetadataService
{
	IExecutionResult<ComponentMetadataItemHeaderDTO> Create(IUIItemModel iuiModel);

	IExecutionResult<ComponentMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel);

	void Delete(IUIHeadedModel iuiModel);

	IExecutionResult<ComponentMetadataItemHeaderDTO> Edit(IUIItemModel iuiModel);

	IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel, bool forEmulation);

	IExecutionResult<ComponentMetadataItemDTO> Load(Guid uid);

	void MarkAsNotWorking(Guid uid);

	IExecutionResult<ComponentMetadataItemDTO> SaveAndUpdate(ComponentMetadataItemDTO metadata, string name);

	IExecutionResult<ComponentMetadataItemHeaderDTO[]> LoadHeaderAll();

	IExecutionResult<ComponentMetadataItemDTO> LoadDraft(IUIHeadedModel iuiModel);

	IExecutionResult<ComponentMetadataItemHeaderDTO> LoadHeader(IUIHeadedModel iuiModel);

	IExecutionResult<ComponentMetadataItemDTO[]> LoadHistory(IUIHeadedModel iuiModel);

	IExecutionResult<DataClassMetadata> CreateLocalDataClass(IUIHeadedModel iuiModel);

	IExecutionResult<RuntimeResponse> LoadRuntimeMetadata(bool debug, List<Guid> modules, List<Guid> components, List<Guid> dataClasses);
}
