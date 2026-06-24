using System;
using System.Globalization;
using System.Reflection;
using EleWise.ELMA.CAB.Commands;
using EleWise.ELMA.CAB.Properties;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.BuilderStrategies;

public class CommandStrategy : BuilderStrategy
{
	public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
	{
		WorkItem workItem = GetWorkItem(context, existing);
		if (workItem != null)
		{
			Type type = existing.GetType();
			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				RegisterCommandHandlers(context, workItem, existing, id, methodInfo);
			}
		}
		return ((BuilderStrategy)this).BuildUp(context, t, existing, id);
	}

	public override object TearDown(IBuilderContext context, object item)
	{
		WorkItem workItem = GetWorkItem(context, item);
		if (workItem != null)
		{
			Type type = item.GetType();
			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				UnregisterCommandHandlers(context, workItem, item, methodInfo);
			}
		}
		return ((BuilderStrategy)this).TearDown(context, item);
	}

	private void RegisterCommandHandlers(IBuilderContext context, WorkItem workItem, object target, string targetID, MethodInfo methodInfo)
	{
		object[] customAttributes = methodInfo.GetCustomAttributes(typeof(CommandHandlerAttribute), inherit: true);
		for (int i = 0; i < customAttributes.Length; i++)
		{
			CommandHandlerAttribute commandHandlerAttribute = (CommandHandlerAttribute)customAttributes[i];
			Command command = workItem.Commands[commandHandlerAttribute.CommandName];
			if (!command.IsHandlerRegistered(target, methodInfo))
			{
				command.ExecuteAction += CreateCommandHandler(target, methodInfo);
				((BuilderStrategy)this).TraceBuildUp(context, target.GetType(), targetID, Resources.CommandInjectionBuildUp, new object[2] { methodInfo.Name, commandHandlerAttribute.CommandName });
			}
		}
	}

	private void UnregisterCommandHandlers(IBuilderContext context, WorkItem workItem, object target, MethodInfo methodInfo)
	{
		object[] customAttributes = methodInfo.GetCustomAttributes(typeof(CommandHandlerAttribute), inherit: true);
		for (int i = 0; i < customAttributes.Length; i++)
		{
			CommandHandlerAttribute commandHandlerAttribute = (CommandHandlerAttribute)customAttributes[i];
			if (workItem.Commands.Contains(commandHandlerAttribute.CommandName))
			{
				workItem.Commands[commandHandlerAttribute.CommandName].ExecuteAction -= CreateCommandHandler(target, methodInfo);
				((BuilderStrategy)this).TraceTearDown(context, target, Resources.CommandInjectionTearDown, new object[2] { methodInfo.Name, commandHandlerAttribute.CommandName });
			}
		}
	}

	private EventHandler CreateCommandHandler(object target, MethodInfo methodInfo)
	{
		Delegate @delegate = null;
		if (!methodInfo.IsStatic)
		{
			@delegate = Delegate.CreateDelegate(typeof(EventHandler), target, methodInfo);
			return (EventHandler)@delegate;
		}
		throw new CommandException(string.Format(CultureInfo.CurrentCulture, Resources.StaticCommandHandlerNotSupported, new object[1] { methodInfo.Name }));
	}

	private static WorkItem GetWorkItem(IBuilderContext context, object item)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (item is WorkItem)
		{
			return item as WorkItem;
		}
		return ((IReadableLocator)context.get_Locator()).Get<WorkItem>((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
	}
}
