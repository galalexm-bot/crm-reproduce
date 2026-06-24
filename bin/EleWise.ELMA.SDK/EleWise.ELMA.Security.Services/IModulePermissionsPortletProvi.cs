namespace EleWise.ELMA.Security.Services;

public interface IModulePermissionsPortletProvider : IModuleSettingsPageProvider
{
	bool UseOnPortlet { get; }
}
