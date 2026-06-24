using Orchard.Environment.Configuration;
using Orchard.Environment.ShellBuilders;

namespace Orchard.Environment;

public interface IOrchardHost
{
	void Initialize();

	void ReloadExtensions();

	void BeginRequest();

	void EndRequest();

	ShellContext GetShellContext(ShellSettings shellSettings);

	IWorkContextScope CreateStandaloneEnvironment(ShellSettings shellSettings);
}
