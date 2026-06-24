using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.DisplayManagement.Implementation;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.DisplayManagement;

public class ShapeDisplay : IShapeDisplay, IDependency
{
	private class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }

		public ViewDataContainer()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			ViewData = new ViewDataDictionary();
		}
	}

	private readonly IDisplayHelperFactory _displayHelperFactory;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly HttpContextBase _httpContextBase;

	private readonly RequestContext _requestContext;

	public ShapeDisplay(IDisplayHelperFactory displayHelperFactory, IWorkContextAccessor workContextAccessor, HttpContextBase httpContextBase, RequestContext requestContext)
	{
		_displayHelperFactory = displayHelperFactory;
		_workContextAccessor = workContextAccessor;
		_httpContextBase = httpContextBase;
		_requestContext = requestContext;
	}

	public string Display(Shape shape)
	{
		return Display((object)shape);
	}

	public string Display(object shape)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		ViewContext val = new ViewContext();
		((ControllerContext)val).set_HttpContext(_httpContextBase);
		((ControllerContext)val).set_RequestContext(_requestContext);
		ViewContext val2 = val;
		((ControllerContext)val2).get_RouteData().DataTokens["IWorkContextAccessor"] = _workContextAccessor;
		dynamic val3 = _displayHelperFactory.CreateHelper(val2, (IViewDataContainer)(object)new ViewDataContainer());
		return ((DisplayHelper)val3).ShapeExecute(shape).ToString();
	}

	public IEnumerable<string> Display(IEnumerable<object> shapes)
	{
		return shapes.Select(Display).ToArray();
	}
}
