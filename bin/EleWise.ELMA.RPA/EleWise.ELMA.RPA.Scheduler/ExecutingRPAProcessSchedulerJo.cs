using System;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.RPA.DTO.Managers;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Models;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.RPA.Scheduler;

[Component]
internal sealed class ExecutingRPAProcessSchedulerJobExecutor : ISchedulerTaskJobExecutor
{
	private readonly IRPAProcessDTOManager rpaProcessDTOManager;

	private readonly IWorkflowRuntimeService workflowRuntimeService;

	public ExecutingRPAProcessSchedulerJobExecutor(IRPAProcessDTOManager rpaProcessDTOManager, IWorkflowRuntimeService workflowRuntimeService)
	{
		this.rpaProcessDTOManager = rpaProcessDTOManager;
		this.workflowRuntimeService = workflowRuntimeService;
	}

	public bool CanExecute(ISchedulerTaskJob job)
	{
		return job is IExecutingRPAProcessSchedulerJob;
	}

	public JobResult Do(ISchedulerTaskJob job, DateTime dateToRun)
	{
		if (!(job is IExecutingRPAProcessSchedulerJob executingRPAProcessSchedulerJob))
		{
			return null;
		}
		TaskDTO taskStatus = rpaProcessDTOManager.GetTaskStatus((int)executingRPAProcessSchedulerJob.RPATaskId);
		if (taskStatus.Status == TaskStatus.DONE || taskStatus.Status == TaskStatus.ERROR)
		{
			ExecutingRPAProcessData executingRPAProcessData = new ExecutingRPAProcessData(executingRPAProcessSchedulerJob.WorkflowBookmark);
			executingRPAProcessData.SchedulerTaskUid = executingRPAProcessSchedulerJob.SchedulerTaskUid;
			executingRPAProcessData.Task = taskStatus;
			workflowRuntimeService.Execute(executingRPAProcessData);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(SR.T("Проверка статуса завершена")).Append(SR.T("Идентификатор задачи: ")).AppendLine(taskStatus.Id.ToString())
			.Append(SR.T("Статус задачи: "))
			.AppendLine(taskStatus.Status.ToString())
			.AppendLine(SR.T("Лог:"))
			.Append(taskStatus.Log);
		return new JobResult
		{
			Information = stringBuilder.ToString(),
			Status = JobStatus.Success
		};
	}
}
