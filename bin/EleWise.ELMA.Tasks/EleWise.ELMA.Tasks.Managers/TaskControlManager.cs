using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Impl;
using NHibernate.Type;

namespace EleWise.ELMA.Tasks.Managers;

[Component]
public sealed class TaskControlManager : EntityManagerBehavior
{
	private readonly string union = Environment.NewLine + "UNION ALL" + Environment.NewLine;

	private static Guid taskBaseTypeUid = InterfaceActivator.UID<ITaskBase>();

	private static TaskControlManager manager;

	private TaskBaseManager taskBaseManager;

	private IMemoryCacheService memoryCacheService;

	private ICurrentControllersFilterService currentControllersFilterService;

	private ISessionProvider sessionProvider;

	private ITransformationProvider transformationProvider;

	private IEnumerable<ITaskControlCompleteExtension> taskControlCompleteExtensions;

	public static TaskControlManager Instance
	{
		get
		{
			if (manager == null)
			{
				manager = Locator.GetServiceNotNull<TaskControlManager>();
			}
			return manager;
		}
	}

	public TaskControlManager(IMemoryCacheService memoryCacheService, ICurrentControllersFilterService currentControllersFilterService, ISessionProvider sessionProvider, ITransformationProvider transformationProvider, TaskBaseManager taskBaseManager, IEnumerable<ITaskControlCompleteExtension> taskControlCompleteExtensions)
	{
		this.memoryCacheService = memoryCacheService;
		this.currentControllersFilterService = currentControllersFilterService;
		this.sessionProvider = sessionProvider;
		this.transformationProvider = transformationProvider;
		this.taskBaseManager = taskBaseManager;
		this.taskControlCompleteExtensions = taskControlCompleteExtensions;
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		if (!(filter is ITaskControlFilter taskControlFilter) || (!taskControlFilter.ControlStatus.HasValue && !taskControlFilter.ControlType.HasValue && !taskControlFilter.UnderControl.HasValue && taskControlFilter.ControlUser == null && (taskControlFilter.CurrentControllers == null || ((ICollection<IUser>)taskControlFilter.CurrentControllers).Count == 0)))
		{
			return;
		}
		ICollection<ClassMetadata> baseControlClassMetadata = GetBaseControlClassMetadata();
		if (baseControlClassMetadata.Count == 0)
		{
			return;
		}
		ISession session = sessionProvider.GetSession("");
		StringBuilder stringBuilder = new StringBuilder();
		SqlQueryBuilder sqlQueryBuilder = new SqlQueryBuilder(session);
		foreach (ClassMetadata item in baseControlClassMetadata)
		{
			string text = "tc_" + item.Name;
			Type entityType = ModelHelper.GetEntityType(item.Uid);
			ICriteria val = session.CreateCriteria(entityType, text);
			val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")) });
			SetFilter(val, taskControlFilter, item);
			string value = sqlQueryBuilder.AddPartQuery(val, text);
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Append(union);
			}
			stringBuilder.Append(value);
		}
		string queryString = stringBuilder.ToString();
		ISQLQuery val2 = sqlQueryBuilder.Build<ITaskBase>(queryString);
		AbstractQueryImpl val3 = (AbstractQueryImpl)val2;
		object[] array = val3.ValueArray();
		IType[] array2 = val3.TypeArray();
		criteria.Add((ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} in ({1})", transformationProvider.Dialect.QuoteIfNeeded("Id"), ((object)val2).ToString()), array, array2));
	}

	public ICollection<ClassMetadata> GetBaseControlClassMetadata()
	{
		return memoryCacheService.GetOrAdd("TaskControlManagerBehaviorCHildrens", () => MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where(delegate(ClassMetadata m)
		{
			if (m.BaseClassUid != taskBaseTypeUid)
			{
				return false;
			}
			Type entityType = ModelHelper.GetEntityType(m.Uid);
			return entityType != null && entityType.GetInterface(typeof(ITaskControlImplementation).FullName) != null;
		})
			.ToList());
	}

