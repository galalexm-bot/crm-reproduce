using System.CodeDom;
using System.Reflection;

namespace Orchard.Environment;

public interface IAssemblyBuilder
{
	void AddCodeCompileUnit(CodeCompileUnit compileUnit);

	void AddAssemblyReference(Assembly assembly);
}
