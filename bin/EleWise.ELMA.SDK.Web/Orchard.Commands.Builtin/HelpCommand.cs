using System;
using System.Linq;
using Orchard.Localization;

namespace Orchard.Commands.Builtin;

public class HelpCommand : DefaultOrchardCommandHandler
{
	private readonly ICommandManager _commandManager;

	public HelpCommand(ICommandManager commandManager)
	{
		_commandManager = commandManager;
	}

	[CommandName("help commands")]
	[CommandHelp("help commands\r\n\tDisplay help text for all available commands")]
	public void AllCommands()
	{
		base.Context.Output.WriteLine(base.T("List of available commands:"));
		base.Context.Output.WriteLine(base.T("---------------------------"));
		base.Context.Output.WriteLine();
		foreach (CommandDescriptor item in from d in _commandManager.GetCommandDescriptors()
			orderby d.Name
			select d)
		{
			base.Context.Output.WriteLine(GetHelpText(item));
			base.Context.Output.WriteLine();
		}
	}

	private LocalizedString GetHelpText(CommandDescriptor descriptor)
	{
		if (string.IsNullOrEmpty(descriptor.HelpText))
		{
			return base.T("{0}: no help text", descriptor.MethodInfo.DeclaringType.FullName + "." + descriptor.MethodInfo.Name);
		}
		return base.T(descriptor.HelpText);
	}

	[CommandName("help")]
	[CommandHelp("help <command>\r\n\tDisplay help text for <command>")]
	public void SingleCommand(string[] commandNameStrings)
	{
		string command = string.Join(" ", commandNameStrings);
		IOrderedEnumerable<CommandDescriptor> orderedEnumerable = from t in _commandManager.GetCommandDescriptors()
			where t.Name.StartsWith(command, StringComparison.OrdinalIgnoreCase)
			select t into d
			orderby d.Name
			select d;
		if (!orderedEnumerable.Any())
		{
			base.Context.Output.WriteLine(base.T("Command {0} doesn't exist").ToString(), command);
			return;
		}
		foreach (CommandDescriptor item in orderedEnumerable)
		{
			base.Context.Output.WriteLine(GetHelpText(item));
			base.Context.Output.WriteLine();
		}
	}
}
