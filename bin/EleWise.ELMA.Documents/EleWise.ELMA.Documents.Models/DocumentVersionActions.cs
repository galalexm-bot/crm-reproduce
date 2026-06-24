using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class DocumentVersionActions : DefaultEntityActions
{
	[Uid("5348ccff-44f0-40d5-9e45-1f748f792399")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_Lock_DisplayName")]
	[Image(typeof(DocumentVersionActions), "document_lock", 16, ImageFormatType.IconPack, false)]
	public const string Lock = "5348ccff-44f0-40d5-9e45-1f748f792399";

	private static Guid _lockGuid = new Guid("5348ccff-44f0-40d5-9e45-1f748f792399");

	[Uid("f325c9cb-8a81-4372-8db5-4328327b2edd")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_UnLock_DisplayName")]
	[Image(typeof(DocumentVersionActions), "document_lock", 16, ImageFormatType.IconPack, false)]
	public const string UnLock = "f325c9cb-8a81-4372-8db5-4328327b2edd";

	private static Guid _unLockGuid = new Guid("f325c9cb-8a81-4372-8db5-4328327b2edd");

	[Uid("ea5d9da3-dd4b-450d-ae5b-ebfb2ad6580a")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_ChangeStatus_DisplayName")]
	[Image(typeof(DocumentVersionActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeStatus = "ea5d9da3-dd4b-450d-ae5b-ebfb2ad6580a";

	private static Guid _changeStatusGuid = new Guid("ea5d9da3-dd4b-450d-ae5b-ebfb2ad6580a");

	[Uid("c7863144-fc31-46c7-bcec-7ea9f90facd6")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_Edit_DisplayName")]
	[Image(typeof(DocumentVersionActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "c7863144-fc31-46c7-bcec-7ea9f90facd6";

	private static Guid _editGuid = new Guid("c7863144-fc31-46c7-bcec-7ea9f90facd6");

	[Uid("19ef8b48-e82d-44ba-b365-403f84315dd0")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_UserCreate_DisplayName")]
	[Image(typeof(DocumentVersionActions), "add_outline", 16, ImageFormatType.IconPack, false)]
	public const string UserCreate = "19ef8b48-e82d-44ba-b365-403f84315dd0";

	private static Guid _userCreateGuid = new Guid("19ef8b48-e82d-44ba-b365-403f84315dd0");

	[Uid("33fbb723-5681-4499-9d72-c79d436d918d")]
	[DisplayName(typeof(__Resources_DocumentVersionActions), "P_Download_DisplayName")]
	[Description(typeof(__Resources_DocumentVersionActions), "P_Download_Description")]
	[Image(typeof(DocumentVersionActions), "download", 16, ImageFormatType.IconPack, false)]
	public const string Download = "33fbb723-5681-4499-9d72-c79d436d918d";

	private static Guid _downloadGuid = new Guid("33fbb723-5681-4499-9d72-c79d436d918d");

	public static Guid LockGuid => _lockGuid;

	public static Guid UnLockGuid => _unLockGuid;

	public static Guid ChangeStatusGuid => _changeStatusGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid UserCreateGuid => _userCreateGuid;

	public static Guid DownloadGuid => _downloadGuid;

	protected DocumentVersionActions()
	{
	}
}
