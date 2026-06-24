using System;
using System.Collections.Generic;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

public interface IModuleMetadataService
{
	IExecutionResult<ModuleMetadataItemHeaderDTO> Create(IUIEditionsModel model);

	IExecutionResult<string[]> GetEditionTags();

	IExecutionResult<ModuleMetadataItemDTO> Load(Guid uid);

	void Delete(IUIHeadedModel iuiModel);

	IExecutionResult<ModuleMetadataItemDTO[]> GetDrafts();

	IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel);

	void AddReference(Guid moduleUid, ICollection<LinkToModule> references);

	IExecutionResult<ModuleMetadataItemHeaderDTO> SaveHeader(ModuleMetadataItemHeaderDTO header);

	IExecutionResult<ModuleMetadataItemHeaderDTO[]> LoadHeaderAll();

	IExecutionResult<SystemMetadata[]> GetSystemMetadata(InitDataModel initDataModel);

	IExecutionResult<SystemInitData> GetSystemInitData(InitDataModel initDataModel);
}
