using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.IntegrationModules.CodeGeneration;
using EleWise.ELMA.IntegrationModules.Components;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[Serializable]
[XmlRoot("IntegrationModule")]
public class IntegrationModuleMetadata : EntityMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		public string Name => SR.T("Модуль интеграции");

		public string Description => SR.T("Модуль интеграции с привязкой к базе данных");

		public Type MetadataType => typeof(IntegrationModuleMetadata);

		public Type GeneratorType => typeof(IntegrationModuleGenerator);
	}

	private const string MetadataNamespace = "EleWise.ELMA.IntegrationModules";

	public static readonly Guid IntegrationModuleMetadataUid = new Guid("{35fc5381-8e21-48db-a19e-6c64965d9dcf}");

	public const string IntegrationModuleMdUid = "{35fc5381-8e21-48db-a19e-6c64965d9dcf}";

	[XmlElement("Prefix")]
	public virtual string Prefix { get; set; }

	[XmlElement("Logging")]
	public virtual bool Logging { get; set; }

	[XmlElement("IntegrationModuleType")]
	public virtual IntegrationModuleType IntegrationModuleType { get; set; }

	[XmlElement("AuthenticationAttemptCount")]
	public virtual long AuthenticationAttemptCount { get; set; }

	[XmlElement("AuthenticationAttemptInterval")]
	public virtual long AuthenticationAttemptInterval { get; set; }

	[XmlElement("AuthenticationTypeUid")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual Guid AuthenticationTypeUid { get; set; }

	[XmlElement("AuthenticationSubTypeUid")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual Guid? AuthenticationSubTypeUid { get; set; }

	[XmlIgnore]
	public virtual long? Color { get; set; }

	[XmlElement("IntegrationModuleActivity")]
	public virtual List<Guid> IntegrationModuleActivity { get; set; }

	[XmlElement("ExternalEvents")]
	public virtual List<ExternalEvent> ExternalEvents { get; set; }

	[XmlElement("BeforeAuthenticationScriptName")]
	public virtual string BeforeAuthenticationScriptName { get; set; }

	[XmlElement("AfterAuthenticationScriptName")]
	public virtual string AfterAuthenticationScriptName { get; set; }

	public IntegrationModuleMetadata()
	{
		BaseClassUid = IntegrationModuleMetadataUid;
		IntegrationModuleActivity = new List<Guid>();
		ExternalEvents = new List<ExternalEvent>();
		ShowInCatalogList = false;
		ShowInDesigner = false;
		ShowInTypeTree = true;
		Namespace = "EleWise.ELMA.IntegrationModules";
	}

	public override void InitNew()
	{
		base.InitNew();
		AuthenticationTypeUid = HttpBasicIntegrationModuleAuthenticationBase.Uid;
		AuthenticationAttemptCount = IntegrationsConstants.DefaultAuthenticationAttemptCount;
		AuthenticationAttemptInterval = IntegrationsConstants.DefaultAuthenticationAttemptInterval;
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		base.LoadFromType(type, inherit);
		PrefixAttribute prefixAttribute = (PrefixAttribute)type.GetCustomAttributes(typeof(PrefixAttribute), inherit: false).FirstOrDefault();
		if (prefixAttribute != null)
		{
			Prefix = prefixAttribute.Value;
		}
		LoggingAttribute loggingAttribute = (LoggingAttribute)type.GetCustomAttributes(typeof(LoggingAttribute), inherit: false).FirstOrDefault();
		if (loggingAttribute != null)
		{
			Logging = loggingAttribute.Value;
		}
		IntegrationModuleTypeAttribute integrationModuleTypeAttribute = (IntegrationModuleTypeAttribute)type.GetCustomAttributes(typeof(IntegrationModuleTypeAttribute), inherit: false).FirstOrDefault();
		if (integrationModuleTypeAttribute != null)
		{
			IntegrationModuleType = integrationModuleTypeAttribute.Type;
		}
		AuthenticationSettingAttribute authenticationSettingAttribute = (AuthenticationSettingAttribute)type.GetCustomAttributes(typeof(AuthenticationSettingAttribute), inherit: false).FirstOrDefault();
		if (authenticationSettingAttribute != null)
		{
			AuthenticationTypeUid = authenticationSettingAttribute.AuthType;
			AuthenticationSubTypeUid = authenticationSettingAttribute.AuthSubType;
			AuthenticationAttemptInterval = authenticationSettingAttribute.AttemptInterval;
			AuthenticationAttemptCount = authenticationSettingAttribute.AttemptCount;
			BeforeAuthenticationScriptName = authenticationSettingAttribute.BeforeScriptName;
			AfterAuthenticationScriptName = authenticationSettingAttribute.AfterScriptName;
		}
		foreach (ExternalEventAttribute item in type.GetReflectionCustomAttributes(typeof(ExternalEventAttribute), inherit).Cast<ExternalEventAttribute>())
		{
			ExternalEvents.Add(new ExternalEvent
			{
				Name = item.Name,
				Uid = item.Uid,
				ScriptName = item.ScriptName,
				IntegrationModuleMetadata = this
			});
		}
		foreach (IntegrationModuleActivityAttribute item2 in type.GetReflectionCustomAttributes(typeof(IntegrationModuleActivityAttribute), inherit).Cast<IntegrationModuleActivityAttribute>())
		{
			IntegrationModuleActivity.Add(item2.Value);
		}
	}
}
