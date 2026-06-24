using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Web.Content;

[Component]
public class ControllerContentActionProvider : IControllerActionProvider, IModuleEvents
{
	private const string rootSuffix = "-Root";

	private readonly IContentActionUtilsService contentActionUtilsService;

	private LazyWithReset<IEnumerable<IContentAction>> actions;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Installing(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Installed(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Enabling(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Enabled(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Disabling(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Disabled(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Uninstalling(IWebModuleUnit module)
	{
		actions.Reset();
	}

	public void Uninstalled(IWebModuleUnit module)
	{
		actions.Reset();
	}

	[Obsolete("Не использовать", true)]
	public ControllerContentActionProvider(IComponentManager componentManager, ISecurityService securityService, IPermissionManagmentService permissionManagmentService, IModuleService moduleService)
		: this(Locator.GetServiceNotNull<IContentActionUtilsService>())
	{
	}

	public ControllerContentActionProvider(IContentActionUtilsService contentActionUtilsService)
	{
		this.contentActionUtilsService = contentActionUtilsService;
		actions = new LazyWithReset<IEnumerable<IContentAction>>(EvaluteActions);
	}

	public virtual IEnumerable<IContentAction> Actions()
	{
		return actions.Value;
	}

	private IEnumerable<IContentAction> EvaluteActions()
	{
		var source = from v in contentActionUtilsService.GetBaseControllerTypes().SelectMany((Type ct) => (from m in ct.GetMethods(BindingFlags.Instance | BindingFlags.Public)
				where m.ReturnType == TypeOf<ActionResult>.Raw || m.ReturnType == TypeOf<Task<ActionResult>>.Raw
				select m).SelectMany((MethodInfo m) => from ContentItemAttribute a in m.GetCustomAttributes(typeof(ContentItemAttribute), inherit: true)
				select new { a, m }))
			select new
			{
				module = AssemblyModuleName(v.m.DeclaringType.Assembly),
				action = new ContentAction
				{
					Id = (string.IsNullOrWhiteSpace(v.a.Id) ? (v.m.DeclaringType.FullName + "." + v.m.Name + (v.a.Root ? "-Root" : "")) : v.a.Id),
					NameForLocalization = v.a.Name,
					DescriptionForLocalization = v.a.Description,
					Image16 = v.a.GetImage(),
					Image24 = v.a.GetImage(ObjectIconFormat.x24),
					Image32 = v.a.GetImage(ObjectIconFormat.x32),
					ReferenceType = "ControllerAction",
					Category = (v.a.Category ?? contentActionUtilsService.GetCategory(v.m.DeclaringType)),
					ActionType = ContentAction.ActionTypePage,
					Order = v.a.Order,
					Routes = new ActionRoute(v.m.Name, ControllerName(v.m.DeclaringType), new
					{
						area = AssemblyModuleName(v.m.DeclaringType.Assembly)
					}),
					IsAvalilableDelegate = contentActionUtilsService.PermissionDelegate(v.m),
					MatchCurrentDelegate = v.a.MatchCurrentDelegate
				},
				a = v.a,
				m = v.m
			};
		var source2 = source.Where(v => v.a.Root).ToList();
		var source3 = source.Where(v => !v.a.Root).ToList();
		return source2.Select(v => v.action).Union(source3.Select(v => v.action)).ToList();
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
		return ComponentManager.GetAssemblyShortName(assembly);
	}

	public virtual IEnumerable<IContentCategory> Categories()
	{
		return EleWise.ELMA.Helpers.EmptyArray<IContentCategory>.Instance;
	}
}
