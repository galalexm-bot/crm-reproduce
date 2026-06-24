using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Exceptions;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
internal class ContractorPermissionChangeListener : EntityEventsListener
{
	private readonly ISessionProvider sessionProvider;

	private readonly ILockManager lockManager;

	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly SaleManager saleManager;

	private readonly IndexQueueManager indexQueueManager;

	private IUnitOfWorkManager unitOfWorkManager = Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public ICacheService CacheService { get; set; }

	public PostFlushActionRunner PostFlushActionRunner { get; set; }

	public ContractorPermissionChangeListener(ISessionProvider sessionProvider, IContextBoundVariableService contextBoundVariableService, ILockManager lockManager, SaleManager saleManager, IndexQueueManager indexQueueManager)
	{
		this.sessionProvider = sessionProvider;
		this.contextBoundVariableService = contextBoundVariableService;
		this.lockManager = lockManager;
		this.saleManager = saleManager;
		this.indexQueueManager = indexQueueManager;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null)
		{
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContractorPersonPermission)
			{
				AddPermissionOfContragent(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContractorPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ILeadPersonPermission)
			{
				AddPermissionOfLead(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ILeadPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContactPersonPermission)
			{
				AddPermissionOfContact(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContactPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISalePersonPermission)
			{
				AddPermissionOfSale(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISalePersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IRelationship)
			{
				AddRelationshipPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IRelationship);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContractor)
			{
				AddContractorPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContractor);
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		UpdateContragentInSale(@event);
		UpdateContragentInRelationship(@event);
		UpdateResponsible(@event);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null)
		{
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContractorPersonPermission)
			{
				DeletePermissionContractor(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContractorPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ILeadPersonPermission)
			{
				DeletePermissionLead(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ILeadPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContactPersonPermission)
			{
				DeletePermissionContact(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContactPersonPermission);
			}
			if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISalePersonPermission)
			{
				DeletePermissionSale(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISalePersonPermission);
			}
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		CheckContractorInCategory(@event);
		CheckListInContractor(@event, ".ParticipantWork", CommonRoleTypes.ParticipantWork.Id);
		CheckListInContractor(@event, ".Informs", CommonRoleTypes.Informs.Id);
		CheckListInLead(@event, ".ParticipantWork", CommonRoleTypes.ParticipantWork.Id);
		CheckListInLead(@event, ".Informs", CommonRoleTypes.Informs.Id);
		CheckListInRelationship(@event, ".RelationshipUsers", CommonRoleTypes.Informs.Id, RelationshipUserStatus.InfromTo);
		CheckListInRelationship(@event, ".RelationshipUsers", CommonRoleTypes.ParticipantWork.Id, RelationshipUserStatus.Participant);
		CheckContractorPermission(@event);
	}

	private void AddContractorPermission(IContractor Contractor)
	{
		if (Contractor.ParticipantWork != null)
		{
			foreach (EleWise.ELMA.Security.Models.IUser item in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)Contractor.ParticipantWork)
			{
				AddUserContractor(item, Contractor, CommonRoleTypes.ParticipantWork.Id);
			}
		}
		if (Contractor.Informs == null)
		{
			return;
		}
		foreach (EleWise.ELMA.Security.Models.IUser item2 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)Contractor.Informs)
		{
			AddUserContractor(item2, Contractor, CommonRoleTypes.Informs.Id);
		}
	}

	private void AddRelationshipPermission(IRelationship Relationship)
	{
		if (Relationship.Contact != null || Relationship.Contractor != null || Relationship.Lead != null || Relationship.RelationshipUsers == null)
		{
			return;
		}
		foreach (IRelationshipUser item in (IEnumerable<IRelationshipUser>)Relationship.RelationshipUsers)
		{
			AddUserRelationshipNew(item.User, Relationship, (item.Status == RelationshipUserStatus.InfromTo) ? CommonRoleTypes.Informs.Id : CommonRoleTypes.ParticipantWork.Id);
		}
	}

