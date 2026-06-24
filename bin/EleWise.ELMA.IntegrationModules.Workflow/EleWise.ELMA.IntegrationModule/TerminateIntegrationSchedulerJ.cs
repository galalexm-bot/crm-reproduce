using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.IntegrationModules.Workflow.Scheduling;

[Component]
internal sealed class TerminateIntegrationSchedulerJobExecutor : WorkflowInstanceSchedulerJobExecutor<IIntegrationModuleSchedulerTaskJob>
{
	protected override bool NoSaveResult => true;

	protected override IWorkflowBookmark GetBookmark(IIntegrationModuleSchedulerTaskJob job)
	{
		Contract.ArgumentNotNull(job, "job");
		if (job.IntegrationModuleBookmark == null)
		{
			return null;
		}
		return job.IntegrationModuleBookmark.WorkflowBookmark;
	}

	protected override IWorkflowExecuteData CreateData(IIntegrationModuleSchedulerTaskJob job, IWorkflowBookmark bookmark, DateTime dateToRun)
	{
		Contract.ArgumentNotNull(job, "job");
		Contract.ArgumentNotNull(job.IntegrationModuleBookmark, "IntegrationModuleBookmark");
		return new IntegrationExecuteData(job.IntegrationModuleBookmark.WorkflowBookmark, job.IntegrationConnectorUid.Value, job.IntegrationModuleBookmark);
	}

	protected override void SetupFindActiveJobsCriteria(IWorkflowInstance instance, ICriteria criteria)
	{
		ICriteria obj = criteria.CreateAlias("IntegrationModuleBookmark", "ib").CreateAlias("ib.WorkflowBookmark", "wb");
		object[] array = new IWorkflowInstance[1] { instance };
		obj.Add((ICriterion)(object)Restrictions.In("wb.Instance", array));
	}

	protected override void DeleteJob(IIntegrationModuleSchedulerTaskJob job)
	{
		Contract.ArgumentNotNull(job, "job");
		if (job.IntegrationModuleBookmark != null)
		{
			job.IntegrationModuleBookmark.Delete();
		}
		base.DeleteJob(job);
	}

	protected override string GetSuccessMessage()
	{
		return SR.T("Операция ожидания сообщения прервана");
	}
}
