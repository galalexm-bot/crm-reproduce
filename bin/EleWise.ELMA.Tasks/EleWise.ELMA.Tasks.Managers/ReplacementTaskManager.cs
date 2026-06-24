using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ReplacementTaskManager : TaskBaseManager<IReplacementTask>
{
	private static readonly ConcurrentDictionary<int, EntityActionsMetadata> LoadedDefaultActions = new ConcurrentDictionary<int, EntityActionsMetadata>();

	[NotNull]
	public IProductionCalendarService ProductionCalendar { get; set; }

	[NotNull]
	public new static ReplacementTaskManager Instance => Locator.GetServiceNotNull<ReplacementTaskManager>();

	private bool HasActiveTasksByUser(EleWise.ELMA.Security.Models.IUser user)
	{
		ITaskBaseFilter taskBaseFilter = CreateActiveTasksFilter();
		taskBaseFilter.Statuses = TaskBaseExtensions.ActiveTaskStatuses.ToList();
		taskBaseFilter.Executor = user;
		return TaskBaseManager.Instance.Exists(taskBaseFilter);
	}

	public override bool? IsAvailableCopy(ITaskBase task)
	{
		return true;
	}

	internal void SendNotifications(string eventName, Dictionary<string, object> extendedProperties)
	{
		if (string.IsNullOrEmpty(eventName))
		{
			return;
		}
		AuditEventArgs auditEventArgs = new AuditEventArgs();
		if (extendedProperties != null)
		{
			foreach (string key in extendedProperties.Keys)
			{
				auditEventArgs.ExtendedProperties[key] = extendedProperties[key];
			}
		}
		auditEventArgs.Action = EntityAuditAction();
		auditEventArgs.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IReplacementTask>());
		Locator.GetServiceNotNull<IAuditEventProvider>().Notify(eventName, auditEventArgs);
	}

	private static EntityAuditAction EntityAuditAction()
	{
		EntityActionsMetadata entityActionsMetadata = new EntityActionsMetadata();
		entityActionsMetadata.LoadFromType(typeof(ReplacementTaskActions));
		EnumValueMetadata enumValueMetadata = entityActionsMetadata.Values.FirstOrDefault((EnumValueMetadata a) => a.Uid == ReplacementTaskActions.ReplacementGuid);
		return new EntityAuditAction(enumValueMetadata.Uid, enumValueMetadata.Name, (EntityAuditAction a) => GetDefaultLocalizedMetadata(a.Uid), enumValueMetadata.DefaultImage);
	}

	private static EnumValueMetadata GetDefaultLocalizedMetadata(Guid valueUid)
	{
		int key = ((CultureInfo.CurrentCulture != null) ? CultureInfo.CurrentCulture.LCID : 0);
		if (!LoadedDefaultActions.TryGetValue(key, out var value))
		{
			value = new EntityActionsMetadata();
			value.LoadFromType(typeof(DefaultEntityActions));
			LoadedDefaultActions[key] = value;
		}
		return value.Values.FirstOrDefault((EnumValueMetadata v) => v.Uid == valueUid);
	}

	[Transaction]
	public virtual void CreateFromReplacement(IReplacementExtension replacement)
	{
		if (FindByReplacament(replacement) == null)
		{
			DateTime now = DateTime.Now;
			Pair<DateTime, DateTime> pair = CreateDate(replacement);
			IReplacementTask replacementTask = Create();
			replacementTask.CreationAuthor = ((EleWise.ELMA.Security.Models.IUser)base.AuthenticationService.GetCurrentUser()) ?? base.UserManager.Load(SecurityConstants.SystemUserUid);
			replacementTask.Subject = SR.T("Переназначить задачи ({0})", replacement.SourceUser);
			replacementTask.Replacement = replacement;
			replacementTask.NotShowInLists = true;
			replacementTask.Status = TaskBaseStatus.Prepared;
			replacementTask.Executor = (replacement.ReAssignActiveTasks ? replacement.TasksDistributer : replacement.SourceUser);
			replacementTask.StartDate = pair.First;
			replacementTask.EndDate = pair.Second;
			replacementTask.Save();
			ActivateTask(replacementTask, now);
		}
	}

	[Transaction]
	protected internal virtual void ActivateTasks(DateTime date)
	{
		IReplacementTaskFilter replacementTaskFilter = InterfaceActivator.Create<IReplacementTaskFilter>();
		replacementTaskFilter.NotShowInLists = true;
		replacementTaskFilter.Status = TaskBaseStatus.Prepared;
		replacementTaskFilter.StartDate = new DateTimeRange(null, date.Date.AddDays(1.0).AddSeconds(-1.0));
		foreach (IReplacementTask item in Find(replacementTaskFilter, FetchOptions.All))
		{
			ActivateTask(item, date);
		}
	}

	internal void ActivateTask(IReplacementTask task, DateTime date)
	{
		date = date.Date.AddDays(1.0).AddSeconds(-1.0);
		if (CheckActivateTask(task, date))
		{
			task.NotShowInLists = false;
			task.CreationDate = DateTime.Now;
			task.Status = TaskBaseStatus.NewOrder;
			task.Save();
			base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, task, "5e7c9eb0-2f5a-4f59-b39d-053d054a1880"));
		}
	}

	private static bool CheckActivateTask(IReplacementTask task, DateTime date)
	{
		if (task == null || !task.NotShowInLists || task.Status != TaskBaseStatus.Prepared || (task.StartDate.HasValue && task.StartDate.Value > date) || !Instance.HasActiveTasksByUser(task.Replacement.SourceUser))
		{
			return false;
		}
		return true;
	}

	[ActionMethod("00bbefa0-fc95-47e9-9076-0c438e45b633")]
	[Transaction]
	public virtual IReplacementTask Close(long taskId, bool alert, ICommentActionModel actionModel = null)
	{
		IReplacementTask replacementTask = LoadOrNull(taskId);
		if (replacementTask != null && CanClose(taskId, alert, actionModel))
		{
			ApplyCommentActionModel(replacementTask, actionModel);
			replacementTask.Status = TaskBaseStatus.WasClosed;
			Save(replacementTask);
			RaiseCommentActionEvent(null, replacementTask, "00bbefa0-fc95-47e9-9076-0c438e45b633", actionModel, alert);
		}
		return replacementTask;
	}

	[ActionCheck("00bbefa0-fc95-47e9-9076-0c438e45b633")]
	public virtual bool CanClose(long taskId, bool alert, ICommentActionModel actionModel = null)
	{
		if (ContextVars.TryGetValue<bool>("DisableActionCheck", out var value) && value)
		{
			return true;
		}
		IReplacementTask replacementTask = LoadOrNull(taskId);
		if (replacementTask != null)
		{
			return base.TaskWorkflowActions.IsAvailableClose(replacementTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	public virtual void CloseFromReplacement(IReplacement replacement)
	{
		if (replacement == null)
		{
			return;
		}
		IReplacementTask task = FindByReplacament(replacement);
		if (task == null)
		{
			return;
		}
		base.SecurityService.RunBySystemUser(delegate
		{
			if (task.NotShowInLists)
			{
				task.Status = TaskBaseStatus.WasClosed;
			}
			else if (base.TaskWorkflowActions.IsAvailableClose(task, task.CreationAuthor))
			{
				Close(task.Id, alert: true);
			}
			task.Save();
		});
	}

	[Transaction]
	[ActionMethod("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8")]
	public virtual IReplacementTask DoCompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		IReplacementTask task = LoadOrNull(taskId);
		if (task != null && CanDoCompleted(taskId, alertCoexecuters, actionModel))
		{
			List<IReplacementTaskExtension> source = ComponentManager.Current.GetExtensionPoints<IReplacementTaskExtension>().ToList();
			List<IReplacementTaskRemapObjectsFilterExtension> propertyExtensions = (from e in ComponentManager.Current.GetExtensionPoints<IReplacementTaskRemapObjectsFilterExtension>()
				where e.CanUseForReplacementTaskType(task)
				select e).ToList();
			List<ReplacementTaskNotificationItem> sourceUserObjects = new List<ReplacementTaskNotificationItem>();
			Dictionary<long, Pair<EleWise.ELMA.Security.Models.IUser, List<ReplacementTaskNotificationItem>>> replacementUserObjects = new Dictionary<long, Pair<EleWise.ELMA.Security.Models.IUser, List<ReplacementTaskNotificationItem>>>();
			IEnumerable<IReplacementTaskDoCompletedAction> doCompletedExtensions = ComponentManager.Current.GetExtensionPoints<IReplacementTaskDoCompletedAction>();
			(from e in source.SelectMany((IReplacementTaskExtension e) => e.ObjectsList(taskId))
				select e.CastAsRealType() into e
				group e by e.GetType()).Each(delegate(IGrouping<Type, IEntity> g)
			{
				Type key = g.Key;
				List<KeyValuePair<PropertyMetadata, ClassMetadata>> properties = ReplacementTaskFilter.GetProperties(key).ToList();
				g.Each(delegate(IEntity entity)
				{
					ReplacementTaskNotificationItem replacementTaskNotificationItem = new ReplacementTaskNotificationItem(entity);
					sourceUserObjects.Add(replacementTaskNotificationItem);
					IEntity entity2 = CloneHelperBuilder.Create(entity).Restrictions(delegate(RestrictionsBuilder<IEntity> r)
					{
						r.Rule().CloneRecursive(cloneRecursive: false);
					}).Clone();
					List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
					EleWise.ELMA.Security.Models.IUser user = null;
					foreach (KeyValuePair<PropertyMetadata, ClassMetadata> item in properties)
					{
						PropertyMetadata propertyMetadata = item.Key;
						Guid uid = propertyMetadata.Uid;
						EleWise.ELMA.Security.Models.IUser user2 = (EleWise.ELMA.Security.Models.IUser)entity.GetPropertyValue(uid);
						if (user2 != null && task.GetReplacementUser().Id == user2.Id && !propertyExtensions.Any((IReplacementTaskRemapObjectsFilterExtension e) => e.IsPropertyReadOnly(task.GetReplacementObject(), propertyMetadata, entity)))
						{
							EleWise.ELMA.Security.Models.IUser selectUser = task.GetAssignment(new ReferenceOnEntity
							{
								Object = entity
							}, uid);
							if (selectUser.Id != user2.Id)
							{
								list.Add(selectUser);
								user = user2;
								if (!propertyExtensions.Any((IReplacementTaskRemapObjectsFilterExtension p) => p.ReplaceProperty(entity, propertyMetadata, selectUser)))
								{
									entity.SetPropertyValue(uid, selectUser);
								}
								EntityUserSettings entityUserSettings = entity.GetPropertySettings(uid) as EntityUserSettings;
								entity.SetPropertyValue(entityUserSettings.ReplacedUserPropertyUid, user2);
								if (!replacementUserObjects.ContainsKey(selectUser.Id))
								{
									replacementUserObjects.Add(selectUser.Id, new Pair<EleWise.ELMA.Security.Models.IUser, List<ReplacementTaskNotificationItem>>(selectUser, new List<ReplacementTaskNotificationItem>()));
								}
								long entityId = Convert.ToInt64(entity.GetId());
								ReplacementTaskNotificationItem replacementTaskNotificationItem2 = replacementUserObjects[selectUser.Id].Second.FirstOrDefault((ReplacementTaskNotificationItem m) => Convert.ToInt64(m.Entity.GetId()) == entityId);
								if (replacementTaskNotificationItem2 == null)
								{
									replacementTaskNotificationItem2 = new ReplacementTaskNotificationItem(entity);
									replacementUserObjects[selectUser.Id].Second.Add(replacementTaskNotificationItem2);
								}
								replacementTaskNotificationItem2.Properties.Add(new Pair<string, EleWise.ELMA.Security.Models.IUser>(propertyMetadata.DisplayName, selectUser));
								replacementTaskNotificationItem.Properties.Add(new Pair<string, EleWise.ELMA.Security.Models.IUser>(propertyMetadata.DisplayName, selectUser));
							}
						}
					}
					if (user != null)
					{
						entity.Save();
						ReplacementTaskActionEventArgs replacementTaskActionEventArgs = ReplacementTaskActionEventArgs.TryCreate(entity2, entity, taskId);
						if (replacementTaskActionEventArgs != null)
						{
							base.CommentActionHandler.ProcessEventArgs(replacementTaskActionEventArgs, actionModel);
						}
						base.ActionHandler.ActionExecuted(replacementTaskActionEventArgs);
						foreach (IReplacementTaskDoCompletedAction item2 in doCompletedExtensions)
						{
							item2.DoCompleted(task, user, list, entity);
						}
					}
				});
			});
			SendNotifications("EleWise.ELMA.Tasks.ReplacementTask.SourceUser", new Dictionary<string, object>
			{
				{ "Task", task },
				{ "ObjectList", sourceUserObjects }
			});
			foreach (long key2 in replacementUserObjects.Keys)
			{
				Pair<EleWise.ELMA.Security.Models.IUser, List<ReplacementTaskNotificationItem>> pair = replacementUserObjects[key2];
				SendNotifications("EleWise.ELMA.Tasks.ReplacementTask.ReplacementUser", new Dictionary<string, object>
				{
					{ "RecipientUser", pair.First },
					{ "Task", task },
					{ "ObjectList", pair.Second }
				});
			}
			ApplyCommentActionModel(task, actionModel);
			task.Status = TaskBaseStatus.Complete;
			Save(task);
			RaiseCommentActionEvent(null, task, "6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8", actionModel, alertCoexecuters);
		}
		return task;
	}

	[ActionCheck("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8")]
	public virtual bool CanDoCompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		IReplacementTask replacementTask = LoadOrNull(taskId);
		if (replacementTask == null)
		{
			return false;
		}
		return base.TaskWorkflowActions.IsAvailableCompleted(replacementTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	[Transaction]
	[ActionMethod("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual IReplacementTask DoIncompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		IReplacementTask replacementTask = LoadOrNull(taskId);
		if (replacementTask != null && CanDoIncompleted(taskId, alertCoexecuters, actionModel))
		{
			ApplyCommentActionModel(replacementTask, actionModel);
			replacementTask.Status = TaskBaseStatus.Incomplete;
			Save(replacementTask);
			RaiseCommentActionEvent(null, replacementTask, "9a8806b0-8e5a-4f46-868f-9a1604d4ebce", actionModel, alertCoexecuters);
		}
		return replacementTask;
	}

	[ActionCheck("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual bool CanDoIncompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		IReplacementTask replacementTask = LoadOrNull(taskId);
		if (replacementTask != null)
		{
			return base.TaskWorkflowActions.IsAvailableInCompleted(replacementTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	public IReplacementTask FindByReplacament(IReplacement replacement)
	{
		IReplacementTaskFilter replacementTaskFilter = InterfaceActivator.Create<IReplacementTaskFilter>();
		replacementTaskFilter.Replacement = replacement;
		replacementTaskFilter.Statuses = TaskBaseExtensions.ActiveTaskStatuses.ToList();
		FetchOptions fetchOptions = new FetchOptions(0, 1);
		return Find(replacementTaskFilter, fetchOptions).FirstOrDefault();
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(IReplacementTask task, EleWise.ELMA.Security.Models.IUser recipient, string description, bool showAll, IEnumerable<IAttachment> attachments = null)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		IQuestion question = InterfaceActivator.Create<IQuestion>();
		question.RefObject = new ReferenceOnEntity
		{
			Object = task
		};
		question.Subject = task.Subject;
		question.Executor = recipient;
		question.Description = description;
		question.ShowAll = showAll;
		question.Status = TaskBaseStatus.NewOrder;
		if (attachments != null)
		{
			IList<IAttachment> list = (attachments as IList<IAttachment>) ?? attachments.ToList();
			if (list != null && list.Any())
			{
				foreach (IAttachment item in list)
				{
					question.Attachments.Add(item);
				}
			}
		}
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(IReplacementTask task, EleWise.ELMA.Security.Models.IUser recipient, string description, bool showAll)
	{
		AddQuestion(task, recipient, description, showAll, null);
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(IReplacementTask task, IQuestion question)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		question.Subject = question.Subject ?? task.Subject;
		question.RefObject = new ReferenceOnEntity
		{
			Object = task
		};
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	internal static Pair<DateTime, DateTime> CreateDate(IReplacementExtension replacement)
	{
		DateTime first = replacement.StartDate.AddDays(-replacement.ReAssignStartDays).NormalizeStartDate(time: false);
		DateTime second = first.AddDays(replacement.ReAssignFinishDays).NormalizeEndDate(time: false);
		return new Pair<DateTime, DateTime>(first, second);
	}

	public IEnumerable<IReplacementTask> GetBlockUserTasksForUser(EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null)
		{
			return new List<IReplacementTask>();
		}
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IReplacementTask>());
		val.Add((ICriterion)(object)Restrictions.Eq("BlockedUser", (object)user));
		object[] array = TaskBaseExtensions.ActiveTaskStatuses.ToArray();
		val.Add((ICriterion)(object)Restrictions.In("Status", array));
		return Find(val);
	}

	public long GetCountBlockUserTasksForUser(EleWise.ELMA.Security.Models.IUser user)
	{
		ICriteria val = base.Session.CreateCriteria(typeof(IReplacementTask));
		val.Add((ICriterion)(object)Restrictions.Eq("BlockedUser", (object)user));
		object[] array = TaskBaseExtensions.ActiveTaskStatuses.ToArray();
		val.Add((ICriterion)(object)Restrictions.In("Status", array));
		val.SetProjection((IProjection[])(object)new IProjection[1] { Projections.RowCountInt64() });
		return val.UniqueResult<long>();
	}

	public virtual long ActiveTasksCount(long replacementTaskId)
	{
		return ActiveTasksAction(replacementTaskId, (ITaskBaseFilter filter) => TaskBaseManager.Instance.Count(filter), 0L);
	}

	public virtual List<ITaskBase> ActiveTasksList(long replacementTaskId, FetchOptions fetchOptions)
	{
		return ActiveTasksAction(replacementTaskId, (ITaskBaseFilter filter) => TaskBaseManager.Instance.Find(filter, fetchOptions).ToList(), new List<ITaskBase>(), fetchOptions.UseProjections);
	}

	private static T ActiveTasksAction<T>(long replacementTaskId, Func<ITaskBaseFilter, T> action, T defaultValue, bool useProjections = false)
	{
		if (action == null)
		{
			return defaultValue;
		}
		ReplacementTaskFilter.FilterActivate(replacementTaskId, useProjections);
		T result = action(CreateActiveTasksFilter());
		ReplacementTaskFilter.FilterDeactivate();
		return result;
	}

	private static ITaskBaseFilter CreateActiveTasksFilter()
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.DisableSecurity = true;
		return taskBaseFilter;
	}

	public virtual long PeriodicTaskTemplatesCount(long replacementTaskId)
	{
		return PeriodicTaskTemplatesAction(replacementTaskId, (ITaskFilter filter) => TaskManager.Instance.Count(filter), 0L);
	}

	public virtual List<ITask> PeriodicTaskTemplatesList(long replacementTaskId, FetchOptions fetchOptions)
	{
		return PeriodicTaskTemplatesAction(replacementTaskId, (ITaskFilter filter) => TaskManager.Instance.Find(filter, fetchOptions).ToList(), new List<ITask>(), fetchOptions.UseProjections);
	}

	private static T PeriodicTaskTemplatesAction<T>(long replacementTaskId, Func<ITaskFilter, T> action, T defaultValue, bool useProjections = false)
	{
		if (action == null)
		{
			return defaultValue;
		}
		return action(CreatePeriodicTaskTemplatesFilter(replacementTaskId));
	}

	private static ITaskFilter CreatePeriodicTaskTemplatesFilter(long replacementTaskId)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = true;
		taskFilter.Periodical = true;
		taskFilter.IsTemplate = true;
		taskFilter.DisableSecurity = true;
		taskFilter.Status = TaskBaseStatus.NewOrder;
		IReplacementTask replacementTask = Instance.LoadOrNull(replacementTaskId);
		if (replacementTask != null)
		{
			taskFilter.Executor = replacementTask.GetReplacementUser();
		}
		return taskFilter;
	}
}
