using System;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal sealed class ChatActorEvents
{
	public static readonly string SendMessageEvent = "SendMessageEvent";

	public static readonly Guid AddChatParticipantUidEvent = new Guid("A18C155D-C0D0-4170-80DD-A75DC9018296");

	public static readonly Guid DeleteChatParticipantUidEvent = new Guid("B715F793-FEB4-4687-AE77-20A030AFF215");

	public static readonly Guid AddChatToChannelUidEvent = new Guid("FC11D2BD-3F34-4A3F-BB26-F5310EFF1534");

	public static readonly Guid DeleteChatFromChannelUidEvent = new Guid("9A523E47-9BF6-4B28-B191-4D245023D58B");

	public static readonly string UpdatedGroup = "UpdatedGroup";

	public static readonly string UpdatedOrgItem = "UpdatedOrgItem";

	public static readonly string AddedUser = "AddedUser";

	public static readonly string DeletedUser = "DeletedUser";

	public static readonly string AddedGroup = "AddedGroup";

	public static readonly string DeletedGroup = "DeletedGroup";

	public static readonly string AddedOrgItem = "AddedOrgItem";

	public static readonly string DeletedOrgItem = "DeletedOrgItem";

	public static readonly Guid AddUserToGroupUidEvent = new Guid("6BB990B6-6743-4E25-BF71-B0DB2EB17DBE");

	public static readonly Guid DeleteUserFromGroupUidEvent = new Guid("AC1D505D-A67C-4785-9D9B-62C3B4681960");

	public static readonly Guid AddGroupToGroupUidEvent = new Guid("D1DA5A56-A06B-40B3-A6C2-72320F26F32B");

	public static readonly Guid DeleteGroupFromGroupUidEvent = new Guid("8C919D01-E637-4BCB-A368-5B67C9EFD6D9");

	public static readonly Guid AddOrgItemToGroupUidEvent = new Guid("6073FEBD-93CD-449B-A10C-6FB9E0F0EE7C");

	public static readonly Guid DeleteOrgItemFromGroupUidEvent = new Guid("5FEAC29A-C3A1-45D7-AB18-1CCC30C1E0B6");

	public static readonly Guid AddUserToOrgItemUidEvent = new Guid("231961E8-4470-4E67-AC24-CC9A39F95DC4");

	public static readonly Guid DeleteUserFromOrgItemUidEvent = new Guid("7FC805EB-7A2C-4AE6-AA3E-7F31C8F375FA");

	public static readonly string UpdatedChannel = "UpdatedChannel";

	public static readonly Guid AddUserToChannelUidEvent = new Guid("46D556FE-3C48-4B2C-8D6D-C2403EE5ABE0");

	public static readonly Guid DeleteUserFromChannelUidEvent = new Guid("357605CE-DE76-45FF-B615-85F4BC83E5C8");

	public static readonly Guid AddGroupToChannelUidEvent = new Guid("4EFB2DC5-C275-4233-9A3C-0E01AD30A9FD");

	public static readonly Guid DeleteGroupFromChannelUidEvent = new Guid("787498BE-08EC-47D1-B898-A36F97B6D3A8");

	public static readonly Guid AddOrgItemToChannelUidEvent = new Guid("6DD8FAD3-0F46-4FC1-9327-9390E0B3279D");

	public static readonly Guid DeleteOrgItemFromChannelUidEvent = new Guid("9BC2E60F-455F-46E4-A8E7-94F6D7469155");
}
