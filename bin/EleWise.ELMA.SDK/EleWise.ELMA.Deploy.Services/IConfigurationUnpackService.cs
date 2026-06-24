using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Deploy.Services;

public interface IConfigurationUnpackService
{
	IEnumerable<IConfigImportSettings> Unpack(BinaryFile file, ILogger logger = null, bool checkManifests = true, bool tagFilter = true);

	IEnumerable<IConfigImportSettings> FilterByTags(IEnumerable<IConfigImportSettings> importSettings);

	void ValidateComponents(IEnumerable<IConfigImportSettings> importSettings);
}
