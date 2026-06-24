using System;

namespace EleWise.ELMA.Locking;

public interface ILock : IDisposable
{
	string Name { get; }
}
