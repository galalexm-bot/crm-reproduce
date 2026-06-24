using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 2500)]
internal sealed class PackagesChapterBuilder : BPMAppChapterBuilder
{
	internal static PackagesChapterBuilder KivsxrEcVfAYNtrsxmcb;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(PackageExportConsts.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C563243)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A308E9E))
	};

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F4C14));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = PackageExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = new DeployTreeNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16427941)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFD88C2));
		if (!(manifest.GetChapter(PackageExportConsts.ExportExtensionUid) is PackagesBAChapter packagesBAChapter) || packagesBAChapter.Packages == null || packagesBAChapter.Packages.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		deployTreeNode.Children.AddRange(packagesBAChapter.Packages.Select((PackageBAItem pkg) => CreateNode(pkg.PackageId, (!VekeOFEcKA0CPomb3RA5(QPiMBxEcqo47YQhKbSIc(pkg))) ? pkg.PackageTitle : pkg.PackageId, "")).OrderBy((DeployTreeNode n) => n.Text, StringComparer.CurrentCultureIgnoreCase));
		deployTreeNode.Count = deployTreeNode.Children.Count;
		list.Add(deployTreeNode);
		return list;
	}

	public PackagesChapterBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fEBoakEcReysia9JLhpq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void fEBoakEcReysia9JLhpq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool U35OOoEcSOna5OYsVb0A()
	{
		return KivsxrEcVfAYNtrsxmcb == null;
	}

	internal static PackagesChapterBuilder GwGmpSEciIYK6KrRHaRW()
	{
		return KivsxrEcVfAYNtrsxmcb;
	}

	internal static object QPiMBxEcqo47YQhKbSIc(object P_0)
	{
		return ((PackageBAItem)P_0).PackageTitle;
	}

	internal static bool VekeOFEcKA0CPomb3RA5(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
