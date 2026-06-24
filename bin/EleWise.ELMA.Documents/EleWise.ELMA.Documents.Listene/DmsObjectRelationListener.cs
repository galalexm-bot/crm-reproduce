using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DmsObjectRelationListener : PostFlushEventListener, IUnitOfWorkEventListener
{
	private readonly string nameOfFolder = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder));

	private const string MoveRelationIds = "DmsObjectRelationListener.MoveRelationIds";

	private readonly IDmsObjectRelationService dmsObjectRelationService;

	private readonly IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService;

	public DmsObjectRelationListener(IDmsObjectRelationService dmsObjectRelationService, IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService)
	{
		this.dmsObjectRelationService = dmsObjectRelationService;
		this.dmsObjectTreeNodeStateService = dmsObjectTreeNodeStateService;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		base.OnPostInsert(@event);
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IFolder dms)
		{
			dmsObjectRelationService.Insert(dms);
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		base.OnPostUpdate(@event);
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IFolder folder))
		{
			return;
		}
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfFolder);
		if (@event.get_OldState() == null || @event.get_State() == null)
		{
			return;
		}
		IFolder folderNew = @event.get_State()[num] as IFolder;
		IFolder folderOld = @event.get_OldState()[num] as IFolder;
		if (!ContextVars.Contains("EleWise.ELMA.Documents.Managers.DmsObjectManager.MoveTo" + folder.Id) && ((folderNew != null && folderOld != null && folderNew.Id != folderOld.Id) || (folderNew == null && folderOld != null) || (folderNew != null && folderOld == null)))
		{
			Dictionary<Pair<IFolder, IFolder>, List<IDmsObject>> orAdd = ContextVars.GetOrAdd("DmsObjectRelationListener.MoveRelationIds", () => new Dictionary<Pair<IFolder, IFolder>, List<IDmsObject>>());
			Pair<IFolder, IFolder> pair = orAdd.Keys.FirstOrDefault((Pair<IFolder, IFolder> k) => k.First == folderNew && k.Second == folderOld);
			List<IDmsObject> list;
			if (pair == null)
			{
				pair = new Pair<IFolder, IFolder>(folderNew, folderOld);
				list = new List<IDmsObject>();
				orAdd.Add(pair, list);
			}
			else
			{
				list = orAdd[pair];
			}
			list.Add(folder);
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		Dictionary<Pair<IFolder, IFolder>, List<IDmsObject>> orDefault = ContextVars.GetOrDefault<Dictionary<Pair<IFolder, IFolder>, List<IDmsObject>>>("DmsObjectRelationListener.MoveRelationIds");
		if (orDefault == null)
		{
			return;
		}
		foreach (Pair<IFolder, IFolder> key in orDefault.Keys)
		{
			IEnumerable<IDmsObject> source = orDefault[key].Distinct();
			dmsObjectRelationService.Move(source.Distinct(), key.First, key.Second);
			dmsObjectTreeNodeStateService.SetNodeParentExpanded(source.Select((IDmsObject o) => o.Id).Distinct(), expanded: false);
		}
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}
}
