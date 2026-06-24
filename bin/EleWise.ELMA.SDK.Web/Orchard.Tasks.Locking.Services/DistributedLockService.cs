using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using Orchard.Data;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Exceptions;
using Orchard.Logging;
using Orchard.Services;
using Orchard.Tasks.Locking.Records;

namespace Orchard.Tasks.Locking.Services;

public class DistributedLockService : Component, IDistributedLockService, IDependency
{
	private readonly IApplicationEnvironment _applicationEnvironment;

	private readonly ILifetimeScope _lifetimeScope;

	private readonly ILockKeyFactory lockKeyFactory;

	private readonly IClock _clock;

	private readonly ShellSettings _shellSettings;

	private readonly Dictionary<IDisposable, DistributedLock> locks;

	private readonly TimeSpan _defaultRepeatInterval;

	public DistributedLockService(ILockKeyFactory lockKeyFactory, IApplicationEnvironment applicationEnvironment, ILifetimeScope lifetimeScope, IClock clock, ShellSettings shellSettings)
	{
		this.lockKeyFactory = lockKeyFactory;
		_clock = clock;
		_lifetimeScope = lifetimeScope;
		_shellSettings = shellSettings;
		_applicationEnvironment = applicationEnvironment;
		locks = new Dictionary<IDisposable, DistributedLock>();
		_defaultRepeatInterval = TimeSpan.FromMilliseconds(500.0);
	}

