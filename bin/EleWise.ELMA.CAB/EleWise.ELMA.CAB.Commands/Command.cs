#define TRACE
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Commands;

public class Command : IDisposable, IBuilderAware
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(Command).FullName)
		{
		}
	}

	private readonly List<CommandAdapter> adapters = new List<CommandAdapter>();

	private readonly List<CommandAdapter> ownedAdapters = new List<CommandAdapter>();

	private ICommandAdapterMapService mapService;

	private string name;

	private CommandStatus status = CommandStatus.Enabled;

	[ServiceDependency]
	public ICommandAdapterMapService MapService
	{
		set
		{
			mapService = value;
		}
	}

	[ClassNameTraceSource]
	public TraceSource TraceSource { protected get; set; }

	public string Name => name;

	public CommandStatus Status
	{
		get
		{
			return status;
		}
		set
		{
			CommandStatus commandStatus = status;
			status = value;
			if (commandStatus != value)
			{
				OnChanged();
				if (TraceSource != null)
				{
					TraceSource.TraceInformation(Resources.TraceCommandStatusChanged, name, status);
				}
			}
		}
	}

	public virtual ReadOnlyCollection<CommandAdapter> Adapters => new ReadOnlyCollection<CommandAdapter>(adapters);

	public event EventHandler Changed;

	public event EventHandler ExecuteAction;

	public virtual void OnBuiltUp(string id)
	{
		name = id;
	}

	public virtual void OnTearingDown()
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void AddCommandAdapter(CommandAdapter adapter)
	{
		adapter.ExecuteCommand += OnExecuteAction;
		adapter.BindCommand(this);
		adapters.Add(adapter);
	}

	public virtual void RemoveCommandAdapter(CommandAdapter adapter)
	{
		adapter.ExecuteCommand -= OnExecuteAction;
		adapter.UnbindCommand(this);
		adapters.Remove(adapter);
	}

	public virtual void Execute()
	{
		if (status == CommandStatus.Enabled)
		{
			OnExecuteAction(this, EventArgs.Empty);
			if (TraceSource != null)
			{
				TraceSource.TraceInformation(Resources.TraceCommandExecuted, name);
			}
		}
	}

	public virtual ReadOnlyCollection<TAdapter> FindAdapters<TAdapter>() where TAdapter : CommandAdapter
	{
		List<TAdapter> found = new List<TAdapter>();
		adapters.ForEach(delegate(CommandAdapter adapter)
		{
			if (adapter is TAdapter)
			{
				found.Add((TAdapter)adapter);
			}
		});
		return new ReadOnlyCollection<TAdapter>(found);
	}

	public virtual void AddInvoker(object invoker, string eventName)
	{
		if (mapService == null)
		{
			throw new CommandException(string.Format(CultureInfo.CurrentCulture, Resources.CannotGetMapService, new object[1] { name }));
		}
		CommandAdapter commandAdapter = mapService.CreateAdapter(invoker.GetType());
		if (commandAdapter == null)
		{
			throw new CommandException(string.Format(CultureInfo.CurrentCulture, Resources.CannotGetCommandAdapter, new object[1] { invoker.GetType() }));
		}
		commandAdapter.AddInvoker(invoker, eventName);
		AddCommandAdapter(commandAdapter);
		ownedAdapters.Add(commandAdapter);
	}

	public virtual void RemoveInvoker(object invoker, string eventName)
	{
		CommandAdapter[] array = adapters.ToArray();
		foreach (CommandAdapter commandAdapter in array)
		{
			if (!commandAdapter.ContainsInvoker(invoker))
			{
				continue;
			}
			commandAdapter.RemoveInvoker(invoker, eventName);
			if (commandAdapter.InvokerCount == 0)
			{
				RemoveCommandAdapter(commandAdapter);
				if (ownedAdapters.Contains(commandAdapter))
				{
					ownedAdapters.Remove(commandAdapter);
					commandAdapter.Dispose();
				}
			}
		}
	}

	protected virtual void OnExecuteAction(object sender, EventArgs e)
	{
		if (Status == CommandStatus.Enabled && this.ExecuteAction != null)
		{
			this.ExecuteAction(this, e);
		}
	}

	protected virtual void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	internal bool IsHandlerRegistered(object target, MethodInfo methodInfo)
	{
		if (this.ExecuteAction != null)
		{
			Delegate[] invocationList = this.ExecuteAction.GetInvocationList();
			foreach (Delegate @delegate in invocationList)
			{
				if (@delegate.Target == target && @delegate.Method == methodInfo)
				{
					return true;
				}
			}
		}
		return false;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			RemoveCommandAdapters();
		}
	}

	private void RemoveCommandAdapters()
	{
		CommandAdapter[] array = adapters.ToArray();
		foreach (CommandAdapter adapter in array)
		{
			RemoveCommandAdapter(adapter);
		}
		array = ownedAdapters.ToArray();
		foreach (CommandAdapter adapter in array)
		{
			adapter.Dispose();
		}
	}
}
