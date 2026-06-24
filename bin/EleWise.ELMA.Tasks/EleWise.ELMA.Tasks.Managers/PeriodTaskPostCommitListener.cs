using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

[Component(Order = 10000000)]
public class PeriodTaskPostCommitListener : IUnitOfWorkEventListener
{
	internal class UpdatePeriodTaskItem
	{
		public long TemplateId { get; set; }

		public bool ContinueLastPeriodTaskDate { get; set; }
	}

	internal const string UpdatePeriodTaskContextVarName = "PeriodTaskTemplate_UpdatePeriodTask";

	internal const string UpdatePeriodTaskCommitedContextVarName = "PeriodTaskTemplate_UpdatePeriodTask_Commited";

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public static void AddUpdatePeriodTask(ITask template, bool continueLastPeriodTaskDate)
	{
		ContextVars.GetOrAdd("PeriodTaskTemplate_UpdatePeriodTask", () => new List<UpdatePeriodTaskItem>()).Add(new UpdatePeriodTaskItem
		{
			TemplateId = template.Id,
			ContinueLastPeriodTaskDate = continueLastPeriodTaskDate
		});
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		ContextVars.Set("PeriodTaskTemplate_UpdatePeriodTask_Commited", value: true);
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
		if (!ContextVars.TryGetValue<List<UpdatePeriodTaskItem>>("PeriodTaskTemplate_UpdatePeriodTask", out var value) || !(ContextVars.TryGetValue<bool>("PeriodTaskTemplate_UpdatePeriodTask_Commited", out var value2) && value2))
		{
			return;
		}
		ContextVars.Set<List<UpdatePeriodTaskItem>>("PeriodTaskTemplate_UpdatePeriodTask", null);
		if (value == null)
		{
			return;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		foreach (UpdatePeriodTaskItem item2 in value)
		{
			UpdatePeriodTaskItem item = item2;
			serviceNotNull.RunWithElevatedPrivilegies(delegate
			{
				TaskManager.Instance.UpdatePeriodTask(TaskManager.Instance.Load(item.TemplateId), item.ContinueLastPeriodTaskDate);
			});
		}
	}
}
