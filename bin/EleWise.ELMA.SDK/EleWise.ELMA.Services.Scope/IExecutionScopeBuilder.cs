using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Services.Scope;

public interface IExecutionScopeBuilder
{
	IExecutionScopeBuilder AddRegistration(Type type, params Type[] registerTypes);

	IExecutionScopeBuilder AddRegistration(Type type, IEnumerable<Type> registerTypes);

	IExecutionScopeBuilder AddRegistration(object instance, params Type[] registerTypes);

	IExecutionScopeBuilder AddRegistration(object instance, IEnumerable<Type> registerTypes);

	IExecutionScope StartScope();
}
