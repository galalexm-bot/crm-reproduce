using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

public class CalendarEventActions : DefaultEntityActions
{
	[Uid("a615693d-1d05-4dbd-97a2-19331a825093")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_ChangeTime_DisplayName")]
	[Image(typeof(CalendarEventActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeTime = "a615693d-1d05-4dbd-97a2-19331a825093";

	private static Guid _changeTimeGuid = new Guid("a615693d-1d05-4dbd-97a2-19331a825093");

	[Uid("29dc4f17-019c-4f17-a7e3-7c47903c2b7d")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_AddComment_DisplayName")]
	[Description(typeof(__Resources_CalendarEventActions), "P_AddComment_Description")]
	[Image(typeof(CalendarEventActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "29dc4f17-019c-4f17-a7e3-7c47903c2b7d";

	private static Guid _addCommentGuid = new Guid("29dc4f17-019c-4f17-a7e3-7c47903c2b7d");

	[Uid("81e2a8ae-ab4c-4cfd-ab95-21c604c581c3")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_Edit_DisplayName")]
	[Description(typeof(__Resources_CalendarEventActions), "P_Edit_Description")]
	[Image(typeof(CalendarEventActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "81e2a8ae-ab4c-4cfd-ab95-21c604c581c3";

	private static Guid _editGuid = new Guid("81e2a8ae-ab4c-4cfd-ab95-21c604c581c3");

	[Uid("f53d81fc-de2e-4d95-843f-2e3d6464b680")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_Complete_DisplayName")]
	[Description(typeof(__Resources_CalendarEventActions), "P_Complete_Description")]
	[Image(typeof(CalendarEventActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string Complete = "f53d81fc-de2e-4d95-843f-2e3d6464b680";

	private static Guid _completeGuid = new Guid("f53d81fc-de2e-4d95-843f-2e3d6464b680");

	[Uid("deb7e8a2-d861-4a62-9b33-66660bc7f770")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_AddQuestion_DisplayName")]
	[Image(typeof(CalendarEventActions), "question", 16, ImageFormatType.IconPack, false)]
	public const string AddQuestion = "deb7e8a2-d861-4a62-9b33-66660bc7f770";

	private static Guid _addQuestionGuid = new Guid("deb7e8a2-d861-4a62-9b33-66660bc7f770");

	[Uid("a1ab98cb-4bc5-4292-865f-ee6937b0d92d")]
	[DisplayName(typeof(__Resources_CalendarEventActions), "P_DeleteEvent_DisplayName")]
	[Image(typeof(CalendarEventActions), "basket", 16, ImageFormatType.IconPack, false)]
	public const string DeleteEvent = "a1ab98cb-4bc5-4292-865f-ee6937b0d92d";

	private static Guid _deleteEventGuid = new Guid("a1ab98cb-4bc5-4292-865f-ee6937b0d92d");

	public static Guid ChangeTimeGuid => _changeTimeGuid;

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid CompleteGuid => _completeGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	public static Guid DeleteEventGuid => _deleteEventGuid;

	protected CalendarEventActions()
	{
	}
}
