using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.TestFramework.Core;

internal class TestAssemblyBuilder : ITestAssemblyBuilder
{
	public System.Collections.Generic.IEnumerable<ITestAssembly> Build(Assembly[] assemblies)
	{
		Contract.ArgumentNotNull(assemblies, "assemblies");
		List<ITestAssembly> val = new List<ITestAssembly>();
		foreach (Assembly val2 in assemblies)
		{
			if (AttributeHelper<ComponentAssemblyAttribute>.GetAttribute(val2) != null && val2.get_FullName().EndsWith(TestController.FrameworkConfig.TestAssemblyNamePattern))
			{
				ITestAssembly testAssembly = Build(val2);
				val.Add(testAssembly);
			}
		}
		return (System.Collections.Generic.IEnumerable<ITestAssembly>)val;
	}

	public ITestAssembly Build(Assembly assembly)
	{
		Contract.ArgumentNotNull(assembly, "assembly");
		TestAssembly testAssembly = new TestAssembly(assembly);
		System.Type[] types = assembly.GetTypes();
		testAssembly.TestFixtures = (System.Collections.Generic.IEnumerable<ITestFixture>)Build(types);
		return testAssembly;
	}

	private System.Collections.Generic.IList<ITestFixture> Build(System.Type[] types)
	{
		List<ITestFixture> val = new List<ITestFixture>();
		foreach (System.Type type in types)
		{
			TestFixtureAttribute attribute = AttributeHelper<TestFixtureAttribute>.GetAttribute(type, inherited: false);
			if (attribute != null)
			{
				TestFixture testFixture = new TestFixture(type, attribute.Name);
				val.Add((ITestFixture)testFixture);
			}
		}
		return (System.Collections.Generic.IList<ITestFixture>)val;
	}
}
