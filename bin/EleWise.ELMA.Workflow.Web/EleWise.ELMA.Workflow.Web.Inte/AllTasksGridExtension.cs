namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

public class AllTasksGridExtension : TasksGridExtensionBase
{
	public override bool MatchUniqueName(string uniqueName)
	{
		return uniqueName == "AllTasks";
	}
}
