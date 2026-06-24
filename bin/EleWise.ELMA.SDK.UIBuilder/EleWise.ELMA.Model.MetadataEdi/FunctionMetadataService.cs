using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

namespace EleWise.ELMA.Model.MetadataEdit.Services;

[Service]
internal sealed class FunctionMetadataService : IFunctionMetadataService
{
	private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;

	private readonly IFunctionMetadataItemManager functionMetadataItemManager;

	public FunctionMetadataService(IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager, IFunctionMetadataItemManager functionMetadataItemManager)
	{
		this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
		this.functionMetadataItemManager = functionMetadataItemManager;
	}

	public IExecutionResult<FunctionMetadataItemHeaderDTO> Create(IUIItemModel iuiModel)
	{
		return new ExecutionResult<FunctionMetadataItemHeaderDTO>(Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(functionMetadataItemManager.Create(iuiModel.ModuleUid, iuiModel.GroupUid, iuiModel.DisplayName).Header));
	}

	public IExecutionResult<FunctionMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<FunctionMetadataItemHeaderDTO>(Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(functionMetadataItemManager.Copy(iuiModel.HeaderUid).Header));
	}

	public void Delete(IUIHeadedModel iuiModel)
	{
		GetHeader(iuiModel.HeaderUid).Delete();
	}

	public IExecutionResult<FunctionMetadataItemHeaderDTO> Edit(IUIItemModel iuiModel)
	{
		return new ExecutionResult<FunctionMetadataItemHeaderDTO>(Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(functionMetadataItemHeaderManager.Edit(iuiModel.HeaderUid, iuiModel.GroupUid)));
	}

	public IExecutionResult<GenerateFunctionCodeResponse> GenerateCode(GenerateFunctionCodeRequest model)
	{
		return new ExecutionResult<GenerateFunctionCodeResponse>(functionMetadataItemManager.GenerateCode(model));
	}

	public IExecutionResult<FunctionMetadataItemDTO> Load(Guid uid)
	{
		return new ExecutionResult<FunctionMetadataItemDTO>(Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(functionMetadataItemManager.Load(uid)));
	}

	public IExecutionResult<FunctionMetadataItemDTO[]> LoadByUids(Guid[] uids)
	{
		return new ExecutionResult<FunctionMetadataItemDTO[]>(((IEnumerable<FunctionMetadataItem>)functionMetadataItemManager.Find((FunctionMetadataItem a) => uids.Contains(a.Uid))).Select((Func<FunctionMetadataItem, FunctionMetadataItemDTO>)Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>).ToArray());
	}

	public IExecutionResult<FunctionMetadataItemHeaderDTO[]> LoadHeaderAll()
	{
		return new ExecutionResult<FunctionMetadataItemHeaderDTO[]>(((IEnumerable<FunctionMetadataItemHeader>)functionMetadataItemHeaderManager.Find(FetchOptions.All)).Select((Func<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>)Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>).ToArray());
	}

	public IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<UIMetadataPublishResult>(functionMetadataItemManager.Publish(iuiModel.HeaderUid, SR.T("Публикация")));
	}

	public IExecutionResult<FunctionMetadataItemDTO> Save(FunctionMetadataItemDTO functionItem)
	{
		FunctionMetadata oldMetadata = functionMetadataItemManager.LoadOrNull(functionItem.Uid)?.Metadata as FunctionMetadata;
		FunctionMetadataItem functionMetadataItem = Mapper.Map<FunctionMetadataItem>((object)functionItem);
		string sourceCode = functionMetadataItemManager.UpdateScriptCode(functionMetadataItem.Metadata as FunctionMetadata, oldMetadata, functionMetadataItem.ScriptModule.SourceCode);
		functionMetadataItem.ScriptModule.SourceCode = sourceCode;
		functionMetadataItem.Header.IsDirtyItem = true;
		functionMetadataItemManager.Save(functionMetadataItem);
		return new ExecutionResult<FunctionMetadataItemDTO>(Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(functionMetadataItem));
	}

	private FunctionMetadataItemHeader GetHeader(Guid headerUid)
	{
		FunctionMetadataItemHeader functionMetadataItemHeader = functionMetadataItemHeaderManager.LoadOrNull(headerUid);
		Contract.ArgumentNotNull(functionMetadataItemHeader, SR.T("Не найден заголовок функции по идентификатору \"{0}\"", headerUid));
		return functionMetadataItemHeader;
	}
}
