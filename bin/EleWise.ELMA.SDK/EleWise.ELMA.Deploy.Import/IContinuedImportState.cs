using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import;

public interface IContinuedImportState
{
	IReadOnlyCollection<IConfigImportSettings> SettingsList { get; }

	int InitialSettingsCount { get; }
}
