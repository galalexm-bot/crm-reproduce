using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Implementation;

[Service]
internal sealed class UIMetadataService : IUIMetadataService
{
	internal class ItemHeader
	{
		public IMetadata DraftMetadata { get; set; }

		public bool IsPublished { get; set; }

		public bool IsDirtyItem { get; set; }
	}

	private readonly IEnumerable<INamespaceInfo> namespaceInfos;

	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly MetadataItemGroupManager metadataItemGroupManager;

	private readonly IEnumerable<IViewItemToolboxItem> viewItemToolboxItems;

	private readonly IEnumerable<IViewItemToolboxGroup> viewItemToolboxGroups;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly ISessionProvider sessionProvider;

	public UIMetadataService(IEnumerable<INamespaceInfo> namespaceInfos, MetadataItemHeaderManager metadataItemHeaderManager, MetadataItemGroupManager metadataItemGroupManager, IEnumerable<IViewItemToolboxItem> viewItemToolboxItems, IEnumerable<IViewItemToolboxGroup> viewItemToolboxGroups, ISearchMetadataService searchMetadataService, ISessionProvider sessionProvider)
	{
		this.namespaceInfos = namespaceInfos;
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.metadataItemGroupManager = metadataItemGroupManager;
		this.viewItemToolboxItems = viewItemToolboxItems;
		this.viewItemToolboxGroups = viewItemToolboxGroups;
		this.searchMetadataService = searchMetadataService;
		this.sessionProvider = sessionProvider;
	}

	public IExecutionResult<IEnumerable<INamespaceInfo>> GetNamespaceInfo()
	{
		return new ExecutionResult<IEnumerable<INamespaceInfo>>(namespaceInfos);
	}

	public IExecutionResult<IEnumerable<NamespaceMetadata>> GetNamespaceMetadata()
	{
		IEnumerable<NamespaceMetadata> second = (from a in metadataItemHeaderManager.Find((IMetadataItemHeader a) => a.Name == "Configuration")
			select a.Current into a
			select a.Metadata).OfType<NamespaceMetadata>();
		return new ExecutionResult<IEnumerable<NamespaceMetadata>>(MetadataServiceContext.Service.GetMetadataList().OfType<NamespaceMetadata>().Union(second));
	}

	public IExecutionResult<IEnumerable<MetadataItemGroupDTO>> GetMetadataItemGroups()
	{
		return new ExecutionResult<IEnumerable<MetadataItemGroupDTO>>(((IEnumerable<IMetadataItemGroup>)metadataItemGroupManager.Find(FetchOptions.All)).Select((Func<IMetadataItemGroup, MetadataItemGroupDTO>)Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>));
	}

