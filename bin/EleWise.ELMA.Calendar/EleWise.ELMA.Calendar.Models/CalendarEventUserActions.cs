using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

public class CalendarEventUserActions : DefaultEntityActions
{
	[Uid("cd75c8a4-71a4-4e9a-bf60-9eadd957710a")]
	[DisplayName(typeof(__Resources_CalendarEventUserActions), "P_ConfirmParticipation_DisplayName")]
	[Image(typeof(CalendarEventUserActions), "calendar_done", 16, ImageFormatType.IconPack, false)]
	public const string ConfirmParticipation = "cd75c8a4-71a4-4e9a-bf60-9eadd957710a";

	private static Guid _confirmParticipationGuid = new Guid("cd75c8a4-71a4-4e9a-bf60-9eadd957710a");

	[Uid("ce7dbd74-250d-405c-9317-090e5c7a9506")]
	[DisplayName(typeof(__Resources_CalendarEventUserActions), "P_NotConfirmParticipation_DisplayName")]
	[Image(typeof(CalendarEventUserActions), "calendar_decline", 16, ImageFormatType.IconPack, false)]
	public const string NotConfirmParticipation = "ce7dbd74-250d-405c-9317-090e5c7a9506";

	private static Guid _notConfirmParticipationGuid = new Guid("ce7dbd74-250d-405c-9317-090e5c7a9506");

	public static Guid ConfirmParticipationGuid => _confirmParticipationGuid;

	public static Guid NotConfirmParticipationGuid => _notConfirmParticipationGuid;

	protected CalendarEventUserActions()
	{
	}
}
