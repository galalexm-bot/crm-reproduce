using System.Web.Mvc;
using Orchard.DisplayManagement;
using Orchard.Mvc.Filters;

namespace Orchard.UI.Resources;

public class ResourceFilter : FilterProvider, IResultFilter
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly dynamic _shapeFactory;

	public ResourceFilter(IWorkContextAccessor workContextAccessor, IShapeFactory shapeFactory)
	{
		_workContextAccessor = workContextAccessor;
		_shapeFactory = shapeFactory;
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (filterContext.get_Result() is ViewResult)
		{
			WorkContext context = _workContextAccessor.GetContext();
			dynamic val = context.Layout.Head;
			dynamic val2 = context.Layout.Tail;
			val.Add(_shapeFactory.Metas());
			val.Add(_shapeFactory.HeadLinks());
			val.Add(_shapeFactory.StylesheetLinks());
			val.Add(_shapeFactory.HeadScripts());
			val2.Add(_shapeFactory.FootScripts());
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
