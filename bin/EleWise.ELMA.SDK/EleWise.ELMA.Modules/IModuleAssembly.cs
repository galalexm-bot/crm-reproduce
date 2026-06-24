using System.Reflection;

namespace EleWise.ELMA.Modules;

public interface IModuleAssembly : IApplicationUnit
{
	Assembly Assembly { get; }
}
