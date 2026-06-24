using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.OAuth.Client.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IOauthApplicationProvider : IOAuthProvider
{
	object LogOnByAppKey(object authClient, string token);
}
