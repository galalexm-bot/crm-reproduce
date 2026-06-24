using System;

namespace EleWise.ELMA.Runtime.Managers;

public interface IBLOBDataManager
{
	void SetBLOB<T>(Guid uid, string key, T value);

	T GetBLOB<T>(Guid uid, string key);

	void RemoveBLOB<T>(Guid uid, string key);
}
