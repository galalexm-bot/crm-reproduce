using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import;

public interface IImportSettings
{
	int ImportStep { get; set; }

	ICollection<TestImportMessages> TestResult { get; }
}
