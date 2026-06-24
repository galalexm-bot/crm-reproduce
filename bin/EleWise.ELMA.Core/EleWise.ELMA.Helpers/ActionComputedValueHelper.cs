using System;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Helpers;

internal static class ActionComputedValueHelper
{
	internal static ValueTuple<bool, ActionValue> IsAction(ComputedValue computedValue)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		string value = computedValue.Value;
		if (value.Contains("\"MethodName\":\""))
		{
			ActionValue actionValue = SerializationHelper.DeserializeObjectFromJson<ActionValue>(value);
			return new ValueTuple<bool, ActionValue>(true, actionValue);
		}
		return new ValueTuple<bool, ActionValue>(false, (ActionValue)null);
	}

	internal static ActionValue CreateActionValue(ComputedValue actionInputComputedValue, IReactiveModelFactory reactiveModelFactory)
	{
		if (actionInputComputedValue != null)
		{
			ActionValue actionValue = SerializationHelper.DeserializeObjectFromJson<ActionValue>(actionInputComputedValue.Value);
			if (actionValue != null)
			{
				return actionValue;
			}
		}
		if (reactiveModelFactory == null)
		{
			return new ActionValue();
		}
		return reactiveModelFactory.CreateModel<ActionValue>();
	}

	internal static void CreateGlobalFunction(Guid functionHeaderUid, TypeSignature returnTypeSignature, TypeSignature parameterTypeSignature, object context, string propertyName, IConvertService convertService, IActionExecutionFacade actionExecutionFacade)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		Signature returnType = new Signature
		{
			Nullable = returnTypeSignature.Nullable,
			RelationType = returnTypeSignature.RelationType,
			TypeUid = returnTypeSignature.TypeUid,
			SubTypeUid = returnTypeSignature.SubTypeUid
		};
		Signature parameterType = new Signature
		{
			Nullable = parameterTypeSignature.Nullable,
			RelationType = parameterTypeSignature.RelationType,
			TypeUid = parameterTypeSignature.TypeUid,
			SubTypeUid = parameterTypeSignature.SubTypeUid
		};
		GlobalFunctionExecutionContext actionExecutionContext = new GlobalFunctionExecutionContext(functionHeaderUid, returnType, parameterType);
		object obj = CreateClosureForAction(returnTypeSignature, parameterTypeSignature, actionExecutionContext, convertService, actionExecutionFacade);
		PropertyInfoExpression propertyInfoExpression = new PropertyInfoExpression
		{
			ObjectExpression = propertyName,
			ExpressionForSerialize = propertyName
		};
		ClosureHelper.Closure<object, PropertyInfoExpression, object>(context, ConvertHelper.RedefineProp, new object[3] { context, propertyInfoExpression, obj });
	}

	private static object CreateClosureForAction(TypeSignature returnTypeSignature, TypeSignature parameterTypeSignature, IActionExecutionContext actionExecutionContext, IConvertService convertService, IActionExecutionFacade actionExecutionFacade)
	{
		System.Type type = convertService.ToType(returnTypeSignature);
		System.Type type2 = convertService.ToType(parameterTypeSignature);
		return ClosureHelper.CreateForActionWithParam((IAction)Activator.CreateInstance(typeof(ActionWithParamResult<, >).MakeGenericType(new System.Type[2] { type2, type }), new object[2] { actionExecutionContext, actionExecutionFacade }));
	}
}
