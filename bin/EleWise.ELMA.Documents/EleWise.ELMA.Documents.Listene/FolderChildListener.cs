using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component(Order = int.MaxValue)]
internal class FolderChildListener : PostFlushEventListener
{
	private readonly string nameOfFolder;

	private readonly string nameOfIsDeleted;

	private readonly FolderManager folderManager;

	public FolderChildListener(FolderManager folderManager)
	{
		this.folderManager = folderManager;
		nameOfIsDeleted = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsDeleted));
		nameOfFolder = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder));
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		UpdateParentHasChildFor(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), hasChild: true);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null)
		{
			UpdateParentHasChildFor(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), hasChild: false);
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IFolder obj && @event.get_OldState() != null && @event.get_State() != null)
		{
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfFolder);
			if (num >= 0 && !object.Equals(@event.get_OldState()[num], @event.get_State()[num]))
			{
				UpdateHasChildFor(@event.get_State()[num], hasChild: true);
				UpdateHasChildFor(@event.get_OldState()[num], hasChild: false);
			}
			int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfIsDeleted);
			if (num2 >= 0 && !object.Equals(@event.get_OldState()[num2], @event.get_State()[num2]))
			{
				UpdateParentHasChildFor(obj, hasChild: false);
			}
		}
	}

	private void UpdateParentHasChildFor(object obj, bool hasChild)
	{
		if (obj is IFolder folder)
		{
			UpdateHasChildFor(folder.Folder, hasChild);
		}
	}

	private void UpdateHasChildFor(object obj, bool hasChild)
	{
		if (obj is IFolder folder)
		{
			folder.HasChildFolders = hasChild || (folder.HasChildFolders && folderManager.HasNestedFolders(folder));
		}
	}
}
