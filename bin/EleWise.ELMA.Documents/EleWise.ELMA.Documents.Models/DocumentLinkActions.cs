using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class DocumentLinkActions : DefaultEntityActions
{
	[Uid("4fb1ed75-1b50-4fb3-99a2-3d7a7dad3311")]
	[DisplayName(typeof(__Resources_DocumentLinkActions), "P_UserCreate_DisplayName")]
	[Image(typeof(DocumentLinkActions), "add_outline", 16, ImageFormatType.IconPack, false)]
	public const string UserCreate = "4fb1ed75-1b50-4fb3-99a2-3d7a7dad3311";

	private static Guid _userCreateGuid = new Guid("4fb1ed75-1b50-4fb3-99a2-3d7a7dad3311");

	[Uid("e3e42d80-cc74-4d71-b162-80c3e8a2dca2")]
	[DisplayName(typeof(__Resources_DocumentLinkActions), "P_UserDelete_DisplayName")]
	[Image(typeof(DocumentLinkActions), "basket", 16, ImageFormatType.IconPack, false)]
	public const string UserDelete = "e3e42d80-cc74-4d71-b162-80c3e8a2dca2";

	private static Guid _userDeleteGuid = new Guid("e3e42d80-cc74-4d71-b162-80c3e8a2dca2");

	[Uid("7e34c261-b319-4414-97fc-f21ee2350009")]
	[DisplayName(typeof(__Resources_DocumentLinkActions), "P_UserEdit_DisplayName")]
	[Image(typeof(DocumentLinkActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string UserEdit = "7e34c261-b319-4414-97fc-f21ee2350009";

	private static Guid _userEditGuid = new Guid("7e34c261-b319-4414-97fc-f21ee2350009");

	public static Guid UserCreateGuid => _userCreateGuid;

	public static Guid UserDeleteGuid => _userDeleteGuid;

	public static Guid UserEditGuid => _userEditGuid;

	protected DocumentLinkActions()
	{
	}
}
