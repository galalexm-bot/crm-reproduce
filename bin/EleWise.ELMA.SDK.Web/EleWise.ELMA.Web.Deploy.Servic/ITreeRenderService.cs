using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.Web.Deploy.Services;

public interface ITreeRenderService
{
	TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest);

	TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, bool expanded);

	TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, string id, bool expanded);

	TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, string id, string title, bool expanded);
}
