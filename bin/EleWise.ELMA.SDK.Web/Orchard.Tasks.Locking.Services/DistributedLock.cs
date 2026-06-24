using System;

namespace Orchard.Tasks.Locking.Services;

public class DistributedLock : IDistributedLock, IDisposable
{
	private readonly string _name;

	private readonly string _internalName;

	private readonly Action _releaseLockAction;

	private int _count;

	string IDistributedLock.Name => _name;

	internal string InternalName => _internalName;

	internal DistributedLock(string name, string internalName, Action releaseLockAction)
	{
		_name = name;
		_internalName = internalName;
		_releaseLockAction = releaseLockAction;
		_count = 1;
	}

	internal void Increment()
	{
		_count++;
	}

	public void Dispose()
	{
		_count--;
		if (_count == 0)
		{
			_releaseLockAction();
		}
	}
}
