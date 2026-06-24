using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class ContentFilterMenuItemIdAttributeExtension : IContentFilterMenuItemIdExtension
{
	public IComponentManager ComponentManager { get; set; }

	public bool SetParameters(IFilterActionLink action, ActionRoute route, ref bool canMakeDefault)
	{
		FilterMenuItemAttribute filterMenuItemAttribute = ComponentManager.GetExtensionPointTypes(typeof(IBaseController)).SelectMany((Type ct) => ct.GetMethods(BindingFlags.Instance | BindingFlags.Public).SelectMany((MethodInfo m) => m.GetCustomAttributes(typeof(FilterMenuItemAttribute), inherit: true).Cast<FilterMenuItemAttribute>())).FirstOrDefault((FilterMenuItemAttribute a) => a.TypeUid == action.ObjectsType.TypeUid && (!action.Code.HasValue || (!string.IsNullOrEmpty(a.CodeStr) && action.Code.Value == new Guid(a.CodeStr))));
		if (filterMenuItemAttribute != null)
		{
			route.Routes.Add("activeMenuItemCode", filterMenuItemAttribute.Id);
			route.Routes.Add("showFiltersTree", true);
			canMakeDefault = true;
			return true;
		}
		return false;
	}
}
