using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.TestFramework.Core;
using EleWise.ELMA.TestFramework.Notification;

namespace EleWise.ELMA.TestFramework;

[ServiceContract]
internal interface ITestController
{
	void RunTests();

	void RunComponentTests(Guid componentUid, ITestNotifier testNotifier = null);

	System.Threading.Tasks.Task<ComponentTestFixtureTree> LoadComponentTests();

	System.Threading.Tasks.Task RunComponentTests(ITestNotifier testNotifier);
}
