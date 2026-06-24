using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.MetadataEdit.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Implementation;

[Service]
internal sealed class MetadataItemGroupUIService : IMetadataItemGroupUIService
{
	private readonly IMetadataItemGroupUIManager metadataItemGroupUiManager;

	public MetadataItemGroupUIService(IMetadataItemGroupUIManager metadataItemGroupUiManager)
	{
		this.metadataItemGroupUiManager = metadataItemGroupUiManager;
	}

	public IExecutionResult<MetadataItemGroupUIDTO> Create(IUIItemModel iuiModel)
	{
		return new ExecutionResult<MetadataItemGroupUIDTO>(Mapper.Map<MetadataItemGroupUI, MetadataItemGroupUIDTO>(metadataItemGroupUiManager.Create(iuiModel.TypeUid, iuiModel.ModuleUid, iuiModel.GroupUid, iuiModel.DisplayName, iuiModel.Name)));
	}

	public void Delete(IUIItemModel iuiModel)
	{
		MetadataItemGroupUI metadataItemGroupUI = metadataItemGroupUiManager.LoadOrNull(iuiModel.Uid);
		Contract.NotNull(metadataItemGroupUI, SR.T("Не найдена группа по указанному идентификатору: {0}", iuiModel.HeaderUid));
		metadataItemGroupUiManager.Delete(metadataItemGroupUI);
	}

	public IExecutionResult<MetadataItemGroupUIDTO> Edit(IUIItemModel iuiModel)
	{
		return new ExecutionResult<MetadataItemGroupUIDTO>(Mapper.Map<MetadataItemGroupUI, MetadataItemGroupUIDTO>(metadataItemGroupUiManager.Edit(iuiModel.Uid, iuiModel.TypeUid, iuiModel.ModuleUid, iuiModel.GroupUid, iuiModel.DisplayName, iuiModel.Name)));
	}

	public IExecutionResult<MetadataItemGroupUIDTO[]> LoadGroups()
	{
		return new ExecutionResult<MetadataItemGroupUIDTO[]>(((IEnumerable<MetadataItemGroupUI>)metadataItemGroupUiManager.Find(FetchOptions.All)).Select((Func<MetadataItemGroupUI, MetadataItemGroupUIDTO>)Mapper.Map<MetadataItemGroupUI, MetadataItemGroupUIDTO>).ToArray());
	}
}
