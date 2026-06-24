using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Implementation;

[Service]
internal sealed class ComponentMetadataService : IComponentMetadataService
{
	private const string historyEqlFormat = "Header = {0} AND IsEmulation = FALSE AND NOT VersionNumber IS NULL";

	private readonly FetchOptions fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, LinqUtils.NameOf((Expression<Func<ComponentMetadataItem, object>>)((ComponentMetadataItem u) => u.VersionNumber)));

	private readonly IModuleMetadataItemManager moduleMetadataItemManager;

	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly IFindComponentService findComponentService;

	public ComponentMetadataService(IModuleMetadataItemManager moduleMetadataItemManager, IComponentMetadataItemManager componentMetadataItemManager, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IDataClassMetadataItemManager dataClassMetadataItemManager, IFindComponentService findComponentService)
	{
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.componentMetadataItemManager = componentMetadataItemManager;
		this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
		this.findComponentService = findComponentService;
	}

	public IExecutionResult<ComponentMetadataItemHeaderDTO> Create(IUIItemModel iuiModel)
	{
		return new ExecutionResult<ComponentMetadataItemHeaderDTO>(Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(componentMetadataItemManager.Create(iuiModel.TypeUid, iuiModel.ModuleUid, iuiModel.GroupUid, iuiModel.DisplayName).Header));
	}

	public IExecutionResult<ComponentMetadataItemHeaderDTO> Copy(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<ComponentMetadataItemHeaderDTO>(Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(componentMetadataItemManager.Copy(iuiModel.HeaderUid).Header));
	}

	public void Delete(IUIHeadedModel iuiModel)
	{
		GetHeader(iuiModel.HeaderUid).Delete();
	}

	public IExecutionResult<ComponentMetadataItemHeaderDTO> Edit(IUIItemModel iuiModel)
	{
		return new ExecutionResult<ComponentMetadataItemHeaderDTO>(Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(componentMetadataItemHeaderManager.Edit(iuiModel.HeaderUid, iuiModel.GroupUid)));
	}

	public IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel, bool forEmulation)
	{
		return new ExecutionResult<UIMetadataPublishResult>(componentMetadataItemManager.Publish(iuiModel.HeaderUid, SR.T("Публикация"), forEmulation));
	}

	public IExecutionResult<ComponentMetadataItemDTO> Load(Guid uid)
	{
		return new ExecutionResult<ComponentMetadataItemDTO>(Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(componentMetadataItemManager.Load(uid)));
	}

	public void MarkAsNotWorking(Guid uid)
	{
		ComponentMetadataItem obj = componentMetadataItemManager.Load(uid);
		componentMetadataItemManager.MarkAsNotWorking(obj);
	}

	public IExecutionResult<ComponentMetadataItemDTO> SaveAndUpdate(ComponentMetadataItemDTO metadata, string name)
	{
		string text = (componentMetadataItemManager.LoadOrNull(metadata.Uid)?.Metadata as ComponentMetadata)?.Name;
		bool num = text != name;
		ComponentMetadataItem componentMetadataItem = Mapper.Map<ComponentMetadataItem>((object)metadata);
		if (num)
		{
			componentMetadataItemManager.Rename(componentMetadataItem, text);
		}
		componentMetadataItem.Header.IsDirtyItem = true;
		componentMetadataItemManager.Save(componentMetadataItem);
		return new ExecutionResult<ComponentMetadataItemDTO>(Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(componentMetadataItem));
	}

	public IExecutionResult<ComponentMetadataItemHeaderDTO[]> LoadHeaderAll()
	{
		return new ExecutionResult<ComponentMetadataItemHeaderDTO[]>(((IEnumerable<ComponentMetadataItemHeader>)componentMetadataItemHeaderManager.Find(FetchOptions.All)).Select((Func<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>)Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>).ToArray());
	}

	public IExecutionResult<ComponentMetadataItemDTO> LoadDraft(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<ComponentMetadataItemDTO>(Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(GetHeader(iuiModel.HeaderUid).Draft));
	}

	public IExecutionResult<ComponentMetadataItemHeaderDTO> LoadHeader(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<ComponentMetadataItemHeaderDTO>(Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(GetHeader(iuiModel.HeaderUid)));
	}

	public IExecutionResult<ComponentMetadataItemDTO[]> LoadHistory(IUIHeadedModel iuiModel)
	{
		ComponentMetadataItemHeader header = GetHeader(iuiModel.HeaderUid);
		return new ExecutionResult<ComponentMetadataItemDTO[]>(((IEnumerable<ComponentMetadataItem>)componentMetadataItemManager.Find(new Filter
		{
			Query = $"Header = {header.Id} AND IsEmulation = FALSE AND NOT VersionNumber IS NULL"
		}, fetchOptions)).Select((Func<ComponentMetadataItem, ComponentMetadataItemDTO>)Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>).ToArray());
	}

	public IExecutionResult<DataClassMetadata> CreateLocalDataClass(IUIHeadedModel iuiModel)
	{
		ComponentMetadata componentMetadata = (ComponentMetadata)GetHeader(iuiModel.HeaderUid).Draft.Metadata;
		DataClassMetadata dataClassMetadata = new DataClassMetadata();
		dataClassMetadata.InitNew();
		dataClassMetadata.ModuleUid = componentMetadata.ModuleUid;
		dataClassMetadata.Namespace = componentMetadata.Namespace;
		dataClassMetadata.Internal = true;
		return new ExecutionResult<DataClassMetadata>(dataClassMetadata);
	}

	public IExecutionResult<RuntimeResponse> LoadRuntimeMetadata(bool debug, List<Guid> modules, List<Guid> components, List<Guid> dataClasses)
	{
		List<RuntimeComponentModelDTO> components2 = componentMetadataItemManager.LoadRuntimeMetadata(components, debug).Select(delegate(RuntimeComponentModel c)
		{
			RuntimeComponentModelDTO runtimeComponentModelDTO = Mapper.Map<RuntimeComponentModelDTO>((object)c);
			if (runtimeComponentModelDTO != null)
			{
				ComponentMetadataItemDTO metadataItem2 = runtimeComponentModelDTO.MetadataItem;
				if (metadataItem2 != null)
				{
					metadataItem2.IsEmulation = object.Equals(c.MetadataItem.Header.Emulation, c.MetadataItem);
					metadataItem2.IsPublished = !object.Equals(c.MetadataItem.Header.Draft, c.MetadataItem);
				}
			}
			return runtimeComponentModelDTO;
		}).ToList();
		List<RuntimeDataClassModelDTO> dataClasses2 = dataClassMetadataItemManager.LoadRuntimeMetadata(dataClasses).Select(delegate(RuntimeDataClassModel dc)
		{
			RuntimeDataClassModelDTO runtimeDataClassModelDTO = Mapper.Map<RuntimeDataClassModelDTO>((object)dc);
			if (runtimeDataClassModelDTO != null)
			{
				DataClassMetadataItemDTO metadataItem = runtimeDataClassModelDTO.MetadataItem;
				if (metadataItem != null)
				{
					metadataItem.IsPublished = !object.Equals(dc.MetadataItem.Header.Draft, dc.MetadataItem);
				}
			}
			return runtimeDataClassModelDTO;
		}).ToList();
		List<RuntimeModuleModelDTO> list = ((IEnumerable<RuntimeModuleModel>)moduleMetadataItemManager.LoadRuntimeMetadata(modules, debug)).Select((Func<RuntimeModuleModel, RuntimeModuleModelDTO>)Mapper.Map<RuntimeModuleModelDTO>).ToList();
		RuntimeResponse runtimeResponse = new RuntimeResponse
		{
			Components = components2,
			DataClasses = dataClasses2,
			Modules = list
		};
		UIRuntimeModel uIRuntimeModel = new UIRuntimeModel();
		foreach (RuntimeModuleModelDTO item in list)
		{
			uIRuntimeModel.RuntimeModules.Add(new ItemRuntimeModel
			{
				HeaderUid = item.MetadataItem.Header_Uid,
				ItemUid = item.MetadataItem.Uid
			});
		}
		UIRuntimeModel orDefault = ContextVars.GetOrDefault<UIRuntimeModel>("UIBuilderRuntime");
		if (orDefault.RuntimeModules.Count > 0)
		{
			foreach (ItemRuntimeModel module in uIRuntimeModel.RuntimeModules)
			{
				ItemRuntimeModel itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault((ItemRuntimeModel m) => m.HeaderUid == module.HeaderUid && m.ItemUid != module.ItemUid);
				if (itemRuntimeModel != null)
				{
					Logger.Log.Error(SR.T("При загрузке модулей произошла ошибка совместимости версий. Модуль: \"{0}\" уже загружен в другой версии.", itemRuntimeModel.HeaderUid));
				}
				else
				{
					orDefault.RuntimeModules.Add(module);
				}
			}
		}
		ContextVars.Set("UIBuilderRuntime", orDefault);
		ClientComponentModel[] source = findComponentService.GetAdditionalModules().ToArray();
		List<RuntimeModuleModel> source2 = moduleMetadataItemManager.LoadRuntimeMetadata(source.Select((ClientComponentModel a) => a.ModuleItemUid), debug);
		IEnumerable<ClientDataClassModel> enumerable = source.SelectMany((ClientComponentModel a) => a.DataClasses);
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (ClientDataClassModel item2 in enumerable)
		{
			if (!(item2.ModuleItemUid != Guid.Empty))
			{
				Guid headerUid = item2.HeaderUid;
				if (dataClasses.FirstOrDefault((Guid a) => a == headerUid) == Guid.Empty)
				{
					hashSet.Add(headerUid);
				}
			}
		}
		List<RuntimeDataClassModel> source3 = dataClassMetadataItemManager.LoadRuntimeMetadata(hashSet);
		foreach (RuntimeModuleModelDTO item3 in ((IEnumerable<RuntimeModuleModel>)source2).Select((Func<RuntimeModuleModel, RuntimeModuleModelDTO>)Mapper.Map<RuntimeModuleModelDTO>))
		{
			runtimeResponse.Modules.Add(item3);
		}
		foreach (RuntimeDataClassModelDTO item4 in ((IEnumerable<RuntimeDataClassModel>)source3).Select((Func<RuntimeDataClassModel, RuntimeDataClassModelDTO>)Mapper.Map<RuntimeDataClassModelDTO>))
		{
			runtimeResponse.DataClasses.Add(item4);
		}
		return new ExecutionResult<RuntimeResponse>(runtimeResponse);
	}

	private ComponentMetadataItemHeader GetHeader(Guid headerUid)
	{
		ComponentMetadataItemHeader componentMetadataItemHeader = componentMetadataItemHeaderManager.LoadOrNull(headerUid);
		Contract.ArgumentNotNull(componentMetadataItemHeader, SR.T("Не найден заголовок компонента по идентификатору {0}", headerUid));
		return componentMetadataItemHeader;
	}
}
