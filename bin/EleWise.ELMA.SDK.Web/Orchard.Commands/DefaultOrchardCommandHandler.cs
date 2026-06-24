using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Orchard.Exceptions;
using Orchard.Localization;

namespace Orchard.Commands;

public abstract class DefaultOrchardCommandHandler : ICommandHandler, IDependency
{
	public Localizer T { get; set; }

	public CommandContext Context { get; set; }

	protected DefaultOrchardCommandHandler()
	{
		T = NullLocalizer.Instance;
	}

	public void Execute(CommandContext context)
	{
		SetSwitchValues(context);
		Invoke(context);
	}

	private void SetSwitchValues(CommandContext context)
	{
		if (context.Switches == null || !context.Switches.Any())
		{
			return;
		}
		foreach (KeyValuePair<string, string> @switch in context.Switches)
		{
			SetSwitchValue(@switch);
		}
	}

	private void SetSwitchValue(KeyValuePair<string, string> commandSwitch)
	{
		PropertyInfo property = GetType().GetProperty(commandSwitch.Key, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		if (property == null)
		{
			throw new InvalidOperationException(T("Switch \"{0}\" was not found", commandSwitch.Key).Text);
		}
		if (property.GetCustomAttributes(typeof(OrchardSwitchAttribute), inherit: false).Length == 0)
		{
			throw new InvalidOperationException(T("A property \"{0}\" exists but is not decorated with \"{1}\"", commandSwitch.Key, typeof(OrchardSwitchAttribute).Name).Text);
		}
		try
		{
			object value = Convert.ChangeType(commandSwitch.Value, property.PropertyType);
			property.SetValue(this, value, null);
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			throw new InvalidOperationException(T("Error converting value \"{0}\" to \"{1}\" for switch \"{2}\"", LocalizedString.TextOrDefault(commandSwitch.Value, T("(empty)")), property.PropertyType.FullName, commandSwitch.Key).Text, ex);
		}
	}

	private void Invoke(CommandContext context)
	{
		CheckMethodForSwitches(context.CommandDescriptor.MethodInfo, context.Switches);
		string[] array = (context.Arguments ?? Enumerable.Empty<string>()).ToArray();
		object[] invokeParametersForMethod = GetInvokeParametersForMethod(context.CommandDescriptor.MethodInfo, array);
		if (invokeParametersForMethod == null)
		{
			throw new InvalidOperationException(T("Command arguments \"{0}\" don't match command definition", string.Join(" ", array)).ToString());
		}
		Context = context;
		object obj = context.CommandDescriptor.MethodInfo.Invoke(this, invokeParametersForMethod);
		if (obj is string)
		{
			context.Output.Write(obj);
		}
	}

	private static object[] GetInvokeParametersForMethod(MethodInfo methodInfo, IList<string> arguments)
	{
		List<object> list = new List<object>();
		List<string> list2 = new List<string>(arguments);
		ParameterInfo[] parameters = methodInfo.GetParameters();
		bool flag = false;
		if (parameters.Length == 0)
		{
			if (list2.Count == 0)
			{
				return list.ToArray();
			}
			return null;
		}
		if (parameters[parameters.Length - 1].ParameterType.IsAssignableFrom(typeof(string[])))
		{
			flag = true;
		}
		if (!flag && list2.Count != parameters.Length)
		{
			return null;
		}
		if (flag && parameters.Length - list2.Count >= 2)
		{
			return null;
		}
		for (int i = 0; i < list2.Count; i++)
		{
			if (parameters[i].ParameterType.IsAssignableFrom(typeof(string[])))
			{
				list.Add(list2.GetRange(i, list2.Count - i).ToArray());
				break;
			}
			list.Add(Convert.ChangeType(arguments[i], parameters[i].ParameterType));
		}
		if (flag && parameters.Length - list2.Count == 1)
		{
			list.Add(new string[0]);
		}
		return list.ToArray();
	}

	private void CheckMethodForSwitches(MethodInfo methodInfo, IDictionary<string, string> switches)
	{
		if (switches == null || switches.Count == 0)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		object[] customAttributes = methodInfo.GetCustomAttributes(typeof(OrchardSwitchesAttribute), inherit: false);
		for (int i = 0; i < customAttributes.Length; i++)
		{
			OrchardSwitchesAttribute orchardSwitchesAttribute = (OrchardSwitchesAttribute)customAttributes[i];
			hashSet.UnionWith(orchardSwitchesAttribute.Switches);
		}
		foreach (string key in switches.Keys)
		{
			if (!hashSet.Contains(key))
			{
				throw new InvalidOperationException(T("Method \"{0}\" does not support switch \"{1}\".", methodInfo.Name, key).ToString());
			}
		}
	}
}
