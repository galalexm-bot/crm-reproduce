using System;
using System.Collections.Generic;
using System.Reflection;
using System.ServiceModel.Description;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.IntegrationModules.Components;

[Component]
internal class BasicSoapIntegrationModuleAuthentication : IIntegrationModuleAuthentication, IClientCredentialsDataFiller
{
	public static Guid Uid = new Guid("609fd022-a0ca-4795-a5ae-f3b341876c8f");

	public Guid Guid => Uid;

	public IntegrationModuleType? IntergrationType => IntegrationModuleType.SOAPAPI;

	public string DisplayName => SR.T("Basic");

	public IEnumerable<KeyValuePair<Guid, string>> AuthenticationSubTypes => null;

	public bool SubTypeRequired => false;

	public List<PropertyMetadata> AuthenticationProperties()
	{
		return new List<PropertyMetadata>
		{
			CreateProperty(IntegrationsConstants.LoginPropertyUid, "UserName", SR.T("Имя пользователя")),
			CreateProperty(IntegrationsConstants.PasswordPropertyUid, "Password", SR.T("Пароль"))
		};
	}

	public IAuthenticationDataFillingResult FillInAuthenticationData(ClientCredentials credentials, IIntegrationModule integration)
	{
		if (integration == null)
		{
			return new AuthenticationDataFillingResult(success: false);
		}
		Type type = integration.GetType();
		PropertyInfo property = type.GetProperty("UserName");
		PropertyInfo property2 = type.GetProperty("Password");
		if (property != null && property2 != null)
		{
			object value = property.GetValue(integration);
			if (value != null)
			{
				credentials.UserName.UserName = value.ToString();
				object value2 = property2.GetValue(integration);
				credentials.UserName.Password = ((value2 == null) ? null : property2.ToString());
				return new AuthenticationDataFillingResult(success: true);
			}
		}
		return new AuthenticationDataFillingResult(success: false);
	}

	public void AfterAuthentication(IIntegrationModule integration, object authObject, object authResponse)
	{
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

	private EntityPropertyMetadata CreateProperty(Guid uid, string name, string displayName, bool required = false)
	{
		EntityPropertyMetadata entityPropertyMetadata = new EntityPropertyMetadata();
		entityPropertyMetadata.InitNew();
		entityPropertyMetadata.Uid = uid;
		entityPropertyMetadata.IsSystem = true;
		entityPropertyMetadata.Name = name;
		entityPropertyMetadata.DisplayName = displayName;
		entityPropertyMetadata.TypeUid = StringDescriptor.UID;
		entityPropertyMetadata.Settings = new StringSettings
		{
			FieldName = name
		};
		entityPropertyMetadata.Required = required;
		entityPropertyMetadata.ViewSettings = new PropertyViewSettings();
		return entityPropertyMetadata;
	}
}
