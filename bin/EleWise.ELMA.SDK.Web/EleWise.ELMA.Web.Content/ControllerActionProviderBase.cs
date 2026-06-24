using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Web.Content;

public abstract class ControllerActionProviderBase : IControllerActionProvider
{
	private IEnumerable<IContentAction> contentActions;

	public ILogger Logger { get; set; }

	[Obsolete("Нужно использовать сервис IContentActionUtilsService", true)]
	public ControllerContentActionProvider ControllerContentActionProvider { get; set; }

	public IContentActionUtilsService ContentActionUtilsService { get; set; }

	[Obsolete("Нужно использовать SR.M при присваивании названий в менюшках")]
	public virtual List<string> LocalizedItemsNames => new List<string>();

	[Obsolete("Нужно использовать SR.M при присваивании описаний в менюшках")]
	public virtual List<string> LocalizedItemsDescriptions => new List<string>();

	protected ControllerActionProviderBase()
	{
		Logger = NullLogger.Instance;
	}

	public IEnumerable<IContentAction> Actions()
	{
		if (contentActions == null)
		{
			List<ContentAction> list = GetAction().ToList();
			foreach (ContentAction item in list)
			{
				if (item.Category == null)
				{
					item.Category = ContentActionUtilsService?.GetCategory(GetType()) ?? string.Empty;
				}
				if (item.IsAvalilableDelegate != null || item.Routes == null)
				{
					continue;
				}
				Type type = ReflectionType.GetType(item.Routes.Area + ".Controllers." + item.Routes.Controller + "Controller, " + item.Routes.Area);
				if (type == null)
				{
					if (Logger.IsWarnEnabled())
					{
						Logger.WarnFormat("Cannot find type for Routes {0}", item.Routes);
					}
					continue;
				}
				MethodInfo method;
				try
				{
					method = type.GetMethod(item.Routes.Action);
				}
				catch (Exception)
				{
					if (Logger.IsWarnEnabled())
					{
						Logger.WarnFormat("Cannot receive method for Routes {0}", item.Routes);
					}
					continue;
				}
				if (method == null)
				{
					if (Logger.IsWarnEnabled())
					{
						Logger.WarnFormat("Cannot find method for Routes {0}", item.Routes);
					}
				}
				else
				{
					item.IsAvalilableDelegate = ContentActionUtilsService?.PermissionDelegate(method);
				}
			}
			contentActions = list;
		}
		return contentActions;
	}

	public IEnumerable<IContentCategory> Categories()
	{
		return GetCategories();
	}

	protected abstract IEnumerable<ContentAction> GetAction();

	protected virtual IEnumerable<IContentCategory> GetCategories()
	{
		return EleWise.ELMA.Helpers.EmptyArray<IContentCategory>.Instance;
	}
}
