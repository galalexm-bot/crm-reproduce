using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Services.FindComponent;
using EleWise.ELMA.Web.Service.Internal.Model;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{B91372F0-5073-4DCE-9187-B6EB64E25533}")]
internal sealed class ScriptExecutionService : IScriptExecutionService, IInternalAPIWebService
{
	private const string GuidS = "{B91372F0-5073-4DCE-9187-B6EB64E25533}";

	private static IEnumerable<IScriptExecutionHandler> scriptExecutionHandlers;

	private static IMetadataRuntimeService metadataRuntimeService;

	private static IFindComponentService findComponentService;

	private static DataClassDescriptor dataClassDescriptor;

	private static IMapperService mapperService;

	private static IEnumerable<IScriptExecutionHandler> ScriptExecutionHandlers => scriptExecutionHandlers ?? (scriptExecutionHandlers = Locator.GetServiceNotNull<IEnumerable<IScriptExecutionHandler>>());

	private static IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	private static IFindComponentService FindComponentService => findComponentService ?? (findComponentService = Locator.GetServiceNotNull<IFindComponentService>());

	private static DataClassDescriptor DataClassDescriptor => dataClassDescriptor ?? (dataClassDescriptor = Locator.GetServiceNotNull<DataClassDescriptor>());

	private static IMapperService MapperService => mapperService ?? (mapperService = Locator.GetServiceNotNull<IMapperService>());

