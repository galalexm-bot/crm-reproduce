using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.TestFramework.Notification;

namespace EleWise.ELMA.TestFramework.Core;

[ServiceContract]
internal interface ITestRunner
{
	void Run(System.Collections.Generic.IEnumerable<ITestAssembly> testAssemblies);

	void Run(ITestAssembly testAssembly);

	void Run(System.Collections.Generic.IEnumerable<ITestFixture> testFixtures);

	void Run(ITestFixture testFixture, ITestNotifier testNotifier = null, Func<System.Threading.Tasks.Task> setup = null);

	void Run(ITestMethod test);
}
