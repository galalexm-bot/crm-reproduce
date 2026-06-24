using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy;

internal interface IConfigurationImportInternalFactory
{
	IConfigurationTesterInternal CreateTester(IImportSettings importSettings);

	IConfigurationImporterInternal CreateImporter(IImportSettings importSettings);
}
