using System;

namespace EleWise.ELMA.Locking;

public interface ILockKeyFactory
{
	IDisposable Get(string keyName);
}
