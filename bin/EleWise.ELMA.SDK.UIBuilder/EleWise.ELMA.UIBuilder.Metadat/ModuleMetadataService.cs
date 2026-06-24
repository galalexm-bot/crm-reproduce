using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Services.Implementation;

[Service]
internal sealed class ModuleMetadataService : IModuleMetadataService
{
	internal sealed class ModuleProjectionClass
	{
		public ModuleInfoMetadata Metadata { get; set; }

		public Guid HeaderUid { get; set; }

		public Guid VersionUid { get; set; }

		public byte[] AssemblyRaw { get; set; }
	}

	private static class _Resources_PropertyNames
	{
		public static readonly string Id = "Id";

		public static readonly string Uid = "Uid";

		public static readonly string Name = "Name";

		public static readonly string DisplayName = "DisplayName";

		public static readonly string CreationDate = "CreationDate";

		public static readonly string CreationAuthorId = "CreationAuthorId";

		public static readonly string Draft = "Draft";

		public static readonly string Published = "Published";

		public static readonly string Header = "Header";
	}

	private static class _Resources_DtoPropertyNames
	{
		public static readonly string Uid = "Uid";

		public static readonly string Name = "Name";

		public static readonly string DisplayName = "DisplayName";

		public static readonly string CreationDate = "CreationDate";

		public static readonly string CreationAuthorId = "CreationAuthorId";

		public static readonly string DraftId = "Draft_Uid";

		public static readonly string PublishedId = "Published_Uid";
	}

	private readonly ITagService tagService;

	private readonly IModuleMetadataItemManager moduleMetadataItemManager;

	private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;

	private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;

	private readonly ISessionProvider sessionProvider;

	public ModuleMetadataService(ITagService tagService, IModuleMetadataItemManager moduleMetadataItemManager, ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, ISessionProvider sessionProvider)
	{
		this.tagService = tagService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
		this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
		this.sessionProvider = sessionProvider;
	}

	public IExecutionResult<ModuleMetadataItemHeaderDTO> Create(IUIEditionsModel model)
	{
		Contract.ArgumentNotNullOrEmpty(model.Name, SR.T("Отсутствует наименование заголовка"));
		Contract.ArgumentNotNullOrEmpty(model.DisplayName, SR.T("Отсутствует отображаемое имя заголовка"));
		return new ExecutionResult<ModuleMetadataItemHeaderDTO>(Mapper.Map<ModuleMetadataItemHeader, ModuleMetadataItemHeaderDTO>(moduleMetadataItemManager.Create(model.Name, model.DisplayName, model.Description).Header));
	}

	public IExecutionResult<ModuleMetadataItemDTO> Load(Guid uid)
	{
		return new ExecutionResult<ModuleMetadataItemDTO>(Mapper.Map<ModuleMetadataItem, ModuleMetadataItemDTO>(moduleMetadataItemManager.Load(uid)));
	}

	public IExecutionResult<UIMetadataPublishResult> Publish(IUIHeadedModel iuiModel)
	{
		return new ExecutionResult<UIMetadataPublishResult>(moduleMetadataItemManager.Publish(iuiModel.HeaderUid, SR.T("Публикация")));
	}

	public void Delete(IUIHeadedModel iuiModel)
	{
		GetHeader(iuiModel.HeaderUid).Delete();
	}

	public IExecutionResult<string[]> GetEditionTags()
	{
		return new ExecutionResult<string[]>(tagService.TagEdition.ToArray());
	}

	public IExecutionResult<ModuleMetadataItemDTO[]> GetDrafts()
	{
		return new ExecutionResult<ModuleMetadataItemDTO[]>((from m in moduleMetadataItemHeaderManager.Find("NOT (Uid in (" + string.Join(",", ModuleMetadataItemHeaderManager.DesignerModules.Select((Guid x) => $"Guid('{x}')")) + "))")
			select Mapper.Map<ModuleMetadataItem, ModuleMetadataItemDTO>(m.Draft ?? m.Published)).ToArray());
	}

	public void AddReference(Guid moduleUid, ICollection<LinkToModule> references)
	{
		ModuleMetadataItem draft = GetHeader(moduleUid).Draft;
		ModuleInfoMetadata moduleInfoMetadata = (ModuleInfoMetadata)ClassSerializationHelper.CloneObjectByXml(draft.Metadata);
		moduleInfoMetadata.DependencyModules.Clear();
		moduleInfoMetadata.DependencyModules.AddRange(references);
		draft.Metadata = moduleInfoMetadata;
		draft.Save();
	}

	public IExecutionResult<ModuleMetadataItemHeaderDTO> SaveHeader(ModuleMetadataItemHeaderDTO headerDto)
	{
		ModuleMetadataItemHeader moduleMetadataItemHeader = Mapper.Map<ModuleMetadataItemHeaderDTO, ModuleMetadataItemHeader>(headerDto);
		moduleMetadataItemHeaderManager.Save(moduleMetadataItemHeader);
		return new ExecutionResult<ModuleMetadataItemHeaderDTO>(Mapper.Map<ModuleMetadataItemHeader, ModuleMetadataItemHeaderDTO>(moduleMetadataItemHeader));
	}

