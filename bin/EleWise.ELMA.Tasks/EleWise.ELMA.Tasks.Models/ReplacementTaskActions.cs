using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class ReplacementTaskActions : TaskBaseActions
{
	[Uid("2da98d86-c11a-46f4-9159-33bb8cdf73b4")]
	[DisplayName(typeof(__Resources_ReplacementTaskActions), "P_Reopen_DisplayName")]
	[Image(typeof(ReplacementTaskActions), "refresh", 16, ImageFormatType.IconPack, false)]
	public const string Reopen = "2da98d86-c11a-46f4-9159-33bb8cdf73b4";

	private static Guid _reopenGuid = new Guid("2da98d86-c11a-46f4-9159-33bb8cdf73b4");

	[Uid("00bbefa0-fc95-47e9-9076-0c438e45b633")]
	[DisplayName(typeof(__Resources_ReplacementTaskActions), "P_Close_DisplayName")]
	[Image(typeof(ReplacementTaskActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string Close = "00bbefa0-fc95-47e9-9076-0c438e45b633";

	private static Guid _closeGuid = new Guid("00bbefa0-fc95-47e9-9076-0c438e45b633");

	[Uid("18fae09f-09c2-4b56-b979-274be486f00d")]
	[DisplayName(typeof(__Resources_ReplacementTaskActions), "P_Replacement_DisplayName")]
	[Image(typeof(ReplacementTaskActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string Replacement = "18fae09f-09c2-4b56-b979-274be486f00d";

	private static Guid _replacementGuid = new Guid("18fae09f-09c2-4b56-b979-274be486f00d");

	public static Guid ReopenGuid => _reopenGuid;

	public static Guid CloseGuid => _closeGuid;

	public static Guid ReplacementGuid => _replacementGuid;

	protected ReplacementTaskActions()
	{
	}
}
