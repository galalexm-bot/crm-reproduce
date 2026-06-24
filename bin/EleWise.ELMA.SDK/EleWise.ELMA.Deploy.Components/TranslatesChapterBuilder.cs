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

[Component(Order = 2700)]
internal sealed class TranslatesChapterBuilder : BPMAppChapterBuilder
{
	internal static TranslatesChapterBuilder fvK1YSEcwZLgLDc62wJF;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(TranslateExportConst.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -233974658)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE6D6BB))
	};

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD52E56));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		if (!(manifest.GetChapter(TranslateExportConst.ExportExtensionUid) is TranslatesBAChapter translatesBAChapter) || translatesBAChapter.Translates == null || translatesBAChapter.Translates.Count == 0)
		{
			return list;
		}
		List<DeployTreeNode> children = translatesBAChapter.Translates.Select((TranslateBAItem item) => CreateNode(tI9LXiEcHkO9UPfY2ZKD(item).ToString(), item.Name, "")).OrderBy((DeployTreeNode n) => (string)_003C_003Ec.f0WNnt8ym7HYe6tnLdWu(n), StringComparer.CurrentCultureIgnoreCase).ToList();
		DeployTreeNode deployTreeNode = new DeployTreeNode(translatesBAChapter.Uid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106319802)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC44C82), children);
		deployTreeNode.Count = deployTreeNode.Children.Count;
		list.Add(deployTreeNode);
		return list;
	}

	public TranslatesChapterBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dycHabEc4OoD3Ucc6M8E()
	{
		return fvK1YSEcwZLgLDc62wJF == null;
	}

	internal static TranslatesChapterBuilder GxkEpEEc6fk44anuKIom()
	{
		return fvK1YSEcwZLgLDc62wJF;
	}

	internal static Guid tI9LXiEcHkO9UPfY2ZKD(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}
}
