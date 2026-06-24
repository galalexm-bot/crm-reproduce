using System;
using System.Collections.Generic;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Security;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class MonitorModel
{
	private Lazy<bool> hasMonitorAdminPermission;

	private Lazy<bool> hasMonitorDesignerStartPermission;

	private Lazy<bool> hasAdminPermission;

	public List<MonitorPartModel> Parts { get; set; }

	public bool HasMonitorAdminPermission
	{
		get
		{
			if (hasMonitorAdminPermission == null)
			{
				hasMonitorAdminPermission = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(WorkflowProcessesPermissionProvider.MonitorAdminPermission));
			}
			return hasMonitorAdminPermission.Value;
		}
	}

	public bool HasMonitorDesignerStartPermission
	{
		get
		{
			if (hasMonitorDesignerStartPermission == null)
			{
				hasMonitorDesignerStartPermission = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(CommonPermissions.DesignerAccessPermission));
			}
			return hasMonitorDesignerStartPermission.Value;
		}
	}

	public bool HasAdminPermission
	{
		get
		{
			if (hasAdminPermission == null)
			{
				hasAdminPermission = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(CommonPermissions.AdminPermission));
			}
			return hasAdminPermission.Value;
		}
	}

	public ISet<EleWise.ELMA.Security.Models.IUser> Owner { get; set; }

	public string ProcessName { get; set; }

	public MonitorModel()
	{
		Parts = new List<MonitorPartModel>();
	}
}
