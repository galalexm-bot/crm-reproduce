using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class ServerRestartController : BPMController
{
	private IServerRestartService serverRestartService;

	private IScheduledRestartService scheduledRestartService;

	private IServerRestartMessageService messageService;

	private ServerRestartSettingsModule settingsModule;

	private UserManager userManager;

	public ServerRestartController(IServerRestartService serverRestartService, IScheduledRestartService scheduledRestartService, IServerRestartMessageService messageService, ServerRestartSettingsModule settingsModule, UserManager userManager)
	{
		Contract.ArgumentNotNull(serverRestartService, "serverRestartService");
		Contract.ArgumentNotNull(scheduledRestartService, "scheduledRestartService");
		Contract.ArgumentNotNull(messageService, "messageService");
		Contract.ArgumentNotNull(settingsModule, "settingsModule");
		Contract.ArgumentNotNull(userManager, "userManager");
		this.serverRestartService = serverRestartService;
		this.scheduledRestartService = scheduledRestartService;
		this.messageService = messageService;
		this.settingsModule = settingsModule;
		this.userManager = userManager;
	}

	[HttpGet]
	public ActionResult View()
	{
		IOrderedEnumerable<ScheduledRestart> orderedEnumerable = from r in scheduledRestartService.GetRestarts((ScheduledRestart r) => r.State == RestartState.Waiting || r.State == RestartState.Restarting)
			orderby r.RestartDate
			select r;
		ICollection<ScheduledRestartHistoryEntry> history = scheduledRestartService.GetHistory();
		IEnumerable<long> first = orderedEnumerable.Select((ScheduledRestart r) => r.Author);
		IEnumerable<long> second = history.Select((ScheduledRestartHistoryEntry r) => r.Author);
		ICollection<IUser> inner = userManager.FindByIdArray(first.Union(second).ToArray());
		ServerRestartSettingsViewModel serverRestartSettingsViewModel = new ServerRestartSettingsViewModel
		{
			Settings = settingsModule.GetSettingsCopyThreadSafe(),
			Restarts = (from restart in orderedEnumerable
				join author in inner on restart.Author equals author.Id
				select new ScheduledRestartViewModel
				{
					Id = restart.Id,
					Reason = restart.Reason,
					RestartDate = restart.RestartDate,
					CreationDate = restart.CreationDate,
					Author = author
				} into x
				orderby x.RestartDate descending
				select x).ToArray(),
			History = (from restart in history
				join author in inner on restart.Author equals author.Id
				select new ScheduledRestartHistoryEntryViewModel
				{
					Id = restart.Id,
					Reason = restart.Reason,
					RestartDate = restart.RestartDate,
					CreationDate = restart.CreationDate,
					Author = author,
					Result = restart.Result,
					Information = restart.Information
				} into x
				orderby x.RestartDate descending
				select x).ToArray(),
			IsOwnPage = (((Controller)this).get_Request().QueryString.Get("module") == "EleWise.ELMA.Common")
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)serverRestartSettingsViewModel);
	}

	[HttpGet]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)settingsModule.GetSettingsCopyThreadSafe());
	}

	[HttpGet]
	public ActionResult SchedulePopup()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)new CreateScheduledRestartModel());
	}

	[HttpGet]
	public ActionResult FormattingHelp()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public ActionResult CreateAjax(CreateScheduledRestartModel model)
	{
		try
		{
			serverRestartService.Schedule(base.AuthenticationService.GetCurrentUser<IUser>().Id, model.RestartDate, model.Reason, model.SendNotifications);
		}
		catch (ServerRestartScheduleException ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				message = ex.Message
			});
		}
		catch (Exception ex2)
		{
			base.Logger.Error(ex2, SR.T("Ошибка при планировании перезапуска сервера: {0}", ex2.Message));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				message = SR.T("Произошла непредвиденная ошибка: {0}", ex2.Message)
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpPost]
	public ActionResult GetChannels()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		SelectList val = new SelectList((IEnumerable)(from c in messageService.GetInformationChannelInfo()
			select new
			{
				id = c.Id,
				text = c.Name
			}), "id", "text");
		return (ActionResult)(object)((Controller)this).Json((object)val);
	}

	[HttpPost]
	public ActionResult CancelRestart(Guid restartId)
	{
		try
		{
			serverRestartService.CancelRestart(restartId);
		}
		catch (ServerRestartCancellationException ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				message = ex.Message
			});
		}
		catch (Exception ex2)
		{
			base.Logger.Error(ex2, SR.T("Ошибка при отмене перезапуска сервера: {0}", ex2.Message));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}
}
