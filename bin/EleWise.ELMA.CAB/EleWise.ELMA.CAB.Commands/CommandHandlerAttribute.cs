using System;

namespace EleWise.ELMA.CAB.Commands;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class CommandHandlerAttribute : Attribute
{
	private readonly string commandName;

	public string CommandName => commandName;

	public CommandHandlerAttribute(string commandName)
	{
		this.commandName = commandName;
	}
}
