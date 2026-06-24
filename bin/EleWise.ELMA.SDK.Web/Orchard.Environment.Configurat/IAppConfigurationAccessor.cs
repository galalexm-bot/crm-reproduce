namespace Orchard.Environment.Configuration;

public interface IAppConfigurationAccessor : IDependency
{
	string GetConfiguration(string name);
}
