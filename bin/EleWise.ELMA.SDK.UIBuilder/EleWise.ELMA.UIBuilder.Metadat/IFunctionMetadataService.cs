using System;
using EleWise.ELMA.Model;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

public interface IFunctionMetadataService
{
	IExecutionResult<FunctionMetadataItemHeaderDTO> Create(IUIItemModel iuiModel);

	IExecutionResult<FunctionMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel);

	void Delete(IUIHeadedModel iuiModel);

	IExecutionResult<FunctionMetadataItemHeaderDTO> Edit(IUIItemModel iuiModel);

	IExecutionResult<GenerateFunctionCodeResponse> GenerateCode(GenerateFunctionCodeRequest model);

	IExecutionResult<FunctionMetadataItemDTO> Load(Guid uid);

	IExecutionResult<FunctionMetadataItemDTO[]> LoadByUids(Guid[] uids);

	IExecutionResult<FunctionMetadataItemHeaderDTO[]> LoadHeaderAll();

	IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel);

	IExecutionResult<FunctionMetadataItemDTO> Save(FunctionMetadataItemDTO functionItem);
}
