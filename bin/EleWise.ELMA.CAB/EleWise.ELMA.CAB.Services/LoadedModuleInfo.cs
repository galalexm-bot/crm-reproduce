using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.CAB.Services;

public class LoadedModuleInfo
{
	private readonly Assembly assembly;

	private readonly List<string> dependencies;

	private readonly string name;

	private readonly List<string> roles;

	public Assembly Assembly => assembly;

	public string Name => name;

	public IList<string> Dependencies => dependencies.AsReadOnly();

	public IList<string> Roles => roles.AsReadOnly();

	public LoadedModuleInfo(Assembly assembly, string name, IEnumerable<string> roles, IEnumerable<string> dependencies)
	{
		this.assembly = assembly;
		this.name = name;
		this.roles = new List<string>();
		if (roles != null)
		{
			this.roles.AddRange(roles);
		}
		this.dependencies = new List<string>();
		if (dependencies != null)
		{
			this.dependencies.AddRange(dependencies);
		}
	}

	public LoadedModuleInfo(LoadedModuleInfo toCopy)
	{
		assembly = toCopy.assembly;
		name = toCopy.name;
		roles = new List<string>(toCopy.roles);
		dependencies = new List<string>(toCopy.dependencies);
	}
}
