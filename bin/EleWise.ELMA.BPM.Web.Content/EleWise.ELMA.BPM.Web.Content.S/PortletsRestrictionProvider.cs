using System;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Security;

[Component]
public class PortletsRestrictionProvider : IPortletsRestrictionProvider
{
	public const string pagePrefix = "portletPage_";

	public ISecurityService SecurityService { get; set; }

	public IEntityManager<IPortletPage> PageManager { get; set; }

	public static string PortalPageDataPath(IPortletPage portletPage)
	{
		return "portletPage_" + portletPage.Id;
	}

	public bool Match([NotNull] string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return GetId(path).HasValue;
	}

	private long? GetId(string path)
	{
		if (path.StartsWith("portletPage_") && long.TryParse(path.Substring("portletPage_".Length), out var result))
		{
			return result;
		}
		return null;
	}

	public bool AllowedAddPortlet(IPortlet portlet, string path)
	{
		return AllowedAddPortlet(path);
	}

	public bool AllowedAddPortlet(string path)
	{
		return HasPermission(PageSecurity.ViewPagePermission, path);
	}

	public bool AllowedView(string path)
	{
		return HasPermission(PageSecurity.ViewPagePermission, path);
	}

	public bool AllowedPersonalization(string path)
	{
		return HasPermission(PageSecurity.ViewPagePermission, path);
	}

	public bool AllowedChangeSharedSettings(string path)
	{
		return HasPermission(PageSecurity.EditPagePermission, path);
	}

	private bool HasPermission(Permission permission, string path)
	{
		if (SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission))
		{
			return true;
		}
		long? id = GetId(path);
		if (!id.HasValue)
		{
			throw new Exception(SR.T("Идентификатор страницы не определен: {0}", path));
		}
		IPortletPage target;
		try
		{
			target = PageManager.Load(id.Value);
		}
		catch (SecurityException)
		{
			return false;
		}
		return SecurityService.HasPermission(permission, target);
	}
}
