namespace Orchard.Security;

public interface ISslSettingsProvider : IDependency
{
	bool GetRequiresSSL();
}
