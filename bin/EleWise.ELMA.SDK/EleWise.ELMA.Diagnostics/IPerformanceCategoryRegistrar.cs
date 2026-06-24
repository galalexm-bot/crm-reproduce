using System.Collections.Generic;
using System.Diagnostics;

namespace EleWise.ELMA.Diagnostics;

internal interface IPerformanceCategoryRegistrar
{
	void CheckRegisterDefault();

	string GetMissingCountersFileName();

	void CreateCategory(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, IEnumerable<CounterCreationData> allCreationData);
}