	public IExecutionResult<ModuleMetadataItemHeaderDTO[]> LoadHeaderAll()
	{
		return new ExecutionResult<ModuleMetadataItemHeaderDTO[]>(sessionProvider.GetSession(string.Empty).CreateCriteria(typeof(ModuleMetadataItemHeader)).CreateAlias(_Resources_PropertyNames.Draft, "dft", (JoinType)1)
			.CreateAlias(_Resources_PropertyNames.Published, "pub", (JoinType)1)
			.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In("Uid", (ICollection)ModuleMetadataItemHeaderManager.DesignerModules.ToArray())))
			.SetProjection((IProjection[])(object)new IProjection[7]
			{
				Projections.Alias((IProjection)(object)Projections.Property(_Resources_PropertyNames.Uid), _Resources_DtoPropertyNames.Uid),
				Projections.Alias((IProjection)(object)Projections.Property(_Resources_PropertyNames.Name), _Resources_DtoPropertyNames.Name),
				Projections.Alias((IProjection)(object)Projections.Property(_Resources_PropertyNames.DisplayName), _Resources_DtoPropertyNames.DisplayName),
				Projections.Alias((IProjection)(object)Projections.Property(_Resources_PropertyNames.CreationDate), _Resources_DtoPropertyNames.CreationDate),
				Projections.Alias((IProjection)(object)Projections.Property(_Resources_PropertyNames.CreationAuthorId), _Resources_DtoPropertyNames.CreationAuthorId),
				Projections.Alias((IProjection)(object)Projections.Property("dft." + _Resources_PropertyNames.Uid), _Resources_DtoPropertyNames.DraftId),
				Projections.Alias((IProjection)(object)Projections.Property("pub." + _Resources_PropertyNames.Uid), _Resources_DtoPropertyNames.PublishedId)
			})
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ModuleMetadataItemHeaderDTO)))
			.List<ModuleMetadataItemHeaderDTO>()
			.ToArray());
	}

	public IExecutionResult<SystemMetadata[]> GetSystemMetadata(InitDataModel initDataModel)
	{
		return new ExecutionResult<SystemMetadata[]>((from runtimeModule in moduleMetadataItemManager.LoadRuntimeMetadata(initDataModel.Modules, debug: false).ToList()
			select new SystemMetadata((ModuleInfoMetadata)runtimeModule.MetadataItem.Metadata)
			{
				Script = runtimeModule.Script
			}).ToArray());
	}

	public IExecutionResult<SystemInitData> GetSystemInitData(InitDataModel initDataModel)
	{
		ModuleProjectionClass[] array = sessionProvider.GetSession(string.Empty).CreateCriteria(typeof(ModuleMetadataItemHeader), "h").CreateAlias("Published", "m", (JoinType)0)
			.Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property("h.Uid"), (ICollection)initDataModel.Modules))
			.SetProjection((IProjection[])(object)new IProjection[2]
			{
				Projections.Alias((IProjection)(object)Projections.Property("h.Uid"), "HeaderUid"),
				Projections.Alias((IProjection)(object)Projections.Property("m.Uid"), "VersionUid")
			})
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ModuleProjectionClass)))
			.List<ModuleProjectionClass>()
			.ToArray();
		DataClassTypeReference[] array2 = dataClassTypeReferenceManager.FindReferencesByItemUid(array.Select((ModuleProjectionClass a) => a.VersionUid).ToArray());
		MetadataReference[] array3 = new MetadataReference[array2.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			DataClassTypeReference dataClassTypeReference = array2[i];
			array3[i] = new MetadataReference
			{
				Uid = dataClassTypeReference.MetadataUid,
				TypeRef = dataClassTypeReference.Id.ToString()
			};
		}
		ItemRuntimeModel[] array4 = new ItemRuntimeModel[array.Length];
		for (int j = 0; j < array.Length; j++)
		{
			ModuleProjectionClass moduleProjectionClass = array[j];
			array4[j] = new ItemRuntimeModel
			{
				HeaderUid = moduleProjectionClass.HeaderUid,
				ItemUid = moduleProjectionClass.VersionUid
			};
		}
		return new ExecutionResult<SystemInitData>(new SystemInitData
		{
			MetadataReferences = array3,
			ItemRuntimeModels = array4
		});
	}

	private ModuleMetadataItemHeader GetHeader(Guid headerUid)
	{
		ModuleMetadataItemHeader moduleMetadataItemHeader = moduleMetadataItemHeaderManager.LoadOrNull(headerUid);
		Contract.ArgumentNotNull(moduleMetadataItemHeader, SR.T("Не найден заголовок метаданных модуля по идентификатору {0}", headerUid));
		return moduleMetadataItemHeader;
	}
}
