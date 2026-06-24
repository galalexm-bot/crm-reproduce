using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy;

internal interface IConfigurationTesterInternal : IConfigurationTester
{
	string AppId { get; }

	event Action<TestImportMessages> BeforeAddTestMessage;

	List<DeploySystemMessage> GetTestSystemMessages();
}
