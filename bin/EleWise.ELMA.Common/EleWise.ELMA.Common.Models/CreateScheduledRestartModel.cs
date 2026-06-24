using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.Models;

public class CreateScheduledRestartModel
{
	internal class __Resources_CreateScheduledRestartModel
	{
		public static string RestartDate => SR.T("Дата перезапуска");

		public static string Reason => SR.T("Причина перезапуска");

		public static string SendNotifications => SR.T("Отправлять уведомления о перезапуске в ленту");
	}

	[DisplayName(typeof(__Resources_CreateScheduledRestartModel), "RestartDate")]
	[Required(true)]
	public DateTime RestartDate { get; set; }

	[DisplayName(typeof(__Resources_CreateScheduledRestartModel), "Reason")]
	[StringSettings(MultiLine = true)]
	[Required(true)]
	public string Reason { get; set; }

	[DisplayName(typeof(__Resources_CreateScheduledRestartModel), "SendNotifications")]
	[Required(true)]
	public bool SendNotifications { get; set; }

	public CreateScheduledRestartModel()
	{
		SendNotifications = true;
	}
}
