using System.Collections.Generic;
using Orchard.Caching;

namespace Orchard.Environment;

public static class OrchardHostContainerRegistry
{
	private static readonly IList<Weak<IShim>> _shims = new List<Weak<IShim>>();

	private static IOrchardHostContainer _hostContainer;

	private static readonly object _syncLock = new object();

	public static void RegisterShim(IShim shim)
	{
		lock (_syncLock)
		{
			CleanupShims();
			_shims.Add(new Weak<IShim>(shim));
			shim.HostContainer = _hostContainer;
		}
	}

	public static void RegisterHostContainer(IOrchardHostContainer container)
	{
		lock (_syncLock)
		{
			CleanupShims();
			_hostContainer = container;
			RegisterContainerInShims();
		}
	}

	private static void RegisterContainerInShims()
	{
		foreach (Weak<IShim> shim in _shims)
		{
			IShim target = shim.Target;
			if (target != null)
			{
				target.HostContainer = _hostContainer;
			}
		}
	}

	private static void CleanupShims()
	{
		for (int num = _shims.Count - 1; num >= 0; num--)
		{
			if (_shims[num].Target == null)
			{
				_shims.RemoveAt(num);
			}
		}
	}
}
