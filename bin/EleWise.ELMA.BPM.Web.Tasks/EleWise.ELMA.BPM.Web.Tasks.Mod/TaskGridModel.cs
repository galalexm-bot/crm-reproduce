using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskGridModel : GridData<ITaskBase, ITaskBaseFilter>
{
	public string CallbackFunction { get; set; }

	public string GridId { get; set; }

	public string UniqueName { get; set; }

	public bool EnableCustomize { get; set; }

	public bool CanExportToExcel { get; set; }

	public SearchTasksType SearchTasksType { get; set; }
}
