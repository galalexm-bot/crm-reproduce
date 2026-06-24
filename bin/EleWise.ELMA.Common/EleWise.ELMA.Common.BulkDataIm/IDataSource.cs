using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

public interface IDataSource : IEnumerable<DataTable>, IEnumerable
{
	int PackageSize { get; }

	long CurrentIndex { get; }

	DataTable Current { get; }

	long Count();

	bool Read();

	void CleanUp();
}
