using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.TestFramework.Core;

internal interface ITestAssembly
{
	Assembly Assembly { get; }

	string Name { get; }

	System.Collections.Generic.IEnumerable<ITestFixture> TestFixtures { get; set; }
}
