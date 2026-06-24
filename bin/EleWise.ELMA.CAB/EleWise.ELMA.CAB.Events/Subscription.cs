#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Events;

internal class Subscription
{
	private struct CallInBackgroundArguments
	{
		public readonly EventArgs EventArgs;

		public readonly Delegate Handler;

		public readonly object Sender;

		public readonly TraceSource TraceSource;

		public CallInBackgroundArguments(object sender, EventArgs eventArgs, Delegate handler, TraceSource traceSource)
		{
			Sender = sender;
			EventArgs = eventArgs;
			Handler = handler;
			TraceSource = traceSource;
		}
	}

	private readonly Type handlerEventArgsType;

	private readonly string _handlerMethodName;

	private readonly RuntimeMethodHandle methodHandle;

	private readonly SynchronizationContext syncContext;

	private readonly ThreadOption threadOption;

	private readonly RuntimeTypeHandle typeHandle;

	private readonly WeakReference wrSubscriber;

	private WorkItemSubscriptions workItemSubscriptions;

	public object Subscriber => wrSubscriber.Target;

	public string HandlerMethodName => _handlerMethodName;

	public ThreadOption ThreadOption => threadOption;

	internal Subscription(WorkItemSubscriptions workItemSubscriptions, object subscriber, string handlerMethodName, ThreadOption threadOption)
		: this(workItemSubscriptions, subscriber, handlerMethodName, null, threadOption)
	{
	}

	internal Subscription(WorkItemSubscriptions workItemSubscriptions, object subscriber, string handlerMethodName, Type[] parameterTypes, ThreadOption threadOption)
	{
		wrSubscriber = new WeakReference(subscriber);
		_handlerMethodName = handlerMethodName;
		this.threadOption = threadOption;
		this.workItemSubscriptions = workItemSubscriptions;
		MethodInfo methodInfo = GetMethodInfo(subscriber, handlerMethodName, parameterTypes);
		if (methodInfo == null)
		{
			throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.SubscriberHandlerNotFound, new object[2]
			{
				handlerMethodName,
				subscriber.GetType()
			}));
		}
		if (methodInfo.IsStatic)
		{
			throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.CannotRegisterStaticSubscriptionMethods, new object[2]
			{
				methodInfo.DeclaringType.FullName,
				methodInfo.Name
			}));
		}
		typeHandle = subscriber.GetType().TypeHandle;
		methodHandle = methodInfo.MethodHandle;
		ParameterInfo[] parameters = methodInfo.GetParameters();
		if (IsValidEventHandler(parameters))
		{
			ParameterInfo parameterInfo = methodInfo.GetParameters()[1];
			Type parameterType = parameterInfo.ParameterType;
			handlerEventArgsType = typeof(EventHandler<>).MakeGenericType(parameterType);
			if (threadOption == ThreadOption.UserInterface && SynchronizationContext.Current != null)
			{
				syncContext = SynchronizationContext.Current;
			}
			return;
		}
		throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidSubscriptionSignature, new object[2]
		{
			methodInfo.DeclaringType.FullName,
			methodInfo.Name
		}));
	}

	private static bool IsValidEventHandler(ParameterInfo[] parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		return parameters.Length == 2 && typeof(EventArgs).IsAssignableFrom(parameters[1].ParameterType);
	}

	private static MethodInfo GetMethodInfo(object subscriber, string handlerMethodName, Type[] parameterTypes)
	{
		if (subscriber == null)
		{
			throw new ArgumentNullException("subscriber");
		}
		if (handlerMethodName == null)
		{
			throw new ArgumentNullException("handlerMethodName");
		}
		return (parameterTypes != null) ? subscriber.GetType().GetMethod(handlerMethodName, EventInspector.SearchFlags, null, parameterTypes, null) : subscriber.GetType().GetMethod(handlerMethodName, EventInspector.SearchFlags);
	}

	internal EventTopicFireDelegate GetHandler()
	{
		return EventTopicFireHandler;
	}

	private void EventTopicFireHandler(object sender, EventArgs e, List<Exception> exceptions, TraceSource traceSource)
	{
		object target = wrSubscriber.Target;
		if (target != null)
		{
			switch (threadOption)
			{
			case ThreadOption.Publisher:
				CallOnPublisher(sender, e, exceptions);
				break;
			case ThreadOption.Background:
				CallOnBackgroundWorker(sender, e, traceSource);
				break;
			case ThreadOption.UserInterface:
				CallOnUserInterface(sender, e, exceptions);
				break;
			}
		}
	}

	private void CallOnPublisher(object sender, EventArgs e, List<Exception> exceptions)
	{
		if (exceptions == null)
		{
			throw new ArgumentNullException("exceptions");
		}
		try
		{
			CreateSubscriptionDelegate()?.DynamicInvoke(sender, e);
		}
		catch (TargetInvocationException ex)
		{
			exceptions.Add(ex.InnerException);
		}
	}

	private void CallOnBackgroundWorker(object sender, EventArgs e, TraceSource traceSource)
	{
		Delegate @delegate = CreateSubscriptionDelegate();
		if ((object)@delegate == null)
		{
			return;
		}
		ThreadPool.QueueUserWorkItem(delegate(object state)
		{
			if (state != null)
			{
				CallInBackgroundArguments callInBackgroundArguments = (CallInBackgroundArguments)state;
				try
				{
					callInBackgroundArguments.Handler.DynamicInvoke(callInBackgroundArguments.Sender, callInBackgroundArguments.EventArgs);
				}
				catch (Exception ex)
				{
					callInBackgroundArguments.TraceSource.TraceInformation(Resources.BackgroundSubscriberException, ex.ToString());
					throw;
				}
			}
		}, new CallInBackgroundArguments(sender, e, @delegate, traceSource));
	}

	private void CallOnUserInterface(object sender, EventArgs e, List<Exception> exceptions)
	{
		if (exceptions == null)
		{
			throw new ArgumentNullException("exceptions");
		}
		Delegate @delegate = CreateSubscriptionDelegate();
		if ((object)@delegate == null)
		{
			return;
		}
		if (syncContext != null)
		{
			syncContext.Send(delegate(object data)
			{
				try
				{
					if (data != null)
					{
						((Delegate)data).DynamicInvoke(sender, e);
					}
				}
				catch (TargetInvocationException ex2)
				{
					exceptions.Add(ex2.InnerException);
				}
			}, @delegate);
			return;
		}
		try
		{
			@delegate.DynamicInvoke(sender, e);
		}
		catch (TargetInvocationException ex)
		{
			exceptions.Add(ex.InnerException);
		}
	}

	private Delegate CreateSubscriptionDelegate()
	{
		object target = wrSubscriber.Target;
		if (target != null && handlerEventArgsType != null)
		{
			return Delegate.CreateDelegate(handlerEventArgsType, target, (MethodInfo)MethodBase.GetMethodFromHandle(methodHandle, typeHandle));
		}
		return null;
	}
}
