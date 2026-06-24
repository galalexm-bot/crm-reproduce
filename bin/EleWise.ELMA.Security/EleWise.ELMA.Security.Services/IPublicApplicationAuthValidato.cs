using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Services.API;

[ExtensionPoint(ComponentType.All)]
public interface IPublicApplicationAuthValidator
{
	string AppToken { get; }

	bool Validate(IUser user);
}
