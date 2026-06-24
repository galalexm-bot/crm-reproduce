using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.ExtensionPoint;

[ExtensionPoint(ComponentType.All)]
public interface IIntegrationModuleAuthentication
{
	Guid Guid { get; }

	IntegrationModuleType? IntergrationType { get; }

	string DisplayName { get; }

	IEnumerable<KeyValuePair<Guid, string>> AuthenticationSubTypes { get; }

	bool SubTypeRequired { get; }

	List<PropertyMetadata> AuthenticationProperties();

	void BeforeAuthentication(IIntegrationModule integration, object authObject);

	object CreateAuthenticationObject(IIntegrationModule integration, string error);

	object GetAuthenticationResponse(IIntegrationModule integration, object authObject, string error);

	void AfterAuthentication(IIntegrationModule integration, object authObject, object authResponse);
}
