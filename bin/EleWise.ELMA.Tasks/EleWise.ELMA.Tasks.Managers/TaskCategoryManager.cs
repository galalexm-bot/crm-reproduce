using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

public class TaskCategoryManager : EntityManager<ITaskCategory, long>
{
	public new static TaskCategoryManager Instance => Locator.GetServiceNotNull<TaskCategoryManager>();

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}
}
