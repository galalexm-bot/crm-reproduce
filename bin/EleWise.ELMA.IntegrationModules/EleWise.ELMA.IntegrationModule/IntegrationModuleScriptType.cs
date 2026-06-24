using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.IntegrationModules.Scripts.Types;

[Component]
internal sealed class IntegrationModuleScriptType : ScriptType
{
	private const string ReturnScriptType = "System.Collections.Generic.IEnumerable<Guid>";

	public const string UID_S = "{7625CEFE-9196-48D7-91F8-317B290C94F2}";

	public static readonly Guid UID = new Guid("{7625CEFE-9196-48D7-91F8-317B290C94F2}");

	protected override string ReturnType => "System.Collections.Generic.IEnumerable<Guid>";

	public override Guid Uid => UID;

	public override string Name => SR.T("Сценарий модуля интеграции");

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration obj = new ScriptMethodDeclaration
		{
			Name = name,
			ReturnType = ReturnType,
			Description = SR.T("Метод выполняющийся при поступлении внешнего события, возвращает ключ активити, которое нужно выполнить")
		};
		EntityMetadata entityMetadata = generationParams.FirstOrDefault((KeyValuePair<string, object> a) => a.Key == IntegrationsConstants.IntegrationParamName).Value as EntityMetadata;
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.IntegrationParamName, entityMetadata?.FullTypeName, SR.T("Экземпляр модуля интеграции")));
		obj.Parameters.Add(new ScriptMethodParameter(IntegrationsConstants.ExternalObjectParamName, typeof(object).FullName, SR.T("Данные запроса")));
		return obj;
	}
}
