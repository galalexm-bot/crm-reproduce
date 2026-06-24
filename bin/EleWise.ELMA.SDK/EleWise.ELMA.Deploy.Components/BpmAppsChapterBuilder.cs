using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 200)]
internal sealed class BpmAppsChapterBuilder : BPMAppChapterBuilder
{
	internal static BpmAppsChapterBuilder XIlaOuEsz9gEx9iTlh3d;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(BpmAppsExportConsts.ExportBpmAppsUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638727891)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978681787))
	};

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710567732));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		if (!(manifest.GetChapter(BpmAppsExportConsts.ExportBpmAppsUid) is BpmAppsBAChapter bpmAppsBAChapter))
		{
			return list;
		}
		List<DeployTreeNode> list2 = bpmAppsBAChapter.Components.Select((BpmAppBAItem item) => CreateNode(dE7OOXEcotSMVjstJQ11(item).ToString(), (string)D53EYAEcbiJfqcU0VRuV(item), "")).ToList();
		if (list2.Count > 0)
		{
			DeployTreeNode deployTreeNode = new DeployTreeNode(bpmAppsBAChapter.Uid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637B20A7)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957494502), list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.G4SsXq8ms5JstyEw2uw1(n), StringComparer.CurrentCultureIgnoreCase).ToList());
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	public BpmAppsChapterBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OGOLwVEcWvn5KGKtnkoD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OGOLwVEcWvn5KGKtnkoD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool e8Ont8EcF7MJF5y7PHV6()
	{
		return XIlaOuEsz9gEx9iTlh3d == null;
	}

	internal static BpmAppsChapterBuilder mhEJc6EcBpBjIEmAq1gP()
	{
		return XIlaOuEsz9gEx9iTlh3d;
	}

	internal static Guid dE7OOXEcotSMVjstJQ11(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static object D53EYAEcbiJfqcU0VRuV(object P_0)
	{
		return ((BpmAppBAItem)P_0).BpmAppTitle;
	}
}
