using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Services;

public interface IAdditionalFilesService
{
	string GetHelpFilePath(string fileName, string helpFileName);

	string GetStoreAdditionalFilesPath(ElmaStoreComponentManifest manifest);

	string GetStoreAdditionalFilesPathMessage(ElmaStoreComponentManifest manifest);
}
