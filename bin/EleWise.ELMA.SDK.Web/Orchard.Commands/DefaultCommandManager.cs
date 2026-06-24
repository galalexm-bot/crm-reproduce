using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Features.Metadata;
using EleWise.ELMA.Logging;
using Orchard.Localization;

namespace Orchard.Commands;

public class DefaultCommandManager : ICommandManager, IDependency
{
	private class Match
	{
		public CommandContext Context { get; set; }

		public Func<ICommandHandler> CommandHandlerFactory { get; set; }
	}

	private readonly IEnumerable<Meta<Func<ICommandHandler>>> _handlers;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public DefaultCommandManager(IEnumerable<Meta<Func<ICommandHandler>>> handlers)
	{
		_handlers = handlers;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public void Execute(CommandParameters parameters)
	{
		IEnumerable<Match> source = MatchCommands(parameters);
		if (source.Count() == 1)
		{
			Match match = source.Single();
			match.CommandHandlerFactory().Execute(match.Context);
			return;
		}
		string text = string.Join(" ", parameters.Arguments.ToArray());
		string text2 = string.Join(",", (from d in GetCommandDescriptors()
			select d.Name).ToArray());
		if (source.Any())
		{
			throw new OrchardCoreException(T("Multiple commands found matching arguments \"{0}\". Commands available: {1}.", text, text2));
		}
		throw new OrchardCoreException(T("No command found matching arguments \"{0}\". Commands available: {1}.", text, text2));
	}

	public IEnumerable<CommandDescriptor> GetCommandDescriptors()
	{
		return _handlers.SelectMany((Meta<Func<ICommandHandler>> h) => GetDescriptor(h.get_Metadata()).Commands);
	}

	private IEnumerable<Match> MatchCommands(CommandParameters parameters)
	{
		foreach (int item in Enumerable.Range(1, parameters.Arguments.Count()).Reverse())
		{
			int count = item;
			List<Match> list = _handlers.SelectMany((Meta<Func<ICommandHandler>> h) => MatchCommands(parameters, count, GetDescriptor(h.get_Metadata()), h.get_Value())).ToList();
			if (list.Any())
			{
				return list;
			}
		}
		return Enumerable.Empty<Match>();
	}

	private static IEnumerable<Match> MatchCommands(CommandParameters parameters, int argCount, CommandHandlerDescriptor descriptor, Func<ICommandHandler> handlerFactory)
	{
		foreach (CommandDescriptor command in descriptor.Commands)
		{
			string[] array = command.Name.Split(' ');
			if (parameters.Arguments.Take(argCount).SequenceEqual(array, StringComparer.OrdinalIgnoreCase))
			{
				yield return new Match
				{
					Context = new CommandContext
					{
						Arguments = parameters.Arguments.Skip(array.Count()),
						Command = string.Join(" ", array),
						CommandDescriptor = command,
						Input = parameters.Input,
						Output = parameters.Output,
						Switches = parameters.Switches
					},
					CommandHandlerFactory = handlerFactory
				};
			}
		}
	}

	private static CommandHandlerDescriptor GetDescriptor(IDictionary<string, object> metadata)
	{
		return (CommandHandlerDescriptor)metadata[typeof(CommandHandlerDescriptor).FullName];
	}
}
