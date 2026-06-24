using System;
using System.Collections.Generic;
using EleWise.ELMA.Logging;
using Orchard.Data;
using Orchard.Environment.Configuration;
using Orchard.Exceptions;
using Orchard.Logging;

namespace Orchard.Tasks;

public class BackgroundService : IBackgroundService, IDependency
{
	private readonly IEnumerable<IBackgroundTask> _tasks;

	private readonly ITransactionManager _transactionManager;

	private readonly string _shellName;

	public ILogger Logger { get; set; }

	public BackgroundService(IEnumerable<IBackgroundTask> tasks, ITransactionManager transactionManager, ShellSettings shellSettings)
	{
		_tasks = tasks;
		_transactionManager = transactionManager;
		_shellName = shellSettings.Name;
		Logger = NullLogger.Instance;
	}

	public void Sweep()
	{
		foreach (IBackgroundTask task in _tasks)
		{
			string fullName = task.GetType().FullName;
			try
			{
				Logger.Information("Start processing background task \"{0}\" on tenant \"{1}\".", fullName, _shellName);
				_transactionManager.RequireNew();
				task.Sweep();
				Logger.Information("Finished processing background task \"{0}\" on tenant \"{1}\".", fullName, _shellName);
			}
			catch (Exception ex)
			{
				if (ex.IsFatal())
				{
					throw;
				}
				_transactionManager.Cancel();
				Logger.Error(ex, "Error while processing background task \"{0}\" on tenant \"{1}\".", fullName, _shellName);
			}
		}
	}
}
