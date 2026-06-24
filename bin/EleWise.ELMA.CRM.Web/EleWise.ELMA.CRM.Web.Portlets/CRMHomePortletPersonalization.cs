using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Serializable]
public class CRMHomePortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/CRM/Admin";
}
