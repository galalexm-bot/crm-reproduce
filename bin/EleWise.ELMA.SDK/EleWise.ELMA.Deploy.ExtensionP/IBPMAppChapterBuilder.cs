using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;

namespace EleWise.ELMA.Deploy.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IBPMAppChapterBuilder
{
	IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppFakeManifest manifest);

	IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters);
}
