using System;
using System.Collections.Generic;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Actions;

internal sealed class GlobalFunctionExecutionHandler : AbstractServerActionExecutionHandler
{
	private readonly FunctionMetadataItemManager functionMetadataItemManager;

	public GlobalFunctionExecutionHandler(IActionExecutionService actionExecutionService, IExtendEntityService extendEntityService, ICurrentPageService currentPageService, FindComponentService findComponentService, IProxyGeneratorService proxyGeneratorService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList, IApplicationData applicationData, FunctionMetadataItemManager functionMetadataItemManager)
		: base(actionExecutionService, extendEntityService, currentPageService, findComponentService, proxyGeneratorService, dependencyHackList, applicationData)
	{
		this.functionMetadataItemManager = functionMetadataItemManager;
	}

	public override bool Check(IActionExecutionContext context)
	{
		return context.ActionExecutionType == ActionExecutionType.GlobalFunction;
	}

	public override ActionExecutionRequestDto CreateRequest(IActionExecutionContext context)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (!(context is GlobalFunctionExecutionContext globalFunctionExecutionContext))
		{
			return null;
		}
		Signature parameterType = globalFunctionExecutionContext.ParameterType;
		Signature returnType = globalFunctionExecutionContext.ReturnType;
		Guid functionItemUid = globalFunctionExecutionContext.FunctionItemUid;
		return new ActionExecutionRequestDto
		{
			TypeUid = MetadataConstants.FunctionMetadataTypeUid,
			ScriptName = (functionMetadataItemManager.LoadHeaderName(functionItemUid) ?? ((object)(Guid)(ref functionItemUid)).ToString()),
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
			InstanceUid = functionItemUid,
			EntityTypeSerializationSettings = GetEntityTypeSerializationSettings(),
			RuntimeModel = findComponentService.GetCurrentRuntimeModel()
		};
	}
}