	public long GetCurrentControlCount(IUser user = null)
	{
		user = user ?? AuthenticationService.GetCurrentUser<IUser>();
		return GetCurrentControlCount(user, null);
	}

	public long GetCurrentControlCount(IUser user, List<Guid> types)
	{
		ITaskControlFilter taskControlFilter = InterfaceActivator.Create<ITaskControlFilter>();
		taskControlFilter.NotShowInLists = false;
		taskControlFilter.UnderControl = true;
		taskControlFilter.CurrentControllers.Add(user);
		taskControlFilter.ControlStatus = TaskControlStatus.Current;
		if (types != null)
		{
			taskControlFilter.TypeUids = types;
		}
		return taskBaseManager.Count(taskControlFilter);
	}

	public long GetExecutionControlCount(IUser user = null)
	{
		user = user ?? AuthenticationService.GetCurrentUser<IUser>();
		return GetExecutionControlCount(user, null);
	}

	public long GetExecutionControlCount(IUser user, List<Guid> types)
	{
		ITaskControlFilter taskControlFilter = InterfaceActivator.Create<ITaskControlFilter>();
		taskControlFilter.NotShowInLists = false;
		taskControlFilter.UnderControl = true;
		taskControlFilter.ControlUser = user;
		taskControlFilter.ControlType = TaskControlType.Execution;
		taskControlFilter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
		if (types != null)
		{
			taskControlFilter.TypeUids = types;
		}
		return taskBaseManager.Count(taskControlFilter);
	}

	public ITaskBase DoControlComplete(long taskId, ICommentActionModel actionModel = null)
	{
		string sql = string.Format("select tb.{0} from {1} where tb.{2} = {3}Id", transformationProvider.Dialect.QuoteIfNeeded("TypeUid"), transformationProvider.NoLockTableExpression("TaskBase", "tb"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.ParameterSeparator);
		Guid guid = transformationProvider.Dialect.GetGuid(transformationProvider.ExecuteScalar(sql, new Dictionary<string, object> { { "Id", taskId } }));
		Type type = ModelHelper.GetEntityType(guid);
		return taskControlCompleteExtensions.FirstOrDefault((ITaskControlCompleteExtension e) => e.Can(type))?.DoControlComplete(type, taskId, actionModel);
	}

	private void SetFilter(ICriteria criteria, ITaskControlFilter filter, ClassMetadata metadata)
	{
		if (filter.ControlStatus.HasValue)
		{
			switch (filter.ControlStatus.Value)
			{
			case TaskControlStatus.ExecutionAll:
				criteria.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)TaskBaseExtensions.ControlAllStatuses.Select((TaskBaseStatus s) => s.Value).ToList()));
				break;
			case TaskControlStatus.ExecutionActive:
				criteria.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)TaskBaseExtensions.ControlStatuses.Select((TaskBaseStatus s) => s.Value).ToList()));
				break;
			case TaskControlStatus.Current:
				criteria.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)TaskBaseExtensions.CurrentControlStatuses.Select((TaskBaseStatus s) => s.Value).ToList()));
				break;
			}
		}
		string currentControllersPropertyName = LinqUtils.NameOf((Expression<Func<ITaskControlFilter, object>>)((ITaskControlFilter m) => m.CurrentControllers));
		if (metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == currentControllersPropertyName) is EntityPropertyMetadata entityPropertyMetadata)
		{
			EntitySettings entitySettings = (EntitySettings)entityPropertyMetadata.Settings;
			currentControllersFilterService.SetupCurrentControllersFilter(criteria, filter.UnderControl, filter.ControlType, filter.ControlUser, (ISet<IUser>)(object)((filter.CurrentControllers != null) ? new HashSet<IUser>((IEnumerable<IUser>)filter.CurrentControllers) : null), metadata.Name, entityPropertyMetadata.RelationTableName, entitySettings.ParentColumnName, entitySettings.ChildColumnName);
		}
	}
}