	private static void LogServiceError(Expression<Action<ScriptExecutionService>> method, string message)
	{
		Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(ScriptExecutionService), method, message));
	}

	public ScriptExecutionResponse ExecuteScript(ScriptExecutionRequest request)
	{
		if (request == null)
		{
			string text = SR.T("Запрос на исполнение сценария пустой");
			LogServiceError((ScriptExecutionService s) => s.ExecuteScript(request), text);
			return new ScriptExecutionResponse
			{
				ExceptionMessage = text
			};
		}
		ScriptExecutionParams parameters = request.ToParams();
		ModelInfo modelInfo = parameters.ModelInfo;
		if (modelInfo == null)
		{
			string text2 = SR.T("Не найдена информация о модели");
			LogServiceError((ScriptExecutionService s) => s.ExecuteScript(request), text2);
			return new ScriptExecutionResponse
			{
				ExceptionMessage = text2
			};
		}
		UIRuntimeModel runtimeModel = request.RuntimeModel;
		ContextVars.Set("UIBuilderRuntime", runtimeModel);
		ContextVars.Set("UIBuilderEntityDependencies", request.EntityTypeSerializationSettings);
		IScriptExecutionHandler scriptExecutionHandler = ScriptExecutionHandlers.FirstOrDefault((IScriptExecutionHandler item) => item.Check(parameters));
		if (scriptExecutionHandler == null)
		{
			return new ScriptExecutionResponse
			{
				ExceptionMessage = SR.T("Не найдена реализация для исполнения скрипта")
			};
		}
		ScriptExecutionResult scriptExecutionResult;
		try
		{
			scriptExecutionResult = scriptExecutionHandler.ExecuteScript(parameters);
		}
		catch (Exception innerException)
		{
			if (innerException is TargetInvocationException)
			{
				innerException = innerException.InnerException;
			}
			LogServiceError((ScriptExecutionService s) => s.ExecuteScript(request), innerException.ToString());
			return new ScriptExecutionResponse
			{
				ExceptionMessage = innerException.StackTrace,
				ExceptionStackTrace = innerException.StackTrace
			};
		}
		EntityTypeSerializationSettings[] entityTypeSerializationSettings = request.EntityTypeSerializationSettings;
		EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings
		{
			WriteReferences = true
		};
		if (entityTypeSerializationSettings != null && entityTypeSerializationSettings.Length != 0)
		{
			IEnumerable<EntityTypeSerializationSettings> source = entityTypeSerializationSettings.Where((EntityTypeSerializationSettings a) => a.Properties.Count > 0);
			entitySerializationSettings.Mode = EntitySerializationMode.Default;
			entitySerializationSettings.TypePropertySelector = source.ToDictionary((EntityTypeSerializationSettings d) => d.TypeUid, delegate(EntityTypeSerializationSettings d)
			{
				EntityMetadata entityMetadata2 = MetadataLoader.LoadMetadata(d.TypeUid) as EntityMetadata;
				List<string> properties = d.Properties;
				if (!properties.Contains("Uid"))
				{
					properties.Add("Uid");
				}
				if (entityMetadata2.IsGroupPropertyUid != Guid.Empty)
				{
					properties.Remove("IsGroup");
				}
				return EntitySerializationSelector.CreateFromSelect(string.Join(",", properties), entityMetadata2);
			});
		}
		EleWise.ELMA.Model.Views.FormViewBuilderInfo formViewBuilderInfo = DynamicFormHelper.GetFormViewBuilderInfo(scriptExecutionResult.PropertyContainer);
		WebData webData = null;
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(modelInfo.SubTypeUid);
		if (typeByUidOrNull != null && MetadataLoader.LoadMetadata(typeByUidOrNull) is EntityMetadata entityMetadata && entityMetadata.ViewModelMetadata != null && DataClassDescriptor.SerializeSimple(scriptExecutionResult.Model, scriptExecutionResult.Model.GetType(), entitySerializationSettings) is IDictionary<string, object> dicObj)
		{
			webData = new WebData(dicObj);
		}
		if (webData == null)
		{
			webData = ((scriptExecutionResult.Model is IEntity entity) ? WebData.CreateFromEntity(entity, entitySerializationSettings) : ((scriptExecutionResult.Model is DataClass dataClass && DataClassDescriptor.SerializeSimple(dataClass, dataClass.GetType(), entitySerializationSettings) is IDictionary<string, object> dicObj2) ? new WebData(dicObj2) : WebData.CreateFromObject(scriptExecutionResult.Model, entitySerializationSettings)));
		}
		WebData item2 = null;
		if (scriptExecutionResult.Item is IEntity entity2)
		{
			item2 = WebData.CreateFromEntity(entity2, entitySerializationSettings).UpdateVersion();
		}
		EleWise.ELMA.Web.Service.Internal.Model.FormViewBuilderInfo formViewBuilderInfo2 = null;
		if (formViewBuilderInfo != null)
		{
			formViewBuilderInfo2 = new EleWise.ELMA.Web.Service.Internal.Model.FormViewBuilderInfo();
			formViewBuilderInfo2.Notifications.AddRange(formViewBuilderInfo.Notifications);
			formViewBuilderInfo2.ClosePopup = formViewBuilderInfo.ClosePopup;
			foreach (EleWise.ELMA.Model.Views.PropertyViewInfo property in formViewBuilderInfo.Properties)
			{
				EleWise.ELMA.Web.Service.Internal.Model.PropertyViewInfo propertyViewInfo = new EleWise.ELMA.Web.Service.Internal.Model.PropertyViewInfo
				{
					Required = property.Required,
					Uid = property.Uid,
					Visible = property.Visible,
					IsValid = property.IsValid,
					ValidationMessage = property.ValidationMessage,
					ReadOnly = property.ReadOnly
				};
				TypeSettings settings = property.Settings;
				if (settings != null)
				{
					DataClass dataClass2 = MapperService.Map<DataClass>(settings);
					if (dataClass2 != null)
					{
						propertyViewInfo.Settings = DataClassDescriptor.SerializeSimple(dataClass2, dataClass2.GetType(), entitySerializationSettings);
					}
				}
				formViewBuilderInfo2.Properties.Add(propertyViewInfo);
			}
		}
		return new ScriptExecutionResponse
		{
			AdditionalComponentModels = FindComponentService.GetAdditionalModules().ToArray(),
			Model = webData.UpdateVersion(),
			Item = item2,
			FormViewBuilderInfo = formViewBuilderInfo2,
			RedirectUrl = scriptExecutionResult.RedirectUrl,
			ReturnValue = scriptExecutionResult.ReturnValue
		};
	}
}
