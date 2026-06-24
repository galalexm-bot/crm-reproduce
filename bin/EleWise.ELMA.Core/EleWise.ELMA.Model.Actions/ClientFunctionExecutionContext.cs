using System;
using EleWise.ELMA.Core.Controllers;

namespace EleWise.ELMA.Model.Actions;

public sealed class ClientFunctionExecutionContext : IActionExecutionContext
{
	private readonly ActionExecutionType _003CActionExecutionType_003Ek__BackingField;

	private readonly string _003CMethodName_003Ek__BackingField;

	private readonly Func<IController> _003CController_003Ek__BackingField;

	private readonly IDataStack _003CDataStack_003Ek__BackingField;

	public ActionExecutionType ActionExecutionType => _003CActionExecutionType_003Ek__BackingField;

	public bool IsEmpty => false;

	public string MethodName => _003CMethodName_003Ek__BackingField;

	public Func<IController> Controller => _003CController_003Ek__BackingField;

	public IDataStack DataStack => _003CDataStack_003Ek__BackingField;

	public ClientFunctionExecutionContext(string methodName)
		: this(methodName, null, null)
	{
	}

	public ClientFunctionExecutionContext(string methodName, Func<IController> controller, IDataStack dataStack)
	{
		_003CMethodName_003Ek__BackingField = methodName;
		_003CController_003Ek__BackingField = controller;
		_003CDataStack_003Ek__BackingField = dataStack;
		_003CActionExecutionType_003Ek__BackingField = ActionExecutionType.ClientFunction;
	}
}
