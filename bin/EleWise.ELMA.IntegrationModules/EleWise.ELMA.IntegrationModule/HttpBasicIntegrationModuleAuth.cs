using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Authentication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.IntegrationModules.Components;

[Component]
internal class HttpBasicIntegrationModuleAuthenticationBase : IIntegrationModuleAuthentication
{
	public static Guid Uid = new Guid("4BFF139A-F088-494D-A517-EE7E179767E8");

	private readonly Guid urlPropertyUid = new Guid("A3527DB9-DB37-4E35-9D49-74B5528F7710");

	private const string UrlPropertyName = "Url";

	private readonly Guid methodPropertyUid = new Guid("FA151A0B-8215-4813-87C5-D5EA315F2E52");

	private const string MethodPropertyName = "AuthMethod";

	public Guid Guid => Uid;

	public IntegrationModuleType? IntergrationType => IntegrationModuleType.RestAPI;

	public Type AuthenticationObjectType => typeof(WebRequest);

	public string DisplayName => SR.T("Basic");

	public IEnumerable<KeyValuePair<Guid, string>> AuthenticationSubTypes => null;

	public bool SubTypeRequired => false;

	public List<PropertyMetadata> AuthenticationProperties()
	{
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		list.Add(CreateProperty(urlPropertyUid, "Url", SR.T("Url"), required: true));
		list.Add(CreateProperty(IntegrationsConstants.LoginPropertyUid, "UserName", SR.T("Имя пользователя")));
		list.Add(CreateProperty(IntegrationsConstants.PasswordPropertyUid, "Password", SR.T("Пароль")));
		if (MetadataLoader.LoadMetadata(typeof(BasicAuthenticationMethod)) is EnumMetadata enumMetadata)
		{
			EntityPropertyMetadata entityPropertyMetadata = CreateProperty(methodPropertyUid, "AuthMethod", SR.T("Метод аутентификации"));
			entityPropertyMetadata.TypeUid = EnumDescriptor.UID;
			entityPropertyMetadata.SubTypeUid = enumMetadata.Uid;
			entityPropertyMetadata.Settings = new EnumSettings
			{
				FieldName = "AuthMethod"
			};
			list.Add(entityPropertyMetadata);
		}
		return list;
	}

	public void BeforeAuthentication(IIntegrationModule integration, object authObject)
	{
	}

	public object CreateAuthenticationObject(IIntegrationModule integration, string error)
	{
		Type type = integration.GetType();
		object value = type.GetProperty("Url").GetValue(integration);
		if (value != null)
		{
			object value2 = type.GetProperty("UserName").GetValue(integration);
			object value3 = type.GetProperty("Password").GetValue(integration);
			try
			{
				return new HttpClient(new UriBuilder(value.ToString())
				{
					UserName = ((value2 != null) ? value2.ToString() : ""),
					Password = ((value3 != null) ? value3.ToString() : "")
				}.Uri);
			}
			catch (Exception innerException)
			{
				throw new AuthenticationException(SR.T("Невозможно создать экземпляр подключения"), innerException);
			}
		}
		throw new AuthenticationException(error + SR.T("Невозможно создать экземпляр подключения, не указан Url подключения"));
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
		if (!(authObject is HttpClient httpClient))
		{
			throw new AuthenticationException(SR.T("Ошибка получения ответа аутентификации. Не удалось создать клиента аутентификации"));
		}
		Type type = integration.GetType();
		object value = type.GetProperty("Url").GetValue(integration);
		object value2 = type.GetProperty("AuthMethod").GetValue(integration);
		try
		{
			if (value2 != null && Enum.TryParse<BasicAuthenticationMethod>(value2.ToString(), out var result) && result == BasicAuthenticationMethod.GET)
			{
				return httpClient.Get(value.ToString(), null);
			}
			return httpClient.Post(value.ToString());
		}
		catch (Exception innerException)
		{
			throw new AuthenticationException(SR.T("Ошибка выполнения запроса аутентификации"), innerException);
		}
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
