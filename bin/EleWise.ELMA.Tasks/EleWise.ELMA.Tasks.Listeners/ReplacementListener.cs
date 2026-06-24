using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class ReplacementListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IReplacementExtension replacementExtension)
		{
			ReplacementUpdate(replacementExtension);
			if (replacementExtension.ReAssignActiveTasks)
			{
				ReplacementTaskManager.Instance.CreateFromReplacement(replacementExtension);
			}
		}
	}

	private static void ReplacementUpdate(IReplacementExtension replacement)
	{
		if (replacement != null && replacement.ReAssignActiveTasks)
		{
			if (replacement.TasksDistributer == null)
			{
				replacement.TasksDistributer = replacement.SourceUser;
			}
			if (replacement.ReAssignStartDays < 1)
			{
				replacement.ReAssignStartDays = 1L;
			}
			if (replacement.ReAssignFinishDays < 1)
			{
				replacement.ReAssignFinishDays = 1L;
			}
		}
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (!(((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IReplacementExtension replacement))
		{
			return base.OnPreDelete(@event);
		}
		bool num = base.OnPreDelete(@event);
		if (num)
		{
			ReplacementTaskManager.Instance.CloseFromReplacement(replacement);
		}
		return num;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IReplacementExtension replacementExtension)
		{
			ReplacementUpdate(replacementExtension);
			string value = LinqUtils.NameOf((Expression<Func<IReplacementExtension, object>>)((IReplacementExtension f) => f.ReAssignActiveTasks));
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value);
			bool? flag = (bool?)@event.get_State()[num];
			bool? flag2 = (bool?)@event.get_OldState()[num];
			string value2 = LinqUtils.NameOf((Expression<Func<IReplacement, object>>)((IReplacement f) => f.Status));
			int num2 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value2);
			ReplacementStatus? replacementStatus = (ReplacementStatus?)@event.get_State()[num2];
			ReplacementStatus? replacementStatus2 = (ReplacementStatus?)@event.get_OldState()[num2];
			if (flag != true || (replacementStatus != replacementStatus2 && replacementStatus == ReplacementStatus.Delete))
			{
				ReplacementTaskManager.Instance.CloseFromReplacement(replacementExtension);
			}
			else if (replacementExtension.Status == ReplacementStatus.Active && !ReplacementManager.Instance.CheckReplacementnData(replacementExtension))
			{
				if (flag != flag2)
				{
					ReplacementTaskManager.Instance.CreateFromReplacement(replacementExtension);
				}
				else
				{
					IReplacementTask task = ReplacementTaskManager.Instance.FindByReplacament(replacementExtension);
					if (task == null)
					{
						ReplacementTaskManager.Instance.CreateFromReplacement(replacementExtension);
					}
					else
					{
						Pair<DateTime, DateTime> date = ReplacementTaskManager.CreateDate(replacementExtension);
						ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
						string value3 = LinqUtils.NameOf((Expression<Func<IReplacementExtension, object>>)((IReplacementExtension f) => f.TasksDistributer));
						int num3 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value3);
						EleWise.ELMA.Security.Models.IUser newTasksDistributer = (EleWise.ELMA.Security.Models.IUser)@event.get_State()[num3];
						EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)@event.get_OldState()[num3];
						if (newTasksDistributer != null && user != null && newTasksDistributer.Id != user.Id)
						{
							serviceNotNull.RunWithElevatedPrivilegies(delegate
							{
								ReplacementTaskManager.Instance.ReAssign(task.Id, newTasksDistributer, date.First, date.Second);
							});
						}
						else
						{
							string value4 = LinqUtils.NameOf((Expression<Func<IReplacement, object>>)((IReplacement f) => f.StartDate));
							int num4 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value4);
							DateTime dateTime = (DateTime)@event.get_State()[num4];
							DateTime dateTime2 = (DateTime)@event.get_OldState()[num4];
							string value5 = LinqUtils.NameOf((Expression<Func<IReplacement, object>>)((IReplacement f) => f.EndDate));
							int num5 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value5);
							DateTime dateTime3 = (DateTime)@event.get_State()[num5];
							DateTime dateTime4 = (DateTime)@event.get_OldState()[num5];
							string value6 = LinqUtils.NameOf((Expression<Func<IReplacement, object>>)((IReplacement f) => f.PreReplace));
							int num6 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value6);
							long num7 = (long)@event.get_State()[num6];
							long num8 = (long)@event.get_OldState()[num6];
							string value7 = LinqUtils.NameOf((Expression<Func<IReplacementExtension, object>>)((IReplacementExtension f) => f.ReAssignStartDays));
							int num9 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value7);
							long num10 = (long)@event.get_State()[num9];
							long num11 = (long)@event.get_OldState()[num9];
							string value8 = LinqUtils.NameOf((Expression<Func<IReplacementExtension, object>>)((IReplacementExtension f) => f.ReAssignFinishDays));
							int num12 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), value8);
							long num13 = (long)@event.get_State()[num12];
							long num14 = (long)@event.get_OldState()[num12];
							if (dateTime != dateTime2 || dateTime3 != dateTime4 || num7 != num8 || num10 != num11 || num13 != num14)
							{
								serviceNotNull.RunWithElevatedPrivilegies(delegate
								{
									ReplacementTaskManager.Instance.ChangeDate(task.Id, date.First, date.Second);
								});
							}
						}
						ReplacementTaskManager.Instance.ActivateTask(task, DateTime.Now);
					}
				}
			}
		}
		return base.OnPreUpdate(@event);
	}
}
