using System;

namespace Orchard.Commands;

[AttributeUsage(AttributeTargets.Method)]
public class CommandHelpAttribute : Attribute
{
	public string HelpText { get; set; }

	public CommandHelpAttribute(string text)
	{
		HelpText = text;
	}
}
