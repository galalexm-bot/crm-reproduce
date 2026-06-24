using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.Core;

internal interface ITestFixture
{
	string Name { get; }

	System.Type Type { get; }

	System.Collections.Generic.IEnumerable<ITestMethod> Tests { get; }

	Func<System.Threading.Tasks.Task> OneTimeSetUp { get; set; }

	MethodInfo SetUp { get; set; }

	MethodInfo TearDown { get; set; }

	object Instance { get; set; }

	TestFixtureResult Result { get; set; }

	bool Skip { get; }

	string SkipReason { get; }
}
