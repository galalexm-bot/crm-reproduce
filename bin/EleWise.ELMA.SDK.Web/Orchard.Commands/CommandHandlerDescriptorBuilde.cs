using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Orchard.Commands;

public class CommandHandlerDescriptorBuilder
{
	public CommandHandlerDescriptor Build(Type type)
	{
		return new CommandHandlerDescriptor
		{
			Commands = CollectMethods(type)
		};
	}

	private IEnumerable<CommandDescriptor> CollectMethods(Type type)
	{
		IEnumerable<MethodInfo> enumerable = from m in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)
			where !m.IsSpecialName
			select m;
		foreach (MethodInfo item in enumerable)
		{
			yield return BuildMethod(item);
		}
	}

	private CommandDescriptor BuildMethod(MethodInfo methodInfo)
	{
		return new CommandDescriptor
		{
			Name = GetCommandName(methodInfo),
			MethodInfo = methodInfo,
			HelpText = GetCommandHelpText(methodInfo)
		};
	}

	private string GetCommandHelpText(MethodInfo methodInfo)
	{
		object[] customAttributes = methodInfo.GetCustomAttributes(typeof(CommandHelpAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Any())
		{
			return customAttributes.Cast<CommandHelpAttribute>().Single().HelpText;
		}
		return string.Empty;
	}

	private string GetCommandName(MethodInfo methodInfo)
	{
		object[] customAttributes = methodInfo.GetCustomAttributes(typeof(CommandNameAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Any())
		{
			return customAttributes.Cast<CommandNameAttribute>().Single().Command;
		}
		return methodInfo.Name.Replace('_', ' ');
	}
}
