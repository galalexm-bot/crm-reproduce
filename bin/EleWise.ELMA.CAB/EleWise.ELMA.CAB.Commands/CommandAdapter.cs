using System;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Commands;

public abstract class CommandAdapter : IDisposable
{
	private Command boundCommand;

	public abstract int InvokerCount { get; }

	public event EventHandler ExecuteCommand;

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void BindCommand(Command command)
	{
		Guard.ArgumentNotNull(command, "command");
		if (boundCommand != null)
		{
			throw new InvalidOperationException(Resources.AdapterAlreadyBoundToACommand);
		}
		command.Changed += CommandChangedHandler;
		boundCommand = command;
	}

	public virtual void UnbindCommand(Command command)
	{
		Guard.ArgumentNotNull(command, "command");
		if (boundCommand != command)
		{
			throw new InvalidOperationException(Resources.AdapterNotBoundToGivenCommand);
		}
		command.Changed -= CommandChangedHandler;
		boundCommand = null;
	}

	public abstract void AddInvoker(object invoker, string eventName);

	public abstract void RemoveInvoker(object invoker, string eventName);

	protected virtual void Dispose(bool disposing)
	{
	}

	public abstract bool ContainsInvoker(object invoker);

	protected virtual void OnCommandChanged(Command command)
	{
	}

	protected virtual void FireCommand()
	{
		if (this.ExecuteCommand != null)
		{
			this.ExecuteCommand(this, EventArgs.Empty);
		}
	}

	private void CommandChangedHandler(object sender, EventArgs e)
	{
		OnCommandChanged((Command)sender);
	}
}
