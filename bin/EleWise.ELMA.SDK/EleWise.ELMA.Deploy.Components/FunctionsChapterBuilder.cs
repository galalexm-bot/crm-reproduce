using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 1050)]
internal sealed class FunctionsChapterBuilder : BPMAppChapterBuilder
{
	private readonly IFunctionMetadataItemHeaderManager funcManager;

	private static FunctionsChapterBuilder VPrQdeEcfv6Yb6oXM4J4;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(FunctionExportConsts.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53FA46B)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289686636))
	};

	public FunctionsChapterBuilder(IFunctionMetadataItemHeaderManager funcManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JtOCmFEcv7POcMTd07g1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
			this.funcManager = funcManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812054968));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = FunctionExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103CE1BD)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5115F7E3));
		if (!(manifest.GetChapter(FunctionExportConsts.ExportExtensionUid) is FunctionBAChapter functionBAChapter) || functionBAChapter.Functions == null || functionBAChapter.Functions.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		ICollection<DeployTreeNode> nodes = GetNodes(functionBAChapter.Functions);
		if (parameters.WithEmptyChapters || nodes.Count > 0)
		{
			deployTreeNode.Children.AddRange(nodes.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.fKx9sd8yEMpLTcMP51oX(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	private ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items)
	{
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		foreach (BPMAppManifestItem item in items)
		{
			try
			{
				FunctionMetadataItemHeader functionMetadataItemHeader = funcManager.LoadOrNull(item.Uid);
				if (functionMetadataItemHeader != null)
				{
					list.Add(CreateNode(item.Uid.ToString(), functionMetadataItemHeader.DisplayName, ""));
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939702926) + item.Uid, exception);
			}
		}
		return list;
	}

	internal static void JtOCmFEcv7POcMTd07g1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gUDXfnEcQHEwrEPZYvJZ()
	{
		return VPrQdeEcfv6Yb6oXM4J4 == null;
	}

	internal static FunctionsChapterBuilder oK8QvyEcCxNcOQy6ncbI()
	{
		return VPrQdeEcfv6Yb6oXM4J4;
	}
}
