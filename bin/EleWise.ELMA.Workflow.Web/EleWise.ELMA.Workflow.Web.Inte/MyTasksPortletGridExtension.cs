using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

public class MyTasksPortletGridExtension : TasksGridExtensionBase
{
	public override bool MatchUniqueName(string uniqueName)
	{
		return uniqueName == "MyTasksPortletGrid";
	}

	protected override bool SaveCustomColumnToState(GridState state, ColumnState columnState)
	{
		return false;
	}
}
