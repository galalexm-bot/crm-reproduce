using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.FeatureFlags.Components;
using EleWise.ELMA.Workflow.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Workflow.UIBuilder.Components;

[Component]
internal sealed class WorkflowModuleRuntimeVersionChecker : IUIRuntimeVersionChecker
{
	private readonly ISessionProvider sessionProvider;

	private RuntimeVersion? result;

	private ISession session;

	private ISession Session => session ?? (session = sessionProvider.GetSession(""));

	public WorkflowModuleRuntimeVersionChecker(ISessionProvider sessionProvider)
	{
		this.sessionProvider = sessionProvider;
	}

	public RuntimeVersion CheckRuntimeVersion()
	{
		if (result.HasValue)
		{
			return result.Value;
		}
		long num = Convert.ToInt64(Session.CreateCriteria<IWorkflowProcess>().Add((ICriterion)(object)Restrictions.IsNotNull("ClientScriptModule")).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count((IProjection)(object)Projections.Id()) })
			.UniqueResult());
		RuntimeVersion? runtimeVersion = (result = ((num > 0) ? RuntimeVersion.Version2 : RuntimeVersion.Version1));
		return runtimeVersion.Value;
	}
}
