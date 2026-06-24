using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class DmsObjectActions : DefaultEntityActions
{
	[Uid("5ddacce9-ae0d-4c51-a630-9c5b3e0e94cc")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_Rename_DisplayName")]
	public const string Rename = "5ddacce9-ae0d-4c51-a630-9c5b3e0e94cc";

	private static Guid _renameGuid = new Guid("5ddacce9-ae0d-4c51-a630-9c5b3e0e94cc");

	[Uid("bc7324d5-f4b1-4c2b-b063-58ea707b0408")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_Edit_DisplayName")]
	[Description(typeof(__Resources_DmsObjectActions), "P_Edit_Description")]
	[Image(typeof(DmsObjectActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "bc7324d5-f4b1-4c2b-b063-58ea707b0408";

	private static Guid _editGuid = new Guid("bc7324d5-f4b1-4c2b-b063-58ea707b0408");

	[Uid("b02c8d0e-c782-4637-b5b9-026493bbf823")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_Move_DisplayName")]
	[Image(typeof(DmsObjectActions), "switch", 16, ImageFormatType.IconPack, false)]
	public const string Move = "b02c8d0e-c782-4637-b5b9-026493bbf823";

	private static Guid _moveGuid = new Guid("b02c8d0e-c782-4637-b5b9-026493bbf823");

	[Uid("ddab09b8-1ace-4ca5-be4c-52cb8576d2e2")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_Archive_DisplayName")]
	[Image(typeof(DmsObjectActions), "archive", 16, ImageFormatType.IconPack, false)]
	public const string Archive = "ddab09b8-1ace-4ca5-be4c-52cb8576d2e2";

	private static Guid _archiveGuid = new Guid("ddab09b8-1ace-4ca5-be4c-52cb8576d2e2");

	[Uid("0dac7df0-2db7-42c9-a775-e19a91b0204c")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_UnArchive_DisplayName")]
	[Image(typeof(DmsObjectActions), "unarchive", 16, ImageFormatType.IconPack, false)]
	public const string UnArchive = "0dac7df0-2db7-42c9-a775-e19a91b0204c";

	private static Guid _unArchiveGuid = new Guid("0dac7df0-2db7-42c9-a775-e19a91b0204c");

	[Uid("f607a7b5-360c-4627-872f-02e0c890327b")]
	[DisplayName(typeof(__Resources_DmsObjectActions), "P_ChangeAccess_DisplayName")]
	[Image(typeof(DmsObjectActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeAccess = "f607a7b5-360c-4627-872f-02e0c890327b";

	private static Guid _changeAccessGuid = new Guid("f607a7b5-360c-4627-872f-02e0c890327b");

	public static Guid RenameGuid => _renameGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid MoveGuid => _moveGuid;

	public static Guid ArchiveGuid => _archiveGuid;

	public static Guid UnArchiveGuid => _unArchiveGuid;

	public static Guid ChangeAccessGuid => _changeAccessGuid;

	protected DmsObjectActions()
	{
	}
}
