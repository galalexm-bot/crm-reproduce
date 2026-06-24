using System.Collections.Generic;

namespace EleWise.ELMA.Serialization;

public interface IStoreValuesObject
{
	IDictionary<string, string> GetStorageValues();

	void SetStorageValues(IDictionary<string, string> values);
}
