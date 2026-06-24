using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy;

public interface IConfigurationImportFactory
{
	IConfigurationTester CreateTester(IImportSettings importSettings);

	IConfigurationImporter CreateImporter(IImportSettings importSettings);
}
