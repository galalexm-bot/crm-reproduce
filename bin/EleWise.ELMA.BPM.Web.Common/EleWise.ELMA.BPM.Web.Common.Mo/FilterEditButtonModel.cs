using System;
using System.Web.Routing;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterEditButtonModel
{
	private Lazy<bool> _hasEditPermission;

	private Lazy<bool> _hasFullPermission;

	public long FilterId { get; set; }

	public string BackUrl { get; set; }

	public string Area { get; set; }

	public string ControllerName { get; set; }

	public RouteValueDictionary AdditionalRoute { get; set; }

	public string ScriptFunctionGetParams { get; set; }

	public bool HasEditPermissinon
	{
		get
		{
			if (FilterId <= 0)
			{
				return false;
			}
			if (_hasEditPermission == null)
			{
				_hasEditPermission = new Lazy<bool>(delegate
				{
					IFilter target = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId);
					return Locator.GetService<ISecurityService>().HasPermission(EleWise.ELMA.Common.PermissionProvider.FilterEditPermission, target) || Locator.GetService<ISecurityService>().HasPermission(EleWise.ELMA.Common.PermissionProvider.FilterFullAccessPermission, target);
				});
			}
			return _hasEditPermission.Value;
		}
	}

	public bool HasFullPermissinon
	{
		get
		{
			if (FilterId <= 0)
			{
				return false;
			}
			if (_hasFullPermission == null)
			{
				_hasFullPermission = new Lazy<bool>(delegate
				{
					IFilter target = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId);
					return Locator.GetService<ISecurityService>().HasPermission(EleWise.ELMA.Common.PermissionProvider.FilterFullAccessPermission, target);
				});
			}
			return _hasFullPermission.Value;
		}
	}

	public bool CalcVisible()
	{
		if (((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId) : InterfaceActivator.Create<IFilter>()).FilterType == FilterType.SystemFilter)
		{
			return false;
		}
		return HasEditPermissinon;
	}

	public FilterEditButtonModel()
	{
		AdditionalRoute = new RouteValueDictionary();
	}
}
