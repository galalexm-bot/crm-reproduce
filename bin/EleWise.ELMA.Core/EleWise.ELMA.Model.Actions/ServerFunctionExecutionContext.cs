using System;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Model.Actions;

public sealed class ServerFunctionExecutionContext : IActionExecutionContext
{
	private readonly ActionExecutionType _003CActionExecutionType_003Ek__BackingField;

	private readonly string _003CMethodName_003Ek__BackingField;

	private readonly Guid _003CTypeUid_003Ek__BackingField;

	private readonly Guid _003CInstanceUid_003Ek__BackingField;

	private readonly Signature _003CReturnType_003Ek__BackingField;

	private readonly Signature _003CParameterType_003Ek__BackingField;

	public ActionExecutionType ActionExecutionType => _003CActionExecutionType_003Ek__BackingField;

	public bool IsEmpty => false;

	public string MethodName => _003CMethodName_003Ek__BackingField;

	public Guid TypeUid => _003CTypeUid_003Ek__BackingField;

	public Guid InstanceUid => _003CInstanceUid_003Ek__BackingField;

	public Signature ReturnType => _003CReturnType_003Ek__BackingField;

	public Signature ParameterType => _003CParameterType_003Ek__BackingField;

	public ServerFunctionExecutionContext(string methodName, Guid typeUid, Guid instanceUid, Signature returnType, Signature parameterType)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_003CMethodName_003Ek__BackingField = methodName;
		_003CTypeUid_003Ek__BackingField = typeUid;
		_003CInstanceUid_003Ek__BackingField = instanceUid;
		_003CReturnType_003Ek__BackingField = returnType;
		_003CParameterType_003Ek__BackingField = parameterType;
		_003CActionExecutionType_003Ek__BackingField = ActionExecutionType.ServerFunction;
	}
}
