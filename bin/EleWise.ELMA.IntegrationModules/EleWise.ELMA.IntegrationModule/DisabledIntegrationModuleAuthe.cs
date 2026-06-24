using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Components;

[Component]
internal class DisabledIntegrationModuleAuthentication : IIntegrationModuleAuthentication
{
	public Guid Guid => IntegrationsConstants.DisabledIntegrationModuleAuthenticationUid;

	public IntegrationModuleType? IntergrationType => null;

	public string DisplayName => SR.T("Без аутентификации");

	public IEnumerable<KeyValuePair<Guid, string>> AuthenticationSubTypes => null;

	public bool SubTypeRequired => false;

	public void AfterAuthentication(IIntegrationModule integration, object authObject, object authResponse)
	{
	}

	public List<PropertyMetadata> AuthenticationProperties()
	{
		return new List<PropertyMetadata>();
	}

	public void BeforeAuthentication(IIntegrationModule integration, object authObject)
	{
	}

	public object CreateAuthenticationObject(IIntegrationModule integration, string error)
	{
		return null;
	}

	public object GetAuthenticationResponse(IIntegrationModule integration, object authObject, string error)
	{
		return null;
	}
}
