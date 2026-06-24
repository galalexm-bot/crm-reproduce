using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Implementation;

[Service]
internal sealed class DataClassMetadataService : IDataClassMetadataService
{
	private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;

	private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;

	public DataClassMetadataService(IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, IDataClassMetadataItemManager dataClassMetadataItemManager)
	{
		this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
	}

	public IExecutionResult<DataClassMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<DataClassMetadataItemHeaderDTO>(Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(dataClassMetadataItemManager.Copy(iuiModel.HeaderUid).Header));
	}

	public IExecutionResult<DataClassMetadataItemHeaderDTO> Create(IUIItemModel iuiModel)
	{
		return new ExecutionResult<DataClassMetadataItemHeaderDTO>(Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(dataClassMetadataItemManager.Create(iuiModel.ModuleUid, iuiModel.GroupUid, iuiModel.DisplayName).Header));
	}

	public void Delete(IUIHeadedModel iuiModel)
	{
		GetHeader(iuiModel.HeaderUid).Delete();
	}

	public IExecutionResult<DataClassMetadataItemHeaderDTO> Edit(IUIItemModel editModel)
	{
		return new ExecutionResult<DataClassMetadataItemHeaderDTO>(Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(dataClassMetadataItemHeaderManager.Edit(editModel.HeaderUid, editModel.GroupUid)));
	}

	public IExecutionResult<DataClassMetadataItemDTO> Load(Guid uid)
	{
		DataClassMetadataItem dataClassMetadataItem = dataClassMetadataItemManager.LoadOrNull(uid);
		Contract.NotNull(dataClassMetadataItem != null, SR.T("Не найден тип метаданных по идентификатору {0}", uid));
		return new ExecutionResult<DataClassMetadataItemDTO>(Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(dataClassMetadataItem));
	}

	public IExecutionResult<DataClassMetadataItemHeaderDTO[]> LoadHeaderAll()
	{
		return new ExecutionResult<DataClassMetadataItemHeaderDTO[]>(((IEnumerable<DataClassMetadataItemHeader>)dataClassMetadataItemHeaderManager.Find(FetchOptions.All)).Select((Func<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>)Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>).ToArray());
	}

	public IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<UIMetadataPublishResult>(dataClassMetadataItemManager.Publish("Publish", iuiModel.HeaderUid));
	}

	public void Save(DataClassMetadataItemDTO metadata)
	{
		DataClassMetadataItem obj = Mapper.Map<DataClassMetadataItemDTO, DataClassMetadataItem>(metadata);
		dataClassMetadataItemManager.Save(obj);
	}

	private DataClassMetadataItemHeader GetHeader(Guid headerUid)
	{
		DataClassMetadataItemHeader dataClassMetadataItemHeader = dataClassMetadataItemHeaderManager.LoadOrNull(headerUid);
		Contract.NotNull(dataClassMetadataItemHeader, SR.T("Не найден заголовок метаданных структуры обмена данными по идентификатору {0}", headerUid));
		return dataClassMetadataItemHeader;
	}
}
