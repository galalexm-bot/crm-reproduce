using System.Reflection;

namespace Orchard.Environment;

public interface IAssemblyLoader
{
	Assembly Load(string assemblyName);
}
