using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Serializable]
public class SystemInfoPortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/Common/License";
}
