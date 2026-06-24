using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Exceptions;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.OAuth.Client.Services;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.IntegrationModules.Components;

[Component]
internal class HttpOauthIntegrationModuleAuthentication : IIntegrationModuleAuthentication
{
	private readonly Guid guid = new Guid("{55D9C10D-E096-4262-BE73-512A7D0CADC5}");

	private readonly Guid tokenPropertyUid = new Guid("{04D42ACA-9911-456E-9882-055FD0885FDD}");

	private const string TokenPropertyName = "Token";

	private IEnumerable<IOauthApplicationProvider> oauthProviders;

	public Guid Guid => guid;

	public IntegrationModuleType? IntergrationType => IntegrationModuleType.RestAPI;

	public Type AuthenticationObjectType => typeof(WebRequest);

	public string DisplayName => "OAuth";

	public IEnumerable<KeyValuePair<Guid, string>> AuthenticationSubTypes => oauthProviders.Select((IOauthApplicationProvider a) => new KeyValuePair<Guid, string>(a.ProviderUid, a.ProviderName));

	public bool SubTypeRequired => true;

	public HttpOauthIntegrationModuleAuthentication(IEnumerable<IOauthApplicationProvider> oauthProviders)
	{
		this.oauthProviders = oauthProviders;
	}

	public List<PropertyMetadata> AuthenticationProperties()
	{
		return new List<PropertyMetadata> { CreateProperty(tokenPropertyUid, "Token", SR.T("Токен")) };
	}

	public void BeforeAuthentication(IIntegrationModule integration, object authObject)
	{
	}

	public object CreateAuthenticationObject(IIntegrationModule integration, string error)
	{
		return new HttpClient();
	}

	public virtual void AfterAuthentication(IIntegrationModule integration, object authObject, object authResponse)
	{
		if (!(authObject is HttpClient httpClient) || !(authResponse is HttpWebResponse httpWebResponse))
		{
			return;
		}
		using Stream stream = httpWebResponse.GetResponseStream();
		string input = new StreamReader(stream).ReadToEnd();
		foreach (KeyValuePair<string, string> item in new JsonSerializer().Deserialize<Dictionary<string, string>>(input))
		{
			if (httpClient.Headers.ContainsKey(item.Key))
			{
				if (item.Value != null)
				{
					httpClient.Headers[item.Key] = item.Value;
				}
				else
				{
					httpClient.Headers.Remove(item.Key);
				}
			}
			else if (item.Value != null)
			{
				httpClient.Headers.Add(item.Key, item.Value);
			}
		}
	}

	public object GetAuthenticationResponse(IIntegrationModule integration, object authObject, string error)
	{
		if (!(authObject is HttpClient authClient))
		{
			throw new AuthenticationException(SR.T("Ошибка получения ответа аутентификации. Не удалось создать клиента аутентификации"));
		}
		Type type = integration.GetType();
		IntegrationModuleMetadata integrationMetadata = MetadataLoader.LoadMetadata(type) as IntegrationModuleMetadata;
		if (integrationMetadata == null)
		{
			throw new AuthenticationException(error + SR.T("Невозможно создать экземпляр подключения, не найдены метаданные типа \"{0}\"") + type.FullName);
		}
		IOauthApplicationProvider obj = oauthProviders.FirstOrDefault(delegate(IOauthApplicationProvider a)
		{
			Guid providerUid = a.ProviderUid;
			Guid? authenticationSubTypeUid = integrationMetadata.AuthenticationSubTypeUid;
			return providerUid == authenticationSubTypeUid;
		}) ?? throw new AuthenticationException(error + SR.T("Невозможно создать экземпляр подключения, не определена реализация провайдера OAuth авторизации с идентификатором \"{0}\"") + integrationMetadata.AuthenticationSubTypeUid);
		string token = type.GetProperty("Token").GetValue(integration) as string;
		return obj.LogOnByAppKey(authClient, token);
	}

	private PropertyMetadata CreateProperty(Guid uid, string name, string displayName)
	{
		PropertyMetadata propertyMetadata = new PropertyMetadata();
		propertyMetadata.InitNew();
		propertyMetadata.Uid = uid;
		propertyMetadata.IsSystem = true;
		propertyMetadata.Name = name;
		propertyMetadata.DisplayName = displayName;
		propertyMetadata.TypeUid = StringDescriptor.UID;
		propertyMetadata.SubTypeUid = Guid.Empty;
		propertyMetadata.Settings = new StringSettings
		{
			FieldName = name
		};
		propertyMetadata.ViewSettings = new PropertyViewSettings();
		return propertyMetadata;
	}
}
