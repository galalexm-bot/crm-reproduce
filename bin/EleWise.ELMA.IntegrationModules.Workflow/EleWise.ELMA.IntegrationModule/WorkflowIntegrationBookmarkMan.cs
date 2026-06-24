using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.IntegrationModules.Workflow;

public class WorkflowIntegrationBookmarkManager : EntityManager<IWorkflowIntegrationBookmark, long>
{
	private static readonly string F_Id = "Id";

	private static readonly string F_WIB_Bookmark = "WorkflowBookmark";

	private static readonly string F_WIB_Integration = "Integration";

	private static readonly string F_IM_CreationDate = "CreationDate";

	private static readonly string F_IM_Status = "Status";

	private static readonly string F_IM_Activity = "Activity";

	private static readonly string F_IMA_ActivityName = "Name";

	private static readonly string F_Bookmark_Instance = "Instance";

	private static readonly string F_Bookmark_ElementUid = "ElementUid";

	private static readonly string F_WIABI_Instance = "Instance";

	private static readonly string F_WIABI_CreationDate = "CreationDate";

	private static readonly string F_WIABI_ElementUid = "ElementUid";

	private static readonly string F_WIABI_ActivityName = "ActivityName";

	private static readonly string F_WIABI_Status = "Status";

	public SessionFactoryHolder SessionFactoryHolder { get; set; }

	public WorkflowInstanceManager WorkflowInstanceManager { get; set; }

	public IWorkflowIntegrationBookmark GetIntegrationBookmark(IntegrationModuleElement element, IWorkflowInstance instance)
	{
		IWorkflowIntegrationBookmarkFilter workflowIntegrationBookmarkFilter = InterfaceActivator.Create<IWorkflowIntegrationBookmarkFilter>();
		workflowIntegrationBookmarkFilter.WorkflowInstanceId = instance.Id;
		workflowIntegrationBookmarkFilter.ElementUid = element.Uid;
		return Find(workflowIntegrationBookmarkFilter, FetchOptions.First).FirstOrDefault();
	}

	public void SaveInSeparateSession(long workflowInstanceId, Guid elementUid, IIntegrationModule module, IWorkflowIntegrationBookmark bookmark)
	{
		new StatelessSessionHelper(SessionFactoryHolder).ExecuteOnSeparateTransaction(delegate(IStatelessSession session)
		{
			SaveInNewSession(session, workflowInstanceId, elementUid, module, bookmark);
		});
	}

	public IEnumerable<IWorkflowIntegrationBookmark> GetBookmarkByActivityKey(Guid key)
	{
		ICriteria obj = CreateCriteria();
		obj.CreateAlias("Integration", "integration");
		obj.CreateAlias("integration.Activity", "activity");
		obj.Add((ICriterion)(object)Restrictions.Eq("activity.Actyivitykey", (object)key));
		return obj.List<IWorkflowIntegrationBookmark>();
	}

	public IEnumerable<WorkflowIntegrationActivityBookmarkInfo> GetActiveIntegrationActivityBookmarkInfos(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances = false)
	{
		Contract.ArgumentNotNull(instanceList, "instanceList");
		ICriteria val = CreateCriteria().CreateAlias(F_WIB_Bookmark, "bm", (JoinType)0).CreateAlias(F_WIB_Integration, "im", (JoinType)0).CreateAlias("im." + F_IM_Activity, "act");
		if (!allowSubInstances)
		{
			val.Add((ICriterion)(object)Restrictions.In("bm." + F_Bookmark_Instance, (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val2 = WorkflowInstanceManager.CreateChildInstancesCriterion(instanceList, startFromRoot: false, "ins.Id");
			val.Add(val2);
		}
		return val.SetProjection((IProjection[])(object)new IProjection[6]
		{
			Projections.Alias((IProjection)(object)Projections.Property(F_Id), F_Id),
			Projections.Alias((IProjection)(object)Projections.Property("bm." + F_Bookmark_Instance), F_WIABI_Instance),
			Projections.Alias((IProjection)(object)Projections.Property("bm." + F_WIABI_ElementUid), F_Bookmark_ElementUid),
			Projections.Alias((IProjection)(object)Projections.Property("im." + F_IM_CreationDate), F_WIABI_CreationDate),
			Projections.Alias((IProjection)(object)Projections.Property("im." + F_IM_Status), F_WIABI_Status),
			Projections.Alias((IProjection)(object)Projections.Property("act." + F_IMA_ActivityName), F_WIABI_ActivityName)
		}).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(WorkflowIntegrationActivityBookmarkInfo))).List<WorkflowIntegrationActivityBookmarkInfo>();
	}

	private void SaveInNewSession(IStatelessSession session, long workflowInstanceId, Guid elementUid, IIntegrationModule module, IWorkflowIntegrationBookmark bookmark)
	{
		if (bookmark == null)
		{
			bookmark = InterfaceActivator.Create<IWorkflowIntegrationBookmark>();
			bookmark.ElementUid = elementUid;
			bookmark.WorkflowInstanceId = workflowInstanceId;
		}
		else
		{
			bookmark = new CloneHelperBuilder<IWorkflowIntegrationBookmark>(Load(bookmark.Uid)).Restrictions(delegate(RestrictionsBuilder<IWorkflowIntegrationBookmark> a)
			{
				a.Rule().ForPropertyName((IWorkflowIntegrationBookmark b) => b.Id).Ignore();
				a.Rule().ForPropertyName((IWorkflowIntegrationBookmark b) => b.Uid).Ignore();
			}).Clone(bookmark);
		}
		IIntegrationModule integrationModule;
		if (module.IsNew())
		{
			integrationModule = module;
			if (integrationModule.Activity.IsNew())
			{
				session.Insert((object)integrationModule.Activity);
			}
			else
			{
				session.Update((object)integrationModule.Activity);
			}
			session.Insert((object)integrationModule);
		}
		else
		{
			integrationModule = AbstractNHEntityManager<IIntegrationModule, long>.Instance.LoadOrNull(module.Id);
			if (integrationModule == null)
			{
				throw new Exception();
			}
			integrationModule = new CloneHelperBuilder<IIntegrationModule>(module).Restrictions(delegate(RestrictionsBuilder<IIntegrationModule> a)
			{
				a.Rule().ForPropertyName((IIntegrationModule b) => b.Id).Ignore();
				a.Rule().ForPropertyName((IIntegrationModule b) => b.Uid).Ignore();
			}).Clone(integrationModule);
			if (integrationModule.Activity.IsNew())
			{
				session.Insert((object)integrationModule.Activity);
			}
			else
			{
				session.Update((object)integrationModule.Activity);
			}
			session.Update((object)integrationModule);
		}
		bookmark.Integration = integrationModule;
		if (bookmark.IsNew())
		{
			session.Insert((object)bookmark);
		}
		else
		{
			session.Update((object)bookmark);
		}
	}
}
