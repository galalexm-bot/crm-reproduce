using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class BaseGridViewModel<T, TF> : BaseGridViewModel where TF : IEntityFilter
{
	public GridData<T, TF> Data { get; set; }
}
public class BaseGridViewModel
{
	public string GridId { get; set; }
}
