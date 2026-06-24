using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class WorkLogItemActions : DefaultEntityActions
{
	[Uid("53882117-b3e8-4581-8c76-2f4fcc8e68d5")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_AddQuestion_DisplayName")]
	[Image(typeof(WorkLogItemActions), "help", 16, ImageFormatType.IconPack, false)]
	public const string AddQuestion = "53882117-b3e8-4581-8c76-2f4fcc8e68d5";

	private static Guid _addQuestionGuid = new Guid("53882117-b3e8-4581-8c76-2f4fcc8e68d5");

	[Uid("ef2017b8-8db8-4e03-996c-67e9d53acd0b")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_AddComment_DisplayName")]
	[Image(typeof(WorkLogItemActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "ef2017b8-8db8-4e03-996c-67e9d53acd0b";

	private static Guid _addCommentGuid = new Guid("ef2017b8-8db8-4e03-996c-67e9d53acd0b");

	[Uid("24dc1527-088d-4fec-abcb-be4005ca7cc4")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_ConfirmApproval_DisplayName")]
	[Image(typeof(WorkLogItemActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string ConfirmApproval = "24dc1527-088d-4fec-abcb-be4005ca7cc4";

	private static Guid _confirmApprovalGuid = new Guid("24dc1527-088d-4fec-abcb-be4005ca7cc4");

	[Uid("1b533763-6cb3-46e4-9695-952d48433fbf")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_RefuseApproval_DisplayName")]
	[Image(typeof(WorkLogItemActions), "error", 16, ImageFormatType.IconPack, false)]
	public const string RefuseApproval = "1b533763-6cb3-46e4-9695-952d48433fbf";

	private static Guid _refuseApprovalGuid = new Guid("1b533763-6cb3-46e4-9695-952d48433fbf");

	[Uid("823cc9ce-1ca4-4ee2-a7a0-872054d4f986")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_Redirect_DisplayName")]
	[Image(typeof(WorkLogItemActions), "redirect", 16, ImageFormatType.IconPack, false)]
	public const string Redirect = "823cc9ce-1ca4-4ee2-a7a0-872054d4f986";

	private static Guid _redirectGuid = new Guid("823cc9ce-1ca4-4ee2-a7a0-872054d4f986");

	[Uid("44fceaea-f9fd-4e28-a834-c247a015242f")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_Edit_DisplayName")]
	[Image(typeof(WorkLogItemActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "44fceaea-f9fd-4e28-a834-c247a015242f";

	private static Guid _editGuid = new Guid("44fceaea-f9fd-4e28-a834-c247a015242f");

	[Uid("2a7a7985-796f-4eac-a1aa-4d81234ac405")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_SendToApprove_DisplayName")]
	[Image(typeof(WorkLogItemActions), "add_outline", 16, ImageFormatType.IconPack, false)]
	public const string SendToApprove = "2a7a7985-796f-4eac-a1aa-4d81234ac405";

	private static Guid _sendToApproveGuid = new Guid("2a7a7985-796f-4eac-a1aa-4d81234ac405");

	[Uid("e71c3a9e-e121-4c1b-a7b7-93e90eac242d")]
	[DisplayName(typeof(__Resources_WorkLogItemActions), "P_ChangeStatus_DisplayName")]
	[Image(typeof(WorkLogItemActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeStatus = "e71c3a9e-e121-4c1b-a7b7-93e90eac242d";

	private static Guid _changeStatusGuid = new Guid("e71c3a9e-e121-4c1b-a7b7-93e90eac242d");

	public static Guid AddQuestionGuid => _addQuestionGuid;

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid ConfirmApprovalGuid => _confirmApprovalGuid;

	public static Guid RefuseApprovalGuid => _refuseApprovalGuid;

	public static Guid RedirectGuid => _redirectGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid SendToApproveGuid => _sendToApproveGuid;

	public static Guid ChangeStatusGuid => _changeStatusGuid;

	protected WorkLogItemActions()
	{
	}
}
