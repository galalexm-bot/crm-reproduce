using System;
using System.Collections.Generic;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;

namespace EleWise.ELMA.IntegrationModules.Services;

public interface IIntegrationModuleScriptingService
{
	IIntegrationModule CreateInstanceParameters(Guid integrationInstanceUid, Guid integrationHeaderUid);

	IIntegrationModuleActivity CreateActivityParameters(Guid activityTypeUid, Guid integrationHeaderUid);

	object ExecuteScript(IntegrationModuleMetadata integrationMetadata, string scriptName, object data, Dictionary<string, object> parameters);

	object ExecuteScript(IIntegrationModule instance, IIntegrationModuleActivity activityInstance, string scriptName, Dictionary<string, object> parameters, bool withAuth);
}
