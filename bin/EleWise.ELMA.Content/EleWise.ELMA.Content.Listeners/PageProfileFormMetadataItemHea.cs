using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class PageProfileFormMetadataItemHeaderListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		UpdateGroup(@event, ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IFormMetadataItemGroup);
		UpdateHeader(@event, ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IFormMetadataItemHeader);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		DeleteGroup(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IFormMetadataItemGroup);
	}

	private IPageFolder GetFolder(IFormMetadataItemGroup group)
	{
		if (group == null)
		{
			return PageFolderManager.Instance.LoadOrCreatePageProfilesFolder();
		}
		IPageFolder pageFolder = PageFolderManager.Instance.LoadOrNull(group.Uid);
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

	private void UpdateGroup(PostUpdateEvent @event, IFormMetadataItemGroup group)
	{
		if (group == null || group.MetadataType != PageMetadata.TypeUid)
		{
			return;
		}
		Lazy<IPageFolder> lazy = new Lazy<IPageFolder>(() => PageFolderManager.Instance.LoadOrNull(group.Uid));
		int num = ((IList<string>)((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()).IndexOf(LinqUtils.NameOf((Expression<Func<IFormMetadataItemGroup, object>>)((IFormMetadataItemGroup h) => h.Name)));
		if (num >= 0 && (string)@event.get_OldState()[num] != (string)@event.get_State()[num])
		{
			if (lazy.Value == null)
			{
				return;
			}
			lazy.Value.Name = group.Name;
		}
		num = ((IList<string>)((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()).IndexOf(LinqUtils.NameOf((Expression<Func<IFormMetadataItemGroup, object>>)((IFormMetadataItemGroup h) => h.Parent)));
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

	private void UpdateHeader(PostUpdateEvent @event, IFormMetadataItemHeader header)
	{
		if (header == null || header.MetadataType != PageMetadata.TypeUid)
		{
			return;
		}
		IPageProfile pageProfile = null;
		if (header.IsDeleted)
		{
			PageProfileManager.Instance.LoadOrNull(header.Uid)?.Delete();
			return;
		}
		int num = ((IList<string>)((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()).IndexOf(LinqUtils.NameOf((Expression<Func<IFormMetadataItemHeader, object>>)((IFormMetadataItemHeader h) => h.Published)));
		if (num >= 0 && @event.get_OldState()[num] != @event.get_State()[num])
		{
			if (@event.get_OldState()[num] != null)
			{
				pageProfile = PageProfileManager.Instance.LoadOrNull(header.Uid);
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
			if (pageProfile.Folder == null || pageProfile.Folder.Uid != ((header.Group != null) ? header.Group.Uid : PageFolderManager.PageProfilesFolderUid))
			{
				pageProfile.Folder = GetFolder(header.Group);
			}
			pageProfile.Save();
		}
	}

	private void DeleteGroup(IFormMetadataItemGroup group)
	{
		if (group != null && !(group.MetadataType != PageMetadata.TypeUid))
		{
			IPageFolder pageFolder = PageFolderManager.Instance.LoadOrNull(group.Uid);
			if (pageFolder != null)
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				serviceNotNull.Update("PortalObject", new string[1] { "Folder" }, new object[1] { pageFolder.Folder.Id }, string.Format("{0}={1}", serviceNotNull.Dialect.QuoteIfNeeded("Folder"), pageFolder.Id));
				pageFolder.Delete();
			}
		}
	}
}
