using System.Configuration;

namespace Orchard.Environment.Configuration;

public class AppConfigurationAccessor : IAppConfigurationAccessor, IDependency
{
	private readonly ShellSettings _shellSettings;

	public AppConfigurationAccessor(ShellSettings shellSettings)
	{
		_shellSettings = shellSettings;
	}

	public string GetConfiguration(string name)
	{
		string name2 = $"{_shellSettings.Name}:{name}";
		string text = ConfigurationManager.AppSettings[name2] ?? ConfigurationManager.AppSettings[name];
		if (text != null)
		{
			return text;
		}
		ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[name2] ?? ConfigurationManager.ConnectionStrings[name];
		if (connectionStringSettings != null)
		{
			return connectionStringSettings.ConnectionString;
		}
		return string.Empty;
	}
}
