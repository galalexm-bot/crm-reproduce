using System;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.IntegrationModules.CodeGeneration;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[Serializable]
[XmlRoot("IntegrationModuleActivityMetadata")]
public class IntegrationModuleActivityMetadata : EntityMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		public string Name => SR.T("Плагин модуля интеграции");

		public string Description => SR.T("Плагин модуля интеграции с привязкой к базе данных");

		public Type MetadataType => typeof(IntegrationModuleActivityMetadata);

		public Type GeneratorType => typeof(IntegrationModuleActivityGenerator);
	}

	private const string MetadataNamespace = "EleWise.ELMA.IntegrationModules.Activity";

	[XmlElement("OnEnterScript")]
	public string OnEnterScript { get; set; }

	[XmlElement("OnCompleteScript")]
	public string OnCompleteScript { get; set; }

	[XmlElement("OnEnter")]
	public bool OnEnter { get; set; }

	[XmlElement("OnComplete")]
	public bool OnComplete { get; set; }

	public IntegrationModuleActivityMetadata()
	{
		BaseClassUid = InterfaceActivator.UID(typeof(IIntegrationModuleActivity), loadImplementation: false);
		ShowInCatalogList = false;
		ShowInDesigner = false;
		ShowInTypeTree = true;
		Namespace = "EleWise.ELMA.IntegrationModules.Activity";
	}

	public override void InitNew()
	{
		InitNew("");
	}

	public void InitNew(string prefix)
	{
		base.InitNew();
		OnEnter = true;
		if (!string.IsNullOrWhiteSpace(prefix))
		{
			Name = (string.IsNullOrWhiteSpace(prefix) ? "" : (prefix + "_"));
			TableName = Name;
		}
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		base.LoadFromType(type, inherit);
		IntegrationModuleScriptSettingsAttribute integrationModuleScriptSettingsAttribute = (IntegrationModuleScriptSettingsAttribute)type.GetCustomAttributes(typeof(IntegrationModuleScriptSettingsAttribute), inherit: false).FirstOrDefault();
		if (integrationModuleScriptSettingsAttribute != null)
		{
			OnEnterScript = integrationModuleScriptSettingsAttribute.OnEnterScript;
			OnCompleteScript = integrationModuleScriptSettingsAttribute.OnCompleteScript;
			OnEnter = integrationModuleScriptSettingsAttribute.OnEnterExecute;
			OnComplete = integrationModuleScriptSettingsAttribute.OnCompleteExecute;
		}
	}
}
