using System;
using EleWise.ELMA.BPM.Web.Common.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SystemInfoPortletModel
{
	public SystemInfoPortletPersonalization Settings { get; set; }

	public LicenseViewModel LicenseInfo { get; set; }

	[Obsolete("Не используется")]
	public bool IsPackagesAvailable { get; set; }
}
