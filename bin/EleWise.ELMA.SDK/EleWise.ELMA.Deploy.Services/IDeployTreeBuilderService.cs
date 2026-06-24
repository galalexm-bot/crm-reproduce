using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Models;

namespace EleWise.ELMA.Deploy.Services;

public interface IDeployTreeBuilderService
{
	DeployTreeModel BuildTree(BPMAppFakeManifest manifest, string id, string title);

	DeployTreeModel BuildTree(BPMAppManifest manifest, string id, IChapterParameters parameters);
}
