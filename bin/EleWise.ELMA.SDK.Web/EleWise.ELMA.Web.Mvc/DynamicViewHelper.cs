using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc;

public class DynamicViewHelper
{
	private readonly ControllerContext context;

	public DynamicLoadMode LoadMode
	{
		get
		{
			DynamicLoadMode result = DynamicLoadMode.Server;
			if (context.get_RouteData().Values.ContainsKey("LoadMode"))
			{
				result = (DynamicLoadMode)context.get_RouteData().Values["LoadMode"];
			}
			return result;
		}
	}

	[Obsolete("Это свойство устаревшее как и контрол DynamicPortletControl", false)]
	public bool NeedRenderView => LoadMode == DynamicLoadMode.Server;

	public DynamicViewHelper(ControllerContext context)
	{
		this.context = context;
	}
}
