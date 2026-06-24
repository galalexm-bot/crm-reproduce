using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages;

[Component]
public class MessagesSettingsModule : GlobalSettingsModuleBase<MessagesSettings>
{
	public static Guid _ModuleGuid = new Guid("30429CD4-C1C9-4648-B2BA-5FCD83304EDE");

	public override Guid ModuleGuid => _ModuleGuid;

	public override string ModuleName => SR.T("Сообщения");

	public override Permission AdminPermission => PermissionProvider.ChannelManagmentPermission;
}
