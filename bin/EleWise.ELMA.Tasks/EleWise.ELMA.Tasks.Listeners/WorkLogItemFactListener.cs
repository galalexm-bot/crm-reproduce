using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
public class WorkLogItemFactListener : PostFlushEventListener, IUnitOfWorkEventListener
{
	private class FactWorkLogDelta
	{
		private List<IUpdateFactWorkLogExtension> extensions;

		public long ObjectId { get; private set; }

		public Guid ObjectTypeUid { get; private set; }

		public long Delta { get; set; }

		public List<IUpdateFactWorkLogExtension> GetExtensions
		{
			get
			{
				if (extensions == null)
				{
					extensions = (from e in ComponentManager.Current.GetExtensionPoints<IUpdateFactWorkLogExtension>()
						where e.Can(ObjectTypeUid)
						select e).ToList();
				}
				return extensions;
			}
		}

		public FactWorkLogDelta(long objectId, Guid objectTypeUid, long delta)
		{
			ObjectId = objectId;
			ObjectTypeUid = objectTypeUid;
			Delta = delta;
		}
	}

	internal const string KeyCache = "EleWise.ELMA.Tasks.Listeners.WorkLogItemFactListener";

	public override void OnPostInsert(PostInsertEvent @event)
	{
		base.OnPostInsert(@event);
		CalculateAndUpdateFactWorkLog(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkLogItem, ((AbstractPostDatabaseOperationEvent)@event).get_Persister(), null, @event.get_State());
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		base.OnPostUpdate(@event);
		CalculateAndUpdateFactWorkLog(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkLogItem, ((AbstractPostDatabaseOperationEvent)@event).get_Persister(), @event.get_OldState(), @event.get_State());
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		base.OnPostDelete(@event);
		CalculateAndUpdateFactWorkLog(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkLogItem, ((AbstractPostDatabaseOperationEvent)@event).get_Persister(), @event.get_DeletedState(), null);
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
		UpdateFactWorkLog();
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
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

	private static void CalculateAndUpdateFactWorkLog(IWorkLogItem workLogItem, IEntityPersister persister, object[] oldState, object[] newState)
	{
		if (workLogItem != null)
		{
			CalculateFactWorkLog(persister.get_PropertyNames(), oldState, newState);
		}
	}

	private static void CalculateFactWorkLog(string[] propertyNames, object[] oldState, object[] newState)
	{
		if (oldState == null && newState == null)
		{
			return;
		}
		int num = Array.IndexOf(propertyNames, LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem oi) => oi.IsDeleted)));
		int num2 = Array.IndexOf(propertyNames, LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem oi) => oi.ApprovalWorkTime)));
		int num3 = Array.IndexOf(propertyNames, LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem oi) => oi.ObjectId)));
		int num4 = Array.IndexOf(propertyNames, LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem oi) => oi.ObjectUID)));
		int num5 = Array.IndexOf(propertyNames, LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem oi) => oi.Status)));
		if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0)
		{
			return;
		}
		if (oldState != null && newState != null && (bool)oldState[num] != (bool)newState[num])
		{
			if ((bool)oldState[num])
			{
				oldState = null;
			}
			else
			{
				newState = null;
			}
		}
		bool flag = oldState != null && (WorkLogItemStatus)oldState[num5] == WorkLogItemStatus.Confirm;
		bool flag2 = newState != null && (WorkLogItemStatus)newState[num5] == WorkLogItemStatus.Confirm;
		if (!flag && !flag2)
		{
			return;
		}
		WorkTime? workTime = ((oldState != null) ? (oldState[num2] as WorkTime?) : null);
		WorkTime? workTime2 = ((newState != null) ? (newState[num2] as WorkTime?) : null);
		long num6 = (workTime.HasValue ? workTime.Value.Value : 0);
		long num7 = (workTime2.HasValue ? workTime2.Value.Value : 0);
		long num8;
		long num9;
		Guid guid;
		if (newState == null)
		{
			num8 = -num6;
			num9 = (long)oldState[num3];
			guid = (Guid)oldState[num4];
		}
		else if (oldState == null)
		{
			num8 = num7;
			num9 = (long)newState[num3];
			guid = (Guid)newState[num4];
		}
		else
		{
			num9 = (long)newState[num3];
			guid = (Guid)newState[num4];
			if (num9 != (long)oldState[num3] || guid != (Guid)oldState[num4])
			{
				CalculateFactWorkLog(propertyNames, oldState, null);
				CalculateFactWorkLog(propertyNames, null, newState);
				return;
			}
			num8 = ((!flag) ? num7 : (flag2 ? (num7 - num6) : (-num6)));
		}
		if (num8 != 0L && num9 != 0L && !(guid == Guid.Empty))
		{
			if (!ContextVars.TryGetValue<Dictionary<string, FactWorkLogDelta>>("EleWise.ELMA.Tasks.Listeners.WorkLogItemFactListener", out var value))
			{
				value = new Dictionary<string, FactWorkLogDelta>();
			}
			string key = $"{num9}_{guid}";
			if (value.ContainsKey(key))
			{
				value[key].Delta += num8;
			}
			else
			{
				value.Add(key, new FactWorkLogDelta(num9, guid, num8));
			}
			ContextVars.Set("EleWise.ELMA.Tasks.Listeners.WorkLogItemFactListener", value);
		}
	}

	private static void UpdateFactWorkLog()
	{
		if (!ContextVars.TryGetValue<Dictionary<string, FactWorkLogDelta>>("EleWise.ELMA.Tasks.Listeners.WorkLogItemFactListener", out var value))
		{
			return;
		}
		try
		{
			if (value == null || value.Count <= 0)
			{
				return;
			}
			foreach (FactWorkLogDelta item in value.Values.Where((FactWorkLogDelta m) => m.Delta != 0))
			{
				foreach (IUpdateFactWorkLogExtension getExtension in item.GetExtensions)
				{
					try
					{
						getExtension.UpdateFactWorkLog(item.ObjectId, item.ObjectTypeUid, item.Delta);
					}
					catch (Exception ex)
					{
						string message = SR.T("Не удалось обновить фактические трудозатраты для объекта (Id={0}, TypeUid={1})", item.ObjectId, item.ObjectTypeUid);
						Logger.Log.Error(message, ex);
						throw new Exception(message, ex);
					}
				}
			}
		}
		catch (Exception innerException)
		{
			throw new TransactionRollbackException(SR.T("Ошибка при обновлении фактических трудозатрат"), innerException);
		}
		finally
		{
			ContextVars.Remove("EleWise.ELMA.Tasks.Listeners.WorkLogItemFactListener");
		}
	}
}
