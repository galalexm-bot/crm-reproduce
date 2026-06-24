using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using NHibernate;
using NHibernate.Type;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal class DmsObjectPermissionPatcherService
{
	internal enum PatchType
	{
		Insert,
		Remove
	}

	private class PermissionPatch
	{
		public PatchType Type { get; set; }

		public string Patch { get; set; }

		public bool Ignored { get; set; }

		public PermissionPatch(IDmsObjectPermission permission, PatchType patchType, bool ignored)
		{
			Type = patchType;
			Patch = PatchFromPermission(permission, patchType);
			Ignored = ignored;
		}

		public static string PatchFromPermission(IDmsObjectPermission permission, PatchType patchType)
		{
			if (permission == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(permission.PermissionId);
			stringBuilder.Append(":");
			stringBuilder.Append((permission.User != null) ? permission.User.Id.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append((permission.Group != null) ? permission.Group.Id.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append((permission.OrganizationItemPosition != null) ? permission.OrganizationItemPosition.Id.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append((permission.OrganizationItemEmployee != null) ? permission.OrganizationItemEmployee.Id.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append(permission.UserSecuritySetCacheId.HasValue ? permission.UserSecuritySetCacheId.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append(permission.PermissionRole ?? Guid.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append((permission.InheritedFromFolder != null) ? permission.InheritedFromFolder.Id.ToString() : string.Empty);
			stringBuilder.Append(":");
			stringBuilder.Append((int)patchType);
			return stringBuilder.ToString();
		}
	}

	private class PermissionPatchesHolder
	{
		public List<PermissionPatch> Patches { get; private set; }

		public string ResultInsertPatch => GetResultPatch(PatchType.Insert);

		public string ResultRemovePatch => GetResultPatch(PatchType.Remove);

		public string ResultPatch => string.Join("", (from p in Patches
			orderby p.Type descending
			where !p.Ignored
			select p.Patch + ";").Distinct());

		public PermissionPatchesHolder()
		{
			Patches = new List<PermissionPatch>();
		}

		public void AddPatch(PermissionPatch patch)
		{
			if (!HasPatch(patch))
			{
				Patches.Add(patch);
			}
		}

		public bool HasPatch(PermissionPatch patch)
		{
			if (patch == null)
			{
				return true;
			}
			return (from p in Patches
				where p.Type == patch.Type
				select p.Patch).Contains(patch.Patch);
		}

		public string GetResultPatch(PatchType type)
		{
			return string.Join("", (from p in Patches
				where p.Type == type && !p.Ignored
				select p.Patch + ";").Distinct());
		}
	}

	private const string PatchesDictionaryKey = "EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener";

	public static DmsObjectPermissionPatcherService Instance => Locator.GetServiceNotNull<DmsObjectPermissionPatcherService>();

	public IContextBoundVariableService ContextBoundVariableService { get; set; }

	public PostFlushActionRunner PostFlushActionRunner { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public IDmsObjectPermissionUpdateQueueItemRepository DmsObjectPermissionUpdateQueueItemManager { get; set; }

	public IFeatureFlagService FeatureFlagService { get; set; }

	public ISecurityService SecurityService { get; set; }

	public UserManager UserManager { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	private Dictionary<string, PermissionPatchesHolder> PatchesDictionary => ContextBoundVariableService.GetOrAdd("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener", () => new Dictionary<string, PermissionPatchesHolder>());

	public void AddPermissionPatch(IDmsObjectPermission permssion, PatchType type)
	{
		AddPermissionPatch(permssion, type, ignored: false);
	}

	public void AddPermissionPatch(IDmsObjectPermission permssion, PatchType type, bool ignored)
	{
		if (permssion != null && permssion.DmsObject is IFolder)
		{
			string key2 = permssion.DmsObject.Id.ToString();
			PatchesDictionary.AddIfNotContainsKey(key2, (string key) => new PermissionPatchesHolder()).AddPatch(new PermissionPatch(permssion, type, ignored));
		}
	}

	public void RunPatchingOnFlush(IDmsObjectPermission permission)
	{
		if (permission != null)
		{
			RunPatchingOnFlush(permission.DmsObject);
		}
	}

	public void RunPatchingOnFlush(IDmsObject dmsObject)
	{
		if (dmsObject is IFolder)
		{
			PostFlushActionRunner.Add("dmsObject" + dmsObject.Id, delegate
			{
				ExecutePatchNamedQuery(dmsObject);
			});
		}
	}

	public void RunPatchingNow(IDmsObjectPermission permission)
	{
		if (permission != null)
		{
			RunPatchingNow(permission.DmsObject);
		}
	}

	public void RunPatchingNow(List<IDmsObject> dmsObjects)
	{
		if (dmsObjects != null && dmsObjects.Any())
		{
			dmsObjects.ForEach(delegate(IDmsObject d)
			{
				RunPatchingNow(d);
			});
		}
	}

	public void RunPatchingNow(IDmsObject dmsObject)
	{
		if (dmsObject is IFolder)
		{
			ExecutePatchNamedQuery(dmsObject);
		}
	}

	private void ExecutePatchNamedQuery(IDmsObject dmsObject)
	{
		long dmsObjectId = dmsObject.Id;
		if (!PatchesDictionary.TryGetValue(dmsObjectId.ToString(), out var patchesHolder) || !patchesHolder.Patches.Any())
		{
			return;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = UserManager.GetCurrentUser();
		if (FeatureFlagService.Enabled("DmsObjectPermissionUpdateQueueItem.Enabled", defaultEnabled: true))
		{
			DmsObjectPermissionUpdateQueueItemManager.BulkInsertQueueItems(dmsObject, currentUser.Id, patchesHolder.ResultPatch);
			return;
		}
		ThreadStarter.StartNewThread(new BackgroundTask(delegate
		{
			ExecUpdateInheritDmsObjectPermissionsPatch(dmsObjectId, patchesHolder.ResultPatch);
			patchesHolder.Patches.Clear();
			NotifyPermissionsUpdated(currentUser, dmsObject.Name);
		}, typeof(IDmsObjectPermission), "ExecutePatchNamedQuery", "ExecutePatchNamedQuery").Execute);
	}

	private void ExecUpdateInheritDmsObjectPermissionsPatch(long dmsObjectId, string patch)
	{
		ISession session = SessionProvider.GetSession(string.Empty);
		IQuery namedQuery = session.GetNamedQuery("ExecUpdateInheritDmsObjectPermissionsPatch");
		namedQuery.SetTimeout(0);
		namedQuery.SetParameter<long>("objId", dmsObjectId);
		namedQuery.SetParameter("permsStr", (object)patch, (IType)(object)NHibernateUtil.StringClob);
		namedQuery.ExecuteUpdate(cleanUpCache: false);
		session.CleanUpCache(typeof(IDmsObjectPermission));
	}

	private void DmsObjectPermissionPatch(long dmsObjectId, string patch)
	{
		ISession session = SessionProvider.GetSession(string.Empty);
		IQuery namedQuery = session.GetNamedQuery("ExecDmsObjectPermissionPatch");
		namedQuery.SetTimeout(0);
		namedQuery.SetParameter<long>("objId", dmsObjectId);
		namedQuery.SetParameter("permsStr", (object)patch, (IType)(object)NHibernateUtil.StringClob);
		namedQuery.ExecuteUpdate(cleanUpCache: false);
		session.CleanUpCache(typeof(IDmsObjectPermission));
	}

	public void UpdatePermission(DmsObjectPermissionUpdateQueueItem queueItem)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true, IsolationLevel.ReadCommitted);
		bool flag = false;
		try
		{
			Update(queueItem);
			DmsObjectPermissionUpdateQueueItemManager.Delete(queueItem);
			unitOfWork.Commit();
		}
		catch (Exception exception)
		{
			flag = true;
			Logger.Log.Error(SR.T("Ошибка обработки элемента очереди '{0}' для проекта '{1}'", queueItem.Id, queueItem.DmsObject), exception);
			unitOfWork.Rollback();
		}
		if (flag && queueItem.Attempt < DmsObjectPermissionUpdateQueueItemRepository.AttemptIntervals.Length - 1)
		{
			DateTime now = DateTime.Now;
			queueItem.Attempt++;
			queueItem.LastUpdateDate = now;
			queueItem.NextUpdateDate = now + DmsObjectPermissionUpdateQueueItemRepository.AttemptIntervals[queueItem.Attempt];
			queueItem.ServerConnectionUid = null;
			try
			{
				DmsObjectPermissionUpdateQueueItemManager.UpdateFailedQueueItem(queueItem);
				unitOfWork.Commit();
				return;
			}
			catch (Exception exception2)
			{
				Logger.Log.Error(SR.T("Не удалось обновить элемент очереди обновления ролей проектов '{0}'", queueItem.Id), exception2);
				unitOfWork.Rollback();
				return;
			}
		}
	}

	private void Update(DmsObjectPermissionUpdateQueueItem queueItem)
	{
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			try
			{
				string patch = ClassSerializationHelper.DeserializeObject(queueItem.Patch) as string;
				DmsObjectPermissionPatch(queueItem.DmsObject, patch);
			}
			catch (Exception ex)
			{
				Logger.Log.Error(SR.T("В ходе обновления привилегий возникла ошибка"), ex);
				throw ex;
			}
		});
	}

	internal void NotifyPermissionsUpdated(long recipient, string folderName)
	{
		NotifyPermissionsUpdated(UserManager.Load(recipient), folderName);
	}

	internal void NotifyPermissionsUpdated(EleWise.ELMA.Security.Models.IUser recipient, string folderName)
	{
		IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
		channelMessage.Recipients.Add(recipient);
		channelMessage.Subject = SR.T("Пересчёт прав доступа");
		channelMessage.MessageType = ChannelMessageType.Post;
		channelMessage.CreationAuthor = UserManager.Load(SecurityConstants.SystemUserUid);
		channelMessage.CreationDate = DateTime.Now;
		channelMessage.FullMessage = SR.T("Процедура пересчёта прав доступа, наследуемых от \"" + folderName + "\", завершена.");
		channelMessage.Save();
	}
}
