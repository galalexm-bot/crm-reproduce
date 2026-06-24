using System;
using System.ServiceModel.Dispatcher;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

[AttributeUsage(AttributeTargets.Method)]
public class CustomBehaviorFormatterAttribute : Attribute
{
	public Type BehaviorFormatterType { get; }

	public CustomBehaviorFormatterAttribute(Type behaviorFormatterType)
	{
		Contract.ArgumentNotNull(behaviorFormatterType, "behaviorFormatterType");
		if (!typeof(IDispatchMessageFormatter).IsAssignableFrom(behaviorFormatterType))
		{
			throw new ArgumentException(SR.T("Неверный тип форматтера"));
		}
		BehaviorFormatterType = behaviorFormatterType;
	}
}
