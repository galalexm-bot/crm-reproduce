using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class ApprovalTaskActions : TaskBaseActions
{
	[Uid("a56477d4-cace-4545-9f1e-a318d89f0c54")]
	[DisplayName(typeof(__Resources_ApprovalTaskActions), "P_Close_DisplayName")]
	[Description(typeof(__Resources_ApprovalTaskActions), "P_Close_Description")]
	[Image(typeof(ApprovalTaskActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string Close = "a56477d4-cace-4545-9f1e-a318d89f0c54";

	private static Guid _closeGuid = new Guid("a56477d4-cace-4545-9f1e-a318d89f0c54");

	public static Guid CloseGuid => _closeGuid;

	protected ApprovalTaskActions()
	{
	}
}
