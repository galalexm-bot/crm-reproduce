using System.Web;
using Orchard.Environment.Configuration;

namespace Orchard.Environment;

public interface IRunningShellTable
{
	void Add(ShellSettings settings);

	void Remove(ShellSettings settings);

	void Update(ShellSettings settings);

	ShellSettings Match(HttpContextBase httpContext);

	ShellSettings Match(string host, string appRelativeCurrentExecutionFilePath);
}
