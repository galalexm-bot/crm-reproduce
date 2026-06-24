using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.IntegrationModules.Scripts.Types;

[Component]
internal sealed class IntegrationModuleActivityOnCompleteScriptType : ScriptType
{
	public const string UID_S = "{FD58CE46-3833-4BC9-9CEA-4CBCD411BD5A}";

	public static readonly Guid UID = new Guid("{FD58CE46-3833-4BC9-9CEA-4CBCD411BD5A}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Сценарий завершения активити модуля интеграции");

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration obj = new ScriptMethodDeclaration
		{
			Name = name
		};
		EntityMetadata entityMetadata = generationParams.FirstOrDefault((KeyValuePair<string, object> a) => a.Key == IntegrationsConstants.IntegrationParamName).Value as EntityMetadata;
		EntityMetadata entityMetadata2 = generationParams.FirstOrDefault((KeyValuePair<string, object> a) => a.Key == IntegrationsConstants.ActivityParamName).Value as EntityMetadata;
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.IntegrationParamName, entityMetadata?.FullTypeName, SR.T("Экземпляр модуля интеграции")));
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.ActivityParamName, entityMetadata2?.FullTypeName, SR.T("Экземпляр активити")));
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.DataParamName, "object", SR.T("Данные выполнения")));
		return obj;
	}
}
