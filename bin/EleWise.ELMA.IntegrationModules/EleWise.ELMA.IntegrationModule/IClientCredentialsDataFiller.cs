using System;
using System.ServiceModel.Description;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Models;

namespace EleWise.ELMA.IntegrationModules.ExtensionPoint;

[ExtensionPoint(ComponentType.All)]
public interface IClientCredentialsDataFiller
{
	Guid Guid { get; }

	IntegrationModuleType? IntergrationType { get; }

	IAuthenticationDataFillingResult FillInAuthenticationData(ClientCredentials credentials, IIntegrationModule integration);
}
