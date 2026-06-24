using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal sealed class FilterDocumentFolderAttachmentExtension : IObjectAttachmentExtension
{
	private class FilterDocumentFolderAttachmentExtensionModel
	{
		internal IEntityManager Manager { get; }

		internal IEntityFilter Filter { get; }

		public FilterDocumentFolderAttachmentExtensionModel(IEntityManager manager, IEntityFilter filter)
		{
			Manager = manager;
			Filter = filter;
		}
	}

	private readonly IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions;

	public FilterDocumentFolderAttachmentExtension(IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions)
	{
		this.uniqueFilterExtensions = uniqueFilterExtensions;
	}

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
	}

	public bool EntityType(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IFilterDocumentFolder>(typeUid);
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		FilterDocumentFolderAttachmentExtensionModel filterModel = GetFilterModel(entity);
		if (filterModel == null)
		{
			yield break;
		}
		IEnumerable enumerable = filterModel.Manager.Find(filterModel.Filter, FetchOptions.All);
		foreach (object item in enumerable)
		{
			if (!(item is IDocument document))
			{
				continue;
			}
			IDocumentVersion currentVersion = document.CurrentVersion;
			if (currentVersion != null)
			{
				BinaryFile file = currentVersion.File;
				if (file != null)
				{
					yield return new DocumentFileModel
					{
						Name = document.Name,
						Uid = file.Uid,
						IsDocument = true
					};
				}
			}
		}
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		FilterDocumentFolderAttachmentExtensionModel filterModel = GetFilterModel(entity);
		return filterModel?.Manager.Exists(filterModel.Filter) ?? false;
	}

	private FilterDocumentFolderAttachmentExtensionModel GetFilterModel(IEntity entity)
	{
		if (!(entity is IFilterDocumentFolder filterDocumentFolder))
		{
			return null;
		}
		Guid typeUid = InterfaceActivator.UID<IDocument>();
		filterDocumentFolder.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = typeUid
		};
		IEntityFilter entityFilter = UniversalFilterSaver.UnPack(filterDocumentFolder.FilterFields);
		Type filterType = entityFilter?.GetType();
		IUniqueFilterExtension uniqueFilterExtension = ((filterType != null) ? uniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.FilterType == filterType) : null);
		if (filterType == null && uniqueFilterExtension == null)
		{
			return null;
		}
		return new FilterDocumentFolderAttachmentExtensionModel(ModelHelper.GetEntityManager((uniqueFilterExtension != null) ? uniqueFilterExtension.EntityType : Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterType).Uid)), entityFilter);
	}
}
