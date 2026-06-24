using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal sealed class PageProfileComponentMetadataItemHeaderListener : PostFlushEventListener
{
	private readonly PageFolderManager pageFolderManager;

	private readonly PageProfileManager pageProfileManager;

	private readonly ITransformationProvider transformationProvider;

	public PageProfileComponentMetadataItemHeaderListener(PageFolderManager pageFolderManager, PageProfileManager pageProfileManager, ITransformationProvider transformationProvider)
	{
		this.pageFolderManager = pageFolderManager;
		this.pageProfileManager = pageProfileManager;
		this.transformationProvider = transformationProvider;
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		object entity = ((AbstractPostDatabaseOperationEvent)@event).get_Entity();
		if (entity == null)
		{
			return;
		}
		if (entity is MetadataItemGroupUI metadataItemGroupUI)
		{
			MetadataItemGroupUI metadataItemGroupUI2 = metadataItemGroupUI;
			if (metadataItemGroupUI2.MetadataTypeUid == PageComponentMetadata.TypeUid)
			{
				UpdateGroup(@event, metadataItemGroupUI2);
				return;
			}
		}
		if (entity is ComponentMetadataItemHeader componentMetadataItemHeader)
		{
			ComponentMetadataItemHeader componentMetadataItemHeader2 = componentMetadataItemHeader;
			if (componentMetadataItemHeader2.MetadataTypeUid == PageComponentMetadata.TypeUid)
			{
				UpdateHeader(@event, componentMetadataItemHeader2);
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is MetadataItemGroupUI metadataItemGroupUI && metadataItemGroupUI.MetadataTypeUid == PageComponentMetadata.TypeUid)
		{
			DeleteGroup(metadataItemGroupUI);
		}
	}

	private IPageFolder GetFolder(MetadataItemGroupUI group)
	{
		if (group == null)
		{
			return pageFolderManager.LoadOrCreatePageProfilesFolder();
		}
		IPageFolder pageFolder = pageFolderManager.LoadOrNull(group.Uid);
		if (pageFolder == null)
		{
			InstanceOf<IPageFolder> instanceOf = new InstanceOf<IPageFolder>();
			instanceOf.New.Uid = group.Uid;
			instanceOf.New.Name = group.Name;
			instanceOf.New.Folder = GetFolder(group.Parent);
			instanceOf.New.IsSystem = true;
			pageFolder = instanceOf.New;
			pageFolder.Save();
		}
		return pageFolder;
	}

	private void UpdateGroup(PostUpdateEvent @event, MetadataItemGroupUI group)
	{
		IList<string> propertyNames = ((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames();
		if (propertyNames == null)
		{
			return;
		}
		Lazy<IPageFolder> lazy = new Lazy<IPageFolder>(() => pageFolderManager.LoadOrNull(group.Uid));
		int num = propertyNames.IndexOf("Name");
		if (num >= 0 && (string)@event.get_OldState()[num] != (string)@event.get_State()[num])
		{
			if (lazy.Value == null)
			{
				return;
			}
			lazy.Value.Name = group.Name;
		}
		num = propertyNames.IndexOf("Parent");
		if (num >= 0 && @event.get_OldState()[num] != @event.get_State()[num])
		{
			if (lazy.Value == null)
			{
				return;
			}
			lazy.Value.Folder = GetFolder(group.Parent);
		}
		if (lazy.IsValueCreated)
		{
			lazy.Value.Save();
		}
	}

	private void UpdateHeader(PostUpdateEvent @event, ComponentMetadataItemHeader header)
	{
		IPageProfile pageProfile = null;
		if (header.IsDeleted)
		{
			pageProfileManager.LoadOrNull(header.Uid)?.Delete();
			return;
		}
		IList<string> propertyNames = ((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames();
		if (propertyNames == null)
		{
			return;
		}
		int num = propertyNames.IndexOf("Published");
		if (num >= 0 && @event.get_OldState()[num] != @event.get_State()[num])
		{
			if (@event.get_OldState()[num] != null)
			{
				pageProfile = pageProfileManager.LoadOrNull(header.Uid);
			}
			IPageProfile pageProfile2 = pageProfile;
			if (pageProfile2 == null)
			{
				InstanceOf<IPageProfile> instanceOf = new InstanceOf<IPageProfile>();
				instanceOf.New.Uid = header.Uid;
				instanceOf.New.IsSystem = true;
				pageProfile2 = instanceOf.New;
			}
			pageProfile = pageProfile2;
			pageProfile.Name = header.DisplayName;
			if (pageProfile.Folder == null || pageProfile.Folder.Uid != (header.Group?.Uid ?? PageFolderManager.PageProfilesFolderUid))
			{
				pageProfile.Folder = GetFolder(header.Group);
			}
			pageProfile.Save();
		}
	}

	private void DeleteGroup(MetadataItemGroupUI group)
	{
		IPageFolder pageFolder = pageFolderManager.LoadOrNull(group.Uid);
		if (pageFolder != null)
		{
			transformationProvider.Update("PortalObject", new string[1] { "Folder" }, new object[1] { pageFolder.Folder.Id }, string.Format("{0}={1}", transformationProvider.Dialect.QuoteIfNeeded("Folder"), pageFolder.Id));
			pageFolder.Delete();
		}
	}
}