	public bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out IDistributedLock dLock)
	{
		try
		{
			dLock = AcquireLockInternal(name, maxValidFor, timeout, throwOnTimeout: false);
			if (dLock != null)
			{
				base.Logger.Debug("Successfully acquired lock '{0}'.", name);
				return true;
			}
			base.Logger.Warning("Failed to acquire lock '{0}' within the specified timeout ({1}).", name, timeout);
		}
		catch (Exception exception)
		{
			base.Logger.Error(exception, "Error while trying to acquire lock '{0}'.", name);
		}
		dLock = null;
		return false;
	}

	public IDistributedLock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout)
	{
		try
		{
			DistributedLock result = AcquireLockInternal(name, maxValidFor, timeout, throwOnTimeout: true);
			base.Logger.Debug("Successfully acquired lock '{0}'.", name);
			return result;
		}
		catch (Exception exception)
		{
			base.Logger.Error(exception, "Error while trying to acquire lock '{0}'.", name);
			throw;
		}
	}

	private DistributedLock AcquireLockInternal(string name, TimeSpan? maxValidFor, TimeSpan? timeout, bool throwOnTimeout)
	{
		string internalName = GetInternalLockName(name);
		TimeSpan timeout2 = (timeout.HasValue ? timeout.Value : TimeSpan.FromMilliseconds(-1.0));
		IDisposable monitorObj = lockKeyFactory.Get($"{_applicationEnvironment.GetEnvironmentIdentifier()}:{internalName}");
		try
		{
			if (!Monitor.TryEnter(monitorObj, timeout2))
			{
				base.Logger.Debug("Could not enter local monitor for lock '{0}' within the specified timeout ({1}).", internalName, timeout);
				if (throwOnTimeout)
				{
					throw new TimeoutException($"Failed to acquire lock '{internalName}' within the specified timeout ({timeout}).");
				}
				return null;
			}
			base.Logger.Debug("Successfully entered local monitor for lock '{0}'.", internalName);
			try
			{
				DistributedLock dLock = null;
				if (locks.TryGetValue(monitorObj, out dLock))
				{
					base.Logger.Debug("Current thread is re-entering lock '{0}'; incrementing count.", internalName);
					dLock.Increment();
				}
				else if (!RepeatUntilTimeout(timeout, _defaultRepeatInterval, delegate
				{
					if (EnsureDistributedLockRecord(internalName, maxValidFor))
					{
						base.Logger.Debug("Record for lock '{0}' already owned by current machine or was successfully created; creating lock object.", internalName);
						dLock = new DistributedLock(name, internalName, delegate
						{
							Monitor.Exit(monitorObj);
							DeleteDistributedLockRecord(internalName);
						});
						locks.Add(monitorObj, dLock);
						return true;
					}
					return false;
				}))
				{
					base.Logger.Debug("Record for lock '{0}' could not be created for current machine within the specified timeout ({1}).", internalName, timeout);
					if (throwOnTimeout)
					{
						throw new TimeoutException($"Failed to acquire lock '{internalName}' within the specified timeout ({timeout}).");
					}
					return null;
				}
				return dLock;
			}
			catch (Exception exception)
			{
				Monitor.Exit(monitorObj);
				base.Logger.Error(exception, "An error occurred while trying to acquire lock '{0}'.", internalName);
				throw;
			}
		}
		finally
		{
			if (monitorObj != null)
			{
				monitorObj.Dispose();
			}
		}
	}

	private bool EnsureDistributedLockRecord(string internalName, TimeSpan? maxValidFor)
	{
		string environmentIdentifier = _applicationEnvironment.GetEnvironmentIdentifier();
		bool hasLockRecord = false;
		ExecuteOnSeparateTransaction(delegate(IRepository<DistributedLockRecord> repository)
		{
			List<DistributedLockRecord> list = repository.Table.Where((DistributedLockRecord x) => x.Name == internalName).ToList();
			DistributedLockRecord distributedLockRecord = list.FirstOrDefault((DistributedLockRecord x) => !x.ValidUntilUtc.HasValue || x.ValidUntilUtc >= _clock.UtcNow);
			if (distributedLockRecord == null)
			{
				if (list.Any())
				{
					foreach (DistributedLockRecord item in list)
					{
						repository.Delete(item);
					}
					repository.Flush();
				}
				base.Logger.Debug("No valid record was found for lock '{0}'; creating a new record.", internalName);
				repository.Create(new DistributedLockRecord
				{
					Name = internalName,
					MachineName = environmentIdentifier,
					CreatedUtc = _clock.UtcNow,
					ValidUntilUtc = (maxValidFor.HasValue ? new DateTime?(_clock.UtcNow + maxValidFor.Value) : null)
				});
				hasLockRecord = true;
			}
			else if (distributedLockRecord.MachineName == environmentIdentifier)
			{
				base.Logger.Debug("Found a valid record for lock '{0}' and current local machine name '{1}'.", internalName, environmentIdentifier);
				hasLockRecord = true;
			}
		});
		return hasLockRecord;
	}

	private void DeleteDistributedLockRecord(string internalName)
	{
		try
		{
			ExecuteOnSeparateTransaction(delegate(IRepository<DistributedLockRecord> repository)
			{
				DistributedLockRecord distributedLockRecord = repository.Table.FirstOrDefault((DistributedLockRecord x) => x.Name == internalName);
				if (distributedLockRecord == null)
				{
					throw new Exception($"No record could be found in the database for lock '{internalName}'.");
				}
				repository.Delete(distributedLockRecord);
				base.Logger.Debug("Successfully deleted record for lock '{0}'.", internalName);
			});
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			base.Logger.Warning(ex, "An error occurred while deleting record for lock '{0}'.", internalName);
		}
	}

	private bool RepeatUntilTimeout(TimeSpan? timeout, TimeSpan repeatInterval, Func<bool> action)
	{
		TimeSpan zero = TimeSpan.Zero;
		bool result;
		while (!(result = action()) && (!timeout.HasValue || zero < timeout.Value))
		{
			Task.Delay(repeatInterval).Wait();
			zero += repeatInterval;
		}
		return result;
	}

	private void ExecuteOnSeparateTransaction(Action<IRepository<DistributedLockRecord>> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException();
		}
		ILifetimeScope val = _lifetimeScope.BeginLifetimeScope();
		try
		{
			IRepository<DistributedLockRecord> obj = ResolutionExtensions.Resolve<IRepository<DistributedLockRecord>>((IComponentContext)(object)val);
			ResolutionExtensions.Resolve<ITransactionManager>((IComponentContext)(object)val).RequireNew(IsolationLevel.ReadCommitted);
			action(obj);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private string GetInternalLockName(string name)
	{
		return $"DistributedLock:{_shellSettings.Name}:{name}";
	}
}
