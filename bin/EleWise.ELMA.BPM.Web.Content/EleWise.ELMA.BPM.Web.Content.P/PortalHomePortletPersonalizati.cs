using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Serializable]
public class PortalHomePortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/ContentArea/Portal";
}
