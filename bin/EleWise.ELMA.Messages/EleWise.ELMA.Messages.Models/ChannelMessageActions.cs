using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

public class ChannelMessageActions : DefaultEntityActions
{
	[Uid("5d388b12-37e0-413b-b24b-d13cb57f4142")]
	[DisplayName(typeof(__Resources_ChannelMessageActions), "P_AddRecipients_DisplayName")]
	[Image(typeof(ChannelMessageActions), "relationship", 16, ImageFormatType.IconPack, false)]
	public const string AddRecipients = "5d388b12-37e0-413b-b24b-d13cb57f4142";

	private static Guid _addRecipientsGuid = new Guid("5d388b12-37e0-413b-b24b-d13cb57f4142");

	[Uid("aacb60f1-ba29-49a8-909b-ccbfa5bab433")]
	[DisplayName(typeof(__Resources_ChannelMessageActions), "P_CreateTestMessage_DisplayName")]
	[View(Visibility.Hidden)]
	public const string CreateTestMessage = "aacb60f1-ba29-49a8-909b-ccbfa5bab433";

	private static Guid createTestMessageGuid = new Guid("aacb60f1-ba29-49a8-909b-ccbfa5bab433");

	public static Guid AddRecipientsGuid => _addRecipientsGuid;

	public static Guid CreateTestMessageGuid => createTestMessageGuid;

	protected ChannelMessageActions()
	{
	}
}
