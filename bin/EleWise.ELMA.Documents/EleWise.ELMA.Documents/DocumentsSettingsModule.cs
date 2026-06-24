using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
public class DocumentsSettingsModule : GlobalSettingsModuleBase<DocumentsSettings>
{
	public override string ModuleNamespace => "EleWise.ELMA.Documents";

	public override Guid ModuleGuid => __AssemblyInfo.UID;

	public override string ModuleName => SR.T("Документы");

	public override Permission AdminPermission => PermissionProvider.DocumentsAdminAccessPermission;
}
