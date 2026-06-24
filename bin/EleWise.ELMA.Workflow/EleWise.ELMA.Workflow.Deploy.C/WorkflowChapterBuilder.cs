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

[Component(Order = 400)]
internal sealed class WorkflowChapterBuilder : BPMAppChapterBuilder
{
	private readonly ProcessHeaderManager processHeaderManager;

	internal static WorkflowChapterBuilder mQTWxqOO2nJnZr1tD8dH;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(WorkflowExportConsts.ExportExtensionUid, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716626834)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1E7B3D))
	};

	public WorkflowChapterBuilder(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
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
			this.processHeaderManager = processHeaderManager;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
			{
				num = 0;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772581594));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = WorkflowExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14359042)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716425811));
		if (!(manifest.GetChapter(WorkflowExportConsts.ExportExtensionUid) is WorkflowBAChapter workflowBAChapter) || workflowBAChapter.Processes == null || workflowBAChapter.Processes.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		List<DeployTreeNode> list2 = new List<DeployTreeNode>();
		foreach (ProcessBAItem process in workflowBAChapter.Processes)
		{
			IProcessHeader processHeader = processHeaderManager.LoadOrNull(process.Uid);
			if (processHeader != null)
			{
				list2.Add(CreateNode(process.Uid.ToString(), processHeader.Name, "", processHeader.IsDirtyProcess, processHeader.Published != null));
			}
		}
		if (parameters.WithEmptyChapters || list2.Count > 0)
		{
			deployTreeNode.Children.AddRange(list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.IKG9YFZEOQ73kfI3VUfl(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	internal static bool imeEcoOOoy5OmvLUbP0K()
	{
		return mQTWxqOO2nJnZr1tD8dH == null;
	}

	internal static WorkflowChapterBuilder iJToSXOOFZ9hqOLSdBZi()
	{
		return mQTWxqOO2nJnZr1tD8dH;
	}
}
