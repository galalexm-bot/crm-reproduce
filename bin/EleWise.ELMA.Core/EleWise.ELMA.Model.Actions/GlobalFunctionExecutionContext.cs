using System;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Model.Actions;

public sealed class GlobalFunctionExecutionContext : IActionExecutionContext
{
	private readonly ActionExecutionType _003CActionExecutionType_003Ek__BackingField;

	private readonly Guid _003CFunctionItemUid_003Ek__BackingField;

	private readonly Signature _003CReturnType_003Ek__BackingField;

	private readonly Signature _003CParameterType_003Ek__BackingField;

	public ActionExecutionType ActionExecutionType => _003CActionExecutionType_003Ek__BackingField;

	public bool IsEmpty => false;

	public Guid FunctionItemUid => _003CFunctionItemUid_003Ek__BackingField;

	internal Signature ReturnType => _003CReturnType_003Ek__BackingField;

	internal Signature ParameterType => _003CParameterType_003Ek__BackingField;

	public GlobalFunctionExecutionContext(Guid functionItemUid, Signature returnType, Signature parameterType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003CFunctionItemUid_003Ek__BackingField = functionItemUid;
		_003CReturnType_003Ek__BackingField = returnType;
		_003CParameterType_003Ek__BackingField = parameterType;
		_003CActionExecutionType_003Ek__BackingField = ActionExecutionType.GlobalFunction;
	}
}
