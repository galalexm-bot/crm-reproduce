using System.Collections.Generic;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Actions;

internal sealed class ServerFunctionExecutionHandler : AbstractServerActionExecutionHandler
{
	public ServerFunctionExecutionHandler(IActionExecutionService actionExecutionService, IExtendEntityService extendEntityService, ICurrentPageService currentPageService, FindComponentService findComponentService, IProxyGeneratorService proxyGeneratorService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList, IApplicationData applicationData)
		: base(actionExecutionService, extendEntityService, currentPageService, findComponentService, proxyGeneratorService, dependencyHackList, applicationData)
	{
	}

	public override bool Check(IActionExecutionContext context)
	{
		return context.ActionExecutionType == ActionExecutionType.ServerFunction;
	}

	public override ActionExecutionRequestDto CreateRequest(IActionExecutionContext context)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		if (!(context is ServerFunctionExecutionContext serverFunctionExecutionContext))
		{
			return null;
		}
		Signature parameterType = serverFunctionExecutionContext.ParameterType;
		Signature returnType = serverFunctionExecutionContext.ReturnType;
		return new ActionExecutionRequestDto
		{
			TypeUid = serverFunctionExecutionContext.TypeUid,
			ScriptName = serverFunctionExecutionContext.MethodName,
			ParameterType = new TypeSignatureDto
			{
				TypeUid = parameterType.TypeUid,
				SubTypeUid = parameterType.SubTypeUid,
				RelationType = parameterType.RelationType,
				Nullable = parameterType.Nullable
			},
			ReturnType = new TypeSignatureDto
			{
				TypeUid = returnType.TypeUid,
				SubTypeUid = returnType.SubTypeUid,
				RelationType = returnType.RelationType,
				Nullable = returnType.Nullable
			},
			InstanceUid = serverFunctionExecutionContext.InstanceUid,
			EntityTypeSerializationSettings = GetEntityTypeSerializationSettings(),
			RuntimeModel = findComponentService.GetCurrentRuntimeModel()
		};
	}
}
