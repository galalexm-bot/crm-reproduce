using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(EnableInterceptiors = true)]
public class FilterMenuItemAttributeExtension : IFilterMenuItemExtension
{
	private const string rootSuffix = "-Root";

	private const string TimestampKey = "EleWise.ELMA.BPM.Web.Common.Extensions.FilterMenuItemAttributeExtension.FilterMenuItems.TimeStampKey";

	public IComponentManager ComponentManager { get; set; }

	[ComplexCache("EleWise.ELMA.BPM.Web.Common.Extensions.FilterMenuItemAttributeExtension.FilterMenuItems.TimeStampKey")]
	public virtual IEnumerable<FilterMenuItem> FilterMenuItems()
	{
		var source = from v in ComponentManager.GetExtensionPointTypes(typeof(IBaseController)).SelectMany((Type ct) => (from m in ct.GetMethods(BindingFlags.Instance | BindingFlags.Public)
				where m.ReturnType == typeof(ActionResult)
				select m).SelectMany((MethodInfo m) => from FilterMenuItemAttribute a in m.GetCustomAttributes(typeof(FilterMenuItemAttribute), inherit: true)
				select new { a, m })).ToList()
			select new
			{
				filterMenu = new FilterMenuItem
				{
					TypeUid = v.a.TypeUid,
					Code = (string.IsNullOrWhiteSpace(v.a.Id) ? (v.m.DeclaringType.FullName + "." + v.m.Name + (v.a.Root ? "-Root" : "")) : v.a.Id),
					FilterIdParameter = (string.IsNullOrWhiteSpace(v.a.FilterIdParameter) ? "FilterId" : v.a.FilterIdParameter),
					ClickAction = v.a.ClickAction,
					FilterEditAction = v.a.FilterEditAction,
					Routes = new ActionRoute(v.m.Name, ControllerName(v.m.DeclaringType), new
					{
						area = AssemblyModuleName(v.m.DeclaringType.Assembly)
					}),
					TypeCode = v.a.Code,
					IncludeFavorites = v.a.ShowFilterFavorite
				},
				a = v.a
			};
		var source2 = source.Where(v => v.a.Root).ToList();
		var source3 = source.Where(v => !v.a.Root).ToList();
		return source2.Select(v => v.filterMenu).Union(source3.Select(v => v.filterMenu)).ToList();
	}

	private string ControllerName(Type declaringType)
	{
		if (declaringType == null)
		{
			throw new ArgumentNullException("declaringType");
		}
		string name = declaringType.Name;
		if (name.EndsWith("Controller"))
		{
			return name.Remove(name.Length - "Controller".Length);
		}
		return name;
	}

	private string AssemblyModuleName(Assembly assembly)
	{
		return assembly.GetName().Name;
	}
}
