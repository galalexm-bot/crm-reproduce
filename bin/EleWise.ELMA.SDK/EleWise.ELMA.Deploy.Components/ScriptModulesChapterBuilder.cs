using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.BPMApps;
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 800)]
internal sealed class ScriptModulesChapterBuilder : BPMAppChapterBuilder
{
	private readonly GlobalScriptModuleHeaderManager globalModuleManager;

	private static ScriptModulesChapterBuilder EETTCQEcpsRZWWUB9gZk;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(ScriptModuleExportConsts.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633188067)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x832049A))
	};

	public ScriptModulesChapterBuilder(GlobalScriptModuleHeaderManager globalModuleManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IoSfCeEctyTL6bGFOT9y();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.globalModuleManager = globalModuleManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541741681));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = ScriptModuleExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC7BA05)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A68A6F));
		if (!(manifest.GetChapter(ScriptModuleExportConsts.ExportExtensionUid) is ScriptModulesBAChapter scriptModulesBAChapter) || scriptModulesBAChapter.Modules == null || scriptModulesBAChapter.Modules.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		List<DeployTreeNode> list2 = new List<DeployTreeNode>();
		foreach (ScriptModuleBAItem module in scriptModulesBAChapter.Modules)
		{
			IGlobalScriptModuleHeader globalScriptModuleHeader = globalModuleManager.LoadOrNull(module.Uid);
			if (globalScriptModuleHeader != null)
			{
				list2.Add(CreateNode(module.Uid.ToString(), globalScriptModuleHeader.Name, ""));
			}
		}
		if (parameters.WithEmptyChapters || list2.Count > 0)
		{
			deployTreeNode.Children.AddRange(list2.OrderBy((DeployTreeNode n) => n.Text, StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	internal static void IoSfCeEctyTL6bGFOT9y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool c9xGbAEcaN4C3mYFQEVZ()
	{
		return EETTCQEcpsRZWWUB9gZk == null;
	}

	internal static ScriptModulesChapterBuilder xZX60fEcDVH4EYWWGWyk()
	{
		return EETTCQEcpsRZWWUB9gZk;
	}
}
