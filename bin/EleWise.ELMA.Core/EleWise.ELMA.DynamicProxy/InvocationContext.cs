using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace EleWise.ELMA.DynamicProxy;

public class InvocationContext
{
	private readonly Func<InvocationContext, System.Threading.Tasks.Task> next;

	private readonly object[] _003CArguments_003Ek__BackingField;

	private readonly MethodInfo _003CMethod_003Ek__BackingField;

	private readonly System.Type _003CTargetType_003Ek__BackingField;

	private readonly Dictionary<string, object> _003CContextVars_003Ek__BackingField;

	private object _003CReturnValue_003Ek__BackingField;

	public object[] Arguments => _003CArguments_003Ek__BackingField;

	public MethodInfo Method => _003CMethod_003Ek__BackingField;

	public System.Type TargetType => _003CTargetType_003Ek__BackingField;

	public Dictionary<string, object> ContextVars => _003CContextVars_003Ek__BackingField;

	public object ReturnValue
	{
		get
		{
			return _003CReturnValue_003Ek__BackingField;
		}
		set
		{
			_003CReturnValue_003Ek__BackingField = value;
		}
	}

	internal InvocationContext(MethodInfo proxiedMethod, System.Type targetType, object[] arguments, Func<InvocationContext, System.Threading.Tasks.Task> next, Dictionary<string, object> contextVars)
	{
		_003CMethod_003Ek__BackingField = proxiedMethod;
		_003CTargetType_003Ek__BackingField = targetType;
		_003CArguments_003Ek__BackingField = arguments;
		this.next = next;
		_003CContextVars_003Ek__BackingField = contextVars;
	}

	public System.Threading.Tasks.Task Next()
	{
		return next.Invoke(this);
	}
}
