using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Web.DTO.Managers;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Service(Scope = ServiceScope.Shell)]
public class WorkPlaceTypeService : IWorkPlaceTypeService
{
	internal class FakeController : Controller
	{
		public Guid WorkPlaceTypeUid { get; set; }

		[HttpGet]
		public ActionResult Action()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			return (ActionResult)new EmptyResult();
		}
	}

	public IDictionary<Guid, string> WorkPlaceTypes()
	{
		return ComponentManager.Current.GetExtensionPoints<IWorkPlaceType>().ToDictionary((IWorkPlaceType wpt) => wpt.Uid, (IWorkPlaceType wpt) => wpt.Name);
	}

	public string GetVirtualPath(Guid workPlaceTypeUid, string partialViewName)
	{
		Func<string, string> func = (string partial) => (!partial.StartsWith("~")) ? ((!partial.StartsWith("/")) ? ("~/Views/Shared/" + partial + ".cshtml") : ("~" + partial)) : partial;
		Func<ControllerContext, string, string> func2 = delegate(ControllerContext controllerContext, string viewName)
		{
			ViewEngineResult val = ViewEngines.get_Engines().FindPartialView(controllerContext, viewName);
			if (val == null || val.get_View() == null)
			{
				return null;
			}
			if (val.get_View() is CachedRazorView cachedRazorView)
			{
				return cachedRazorView.ViewPath;
			}
			IView view = val.get_View();
			RazorView val2 = (RazorView)(object)((view is RazorView) ? view : null);
			return (val2 != null) ? ((BuildManagerCompiledView)val2).get_ViewPath() : null;
		};
		using (SafeHttpContext.Create())
		{
			try
			{
				ControllerContext arg = ControllerContextCreator.Create((Controller)(object)new FakeController
				{
					WorkPlaceTypeUid = workPlaceTypeUid
				});
				string text = func2(arg, partialViewName);
				if (text != null)
				{
					return text;
				}
				text = func2(arg, func(partialViewName));
				if (text != null)
				{
					return text;
				}
			}
			catch
			{
			}
		}
		return func(partialViewName);
	}
}