	private void CheckListInRelationship(PreCollectionUpdateEvent @event, string mode, Guid PermissionRole, RelationshipUserStatus relationshipUserStatus)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IRelationship))
		{
			return;
		}
		IRelationship relationship = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IRelationship;
		CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		if (!collectionEntry.get_Role().EndsWith(mode))
		{
			return;
		}
		List<object> source = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
		List<object> source2 = (collectionEntry.get_Snapshot() as IEnumerable).Cast<object>().ToList();
		IEnumerable<IRelationshipUser> source3 = source.OfType<IRelationshipUser>();
		IEnumerable<IRelationshipUser> source4 = source2.OfType<IRelationshipUser>();
		if (source.Count() != source3.Count() || source2.Count() != source4.Count())
		{
			return;
		}
		IEnumerable<IRelationshipUser> newRelationshipUserCust = from a in source.OfType<IRelationshipUser>()
			where a.Status == relationshipUserStatus
			select a;
		IEnumerable<IRelationshipUser> oldRelationshipUserCust = from a in source2.OfType<IRelationshipUser>()
			where a.Status == relationshipUserStatus
			select a;
		foreach (IRelationshipUser item in newRelationshipUserCust.Where((IRelationshipUser e) => !oldRelationshipUserCust.Any((IRelationshipUser re) => re.User.Id == e.User.Id)))
		{
			AddUserRelationship(item.User, relationship, PermissionRole);
		}
		foreach (IRelationshipUser item2 in oldRelationshipUserCust.Where((IRelationshipUser e) => !newRelationshipUserCust.Any((IRelationshipUser re) => re.User.Id == e.User.Id)))
		{
			DelUserRelationship(item2.User, relationship, PermissionRole);
		}
	}

	private void CheckListInContractor(PreCollectionUpdateEvent @event, string mode, Guid permissionRole)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IContractor))
		{
			return;
		}
		IContractor contractor = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IContractor;
		CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		if (!collectionEntry.get_Role().EndsWith(mode))
		{
			return;
		}
		List<object> source = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
		List<object> source2 = (collectionEntry.get_Snapshot() as IEnumerable).Cast<object>().ToList();
		IEnumerable<EleWise.ELMA.Security.Models.IUser> newCategory = source.OfType<EleWise.ELMA.Security.Models.IUser>();
		IEnumerable<EleWise.ELMA.Security.Models.IUser> oldCategory = source2.OfType<EleWise.ELMA.Security.Models.IUser>();
		if (source.Count() != newCategory.Count() || source2.Count() != oldCategory.Count())
		{
			return;
		}
		foreach (EleWise.ELMA.Security.Models.IUser item in newCategory.Where((EleWise.ELMA.Security.Models.IUser e) => !oldCategory.Any((EleWise.ELMA.Security.Models.IUser re) => re.Id == e.Id)))
		{
			AddUserContractor(item, contractor, permissionRole);
		}
		foreach (EleWise.ELMA.Security.Models.IUser item2 in oldCategory.Where((EleWise.ELMA.Security.Models.IUser e) => !newCategory.Any((EleWise.ELMA.Security.Models.IUser re) => re.Id == e.Id)))
		{
			DelUserContractor(item2, contractor, permissionRole);
		}
	}

	private void CheckListInLead(PreCollectionUpdateEvent @event, string mode, Guid permissionRole)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is ILead))
		{
			return;
		}
		ILead lead = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as ILead;
		CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		if (!collectionEntry.get_Role().EndsWith(mode))
		{
			return;
		}
		List<object> source = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
		List<object> source2 = (collectionEntry.get_Snapshot() as IEnumerable).Cast<object>().ToList();
		IEnumerable<EleWise.ELMA.Security.Models.IUser> enumerable = source.OfType<EleWise.ELMA.Security.Models.IUser>();
		IEnumerable<EleWise.ELMA.Security.Models.IUser> enumerable2 = source2.OfType<EleWise.ELMA.Security.Models.IUser>();
		if (source.Count() != enumerable.Count() || source2.Count() != enumerable2.Count())
		{
			return;
		}
		FunctorEqualityComparer<EleWise.ELMA.Security.Models.IUser> comparer = new FunctorEqualityComparer<EleWise.ELMA.Security.Models.IUser>((EleWise.ELMA.Security.Models.IUser a, EleWise.ELMA.Security.Models.IUser b) => a.Id == b.Id);
		foreach (EleWise.ELMA.Security.Models.IUser item in enumerable.Except(enumerable2, comparer))
		{
			AddUserLead(item, lead, permissionRole);
		}
		foreach (EleWise.ELMA.Security.Models.IUser item2 in enumerable2.Except(enumerable, comparer))
		{
			DelUserLead(item2, lead, permissionRole);
		}
	}

	private void AddUserRelationship(EleWise.ELMA.Security.Models.IUser user, IRelationship relationship, Guid permissionRole)
	{
		LockBlocing();
		IRelationshipPersonPermissionFilter relationshipPersonPermissionFilter = InterfaceActivator.Create<IRelationshipPersonPermissionFilter>();
		relationshipPersonPermissionFilter.PermissionRole = permissionRole;
		relationshipPersonPermissionFilter.Relationship = relationship;
		ICollection<IRelationshipPersonPermission> collection = EntityManager<IRelationshipPersonPermission>.Instance.Find(relationshipPersonPermissionFilter, null);
		if (collection != null && collection.Any())
		{
			IRelationshipPersonPermission oldPerm = collection.FirstOrDefault(delegate(IRelationshipPersonPermission c)
			{
				if (c.User.Id != user.Id)
				{
					Guid? permissionRole2 = c.PermissionRole;
					Guid guid = permissionRole;
					if (!permissionRole2.HasValue)
					{
						return false;
					}
					if (!permissionRole2.HasValue)
					{
						return true;
					}
					return permissionRole2.GetValueOrDefault() == guid;
				}
				return false;
			});
			if (oldPerm != null && oldPerm.User != null)
			{
				foreach (IRelationshipPersonPermission item in collection.Where((IRelationshipPersonPermission c) => c.User.Id == oldPerm.User.Id))
				{
					IRelationshipPersonPermission relationshipPersonPermission = EntityManager<IRelationshipPersonPermission>.Create();
					relationshipPersonPermission.User = user;
					relationshipPersonPermission.PermissionId = item.PermissionId;
					relationshipPersonPermission.TypeRoleId = CommonRoleTypes.User.Id;
					relationshipPersonPermission.PermissionRole = permissionRole;
					relationshipPersonPermission.InheritedFromNumber = item.InheritedFromNumber;
					relationshipPersonPermission.Relationship = relationship;
					relationshipPersonPermission.Save();
				}
			}
		}
		UnLockBlocing();
	}

	private void AddUserRelationshipNew(EleWise.ELMA.Security.Models.IUser user, IRelationship Relationship, Guid PermissionRole)
	{
		LockBlocing();
		if (!((IEnumerable<IRelationshipPersonPermission>)Relationship.Permission).Any((IRelationshipPersonPermission p) => p.TypeRoleId == CommonRoleTypes.User.Id && p.User != null && p.User.Id == user.Id))
		{
			IRelationshipPersonPermission relationshipPersonPermission = EntityManager<IRelationshipPersonPermission>.Create();
			relationshipPersonPermission.Relationship = Relationship;
			relationshipPersonPermission.PermissionId = CRMPermissionProvider.ViewRelationshipPermission.Id;
			relationshipPersonPermission.PermissionRole = PermissionRole;
			relationshipPersonPermission.TypeRoleId = CommonRoleTypes.User.Id;
			relationshipPersonPermission.User = user;
			relationshipPersonPermission.Save();
			IRelationshipPersonPermission relationshipPersonPermission2 = EntityManager<IRelationshipPersonPermission>.Create();
			relationshipPersonPermission2.Relationship = Relationship;
			relationshipPersonPermission2.PermissionId = CRMPermissionProvider.EditRelationshipPermission.Id;
			relationshipPersonPermission2.TypeRoleId = CommonRoleTypes.User.Id;
			relationshipPersonPermission2.User = user;
			relationshipPersonPermission2.Save();
			IRelationshipPersonPermission relationshipPersonPermission3 = EntityManager<IRelationshipPersonPermission>.Create();
			relationshipPersonPermission3.Relationship = Relationship;
			relationshipPersonPermission3.PermissionId = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
			relationshipPersonPermission3.TypeRoleId = CommonRoleTypes.User.Id;
			relationshipPersonPermission3.User = user;
			relationshipPersonPermission3.Save();
			IRelationshipPersonPermission relationshipPersonPermission4 = EntityManager<IRelationshipPersonPermission>.Create();
			relationshipPersonPermission4.Relationship = Relationship;
			relationshipPersonPermission4.PermissionId = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
			relationshipPersonPermission4.TypeRoleId = CommonRoleTypes.User.Id;
			relationshipPersonPermission4.User = user;
			relationshipPersonPermission4.Save();
			IRelationshipPersonPermission relationshipPersonPermission5 = EntityManager<IRelationshipPersonPermission>.Create();
			relationshipPersonPermission5.Relationship = Relationship;
			relationshipPersonPermission5.PermissionId = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
			relationshipPersonPermission5.TypeRoleId = CommonRoleTypes.User.Id;
			relationshipPersonPermission5.User = user;
			relationshipPersonPermission5.Save();
		}
		UnLockBlocing();
	}

	private void DelUserContractor(EleWise.ELMA.Security.Models.IUser user, IContractor contractor, Guid permissionRole)
	{
		LockBlocing();
		IContractorPersonPermissionFilter contractorPersonPermissionFilter = InterfaceActivator.Create<IContractorPersonPermissionFilter>();
		contractorPersonPermissionFilter.User = user;
		contractorPersonPermissionFilter.PermissionRole = permissionRole;
		contractorPersonPermissionFilter.Contractor = contractor;
		ICollection<IContractorPersonPermission> collection = EntityManager<IContractorPersonPermission>.Instance.Find(contractorPersonPermissionFilter, null);
		if (collection != null)
		{
			foreach (IContractorPersonPermission item in collection)
			{
				DeletePermissionContractor(item);
				item.Delete();
				((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(item);
			}
		}
		UnLockBlocing();
	}

	private void DelUserLead(EleWise.ELMA.Security.Models.IUser user, ILead lead, Guid permissionRole)
	{
		LockBlocing();
		ILeadPersonPermissionFilter leadPersonPermissionFilter = InterfaceActivator.Create<ILeadPersonPermissionFilter>();
		leadPersonPermissionFilter.User = user;
		leadPersonPermissionFilter.PermissionRole = permissionRole;
		leadPersonPermissionFilter.Lead = lead;
		ICollection<ILeadPersonPermission> collection = EntityManager<ILeadPersonPermission>.Instance.Find(leadPersonPermissionFilter, null);
		if (collection != null)
		{
			foreach (ILeadPersonPermission item in collection)
			{
				DeletePermissionLead(item);
				item.Delete();
				((ICollection<ILeadPersonPermission>)lead.Permission).Remove(item);
			}
		}
		UnLockBlocing();
	}

	private void AddUserContractor(EleWise.ELMA.Security.Models.IUser user, IContractor contractor, Guid permissionRole)
	{
		LockBlocing();
		IContractorPersonPermissionFilter contractorPersonPermissionFilter = InterfaceActivator.Create<IContractorPersonPermissionFilter>();
		contractorPersonPermissionFilter.PermissionRole = permissionRole;
		contractorPersonPermissionFilter.Contractor = contractor;
		ICollection<IContractorPersonPermission> collection = EntityManager<IContractorPersonPermission>.Instance.Find(contractorPersonPermissionFilter, null);
		if (collection != null && collection.Any())
		{
			IContractorPersonPermission oldPerm = collection.FirstOrDefault((IContractorPersonPermission c) => c.User.Id != user.Id);
			if (oldPerm != null && oldPerm.User != null)
			{
				foreach (IContractorPersonPermission item in collection.Where((IContractorPersonPermission c) => c.User.Id == oldPerm.User.Id))
				{
					IContractorPersonPermission permission = EntityManager<IContractorPersonPermission>.Create();
					permission.User = user;
					permission.PermissionId = item.PermissionId;
					permission.TypeRoleId = CommonRoleTypes.User.Id;
					permission.PermissionRole = permissionRole;
					permission.InheritedFromNumber = item.InheritedFromNumber;
					permission.Contractor = contractor;
					permission.Save();
					unitOfWorkManager.RegisterPostCommitAction(delegate
					{
						AddPermissionOfContragent(permission);
					});
				}
			}
		}
		UnLockBlocing();
	}

	private void AddUserLead(EleWise.ELMA.Security.Models.IUser user, ILead Lead, Guid PermissionRole)
	{
		LockBlocing();
		ILeadPersonPermissionFilter leadPersonPermissionFilter = InterfaceActivator.Create<ILeadPersonPermissionFilter>();
		leadPersonPermissionFilter.PermissionRole = PermissionRole;
		leadPersonPermissionFilter.Lead = Lead;
		ICollection<ILeadPersonPermission> collection = EntityManager<ILeadPersonPermission>.Instance.Find(leadPersonPermissionFilter, null);
		if (collection != null && collection.Any())
		{
			ILeadPersonPermission oldPerm = collection.FirstOrDefault((ILeadPersonPermission c) => c.User.Id != user.Id);
			if (oldPerm != null && oldPerm.User != null)
			{
				foreach (ILeadPersonPermission item in collection.Where((ILeadPersonPermission c) => c.User.Id == oldPerm.User.Id))
				{
					ILeadPersonPermission permission = EntityManager<ILeadPersonPermission>.Create();
					permission.User = user;
					permission.PermissionId = item.PermissionId;
					permission.TypeRoleId = CommonRoleTypes.User.Id;
					permission.PermissionRole = PermissionRole;
					permission.InheritedFromNumber = item.InheritedFromNumber;
					permission.Lead = Lead;
					permission.Save();
					unitOfWorkManager.RegisterPostCommitAction(delegate
					{
						AddPermissionOfLead(permission);
					});
				}
			}
		}
		UnLockBlocing();
	}

	private void DelUserRelationship(EleWise.ELMA.Security.Models.IUser user, IRelationship relationship, Guid relationshipRole)
	{
		LockBlocing();
		IRelationshipPersonPermissionFilter relationshipPersonPermissionFilter = InterfaceActivator.Create<IRelationshipPersonPermissionFilter>();
		relationshipPersonPermissionFilter.User = user;
		relationshipPersonPermissionFilter.Relationship = relationship;
		relationshipPersonPermissionFilter.PermissionRole = relationshipRole;
		ICollection<IRelationshipPersonPermission> collection = EntityManager<IRelationshipPersonPermission>.Instance.Find(relationshipPersonPermissionFilter, null);
		if (relationship != null)
		{
			foreach (IRelationshipPersonPermission item in collection)
			{
				item.Delete();
			}
		}
		UnLockBlocing();
	}

	private void CheckContractorInCategory(PreCollectionUpdateEvent @event)
	{
		if (@event != null && ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IContractor)
		{
			IContractor contractor = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IContractor;
			CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
			List<object> source = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
			List<object> source2 = (collectionEntry.get_Snapshot() as IEnumerable).Cast<object>().ToList();
			List<ICategory> newCategory = source.OfType<ICategory>().ToList();
			IEnumerable<ICategory> oldCategory = source2.OfType<ICategory>();
			if (source.Count() == newCategory.Count() && source2.Count() == oldCategory.Count())
			{
				if (oldCategory.Count() == 0 && newCategory.Count() > 0)
				{
					DelCategory(CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid), contractor);
				}
				if (!newCategory.Any())
				{
					newCategory.Add(CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid));
				}
				foreach (ICategory item in oldCategory.Where((ICategory e) => newCategory.All((ICategory re) => re.Id != e.Id)))
				{
					DelCategory(item, contractor);
				}
				foreach (ICategory item2 in newCategory.Where((ICategory e) => !oldCategory.Any((ICategory re) => re.Id == e.Id)))
				{
					AddCategory(item2, contractor);
				}
				IContractorPersonPermissionFilter contractorPersonPermissionFilter = InterfaceActivator.Create<IContractorPersonPermissionFilter>();
				contractorPersonPermissionFilter.Contractor = contractor;
				ICollection<IContractorPersonPermission> source3 = EntityManager<IContractorPersonPermission>.Instance.Find(contractorPersonPermissionFilter, null);
				ContractorManager.Instance.SendChangeAccess(contractor, ((IEnumerable<IContractorPersonPermission>)contractor.Permission).ToList(), source3.ToList());
			}
		}
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is ILead))
		{
			return;
		}
		ILead lead = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as ILead;
		CollectionEntry collectionEntry2 = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		List<object> source4 = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
		List<object> source5 = (collectionEntry2.get_Snapshot() as IEnumerable).Cast<object>().ToList();
		List<ICategory> newCategory2 = source4.OfType<ICategory>().ToList();
		List<ICategory> oldCategory2 = source5.OfType<ICategory>().ToList();
		if (source4.Count() != newCategory2.Count() || source5.Count() != oldCategory2.Count())
		{
			return;
		}
		if (oldCategory2.Count() == 0 && newCategory2.Count() > 0)
		{
			DelLead(CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid), lead);
		}
		if (!newCategory2.Any() && oldCategory2.Any())
		{
			newCategory2.Add(CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid));
		}
		foreach (ICategory item3 in oldCategory2.Where((ICategory e) => newCategory2.All((ICategory re) => re.Id != e.Id)))
		{
			DelLead(item3, lead);
		}
		foreach (ICategory item4 in newCategory2.Where((ICategory e) => !oldCategory2.Any((ICategory re) => re.Id == e.Id)))
		{
			AddLead(item4, lead);
		}
	}

	private void AddCategory(ICategory category, IContractor contractor)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecCheckPermWhenAddCategories").SetParameter<long>("CategoryId", category.Id).SetParameter<long>("ContractorId", contractor.Id);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContractorPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при добавлении категории в контрагента (ExecCheckPermWhenAddCategories) CategoryId={0}, ContractorId={1}", category.Id, contractor.Id), exception);
			throw;
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void AddLead(ICategory category, ILead lead)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecCheckPermWhenAddLeadCategories").SetParameter<long>("CategoryId", category.Id).SetParameter<long>("LeadId", lead.Id);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ILeadPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при добавлении категории в лида (ExecCheckPermWhenAddLeadCategories) CategoryId={0}, LeadId={1}", category.Id, lead.Id), exception);
			throw;
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DelLead(ICategory category, ILead lead)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecCheckPermWhenDelLeadCategories").SetParameter<long>("CategoryId", category.Id).SetParameter<long>("LeadId", lead.Id);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ILeadPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при заборе категории из лида (ExecCheckPermWhenDelCategories) CategoryId={0}, LeadId={1}", category.Id, lead.Id), exception);
			throw;
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DelCategory(ICategory category, IContractor contractor)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecCheckPermWhenDelCategories").SetParameter<long>("CategoryId", category.Id).SetParameter<long>("ContractorId", contractor.Id);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContractorPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при заборе категории из контрагента (ExecCheckPermWhenDelCategories) CategoryId={0}, LeadId={1}", category.Id, contractor.Id), exception);
			throw;
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void AddPermissionOfContragent(IContractorPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecAddUpdateContractorPermissions").SetParameter<Guid>("uid", permission.Uid);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContractorPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка назначения разрешений на контрагента (ExecAddUpdateContractorPermissions) PermissionUid={0}", permission.Uid), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void AddPermissionOfLead(ILeadPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecAddUpdateLeadPermissions").SetParameter<Guid>("uid", permission.Uid);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ILeadPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка добавления  разрешений на взаимоотношение (ExecAddUpdateLeadPermissions)", permission.Uid), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void AddPermissionOfContact(IContactPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecAddUpdateContactPermissions").SetParameter<Guid>("uid", permission.Uid);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContactPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка добавления  разрешений на контакт (ExecAddUpdateContactPermissions) PermissionId={0}", permission.Id), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void AddPermissionOfSale(ISalePersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecAddUpdateSalePermissions").SetParameter<Guid>("uid", permission.Uid);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка добавления  разрешений на сделку (ExecAddUpdateSalePermissions)", permission.Id), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DeletePermissionContractor(IContractorPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecDelUpdateContractorPermissions").SetParameter<Guid>("permissionId", permission.PermissionId).SetParameter<long?>("userSecuritySetCacheId", permission.UserSecuritySetCacheId)
				.SetParameter<long>("ContractorId", permission.Contractor.Id)
				.SetParameter<Guid?>("permissionRole", permission.PermissionRole);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContractorPersonPermission), typeof(IRelationshipPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка забора разрешений на сделку (ExecDelUpdateContractorPermissions) PermissionId={0},userSecuritySetCacheId={1},ContractorId={2}", permission.PermissionId, permission.UserSecuritySetCacheId, permission.Contractor.Id), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DeletePermissionLead(ILeadPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecDelUpdateLeadPermissions").SetParameter<Guid>("permissionId", permission.PermissionId).SetParameter<long>("userSecuritySetCacheId", permission.UserSecuritySetCacheId)
				.SetParameter<long>("LeadId", permission.Lead.Id)
				.SetParameter<Guid?>("permissionRole", permission.PermissionRole);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ILeadPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка забора разрешений у лидов (ExecDelUpdateLeadPermissions) PermissionId={0},userSecuritySetCacheId={1},ContractorId={2}", permission.PermissionId, permission.UserSecuritySetCacheId, permission.Lead.Id), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DeletePermissionContact(IContactPersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecDelUpdateContactPermissions").SetParameter<Guid>("permissionId", permission.PermissionId).SetParameter<long?>("userSecuritySetCacheId", permission.UserSecuritySetCacheId)
				.SetParameter<long>("ContactId", permission.Contact.Id)
				.SetParameter<Guid?>("permissionRole", permission.PermissionRole);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContactPersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка забора разрешений у контакта (ExecDelUpdateContactPermissions)) PermissionId={0},userSecuritySetCacheId={1},ContactId={2},permissionRole={3}", permission.PermissionId, permission.UserSecuritySetCacheId, permission.Contact.Id, permission.PermissionRole), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void DeletePermissionSale(ISalePersonPermission permission)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecDelUpdateSalePermissions").SetParameter<Guid>("permissionId", permission.PermissionId).SetParameter<long>("userSecuritySetCacheId", permission.UserSecuritySetCacheId)
				.SetParameter<long>("SaleId", permission.Sale.Id)
				.SetParameter<Guid?>("permissionRole", permission.PermissionRole);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка забора разрешений на сделку (ExecDelUpdateSalePermissions) PermissionId={0},userSecuritySetCacheId={1},SaleId={2},PermissionRole={3}", permission.PermissionId, permission.UserSecuritySetCacheId, permission.Sale.Id, permission.PermissionRole), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void UpdateResponsible(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() != null && @event.get_OldState() != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IContractor)
		{
			IContractor contractor = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContractor;
			LockBlocing();
			try
			{
				string value = LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Responsible));
				int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value);
				EleWise.ELMA.Security.Models.IUser user = @event.get_OldState()[num] as EleWise.ELMA.Security.Models.IUser;
				EleWise.ELMA.Security.Models.IUser user2 = @event.get_State()[num] as EleWise.ELMA.Security.Models.IUser;
				if (user != null && user2 != null && user.Id != user2.Id)
				{
					bool flag = false;
					foreach (IContractorPersonPermission source2 in ((IEnumerable<IContractorPersonPermission>)contractor.Permission).Where((IContractorPersonPermission a) => a.TypeRoleId == CommonRoleTypes.Responsible.Id))
					{
						DeletePermissionContractor(source2);
						source2.User = user2;
						source2.Save();
						unitOfWorkManager.RegisterPostCommitAction(delegate
						{
							AddPermissionOfContragent(source2);
						});
						flag = true;
					}
					if (flag)
					{
						AddReIndexContractorQueueItem(contractor);
					}
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Ошибка пересчета прав при смене ответственного в контрагенте в "), exception);
			}
			finally
			{
				UnLockBlocing();
			}
		}
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() != null && @event.get_OldState() != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ILead)
		{
			ILead lead = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ILead;
			LockBlocing();
			try
			{
				string value2 = LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead d) => d.Responsible));
				int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value2);
				EleWise.ELMA.Security.Models.IUser user3 = @event.get_OldState()[num2] as EleWise.ELMA.Security.Models.IUser;
				EleWise.ELMA.Security.Models.IUser user4 = @event.get_State()[num2] as EleWise.ELMA.Security.Models.IUser;
				if (user3 != null && user4 != null && user3.Id != user4.Id)
				{
					foreach (ILeadPersonPermission item in ((IEnumerable<ILeadPersonPermission>)lead.Permission).Where((ILeadPersonPermission a) => a.TypeRoleId == CommonRoleTypes.Responsible.Id))
					{
						item.User = user4;
						item.Save();
					}
				}
			}
			catch (Exception exception2)
			{
				Logger.Log.Error(SR.T("Ошибка пересчета прав при смене ответственного в взаимоотношении "), exception2);
			}
			finally
			{
				UnLockBlocing();
			}
		}
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() == null || @event.get_OldState() == null || !(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISale))
		{
			return;
		}
		ISale sale = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISale;
		LockBlocing();
		try
		{
			string value3 = LinqUtils.NameOf((Expression<Func<ISale, object>>)((ISale d) => d.Responsible));
			int num3 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value3);
			EleWise.ELMA.Security.Models.IUser user5 = @event.get_OldState()[num3] as EleWise.ELMA.Security.Models.IUser;
			EleWise.ELMA.Security.Models.IUser user6 = @event.get_State()[num3] as EleWise.ELMA.Security.Models.IUser;
			if (user5 == null || user6 == null || user5.Id == user6.Id)
			{
				return;
			}
			foreach (ISalePersonPermission source in ((IEnumerable<ISalePersonPermission>)sale.Permission).Where((ISalePersonPermission a) => a.TypeRoleId == CommonRoleTypes.Responsible.Id))
			{
				DeletePermissionSale(source);
				source.User = user6;
				source.Save();
				unitOfWorkManager.RegisterPostCommitAction(delegate
				{
					AddPermissionOfSale(source);
				});
			}
		}
		catch (Exception exception3)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при смене ответственного в контрагенте в "), exception3);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void UpdateContragentInSale(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() == null || @event.get_OldState() == null || !(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISale))
		{
			return;
		}
		ISale sale = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISale;
		if (!sale.InheritPermissions)
		{
			return;
		}
		LockBlocing();
		try
		{
			string value = LinqUtils.NameOf((Expression<Func<ISale, object>>)((ISale d) => d.Contractor));
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value);
			IContractor contractor = @event.get_OldState()[num] as IContractor;
			IContractor contractor2 = @event.get_State()[num] as IContractor;
			if (contractor != null && contractor2 != null && contractor.Id != contractor2.Id)
			{
				saleManager.DeleteAllInheritedPermissionInSale(sale);
				saleManager.AddPermissionsFromParent(sale);
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при смене контрагента в сделке (UpdateContragentInSale)"), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void UpdateContragentInRelationship(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() == null || @event.get_OldState() == null || !(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IRelationship))
		{
			return;
		}
		IRelationship relationship = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IRelationship;
		LockBlocing();
		try
		{
			string value = LinqUtils.NameOf((Expression<Func<IRelationship, object>>)((IRelationship d) => d.Contractor));
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value);
			IContractor contractor = @event.get_OldState()[num] as IContractor;
			IContractor contractor2 = @event.get_State()[num] as IContractor;
			string value2 = LinqUtils.NameOf((Expression<Func<IRelationship, object>>)((IRelationship d) => d.Lead));
			int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value2);
			ILead lead = @event.get_OldState()[num2] as ILead;
			ILead lead2 = @event.get_State()[num2] as ILead;
			string value3 = LinqUtils.NameOf((Expression<Func<IRelationship, object>>)((IRelationship d) => d.Sale));
			int num3 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value3);
			ISale sale = @event.get_OldState()[num3] as ISale;
			ISale sale2 = @event.get_State()[num3] as ISale;
			string value4 = LinqUtils.NameOf((Expression<Func<IRelationship, object>>)((IRelationship d) => d.Contact));
			int num4 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value4);
			IContact contact = @event.get_OldState()[num4] as IContact;
			IContact contact2 = @event.get_State()[num4] as IContact;
			if ((contractor?.Id ?? 0) != (contractor2?.Id ?? 0) || (lead?.Id ?? 0) != (lead2?.Id ?? 0) || (contact?.Id ?? 0) != (contact2?.Id ?? 0) || (sale?.Id ?? 0) != (sale2?.Id ?? 0))
			{
				PostFlushActionRunner.Add("UpdateRelationshipPermission" + relationship.Id, delegate
				{
					RelationshipManager.Instance.DeleteAllPermissionInRelationship(relationship);
					RelationshipManager.Instance.AddPermissionsFromParent(relationship);
				});
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка пересчета прав при смене контрагента в сделке (UpdateContragentInSale)"), exception);
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void CheckLockGlobalBlocing()
	{
		if (!ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return;
		}
		int num = 0;
		bool flag = true;
		while (flag)
		{
			if (!ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
			{
				flag = false;
			}
			else
			{
				if (num > 20)
				{
					throw new BlockedPermissionException();
				}
				Thread.Sleep(1000);
			}
			num++;
		}
	}

	private void LockBlocing()
	{
		CheckLockGlobalBlocing();
		if (!CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out var value) && value == null)
		{
			value = new CachePermissionModel
			{
				Blocking = true,
				NumberBlock = 1,
				TimestampTime = DateTime.Now
			};
		}
		else
		{
			if (value.TimestampTime < DateTime.Now.AddMinutes(-1.0))
			{
				value.NumberBlock = 0;
			}
			value.NumberBlock++;
			value.TimestampTime = DateTime.Now;
		}
		CacheService.Insert("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", value, "CRMPermission");
	}

	private void UnLockBlocing()
	{
		if (CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out var value) && value != null)
		{
			value.NumberBlock--;
			value.TimestampTime = DateTime.Now;
			CacheService.Insert("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", value, "CRMPermission");
		}
	}

	private void CheckContractorPermission(PreCollectionUpdateEvent @event)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IContractor contractor))
		{
			return;
		}
		CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		if (collectionEntry.get_Role().EndsWith(".Permission") && collectionEntry.get_Snapshot() is IEnumerable source)
		{
			List<IContractorPersonPermission> list = source.OfType<IContractorPersonPermission>().ToList();
			List<IContractorPersonPermission> newPermissions = ((IEnumerable<IContractorPersonPermission>)contractor.Permission).ToList();
			if (list.Count >= 0)
			{
				ContractorManager.Instance.SendChangeAccess(contractor, list, newPermissions);
			}
		}
	}

	private void AddReIndexContractorQueueItem(IContractor contractor)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		KeyValuePair<string, object> item = new KeyValuePair<string, object>("Key31AA4139D3194D5F917DBF47E08B3CB9", new List<long> { contractor.Id });
		list.Add(item);
		indexQueueManager.AddReindexObjectPartItem(typeof(IContractorFullTextSearchObject), contractor.Id, InterfaceActivator.UID<IContractor>(), list, visualData: true);
	}
}
