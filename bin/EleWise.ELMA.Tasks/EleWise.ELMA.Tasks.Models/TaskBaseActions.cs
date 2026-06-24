using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class TaskBaseActions : DefaultEntityActions
{
	[Uid("e49a86f0-5c45-4db1-945a-6d0e20bde148")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_StartWork_DisplayName")]
	[Image(typeof(TaskBaseActions), "task_start", 16, ImageFormatType.IconPack, false)]
	public const string StartWork = "e49a86f0-5c45-4db1-945a-6d0e20bde148";

	private static Guid _startWorkGuid = new Guid("e49a86f0-5c45-4db1-945a-6d0e20bde148");

	[Uid("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Complete_DisplayName")]
	[Image(typeof(TaskBaseActions), "complete_outline", 16, ImageFormatType.IconPack, false)]
	public const string Complete = "6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8";

	private static Guid _completeGuid = new Guid("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8");

	[Uid("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Incomplete_DisplayName")]
	[Image(typeof(TaskBaseActions), "error", 16, ImageFormatType.IconPack, false)]
	public const string Incomplete = "9a8806b0-8e5a-4f46-868f-9a1604d4ebce";

	private static Guid _incompleteGuid = new Guid("9a8806b0-8e5a-4f46-868f-9a1604d4ebce");

	[Uid("9022bb4f-df58-4f4c-b0b1-f045e0ce293a")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Redirect_DisplayName")]
	[Image(typeof(TaskBaseActions), "redirect", 16, ImageFormatType.IconPack, false)]
	public const string Redirect = "9022bb4f-df58-4f4c-b0b1-f045e0ce293a";

	private static Guid _redirectGuid = new Guid("9022bb4f-df58-4f4c-b0b1-f045e0ce293a");

	[Uid("d18e6155-7947-452e-89f0-8ce9f5ed46ea")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_AddComment_DisplayName")]
	[Image(typeof(TaskBaseActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "d18e6155-7947-452e-89f0-8ce9f5ed46ea";

	private static Guid _addCommentGuid = new Guid("d18e6155-7947-452e-89f0-8ce9f5ed46ea");

	[Uid("76ba2808-a04c-4827-8ec1-0e762ae729de")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_ChangeEndDate_DisplayName")]
	[Image(typeof(TaskBaseActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeEndDate = "76ba2808-a04c-4827-8ec1-0e762ae729de";

	private static Guid _changeEndDateGuid = new Guid("76ba2808-a04c-4827-8ec1-0e762ae729de");

	[Uid("bd4abee0-5880-466a-a0ad-b5da431a52fa")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_AddQuestion_DisplayName")]
	[Image(typeof(TaskBaseActions), "hel", 16, ImageFormatType.IconPack, false)]
	public const string AddQuestion = "bd4abee0-5880-466a-a0ad-b5da431a52fa";

	private static Guid _addQuestionGuid = new Guid("bd4abee0-5880-466a-a0ad-b5da431a52fa");

	[Uid("f1a055dc-2b7f-4220-bae1-471eed6645a9")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_CreateSubTask_DisplayName")]
	public const string CreateSubTask = "f1a055dc-2b7f-4220-bae1-471eed6645a9";

	private static Guid _createSubTaskGuid = new Guid("f1a055dc-2b7f-4220-bae1-471eed6645a9");

	[Uid("eda589f3-0d5d-4c9f-93cb-e0c28851ba04")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Schedule_DisplayName")]
	public const string Schedule = "eda589f3-0d5d-4c9f-93cb-e0c28851ba04";

	private static Guid _scheduleGuid = new Guid("eda589f3-0d5d-4c9f-93cb-e0c28851ba04");

	[Uid("ef34b63c-a9f6-4136-8e80-505a8e728baa")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Edit_DisplayName")]
	[Description(typeof(__Resources_TaskBaseActions), "P_Edit_Description")]
	[Image(typeof(TaskBaseActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "ef34b63c-a9f6-4136-8e80-505a8e728baa";

	private static Guid _editGuid = new Guid("ef34b63c-a9f6-4136-8e80-505a8e728baa");

	[Uid("983b7725-7818-4aed-9367-bf6148e9518a")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_MarkRead_DisplayName")]
	[Description(typeof(__Resources_TaskBaseActions), "P_MarkRead_Description")]
	[Image(typeof(TaskBaseActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string MarkRead = "983b7725-7818-4aed-9367-bf6148e9518a";

	private static Guid _markReadGuid = new Guid("983b7725-7818-4aed-9367-bf6148e9518a");

	[Uid("5e7c9eb0-2f5a-4f59-b39d-053d054a1880")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Activate_DisplayName")]
	[Image(typeof(TaskBaseActions), "add_outline", 16, ImageFormatType.IconPack, false)]
	public const string Activate = "5e7c9eb0-2f5a-4f59-b39d-053d054a1880";

	private static Guid _activateGuid = new Guid("5e7c9eb0-2f5a-4f59-b39d-053d054a1880");

	[Uid("0a37e597-3c2b-4a89-84fa-d8b0bd754fc3")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Expired_DisplayName")]
	[Image(typeof(TaskBaseActions), "clock_question", 16, ImageFormatType.IconPack, false)]
	public const string Expired = "0a37e597-3c2b-4a89-84fa-d8b0bd754fc3";

	private static Guid _expiredGuid = new Guid("0a37e597-3c2b-4a89-84fa-d8b0bd754fc3");

	[Uid("ba0d7c62-8671-4232-ac35-d5006e23dff7")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_AddCoExecutor_DisplayName")]
	[Image(typeof(TaskBaseActions), "user", 16, ImageFormatType.IconPack, false)]
	public const string AddCoExecutor = "ba0d7c62-8671-4232-ac35-d5006e23dff7";

	private static Guid _addCoExecutorGuid = new Guid("ba0d7c62-8671-4232-ac35-d5006e23dff7");

	[Uid("0361b9d5-c125-4e77-b0c2-8609d42a6bdd")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_DeleteCoExecutor_DisplayName")]
	[Image(typeof(TaskBaseActions), "user_delete", 16, ImageFormatType.IconPack, false)]
	public const string DeleteCoExecutor = "0361b9d5-c125-4e77-b0c2-8609d42a6bdd";

	private static Guid _deleteCoExecutorGuid = new Guid("0361b9d5-c125-4e77-b0c2-8609d42a6bdd");

	[Uid("525fb304-05ef-4741-9695-913d708db469")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Terminate_DisplayName")]
	[Image(typeof(TaskBaseActions), "error", 16, ImageFormatType.IconPack, false)]
	public const string Terminate = "525fb304-05ef-4741-9695-913d708db469";

	private static Guid _terminateGuid = new Guid("525fb304-05ef-4741-9695-913d708db469");

	[Uid("299948dc-dad3-443b-a226-c7f6c76d608c")]
	[DisplayName(typeof(__Resources_TaskBaseActions), "P_Watch_DisplayName")]
	[Image(typeof(TaskBaseActions), "task_watch", 16, ImageFormatType.IconPack, false)]
	public const string Watch = "299948dc-dad3-443b-a226-c7f6c76d608c";

	private static Guid _watchGuid = new Guid("299948dc-dad3-443b-a226-c7f6c76d608c");

	public static Guid StartWorkGuid => _startWorkGuid;

	public static Guid CompleteGuid => _completeGuid;

	public static Guid IncompleteGuid => _incompleteGuid;

	public static Guid RedirectGuid => _redirectGuid;

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid ChangeEndDateGuid => _changeEndDateGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	public static Guid CreateSubTaskGuid => _createSubTaskGuid;

	public static Guid ScheduleGuid => _scheduleGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid MarkReadGuid => _markReadGuid;

	public static Guid ActivateGuid => _activateGuid;

	public static Guid ExpiredGuid => _expiredGuid;

	public static Guid AddCoExecutorGuid => _addCoExecutorGuid;

	public static Guid DeleteCoExecutorGuid => _deleteCoExecutorGuid;

	public static Guid TerminateGuid => _terminateGuid;

	public static Guid WatchGuid => _watchGuid;

	protected TaskBaseActions()
	{
	}
}