	public IExecutionResult<IEnumerable<VisibleGroupInfoDTO>> FindVisibleGroupsAndViewItems(NamedMetadata metadata)
	{
		if (metadata is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceExtension)
		{
			metadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid);
		}
		IViewItemToolboxItem[] array = viewItemToolboxItems.Where((IViewItemToolboxItem item) => item.GroupUid != CommonViewItemToolboxGroup.UID && item.IsAvailable(metadata)).ToArray();
		Dictionary<Guid, VisibleGroupInfoDTO> dictionary = new Dictionary<Guid, VisibleGroupInfoDTO>();
		IViewItemToolboxItem[] array2 = array;
		foreach (IViewItemToolboxItem viewItemToolboxItem in array2)
		{
			Guid groupUid = viewItemToolboxItem.GroupUid;
			if (!dictionary.TryGetValue(groupUid, out var value))
			{
				IViewItemToolboxGroup viewItemToolboxGroup = viewItemToolboxGroups.FirstOrDefault((IViewItemToolboxGroup g) => g.GroupUid == groupUid);
				if (viewItemToolboxGroup != null)
				{
					value = new VisibleGroupInfoDTO
					{
						Uid = viewItemToolboxGroup.GroupUid,
						DisplayName = viewItemToolboxGroup.Name,
						ParentUid = viewItemToolboxGroup.ParentGroupUid
					};
					dictionary[value.Uid] = value;
				}
			}
			if (value == null)
			{
				continue;
			}
			VisibleViewItemInfoDTO visibleViewItemInfoDTO = new VisibleViewItemInfoDTO
			{
				DisplayName = viewItemToolboxItem.Name
			};
			Type type = viewItemToolboxItem.GetType();
			if (type.BaseType != null && type.BaseType.IsGenericType)
			{
				Type type2 = type.BaseType.GetGenericArguments().First();
				if (type2 == typeof(DefaultContainerViewItem))
				{
					continue;
				}
				visibleViewItemInfoDTO.Name = type2.FullName + ", " + type2.Assembly.GetName().Name;
			}
			value.Items.Add(visibleViewItemInfoDTO);
		}
		return new ExecutionResult<IEnumerable<VisibleGroupInfoDTO>>(dictionary.Values.ToArray());
	}

	public IExecutionResult<IEnumerable<MetadataHeaderDTO>> GetMetadataHeaders(MetadataHeadersModel metadataHeadersModel)
	{
		List<MetadataHeaderDTO> list = GetSystemMetadata().Concat<ICodeItemMetadata>(from a in GetEnumMetadata()
			where a.Type != EnumMetadataType.EnumExtension
			select a).Concat(GetDataClassMetadata()).Select(GenerateMetadataHeaderDto)
			.ToList();
		IEnumerable<ItemHeader> metadataItemHeaders = GetMetadataItemHeaders();
		foreach (MetadataHeaderDTO resultHeader in ProcessHeaders(list, metadataItemHeaders, metadataHeadersModel.WithDrafts))
		{
			MetadataHeaderDTO metadataHeaderDTO = list.Find((MetadataHeaderDTO a) => a.Uid == resultHeader.Uid);
			if (metadataHeaderDTO != null)
			{
				list.Remove(metadataHeaderDTO);
			}
			list.Add(resultHeader);
		}
		return new ExecutionResult<IEnumerable<MetadataHeaderDTO>>(list);
	}

	public IExecutionResult<IEnumerable<MetadataHeaderDTO>> LoadMetadataHeaders(IEnumerable<LoadMetadataHeaders> updateRequests)
	{
		Guid guid = InterfaceActivator.UID<IMetadataItemHeader>();
		Guid guid2 = InterfaceActivator.UID<DataClassMetadataItemHeader>();
		List<MetadataHeaderDTO> list = new List<MetadataHeaderDTO>();
		foreach (LoadMetadataHeaders updateRequest in updateRequests)
		{
			if (updateRequest.TypeUid == guid)
			{
				List<MetadataHeaderDTO> runtimeHeaders = GetSystemMetadata().Concat<ICodeItemMetadata>(from a in GetEnumMetadata()
					where a.Type != EnumMetadataType.EnumExtension
					select a).Select(GenerateMetadataHeaderDto).ToList();
				list.AddRange(ProcessHeaders(runtimeHeaders, GetMetadataItemHeaders(), withDrafts: true));
			}
			else if (updateRequest.TypeUid == guid2)
			{
				List<MetadataHeaderDTO> runtimeHeaders2 = GetDataClassMetadata().Select(GenerateMetadataHeaderDto).ToList();
				list.AddRange(ProcessHeaders(runtimeHeaders2, DataClassMetadataItemHeaders(sessionProvider), withDrafts: true));
			}
		}
		return new ExecutionResult<IEnumerable<MetadataHeaderDTO>>(list);
	}

	public IExecutionResult<IMetadata> LoadDraftMetadataByTypeUid(Guid type)
	{
		return new ExecutionResult<IMetadata>(GetDraftMetadataByUid(type));
	}

	private static IEnumerable<ClassMetadata> GetSystemMetadata()
	{
		return MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where(delegate(ClassMetadata m)
		{
			EntityMetadata entityMetadata = m as EntityMetadata;
			if (m is IEntityMetadata && entityMetadata == null)
			{
				return m.ShowInTypeTree;
			}
			return entityMetadata != null && !entityMetadata.IsInterfaceType;
		});
	}

	private static IEnumerable<EnumMetadata> GetEnumMetadata()
	{
		return MetadataServiceContext.Service.GetMetadataList().OfType<EnumMetadata>();
	}

	private IEnumerable<DataClassMetadata> GetDataClassMetadata()
	{
		return searchMetadataService.GetNonInternalDraftDataClasses();
	}

	private ICodeItemMetadata GetDraftMetadataByUid(Guid uid)
	{
		DataClassMetadata dataClassMetadata = GetDataClassMetadata().FirstOrDefault((DataClassMetadata a) => a.Uid == uid);
		if (dataClassMetadata != null)
		{
			return dataClassMetadata;
		}
		if (MetadataLoader.LoadMetadataOrNull(uid) is ICodeItemMetadata result)
		{
			return result;
		}
		return null;
	}

	private IEnumerable<ItemHeader> GetMetadataItemHeaders()
	{
		return sessionProvider.GetSession(string.Empty).CreateCriteria(typeof(IMetadataItemHeader)).CreateAlias("Current", "draft", (JoinType)1)
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Conditional((ICriterion)(object)Restrictions.IsNotNull("Published"), Projections.Constant((object)true, (IType)(object)NHibernateUtil.Boolean), Projections.Constant((object)false, (IType)(object)NHibernateUtil.Boolean)), "IsPublished").Add((IProjection)(object)Projections.Property("IsDirtyItem"), "IsDirtyItem")
				.Add((IProjection)(object)Projections.Property("draft.Metadata"), "DraftMetadata") })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ItemHeader)))
			.List<ItemHeader>();
	}

	private static MetadataHeaderDTO GenerateMetadataHeaderDto(ICodeItemMetadata codeItemMetadata)
	{
		bool showInTypeTree = true;
		if (codeItemMetadata is ClassMetadata classMetadata)
		{
			showInTypeTree = classMetadata.ShowInTypeTree;
		}
		bool showInCatalogList = false;
		Guid uid;
		if (codeItemMetadata is EntityMetadata entityMetadata)
		{
			showInCatalogList = entityMetadata.ShowInCatalogList;
			uid = ((entityMetadata.Type == EntityMetadataType.InterfaceImplementation) ? entityMetadata.ImplementationUid : codeItemMetadata.Uid);
		}
		else if (codeItemMetadata is EnumMetadata enumMetadata)
		{
			showInTypeTree = enumMetadata.ShowInTypeTree;
			uid = codeItemMetadata.Uid;
		}
		else
		{
			uid = codeItemMetadata.Uid;
		}
		return new MetadataHeaderDTO
		{
			MetadataType = GetMetadataType(codeItemMetadata),
			Uid = uid,
			Internal = codeItemMetadata.Internal,
			ModuleUid = codeItemMetadata.ModuleUid,
			Name = codeItemMetadata.Name,
			DisplayName = codeItemMetadata.DisplayName,
			Namespace = codeItemMetadata.Namespace,
			NamespaceForDisplay = codeItemMetadata.NamespaceForDisplay,
			GroupId = ((codeItemMetadata is IGroupedMetadata groupedMetadata) ? groupedMetadata.GroupId : 0),
			Status = 2,
			ShowInTypeTree = showInTypeTree,
			ShowInCatalogList = showInCatalogList
		};
	}

	private static Guid GetMetadataType(ICodeItemMetadata metadata)
	{
		if (metadata != null)
		{
			if (metadata is EnumMetadata)
			{
				return new Guid("{25A6FECE-0C54-4CAD-B9CE-9C3523BB9750}");
			}
			if (metadata is DataClassMetadata)
			{
				return new Guid("{6F1B7544-AA48-4820-823C-3579B8AF0A22}");
			}
			if (metadata is EntityMetadata entityMetadata)
			{
				return AttributeHelper<UidAttribute>.GetAttribute(entityMetadata.GetType(), inherited: false)?.Uid ?? new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");
			}
			if (metadata is ClassMetadata classMetadata)
			{
				return classMetadata.GetType().FullName.GetDeterministicGuid();
			}
		}
		return Guid.Empty;
	}

	internal static IEnumerable<MetadataHeaderDTO> ProcessHeaders(List<MetadataHeaderDTO> runtimeHeaders, IEnumerable<ItemHeader> itemHeaders, bool withDrafts)
	{
		List<MetadataHeaderDTO> list = new List<MetadataHeaderDTO>();
		foreach (ItemHeader itemHeader in itemHeaders)
		{
			IMetadata draftMetadata = itemHeader.DraftMetadata;
			bool isPublished = itemHeader.IsPublished;
			bool flag = !isPublished && itemHeader.IsDirtyItem;
			if (!withDrafts && (!isPublished || itemHeader.IsDirtyItem))
			{
				continue;
			}
			MetadataHeaderDTO metadataHeaderDTO = null;
			EntityMetadata entityMetadata;
			if ((entityMetadata = draftMetadata as EntityMetadata) != null)
			{
				if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
				{
					metadataHeaderDTO = runtimeHeaders.Find((MetadataHeaderDTO a) => a.Uid == entityMetadata.BaseClassUid);
					if (metadataHeaderDTO == null)
					{
						continue;
					}
					flag = false;
				}
				if (entityMetadata.Type == EntityMetadataType.Interface)
				{
					metadataHeaderDTO = GenerateMetadataHeaderDto(entityMetadata);
					list.Add(metadataHeaderDTO);
				}
			}
			EnumMetadata enumMetadata;
			if ((enumMetadata = draftMetadata as EnumMetadata) != null)
			{
				if (enumMetadata.Type == EnumMetadataType.EnumExtension)
				{
					metadataHeaderDTO = runtimeHeaders.Find((MetadataHeaderDTO a) => a.Uid == enumMetadata.BaseTypeUid);
					if (metadataHeaderDTO == null)
					{
						continue;
					}
					flag = false;
				}
				if (enumMetadata.Type == EnumMetadataType.Enum)
				{
					metadataHeaderDTO = GenerateMetadataHeaderDto(enumMetadata);
					list.Add(metadataHeaderDTO);
				}
			}
			if (draftMetadata is DataClassMetadata codeItemMetadata)
			{
				metadataHeaderDTO = GenerateMetadataHeaderDto(codeItemMetadata);
				list.Add(metadataHeaderDTO);
			}
			if (metadataHeaderDTO != null)
			{
				metadataHeaderDTO.Status = ((!flag) ? (itemHeader.IsDirtyItem ? 1 : 2) : 0);
			}
		}
		return list;
	}

	private static IEnumerable<ItemHeader> DataClassMetadataItemHeaders(ISessionProvider sessionProvider)
	{
		return sessionProvider.GetSession(string.Empty).CreateCriteria(typeof(DataClassMetadataItem)).CreateAlias("Draft", "draft", (JoinType)1)
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Conditional((ICriterion)(object)Restrictions.IsNotNull("Published"), Projections.Constant((object)true, (IType)(object)NHibernateUtil.Boolean), Projections.Constant((object)false, (IType)(object)NHibernateUtil.Boolean)), "IsPublished").Add((IProjection)(object)Projections.Property("IsDirtyItem"), "IsDirtyItem")
				.Add((IProjection)(object)Projections.Property("draft.Metadata"), "DraftMetadata") })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ItemHeader)))
			.List<ItemHeader>();
	}
}
