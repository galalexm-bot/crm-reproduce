using System;

namespace Orchard.Commands;

[AttributeUsage(AttributeTargets.Method)]
public class CommandNameAttribute : Attribute
{
	private readonly string _commandAlias;

	public string Command => _commandAlias;

	public CommandNameAttribute(string commandAlias)
	{
		_commandAlias = commandAlias;
	}
}
