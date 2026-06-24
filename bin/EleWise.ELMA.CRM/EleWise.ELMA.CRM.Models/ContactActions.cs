using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class ContactActions : DefaultEntityActions
{
	[Uid("84e21e1c-9805-4f6b-b919-8dcc049366c9")]
	[DisplayName(typeof(__Resources_ContactActions), "P_AddComment_DisplayName")]
	[Image(typeof(ContactActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "84e21e1c-9805-4f6b-b919-8dcc049366c9";

	private static Guid _addCommentGuid = new Guid("84e21e1c-9805-4f6b-b919-8dcc049366c9");

	public static Guid AddCommentGuid => _addCommentGuid;

	protected ContactActions()
	{
	}
}
