using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

public abstract class MetadataHeaderChapterBuilder : BPMAppChapterBuilder
{
	protected readonly IMetadataRuntimeService MetadataService;

	protected readonly MetadataItemHeaderManager MetadataItemHeaderManager;

	internal static MetadataHeaderChapterBuilder bCdb4nEs0h34KTbqcQ74;

	public MetadataHeaderChapterBuilder(IMetadataRuntimeService metadataService, MetadataItemHeaderManager metadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IMRgiCEsMaJPMYWjw1Gv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				MetadataItemHeaderManager = metadataItemHeaderManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				break;
			default:
				MetadataService = metadataService;
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}

	protected ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items)
	{
		return GetNodes(items, isSystemObject: false, null);
	}

	protected ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items, bool isSystemObject)
	{
		return GetNodes(items, isSystemObject, null);
	}

	protected ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items, Func<BPMAppManifestItem, string, string> getNodeName)
	{
		return GetNodes(items, isSystemObject: false, getNodeName);
	}

	protected ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items, bool isSystemObject, Func<BPMAppManifestItem, string, string> getNodeName)
	{
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		foreach (BPMAppManifestItem item in items)
		{
			DeployTreeNode deployTreeNode = null;
			if (!isSystemObject)
			{
				deployTreeNode = GetNodeByLoadMetadataHeader(item.Uid);
			}
			if (deployTreeNode == null)
			{
				deployTreeNode = GetNodeWithMetadataService(item.Uid);
			}
			if (deployTreeNode != null)
			{
				UpdateNodeNameIfNeed(getNodeName, item, deployTreeNode);
				list.Add(deployTreeNode);
			}
		}
		return list;
	}

	protected DeployTreeNode GetNodeByLoadMetadataHeader(Guid itemUid)
	{
		int num = 1;
		int num2 = num;
		string title = default(string);
		IMetadataItemHeader metadataItemHeader = default(IMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				title = (string)No9CidEsJKGYreRHfalZ(metadataItemHeader);
				num2 = 3;
				continue;
			case 3:
				return CreateNode(itemUid.ToString(), title, "", oqOGEbEs9nDJYQBRokDp(metadataItemHeader), LK7r4fEsd9ywRnsKHpXH(metadataItemHeader) != null);
			case 1:
				metadataItemHeader = LoadHeaderData(itemUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (metadataItemHeader != null)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return null;
		}
	}

	protected DeployTreeNode GetNodeWithMetadataService(Guid itemUid)
	{
		//Discarded unreachable code: IL_0043, IL_00a1, IL_00b0, IL_00ed, IL_0149, IL_0158
		switch (1)
		{
		case 1:
			try
			{
				NamedMetadata namedMetadata = MetadataService.GetMetadata(itemUid) as NamedMetadata;
				int num = 3;
				DeployTreeNode result = default(DeployTreeNode);
				while (true)
				{
					switch (num)
					{
					case 2:
						result = CreateNode(itemUid.ToString(), (string)T2jCqBEslw30DuFkgXJl(namedMetadata), "");
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num = 0;
						}
						continue;
					case 3:
						if (namedMetadata != null)
						{
							num = 2;
							continue;
						}
						break;
					case 1:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						Kx6txuEsjiVdMr72RaTx(uYJesmEsrE2qL1GDODpO(), o4BFc4Es5CST55iWYDie(uHgJyTEsgOvmGhc2mAQU(-105199646 ^ -104870114), itemUid), ex);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			break;
		}
		return null;
	}

	private void UpdateNodeNameIfNeed(Func<BPMAppManifestItem, string, string> getNodeName, BPMAppManifestItem item, DeployTreeNode node)
	{
		if (getNodeName != null)
		{
			node.Text = getNodeName(item, node.Text);
		}
	}

	private IMetadataItemHeader LoadHeaderData(Guid uid)
	{
		return MetadataItemHeaderManager.LoadOrNull(uid);
	}

	internal static void IMRgiCEsMaJPMYWjw1Gv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cMQRX8EsmCaMwvTL4d1D()
	{
		return bCdb4nEs0h34KTbqcQ74 == null;
	}

	internal static MetadataHeaderChapterBuilder i2oIbmEsyVa0YZrRO6KC()
	{
		return bCdb4nEs0h34KTbqcQ74;
	}

	internal static object No9CidEsJKGYreRHfalZ(object P_0)
	{
		return ((IMetadataItemHeader)P_0).DisplayName;
	}

	internal static bool oqOGEbEs9nDJYQBRokDp(object P_0)
	{
		return ((IMetadataItemHeader)P_0).IsDirtyItem;
	}

	internal static object LK7r4fEsd9ywRnsKHpXH(object P_0)
	{
		return ((IMetadataItemHeader)P_0).Published;
	}

	internal static object T2jCqBEslw30DuFkgXJl(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object uYJesmEsrE2qL1GDODpO()
	{
		return Logger.Log;
	}

	internal static object uHgJyTEsgOvmGhc2mAQU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object o4BFc4Es5CST55iWYDie(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void Kx6txuEsjiVdMr72RaTx(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
