using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class ContractorActions : DefaultEntityActions
{
	[Uid("81a9ad42-5ade-4eb5-93e1-a22c537c4478")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_AddComment_DisplayName")]
	[Image(typeof(ContractorActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "81a9ad42-5ade-4eb5-93e1-a22c537c4478";

	private static Guid _addCommentGuid = new Guid("81a9ad42-5ade-4eb5-93e1-a22c537c4478");

	[Uid("c7b89bfd-dc8f-440d-82a9-da1ee469afd9")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_Edit_DisplayName")]
	[Image(typeof(ContractorActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "c7b89bfd-dc8f-440d-82a9-da1ee469afd9";

	private static Guid _editGuid = new Guid("c7b89bfd-dc8f-440d-82a9-da1ee469afd9");

	[Uid("c34e8c84-3977-42fe-8d1a-a6482ceb865c")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_AddSlave_DisplayName")]
	[Image(typeof(ContractorActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string AddSlave = "c34e8c84-3977-42fe-8d1a-a6482ceb865c";

	private static Guid _addSlaveGuid = new Guid("c34e8c84-3977-42fe-8d1a-a6482ceb865c");

	[Uid("636c5d4d-a6a1-4b71-99fc-038dd018f596")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_DelSlave_DisplayName")]
	public const string DelSlave = "636c5d4d-a6a1-4b71-99fc-038dd018f596";

	private static Guid _delSlaveGuid = new Guid("636c5d4d-a6a1-4b71-99fc-038dd018f596");

	[Uid("e1f4165f-9ff2-4a21-8ffa-6c06e03684f9")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_ChangeAccess_DisplayName")]
	public const string ChangeAccess = "e1f4165f-9ff2-4a21-8ffa-6c06e03684f9";

	private static Guid _changeAccessGuid = new Guid("e1f4165f-9ff2-4a21-8ffa-6c06e03684f9");

	[Uid("d17e073c-0f95-4c57-9322-4f18d560401e")]
	[DisplayName(typeof(__Resources_ContractorActions), "P_Watch_DisplayName")]
	[Image(typeof(ContractorActions), "visualibility", 16, ImageFormatType.IconPack, false)]
	public const string Watch = "d17e073c-0f95-4c57-9322-4f18d560401e";

	private static Guid _watchGuid = new Guid("d17e073c-0f95-4c57-9322-4f18d560401e");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid AddSlaveGuid => _addSlaveGuid;

	public static Guid DelSlaveGuid => _delSlaveGuid;

	public static Guid ChangeAccessGuid => _changeAccessGuid;

	public static Guid WatchGuid => _watchGuid;

	protected ContractorActions()
	{
	}
}
