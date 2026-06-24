using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Exceptions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
internal class CategoryPermissionChangeListener : EntityEventsListener
{
	internal class UpdatePermission
	{
		public static readonly UpdatePermission True = new UpdatePermission(enabled: true);

		public static readonly UpdatePermission False = new UpdatePermission(enabled: false);

		public bool Enabled { get; set; }

		public UpdatePermission(bool enabled)
		{
			Enabled = enabled;
		}
	}

	private readonly ISessionProvider sessionProvider;

	private readonly ILockManager lockManager;

	private readonly IContextBoundVariableService contextBoundVariableService;

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public ICacheService CacheService { get; set; }

	public CategoryPermissionChangeListener(ISessionProvider sessionProvider, IContextBoundVariableService contextBoundVariableService, ILockManager lockManager)
	{
		this.sessionProvider = sessionProvider;
		this.contextBoundVariableService = contextBoundVariableService;
		this.lockManager = lockManager;
	}

	public new virtual bool OnPreDelete(PreDeleteEvent @event)
	{
		if (@event == null)
		{
			return false;
		}
		return lockBlocing(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
	}

	public new virtual bool OnPreInsert(PreInsertEvent @event)
	{
		if (@event == null)
		{
			return false;
		}
		return lockBlocing(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (@event == null)
		{
			return false;
		}
		return lockBlocing(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null)
		{
			AddPermissions(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
			addTemplatePermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
			unLockBlocing(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	public new virtual void OnPostUpdate(PostUpdateEvent @event)
	{
		if (@event != null)
		{
			addTemplatePermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
			unLockBlocing(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null)
		{
			DeleteCategory(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
			unLockBlocing(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	private void DeleteCategory(object entity)
	{
		if (!(entity is ICategory))
		{
			return;
		}
		ICategory category = entity as ICategory;
		if (category.ContainerContractorPermission != null)
		{
			ITemplateContractorPermissionFilter templateContractorPermissionFilter = InterfaceActivator.Create<ITemplateContractorPermissionFilter>();
			templateContractorPermissionFilter.ContainerContractor = category.ContainerContractorPermission;
			foreach (ITemplateContractorPermission item in EntityManager<ITemplateContractorPermission>.Instance.Find(templateContractorPermissionFilter, null))
			{
				item.DelPermission = true;
				item.Save();
			}
		}
		if (category.ContainerContractorPermission == null)
		{
			return;
		}
		ITemplateLeadPermissionFilter templateLeadPermissionFilter = InterfaceActivator.Create<ITemplateLeadPermissionFilter>();
		templateLeadPermissionFilter.ContainerLead = category.ContainerLeadPermission;
		foreach (ITemplateLeadPermission item2 in EntityManager<ITemplateLeadPermission>.Instance.Find(templateLeadPermissionFilter, null))
		{
			item2.DelPermission = true;
			item2.Save();
		}
	}

	private void addTemplatePermission(object entity)
	{
		if (entity is ICategory)
		{
			IUser user = UserManager.Instance.LoadOrNull(Convert.ToInt64(AuthenticationService.GetCurrentUser().GetId()));
			ICategory category = entity as ICategory;
			bool flag = false;
			if (category.ContainerContractorPermission == null)
			{
				IContContractorPermission contContractorPermission = AbstractNHEntityManager<IContContractorPermission, long>.Instance.Create();
				contContractorPermission.CreationAuthor = user;
				contContractorPermission.Responsible = user;
				contContractorPermission.Save();
				category.ContainerContractorPermission = contContractorPermission;
				flag = true;
			}
			if (category.ContainerLeadPermission == null)
			{
				IContLeadPermission contLeadPermission = AbstractNHEntityManager<IContLeadPermission, long>.Instance.Create();
				contLeadPermission.CreationAuthor = user;
				contLeadPermission.Responsible = user;
				contLeadPermission.Save();
				category.ContainerLeadPermission = contLeadPermission;
				flag = true;
			}
			if (flag)
			{
				category.Save();
			}
		}
	}

	private void AddPermissions(object entity)
	{
		if (entity is ITemplateContractorPermission)
		{
			ITemplateContractorPermission obj = entity as ITemplateContractorPermission;
			obj.AddPermission = true;
			obj.DelPermission = false;
		}
		if (entity is ITemplateLeadPermission)
		{
			ITemplateLeadPermission obj2 = entity as ITemplateLeadPermission;
			obj2.AddPermission = true;
			obj2.DelPermission = false;
		}
	}

	private bool lockBlocing(object entity)
	{
		if (entity is ITemplateLeadPermission || entity is ITemplateContractorPermission || entity is IContractorPersonPermission || entity is IContactPersonPermission || entity is IRelationshipPersonPermission || entity is ILeadPersonPermission || entity is ISalePersonPermission)
		{
			if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
			{
				bool flag = true;
				while (flag)
				{
					if (!ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
					{
						flag = false;
						continue;
					}
					throw new BlockedPermissionException();
				}
			}
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
		return false;
	}

	private void unLockBlocing(object entity)
	{
		if ((entity is ITemplateLeadPermission || entity is ITemplateContractorPermission || entity is IContractorPersonPermission || entity is IContactPersonPermission || entity is IRelationshipPersonPermission || entity is ILeadPersonPermission || entity is ISalePersonPermission) && CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out var value) && value != null)
		{
			value.NumberBlock--;
			value.TimestampTime = DateTime.Now;
			CacheService.Insert("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", value, "CRMPermission");
		}
	}
}
