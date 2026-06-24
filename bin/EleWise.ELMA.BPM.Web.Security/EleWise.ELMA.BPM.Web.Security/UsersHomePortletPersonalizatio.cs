using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Serializable]
public class UsersHomePortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/Security";
}
