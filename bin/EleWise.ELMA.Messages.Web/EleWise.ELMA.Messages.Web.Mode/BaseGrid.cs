using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Messages.Web.Models;

public class BaseGrid<T, TF> : BaseGridViewModel<T, TF> where TF : IEntityFilter
{
	public MessagesExpandedState MessagesState { get; set; }

	public bool CheckBoxGrid { get; set; }

	public bool CompactView { get; set; }
}
