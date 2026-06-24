using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Components;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.BPMApps;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Components;

[Component(Order = 410)]
internal sealed class CustomActivityChapterBuilder : BPMAppChapterBuilder
{
	private readonly CustomActivityHeaderManager caManager;

	internal static CustomActivityChapterBuilder s9cpltcxynCL4cGXHqx;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(CustomActivityExportConsts.ExportExtensionUid, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658660029)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1969850261 ^ -1969880765))
	};

	public CustomActivityChapterBuilder(CustomActivityHeaderManager caManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O8orHhcwHNL3AJKE79C();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.caManager = caManager;
			num = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901337984 ^ -901327430));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = CustomActivityExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x927D360 ^ 0x9279486)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1363339545 ^ -1363316785));
		if (!(manifest.GetChapter(CustomActivityExportConsts.ExportExtensionUid) is CustomActivityBAChapter customActivityBAChapter) || customActivityBAChapter.CustomActivities == null || customActivityBAChapter.CustomActivities.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		List<DeployTreeNode> list2 = new List<DeployTreeNode>();
		foreach (CustomActivityBAItem customActivity in customActivityBAChapter.CustomActivities)
		{
			ICustomActivityHeader customActivityHeader = caManager.LoadOrNull(customActivity.Uid);
			if (customActivityHeader != null)
			{
				list2.Add(CreateNode(customActivity.Uid.ToString(), customActivityHeader.Name, "", customActivityHeader.IsDirtyCustomActivity, customActivityHeader.Published != null));
			}
		}
		if (parameters.WithEmptyChapters || list2.Count > 0)
		{
			deployTreeNode.Children.AddRange(list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.xCxdBjRZsbJnf9h13oS(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	internal static void O8orHhcwHNL3AJKE79C()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool FlPbe9cFPHR3ajgBVPu()
	{
		return s9cpltcxynCL4cGXHqx == null;
	}

	internal static CustomActivityChapterBuilder QdNj9xc8OAPl5f9ePZx()
	{
		return s9cpltcxynCL4cGXHqx;
	}
}
