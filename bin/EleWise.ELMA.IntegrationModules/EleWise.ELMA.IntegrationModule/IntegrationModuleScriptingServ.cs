using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services.Scope;

namespace EleWise.ELMA.IntegrationModules.Services;

[Service]
internal class IntegrationModuleScriptingService : IIntegrationModuleScriptingService
{
	private static readonly ILogger IntegrationLogger = Logger.GetLogger("IntegrationModules");

	private IMetadataRuntimeService metadataRuntimeService;

	private MetadataItemHeaderManager metadataItemHeaderManager;

	private IExecutionScopeFactory executionScopeFactory;

	private IEnumerable<IIntegrationModuleAuthentication> integrationModuleAuthentication;

	private IntegrationModuleManager integrationModuleManager;

	private Func<string, Type> getTypeFunc = MetadataLoader.UseCachingForFunc((string s) => GetType(s));

	public IntegrationModuleScriptingService(IMetadataRuntimeService metadataRuntimeService, MetadataItemHeaderManager metadataItemHeaderManager, IExecutionScopeFactory executionScopeFactory, IEnumerable<IIntegrationModuleAuthentication> integrationModuleAuthentication, IntegrationModuleManager integrationModuleManager)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.executionScopeFactory = executionScopeFactory;
		this.integrationModuleAuthentication = integrationModuleAuthentication;
		this.integrationModuleManager = integrationModuleManager;
	}

	public IIntegrationModuleActivity CreateActivityParameters(Guid activityTypeUid, Guid integrationHeaderUid)
	{
		IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(integrationHeaderUid);
		Contract.ArgumentNotNull(metadataItemHeader, "moduleHeader");
		Contract.ArgumentNotNull(metadataItemHeader.Current, "Published");
		if (!(metadataItemHeader.Published.Metadata is IntegrationModuleMetadata integrationModuleMetadata))
		{
			string message = SR.T("Ошибка создания экземпляра параметров активити. Не найдены опубликованные метаданные интеграции с идентификатором {0}", integrationHeaderUid);
			IntegrationLogger.Error(message);
			throw new ScriptExecuteException(message);
		}
		Guid uid = integrationModuleMetadata.IntegrationModuleActivity.FirstOrDefault((Guid a) => a == activityTypeUid);
		Type typeByUid = metadataRuntimeService.GetTypeByUid(activityTypeUid);
		if (typeByUid == null)
		{
			string message2 = SR.T("Ошибка создания экземпляра параметров активити. Не найден тип с идентификатором {0}", activityTypeUid);
			IntegrationLogger.Error(message2);
			throw new ScriptExecuteException(message2);
		}
		try
		{
			IMetadataItemHeader metadataItemHeader2 = metadataItemHeaderManager.LoadOrNull(uid);
			if (metadataItemHeader2 == null)
			{
				string message3 = SR.T("Ошибка создания экземпляра параметров активити. Не найдены опубликованные метаданные активити интеграции с идентификатором {0}", integrationHeaderUid);
				IntegrationLogger.Error(message3);
				throw new ScriptExecuteException(message3);
			}
			IIntegrationModuleActivity integrationModuleActivity = InterfaceActivator.Create(typeByUid) as IIntegrationModuleActivity;
			integrationModuleActivity.Name = metadataItemHeader2.DisplayName;
			integrationModuleActivity.Actyivitykey = Guid.NewGuid();
			return integrationModuleActivity;
		}
		catch (Exception innerException)
		{
			throw new ScriptExecuteException(SR.T("Не удалось создать экземпляр метода параметров"), innerException);
		}
	}

	public IIntegrationModule CreateInstanceParameters(Guid integrationInstanceUid, Guid integrationTypeUid)
	{
		IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(integrationTypeUid);
		Contract.ArgumentNotNull(metadataItemHeader, "moduleHeader");
		Contract.ArgumentNotNull(metadataItemHeader.Published, "Published");
		IntegrationModuleMetadata integrationModuleMetadata = metadataItemHeader.Current.Metadata as IntegrationModuleMetadata;
		Type typeByUid = metadataRuntimeService.GetTypeByUid(integrationModuleMetadata.Uid);
		IIntegrationModule integrationModule = (IIntegrationModule)ModelHelper.GetEntityManager(typeByUid).Load(integrationInstanceUid);
		if (integrationModule == null || !integrationModule.IsTemplate)
		{
			return integrationModule;
		}
		IIntegrationModule integrationModule2 = InterfaceActivator.Create(typeByUid) as IIntegrationModule;
		integrationModuleManager.CopyFromTemplate(integrationModule, integrationModule2);
		return integrationModule2;
	}

	public object ExecuteScript(IntegrationModuleMetadata integrationMetadata, string scriptName, object data, Dictionary<string, object> parameters)
	{
		if (string.IsNullOrWhiteSpace(scriptName))
		{
			return null;
		}
		string text = SR.T("Ошибка исполнения сценария \"{0}\" в интеграции \"{1}\"", scriptName, integrationMetadata.DisplayName);
		Type scriptModuleType = GetScriptModuleType(integrationMetadata);
		object scriptInstance = CreateScriptInstance(scriptModuleType, text);
		MethodInfo methodInfo = GetMethodInfo(text, scriptModuleType, scriptName, throwOnNotFound: true);
		if (methodInfo == null)
		{
			return null;
		}
		try
		{
			parameters = parameters ?? new Dictionary<string, object>();
			parameters.Add(IntegrationsConstants.ExternalObjectParamName, data);
			return ExecuteScript(text, methodInfo, scriptInstance, parameters, null, null, null, null);
		}
		catch (ScriptExecuteException ex)
		{
			IntegrationLogger.ErrorFormat(text, ex);
			throw ex;
		}
	}

	public object ExecuteScript(IIntegrationModule integration, IIntegrationModuleActivity activityInstance, string scriptName, Dictionary<string, object> parameters, bool withAuth)
	{
		if (string.IsNullOrWhiteSpace(scriptName))
		{
			return null;
		}
		Contract.ArgumentNotNull(integration, "integration");
		Contract.ArgumentNotNull(activityInstance, "activityInstance");
		IntegrationModuleMetadata integrationMetadata = MetadataLoader.LoadMetadata(integration.CastAsRealType().GetType()) as IntegrationModuleMetadata;
		if (integrationMetadata == null)
		{
			string message = SR.T("Не найдены метаданные модуля интеграции с типом \"{0}\"", integration.GetType().Name);
			Logger.Log.Error(message);
			throw new Exception(message);
		}
		IntegrationModuleActivityMetadata integrationModuleActivityMetadata = MetadataLoader.LoadMetadata(activityInstance.CastAsRealType().GetType()) as IntegrationModuleActivityMetadata;
		if (integrationMetadata == null)
		{
			string message2 = SR.T("Не найдены метаданные активити модуля интеграции с типом \"{0}\"", activityInstance.GetType().Name);
			Logger.Log.Error(message2);
			throw new Exception(message2);
		}
		string text = SR.T("Ошибка исполнения сценария \"{0}\" в активити \"{1}\" (Модуль интеграции: {2}; Идентификатор: {3}){4}", scriptName, integrationModuleActivityMetadata.DisplayName, integrationMetadata.DisplayName, integration.GetId(), ". ");
		IIntegrationModuleAuthentication integrationModuleAuthentication = this.integrationModuleAuthentication.FirstOrDefault((IIntegrationModuleAuthentication a) => a.Guid == integrationMetadata.AuthenticationTypeUid);
		if (integrationModuleAuthentication == null)
		{
			Logger.Log.Error(SR.T("{0}Не указан тип аутентификации модуля интеграции", text));
		}
		object authObject = null;
		if (withAuth)
		{
			try
			{
				authObject = Authenticate(integrationModuleAuthentication, integrationMetadata, integration, text);
			}
			catch (ScriptExecuteException ex)
			{
				AddError(integrationMetadata, integration, ex.Message, scriptName, isAuthError: true);
				throw ex;
			}
			catch (AuthenticationException ex2)
			{
				AddError(integrationMetadata, integration, ex2.Message, scriptName, isAuthError: true);
				throw ex2;
			}
			catch (Exception ex3)
			{
				AddError(integrationMetadata, integration, ex3.Message, scriptName, isAuthError: true);
			}
		}
		Type scriptModuleType = GetScriptModuleType(integrationModuleActivityMetadata);
		object scriptInstance = CreateScriptInstance(scriptModuleType, text);
		MethodInfo methodInfo = GetMethodInfo(text, scriptModuleType, scriptName, throwOnNotFound: true);
		if (methodInfo == null)
		{
			AddError(integrationMetadata, integration, SR.T("Сценарий не найден"), scriptName, isAuthError: false);
			return null;
		}
		object obj = null;
		try
		{
			return ExecuteScript(text, methodInfo, scriptInstance, parameters, integration, activityInstance, authObject, null);
		}
		catch (ScriptExecuteException ex4)
		{
			AddError(integrationMetadata, integration, ex4.Message, scriptName, isAuthError: false);
			throw ex4;
		}
	}

	private void AddError(IntegrationModuleMetadata metadata, IIntegrationModule integration, string errorText, string scriptName, bool isAuthError)
	{
		if (metadata.Logging)
		{
			if (isAuthError)
			{
				integration.AuthAttempt++;
				integration.Error += SR.T("{0}{1} Ошибка выполнения аутентификации: {2}", string.IsNullOrWhiteSpace(integration.Error) ? "" : Environment.NewLine, DateTime.Now.ToString("g"), errorText);
			}
			else
			{
				integration.Error += SR.T("{0}{1} Ошибка выполнения сценария \"{2}\" : {3}", string.IsNullOrWhiteSpace(integration.Error) ? "" : Environment.NewLine, DateTime.Now.ToString("g"), scriptName, errorText);
			}
		}
	}

	private object CreateScriptInstance(Type scriptType, string error)
	{
		object obj = null;
		try
		{
			using IExecutionScope executionScope = executionScopeFactory.CreateScope().AddRegistration(scriptType).StartScope();
			return executionScope.Resolve(scriptType);
		}
		catch (Exception ex)
		{
			string text = SR.T("Не удалось создать экземпляр метода сценариев");
			IntegrationLogger.ErrorFormat(error + text, ex);
			throw new ScriptExecuteException(error + text, ex);
		}
	}

	private Type GetScriptModuleType(ClassMetadata metadata)
	{
		if (!string.IsNullOrEmpty(metadata.ScriptModuleTypeName))
		{
			Type type = getTypeFunc(metadata.ScriptModuleTypeName);
			if (type == null)
			{
				throw new ScriptExecuteException(SR.T("Не найден тип \"{0}\"", metadata.ScriptModuleTypeName));
			}
			return type;
		}
		return null;
	}

	private static Type GetType(string scriptModuleTypeName)
	{
		int num = scriptModuleTypeName.IndexOf(",");
		if (num > 0)
		{
			try
			{
				if (new AssemblyName(scriptModuleTypeName.Substring(num + 1)).Name == "EleWise.ELMA.ConfigurationModel.Scripts")
				{
					return ComponentManager.FindLoadedAssembly("EleWise.ELMA.ConfigurationModel.Scripts", isFullName: false).GetType(scriptModuleTypeName.Remove(num));
				}
			}
			catch
			{
			}
		}
		return Type.GetType(scriptModuleTypeName);
	}

	private MethodInfo GetMethodInfo(string errorTitle, Type type, string scriptName, bool throwOnNotFound)
	{
		MethodInfo methodInfo = null;
		try
		{
			string text = scriptName.Split(new string[1] { " - " }, StringSplitOptions.None).First();
			if (!text.Contains("("))
			{
				methodInfo = type.GetMethod(text) ?? type.GetMethods().FirstOrDefault((MethodInfo a) => a.Name.ToLower() == scriptName.ToLower());
			}
			else
			{
				string text2 = text.Substring(text.IndexOf('(') + 1).Replace(")", "");
				List<string> parametersList = text2.Split(new string[1] { ", " }, StringSplitOptions.None).ToList();
				foreach (MethodInfo item in (from q in type.GetMethods().ToList()
					where q.GetParameters().Count() == parametersList.Count
					select q).ToList())
				{
					List<string> values = item.GetParameters().Select(delegate(ParameterInfo q)
					{
						string typeInfo = GetTypeInfo(q.ParameterType);
						return typeInfo.Substring(1, typeInfo.Length - 2);
					}).ToList();
					if (!(string.Format("{0}({1})", item.Name, string.Join(", ", values)) != text))
					{
						methodInfo = item;
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			string text3 = SR.T("Не удалось получить информацию о методе сценария: {0}", scriptName);
			IntegrationLogger.ErrorFormat(errorTitle + text3, ex);
			throw new ScriptExecuteException(errorTitle + text3, ex);
		}
		if (methodInfo != null)
		{
			return methodInfo;
		}
		string text4 = errorTitle + SR.T("Не найден метод сценария: {0}", scriptName);
		if (throwOnNotFound)
		{
			IntegrationLogger.ErrorFormat(errorTitle + text4);
			throw new ScriptExecuteException(text4);
		}
		IntegrationLogger.Warn(text4);
		return null;
	}

	private string GetTypeInfo(Type type)
	{
		if (type.IsGenericType)
		{
			List<string> list = new List<string>();
			Type[] genericArguments = type.GetGenericArguments();
			foreach (Type type2 in genericArguments)
			{
				list.Add(GetTypeInfo(type2));
			}
			string arg = string.Join(",", list);
			return $"[{type.Namespace}.{type.Name}[{arg}]]";
		}
		return $"[{type.Namespace}.{type.Name}]";
	}

	private object Authenticate(IIntegrationModuleAuthentication integrationModuleAuthentication, IntegrationModuleMetadata integrationMetadata, IIntegrationModule integration, string error)
	{
		Contract.ArgumentNotNull(integrationModuleAuthentication, "integrationModuleAuthentication");
		Contract.ArgumentNotNull(integrationMetadata, "integrationMetadata");
		object obj = integrationModuleAuthentication.CreateAuthenticationObject(integration, error);
		Type type = null;
		object obj2 = null;
		if (!string.IsNullOrEmpty(integrationMetadata.BeforeAuthenticationScriptName))
		{
			type = GetScriptModuleType(integrationMetadata);
			obj2 = CreateScriptInstance(type, error);
			MethodInfo methodInfo = GetMethodInfo(error, type, integrationMetadata.BeforeAuthenticationScriptName, throwOnNotFound: true);
			ExecuteScript(error, methodInfo, obj2, null, integration, null, obj, null);
		}
		else
		{
			integrationModuleAuthentication.BeforeAuthentication(integration, obj);
		}
		object authenticationResponse = integrationModuleAuthentication.GetAuthenticationResponse(integration, obj, error);
		if (!string.IsNullOrEmpty(integrationMetadata.AfterAuthenticationScriptName))
		{
			if (type == null)
			{
				type = GetScriptModuleType(integrationMetadata);
			}
			if (obj2 == null)
			{
				obj2 = CreateScriptInstance(type, error);
			}
			MethodInfo methodInfo2 = GetMethodInfo(error, type, integrationMetadata.AfterAuthenticationScriptName, throwOnNotFound: true);
			ExecuteScript(error, methodInfo2, obj2, null, integration, null, obj, authenticationResponse);
		}
		else
		{
			integrationModuleAuthentication.AfterAuthentication(integration, obj, authenticationResponse);
		}
		if (authenticationResponse is IDisposable disposable)
		{
			disposable.Dispose();
		}
		return obj;
	}

	private static object ExecuteScript(string errorTitle, MethodInfo methodInfo, object scriptInstance, Dictionary<string, object> parameters, IIntegrationModule integration, IIntegrationModuleActivity activity, object authObject, object authResponse)
	{
		parameters = parameters ?? new Dictionary<string, object>();
		if (!parameters.ContainsKey(IntegrationsConstants.IntegrationParamName))
		{
			parameters[IntegrationsConstants.IntegrationParamName] = integration;
		}
		if (!parameters.ContainsKey(IntegrationsConstants.ActivityParamName))
		{
			parameters[IntegrationsConstants.ActivityParamName] = activity;
		}
		if (!parameters.ContainsKey(IntegrationsConstants.AuthenticationParamName))
		{
			parameters[IntegrationsConstants.AuthenticationParamName] = authObject;
		}
		if (!parameters.ContainsKey(IntegrationsConstants.AuthenticationResponseParamName))
		{
			parameters[IntegrationsConstants.AuthenticationResponseParamName] = authResponse;
		}
		List<object> list = new List<object>();
		ParameterInfo[] parameters2 = methodInfo.GetParameters();
		foreach (ParameterInfo parameterInfo in parameters2)
		{
			if (parameters.TryGetValue(parameterInfo.Name, out var value))
			{
				object obj = value?.CastAsRealType();
				if (obj == null || parameterInfo.ParameterType.IsAssignableFrom(obj.GetType()))
				{
					list.Add(obj);
				}
			}
		}
		try
		{
			return EntityScriptingService.InvokeWithDiagnostics(methodInfo, scriptInstance, list.ToArray(), errorTitle);
		}
		catch (TargetInvocationException ex)
		{
			IntegrationLogger.ErrorFormat(errorTitle + (ex.InnerException ?? ex).Message, ex);
			throw new ScriptExecuteException(errorTitle + (ex.InnerException ?? ex).Message, ex);
		}
		catch (Exception ex2)
		{
			IntegrationLogger.Error(errorTitle + ex2.Message, ex2);
			throw new ScriptExecuteException(errorTitle + ex2.Message, ex2);
		}
	}
}
