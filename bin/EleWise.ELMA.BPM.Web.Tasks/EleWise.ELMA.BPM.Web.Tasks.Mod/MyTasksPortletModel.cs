using System.ComponentModel;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class MyTasksPortletModel : FromMeTasksBaseModel
{
	public IGridData<ITaskBase> Tasks { get; set; }

	public string DefaultSortExpression { get; set; }

	public ListSortDirection DefaultSortDirection { get; set; }
}
