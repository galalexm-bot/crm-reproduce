using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.TestFramework.Core;

internal interface ITestAssemblyBuilder
{
	System.Collections.Generic.IEnumerable<ITestAssembly> Build(Assembly[] assemblies);

	ITestAssembly Build(Assembly assembly);
}
