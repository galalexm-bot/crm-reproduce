using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.IntegrationModules.Scripts.Types;

[Component]
internal sealed class IntegrationModuleActivityScriptType : ScriptType
{
	public const string UID_S = "{F0C64398-1918-4366-9B6C-5E87FDB808B1}";

	public static readonly Guid UID = new Guid("{F0C64398-1918-4366-9B6C-5E87FDB808B1}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Сценарий активити модуля интеграции");

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
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.AuthenticationParamName, "object", SR.T("Объект аутентификации")));
		return obj;
	}
}
