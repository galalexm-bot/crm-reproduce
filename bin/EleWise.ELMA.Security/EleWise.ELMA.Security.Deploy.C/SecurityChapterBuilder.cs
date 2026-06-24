using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Components;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.BPMApps;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Components;

[Component(Order = 100)]
internal sealed class SecurityChapterBuilder : BPMAppChapterBuilder
{
	private readonly UserGroupManager userGroupManager;

	private static SecurityChapterBuilder D0AUBnbaX4OXdaYghwn;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(SecurityExportConsts.ExportExtensionUidUserGroup, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FACDF7)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x40099E74)),
		new BPMAppChapterBuilderTemplate(SecurityExportConsts.ExportExtensionUidOrgstructure, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA5DAE86 ^ 0xA5D5372)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD4DC5A))
	};

	public SecurityChapterBuilder(UserGroupManager userGroupManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HM0U7cb2WtciDw5F98Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
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
			this.userGroupManager = userGroupManager;
			num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD873E2));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUidOrgstructure = SecurityExportConsts.ExportExtensionUidOrgstructure;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUidOrgstructure.ToString(), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E7956CB)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6547C338 ^ 0x65473D10));
		exportExtensionUidOrgstructure = SecurityExportConsts.ExportExtensionUidUserGroup;
		DeployTreeNode deployTreeNode2 = CreateNode(exportExtensionUidOrgstructure.ToString(), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7A093321 ^ 0x7A09CE9B)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D359B9));
		if (!(manifest.GetChapter(SecurityExportConsts.ExportExtensionUid) is SecurityBAChapter securityBAChapter) || (!securityBAChapter.ExportFullOrgstructure && (securityBAChapter.UserGroups == null || securityBAChapter.UserGroups.Count == 0)))
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
				list.Add(deployTreeNode2);
			}
			return list;
		}
		if (securityBAChapter.ExportFullOrgstructure)
		{
			deployTreeNode.Children.Add(CreateNode(deployTreeNode.Id + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426943278), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DF5BAA)), ""));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		else if (parameters.WithEmptyChapters)
		{
			list.Add(deployTreeNode);
		}
		if (securityBAChapter.UserGroups != null && securityBAChapter.UserGroups.Count > 0)
		{
			List<DeployTreeNode> list2 = new List<DeployTreeNode>();
			foreach (UserGroupBAItem userGroup2 in securityBAChapter.UserGroups)
			{
				IUserGroup userGroup = userGroupManager.LoadOrNull(userGroup2.Uid);
				if (userGroup != null)
				{
					list2.Add(CreateNode(userGroup2.Uid.ToString(), userGroup.Name, ""));
				}
			}
			if (parameters.WithEmptyChapters || list2.Count > 0)
			{
				deployTreeNode2.Children.AddRange(list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.WhXqZepUDWFvkfHJLc6P(n), StringComparer.CurrentCultureIgnoreCase));
				deployTreeNode2.Count = deployTreeNode2.Children.Count;
				list.Add(deployTreeNode2);
			}
		}
		return list;
	}

	internal static void HM0U7cb2WtciDw5F98Z()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool LdwOSLbRYsJ337rvVpa()
	{
		return D0AUBnbaX4OXdaYghwn == null;
	}

	internal static SecurityChapterBuilder EJKSkFbwcyPiDgUaldY()
	{
		return D0AUBnbaX4OXdaYghwn;
	}
}
