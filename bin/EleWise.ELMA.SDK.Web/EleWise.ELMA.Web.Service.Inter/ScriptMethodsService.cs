using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[Component]
[Uid("{C11EF6D5-7D87-4E0E-BDC8-2867DDF603C3}")]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
internal sealed class ScriptMethodsService : IScriptMethodsService, IInternalAPIWebService
{
	public const string GuidS = "{C11EF6D5-7D87-4E0E-BDC8-2867DDF603C3}";

	public static Guid Guid = new Guid("{C11EF6D5-7D87-4E0E-BDC8-2867DDF603C3}");

	private static IScriptService ScriptService => Locator.GetServiceNotNull<IScriptService>();

	private static void LogServiceError(Expression<Func<ScriptMethodsService, object>> method, string message)
	{
		Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(ScriptMethodsService), method, message));
	}

	public EleWise.ELMA.Web.Service.Internal.Model.GenerateMethodCodeResponse GenerateMethodCode(EleWise.ELMA.Web.Service.Internal.Model.GenerateMethodCodeRequest request)
	{
		try
		{
			EleWise.ELMA.Scripts.Models.GenerateMethodCodeRequest request2 = new EleWise.ELMA.Scripts.Models.GenerateMethodCodeRequest
			{
				ClassName = request.ClassName,
				MethodName = request.MethodName,
				ReturnType = request.ReturnType,
				ReturnValue = request.ReturnValue,
				SourceCode = request.SourceCode,
				Parameters = ((request.Parameters != null) ? request.Parameters.Select((EleWise.ELMA.Web.Service.Internal.Model.ScriptMethodParameter p) => new EleWise.ELMA.Model.Scripts.ScriptMethodParameter
				{
					Description = p.Description,
					Name = p.Name,
					Type = p.Type
				}).ToList() : new List<EleWise.ELMA.Model.Scripts.ScriptMethodParameter>()),
				Description = request.Description
			};
			EleWise.ELMA.Scripts.Models.GenerateMethodCodeResponse generateMethodCodeResponse = ScriptService.GenerateMethodCode(request2);
			if (generateMethodCodeResponse != null)
			{
				return new EleWise.ELMA.Web.Service.Internal.Model.GenerateMethodCodeResponse
				{
					InsertPosition = generateMethodCodeResponse.InsertPosition,
					MethodSourceCode = generateMethodCodeResponse.MethodSourceCode
				};
			}
			string message = SR.T("Не удалось сгенерировать код метода");
			LogServiceError((ScriptMethodsService q) => q.GenerateMethodCode(request), message);
			throw PublicServiceException.CreateWebFault(message, 500);
		}
		catch (Exception ex)
		{
			LogServiceError((ScriptMethodsService q) => q.GenerateMethodCode(request), ex.ToString());
			throw PublicServiceException.CreateWebFault(ex.ToString(), 500);
		}
	}

	public EleWise.ELMA.Web.Service.Internal.Model.ScriptMethodDeclaration[] ParseMethods(EleWise.ELMA.Web.Service.Internal.Model.ParseMethodsRequest request)
	{
		try
		{
			EleWise.ELMA.Scripts.Models.ParseMethodsRequest request2 = new EleWise.ELMA.Scripts.Models.ParseMethodsRequest
			{
				SourceCode = request.SourceCode
			};
			return (from m in ScriptService.ParseMethods(request2)
				select new EleWise.ELMA.Web.Service.Internal.Model.ScriptMethodDeclaration
				{
					Description = m.Description,
					Name = m.Name,
					Signature = m.Signature,
					DisplayInfo = m.DisplayInfo,
					ReturnType = m.ReturnType,
					Parameters = ((m.Parameters != null) ? m.Parameters.Select((EleWise.ELMA.Model.Scripts.ScriptMethodParameter p) => new EleWise.ELMA.Web.Service.Internal.Model.ScriptMethodParameter
					{
						Description = p.Description,
						Name = p.Name,
						Type = p.Type
					}).ToList() : new List<EleWise.ELMA.Web.Service.Internal.Model.ScriptMethodParameter>())
				}).ToArray();
		}
		catch (Exception ex)
		{
			LogServiceError((ScriptMethodsService q) => q.ParseMethods(request), ex.ToString());
			throw PublicServiceException.CreateWebFault(ex.ToString(), 500);
		}
	}

	public AddInterfaceResponse AddInterface(AddInterfaceRequest request)
	{
		try
		{
			AddInterfaceData data = new AddInterfaceData
			{
				ClassName = request.ClassName,
				InterfaceName = request.InterfaceName,
				SourceCode = request.SourceCode
			};
			AddInterfaceResult addInterfaceResult = ScriptService.AddInterface(data);
			if (addInterfaceResult != null)
			{
				return new AddInterfaceResponse
				{
					SourceCode = addInterfaceResult.SourceCode
				};
			}
			string message = SR.T("Не удалось добавить интерфейс");
			LogServiceError((ScriptMethodsService q) => q.AddInterface(request), message);
			throw PublicServiceException.CreateWebFault(message, 500);
		}
		catch (Exception ex)
		{
			LogServiceError((ScriptMethodsService q) => q.AddInterface(request), ex.ToString());
			throw PublicServiceException.CreateWebFault(ex.ToString(), 500);
		}
	}

	public bool InterfaceExists(InterfaceExistsRequest request)
	{
		try
		{
			InterfaceExistsInfo info = new InterfaceExistsInfo
			{
				ClassName = request.ClassName,
				InterfaceName = request.InterfaceName,
				SourceCode = request.SourceCode
			};
			return ScriptService.InterfaceExists(info);
		}
		catch (Exception ex)
		{
			LogServiceError((ScriptMethodsService q) => q.InterfaceExists(request), ex.ToString());
			throw PublicServiceException.CreateWebFault(ex.ToString(), 500);
		}
	}
}
