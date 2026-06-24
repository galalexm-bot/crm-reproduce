using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPhoneSettingsExtension
{
	bool IsReplacePhoneStringByLink();
}
