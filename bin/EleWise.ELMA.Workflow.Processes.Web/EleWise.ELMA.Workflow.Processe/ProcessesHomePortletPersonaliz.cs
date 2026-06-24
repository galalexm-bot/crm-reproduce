using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Serializable]
public class ProcessesHomePortletPersonalization : PortletPersonalization
{
	public override string NameUrl => "/Processes/ProcessHeader/Settings";
}
