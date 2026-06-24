using System;
using System.Web.Mvc;
using EleWise.ELMA.Agent.Services;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Agent.Web.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
internal sealed class ElmaAgentSettingsController : BPMController
{
	private IElmaAgentService agentService;

	public ElmaAgentSettingsController(IElmaAgentService agentService)
	{
		this.agentService = agentService;
	}

	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).PartialView("Settings/AgentSettings");
	}

	public JsonResult UpdateAgentsConfig()
	{
		try
		{
			agentService.UpdateAgentsConfig();
			return ((Controller)this).Json((object)new
			{
				success = true,
				message = SR.T("Команда на обновление настроек ELMA Агентов успешно отправлена")
			}, (JsonRequestBehavior)0);
		}
		catch (Exception ex)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				message = ex.Message
			}, (JsonRequestBehavior)0);
		}
	}
}
