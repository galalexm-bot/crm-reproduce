using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

public class ReminderActions : DefaultEntityActions
{
	[Uid("5761c647-866e-4a19-9ebd-1b9ac73eb86d")]
	[DisplayName(typeof(__Resources_ReminderActions), "P_Remind_DisplayName")]
	[Image(typeof(ReminderActions), "question", 16, ImageFormatType.IconPack, false)]
	public const string Remind = "5761c647-866e-4a19-9ebd-1b9ac73eb86d";

	private static Guid _remindGuid = new Guid("5761c647-866e-4a19-9ebd-1b9ac73eb86d");

	public static Guid RemindGuid => _remindGuid;

	protected ReminderActions()
	{
	}
}
