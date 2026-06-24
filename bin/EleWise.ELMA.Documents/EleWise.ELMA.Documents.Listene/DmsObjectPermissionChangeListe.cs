using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class DmsObjectPermissionChangeListener : EntityEventsListener
{
	private readonly string nameOfinheritPermissions;

	private readonly string nameOfFolder;

	private bool _updateInheritedPermissions = true;

	internal const string ApplyInheritPermissions = "EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ApplyInheritPermissions";

	internal const string ChangePermissionsWhenChangeFolder = "EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ChangePermissionsWhenChangeFolder";

	public DmsObjectManager DmsObjectManager { get; set; }

	[Obsolete("Больше не используется")]
	public PostFlushActionRunner PostFlushActionRunner { get; set; }

	[Obsolete("Больше не используется")]
	public new ISessionProvider SessionProvider { get; set; }

	public bool UpdateInheritedPermissions
	{
		get
		{
			return _updateInheritedPermissions;
		}
		set
		{
			_updateInheritedPermissions = value;
		}
	}

	private DmsObjectPermissionPatcherService DmsObjectPermissionPatcherService => DmsObjectPermissionPatcherService.Instance;

	public DmsObjectPermissionChangeListener()
	{
		nameOfinheritPermissions = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.InheritPermissions));
		nameOfFolder = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder));
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Permissions));
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		UpdatePermissionAuthor(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		return false;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null)
		{
			CheckDmsObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), delegate(IDmsObjectPermission p)
			{
				DmsObjectPermissionPatcherService.AddPermissionPatch(p, DmsObjectPermissionPatcherService.PatchType.Insert);
				DmsObjectPermissionPatcherService.RunPatchingOnFlush(p);
			});
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null)
		{
			CheckDmsObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), delegate(IDmsObjectPermission p)
			{
				DmsObjectPermissionPatcherService.AddPermissionPatch(p, DmsObjectPermissionPatcherService.PatchType.Remove);
				DmsObjectPermissionPatcherService.RunPatchingOnFlush(p);
			});
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		UpdatePermissionAuthor(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		return false;
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (@event == null)
		{
			return;
		}
		IDmsObject dmsObject = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IDmsObject;
		if (dmsObject != null)
		{
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfinheritPermissions);
			int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfFolder);
			if (@event.get_OldState() != null && @event.get_State() != null && UpdateInheritedPermissions)
			{
				if (!object.Equals(@event.get_OldState()[num], @event.get_State()[num]) && !ContextVars.Contains("EleWise.ELMA.Documents.Managers.DmsObjectManager.EnableInheritPermissions" + dmsObject.Id) && !ContextVars.Contains("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ApplyInheritPermissions" + dmsObject.Id))
				{
					UpdatePermissions(dmsObject, delegate
					{
						ContextVars.Set("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ApplyInheritPermissions" + dmsObject.GetId(), dmsObject.InheritPermissions);
					});
				}
				IFolder folder = @event.get_State()[num2] as IFolder;
				IFolder folder2 = @event.get_OldState()[num2] as IFolder;
				if (!ContextVars.Contains("EleWise.ELMA.Documents.Managers.DmsObjectManager.MoveTo" + dmsObject.Id) && ((folder != null && folder2 != null && folder.Id != folder2.Id) || (folder == null && folder2 != null) || (folder != null && folder2 == null)))
				{
					UpdatePermissions(dmsObject, delegate
					{
						ContextVars.Set("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ChangePermissionsWhenChangeFolder" + dmsObject.GetId(), dmsObject.InheritPermissions);
					});
				}
			}
		}
		CheckDmsObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), delegate(IDmsObjectPermission newEntity)
		{
			IDmsObjectPermission dmsObjectPermission = InterfaceActivator.Create<IDmsObjectPermission>();
			for (int i = 0; i < @event.get_OldState().Length; i++)
			{
				string text = ((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()[i];
				PropertyInfo reflectionProperty = dmsObjectPermission.GetType().GetReflectionProperty(text);
				if (reflectionProperty != null && reflectionProperty.CanWrite)
				{
					try
					{
						reflectionProperty.SetValue(dmsObjectPermission, @event.get_OldState()[i], null);
					}
					catch (Exception exception)
					{
						Logger.Log.Error($"Cannot set property {text} for entity of type {dmsObjectPermission.GetType().FullName} while forming old state entity", exception);
					}
				}
			}
			DmsObjectPermissionPatcherService.AddPermissionPatch(dmsObjectPermission, DmsObjectPermissionPatcherService.PatchType.Remove);
			DmsObjectPermissionPatcherService.RunPatchingOnFlush(dmsObjectPermission);
			DmsObjectPermissionPatcherService.AddPermissionPatch(newEntity, DmsObjectPermissionPatcherService.PatchType.Insert);
			DmsObjectPermissionPatcherService.RunPatchingOnFlush(newEntity);
		});
	}

	private void CheckDmsObjectPermission(object entity, Action<IDmsObjectPermission> action)
	{
		IDmsObjectPermission dmsObjectPermission = entity as IDmsObjectPermission;
		if (dmsObjectPermission == null || dmsObjectPermission.DmsObject == null)
		{
			return;
		}
		UpdatePermissions(dmsObjectPermission.DmsObject, delegate
		{
			if (action != null)
			{
				action(dmsObjectPermission);
			}
		});
	}

	private void UpdatePermissions(IDmsObject dmsObject, Action action)
	{
		if (UpdateInheritedPermissions)
		{
			action?.Invoke();
			if (dmsObject is IFolder && dmsObject.Uid == DocumentConstants.ArchiveFolderUid)
			{
				Locator.GetServiceNotNull<ISystemFoldersService>().ClearAll();
			}
		}
	}

	private void UpdatePermissionAuthor(object entity)
	{
		CheckDmsObjectPermission(entity, delegate(IDmsObjectPermission p)
		{
			if (p.InheritedFromFolder != null && p.PermissionRole.HasValue && p.PermissionRole.Value == CommonRoleTypes.Author.UID)
			{
				EleWise.ELMA.Security.Models.IUser creationAuthor = p.DmsObject.CreationAuthor;
				if (creationAuthor != null)
				{
					p.User = creationAuthor;
					p.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(creationAuthor.Id);
				}
			}
		});
	}
}
