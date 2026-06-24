using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Serializable]
public class DocumentsHomePortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/Documents/Settings";
}
