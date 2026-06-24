using EleWise.ELMA.Security;

namespace EleWise.ELMA.Runtime.Settings;

public interface IGlobalSettingsModulePermission
{
	Permission AdminPermission { get; }
}
