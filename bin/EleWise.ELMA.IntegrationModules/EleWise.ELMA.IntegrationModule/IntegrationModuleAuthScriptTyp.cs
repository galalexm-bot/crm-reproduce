using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.IntegrationModules.Scripts.Types;

[Component]
internal sealed class IntegrationModuleAuthScriptType : ScriptType
{
	public const string UID_S = "{F9C13097-BEC4-447D-AB64-C9650C19FD4D}";

	public static readonly Guid UID = new Guid("{F9C13097-BEC4-447D-AB64-C9650C19FD4D}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Сценарий аутентификации модуля интеграции");

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration obj = new ScriptMethodDeclaration
		{
			Name = name
		};
		EntityMetadata entityMetadata = generationParams.FirstOrDefault((KeyValuePair<string, object> a) => a.Key == IntegrationsConstants.IntegrationParamName).Value as EntityMetadata;
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.IntegrationParamName, entityMetadata?.FullTypeName, SR.T("Экземпляр модуля интеграции")));
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.AuthenticationParamName, "object"));
		return obj;
	}
}
