using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 570)]
internal sealed class RazorViewsChapterBuilder : BPMAppChapterBuilder
{
	internal static RazorViewsChapterBuilder BUHuu4EcXS3uGS0RBJvT;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(RazorViewsExportConsts.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1BE9C6)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571BA891))
	};

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F3006B0));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = RazorViewsExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A02980)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978681341));
		if (!(manifest.GetChapter(RazorViewsExportConsts.ExportExtensionUid) is RazorViewsBAChapter razorViewsBAChapter) || razorViewsBAChapter.ViewVirtualPaths == null || razorViewsBAChapter.ViewVirtualPaths.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		foreach (RazorViewBAItem viewVirtualPath in razorViewsBAChapter.ViewVirtualPaths)
		{
			FillTree(viewVirtualPath.ViewVirtualPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487395792), deployTreeNode);
		}
		FillCounter(deployTreeNode);
		list.Add(deployTreeNode);
		return list;
	}

	private void FillTree(string path, string parentPath, DeployTreeNode parent)
	{
		//Discarded unreachable code: IL_0180
		int num = 5;
		int num2 = num;
		int num4 = default(int);
		int num3 = default(int);
		string text2 = default(string);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		string text = default(string);
		DeployTreeNode parent2 = default(DeployTreeNode);
		while (true)
		{
			switch (num2)
			{
			case 4:
				num4 = path.IndexOf('/', num3);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				parent.Children.Add(new DeployTreeNode(path, text2, ""));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				parent.Children.Add(new DeployTreeNode(_003C_003Ec__DisplayClass3_.currentPath, text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC5C9B6)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				FillTree(path, _003C_003Ec__DisplayClass3_.currentPath, parent2);
				num2 = 3;
				break;
			case 1:
				text2 = (string)gfGR9mEcO8fLsDsj1vxT(path, num3);
				num2 = 10;
				break;
			case 6:
			{
				int num5 = oAMIVlEc25cNwW7TGt9S(parent);
				vAdhB7Eceyj2UDgVUuAE(parent, num5 + 1);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				return;
			case 9:
				if (parent.Children.Any(_003C_003Ec__DisplayClass3_._003CFillTree_003Eb__0))
				{
					num2 = 13;
					break;
				}
				goto case 8;
			case 12:
				_003C_003Ec__DisplayClass3_.currentPath = (string)q4ivGMEcN8WHebJODPNR(parentPath, text, sF76PrEc11EfOOUynFRZ(--1333735954 ^ 0x4F7F5642));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 9;
				}
				break;
			case 14:
				return;
			case 5:
				num3 = O7HpaVEcnZOnowQS7dKh(parentPath);
				num2 = 4;
				break;
			case 2:
				if (num4 >= 0)
				{
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				parent2 = parent.Children.First(_003C_003Ec__DisplayClass3_._003CFillTree_003Eb__1);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				text = (string)aH0jMuEcPlqJHNus2uvZ(path, num3, num4 - num3);
				num2 = 12;
				break;
			}
		}
	}

	private void FillCounter(DeployTreeNode node)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00ab, IL_0184, IL_01bc
		int num = 3;
		int num2 = num;
		IEnumerator<DeployTreeNode> enumerator = default(IEnumerator<DeployTreeNode>);
		int num4 = default(int);
		DeployTreeNode current = default(DeployTreeNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = node.Children.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				num4 = oAMIVlEc25cNwW7TGt9S(node);
				num2 = 2;
				continue;
			case 4:
				break;
			default:
				try
				{
					while (true)
					{
						IL_0138:
						int num3;
						if (!eeUl92Ec3ZOW6h7ijS8L(enumerator))
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num3 = 3;
							}
							goto IL_00af;
						}
						goto IL_00f3;
						IL_00f3:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num3 = 0;
						}
						goto IL_00af;
						IL_00af:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num4 += oAMIVlEc25cNwW7TGt9S(current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								break;
							default:
								FillCounter(current);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								goto IL_0138;
							case 4:
								goto end_IL_0138;
							}
							break;
						}
						goto IL_00f3;
						continue;
						end_IL_0138:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								enumerator.Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 1:
				return;
			}
			vAdhB7Eceyj2UDgVUuAE(node, num4);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num2 = 1;
			}
		}
	}

	protected override void GetFakeItemNodes(DeployTreeNode parentNode, List<BPMAppManifestFakeItem> parentItems, ICollection<DeployTreeNode> parentNodes)
	{
		int num = 0;
		foreach (BPMAppManifestFakeItem item in parentItems.OrderBy((BPMAppManifestFakeItem i) => (string)_003C_003Ec.NYhOlq8yttg5AqkGufPT(i)))
		{
			DeployTreeNode deployTreeNode = CreateNode(string.IsNullOrWhiteSpace(item.UidProxy) ? item.Uid.ToString() : item.UidProxy, string.IsNullOrWhiteSpace(item.TitleAdditional) ? item.Title : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146594445), item.Title, item.TitleAdditional), string.Equals(Path.GetExtension(item.Title), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633187979), StringComparison.CurrentCultureIgnoreCase) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A3D902) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA1CE3A));
			if (string.Equals(Path.GetExtension(deployTreeNode.Text), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146311165), StringComparison.CurrentCultureIgnoreCase))
			{
				num++;
			}
			parentNodes.Add(deployTreeNode);
			GetFakeItemNodes(deployTreeNode, item.Items, deployTreeNode.Children);
			num += deployTreeNode.Count;
		}
		parentNode.Count = num;
	}

	public RazorViewsChapterBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static int O7HpaVEcnZOnowQS7dKh(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object gfGR9mEcO8fLsDsj1vxT(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static int oAMIVlEc25cNwW7TGt9S(object P_0)
	{
		return ((DeployTreeNode)P_0).Count;
	}

	internal static void vAdhB7Eceyj2UDgVUuAE(object P_0, int value)
	{
		((DeployTreeNode)P_0).Count = value;
	}

	internal static object aH0jMuEcPlqJHNus2uvZ(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object sF76PrEc11EfOOUynFRZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q4ivGMEcN8WHebJODPNR(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool OqjqYYEcTXOLKoxvlaQs()
	{
		return BUHuu4EcXS3uGS0RBJvT == null;
	}

	internal static RazorViewsChapterBuilder dw8WqqEck0M1xM7uoAJR()
	{
		return BUHuu4EcXS3uGS0RBJvT;
	}

	internal static bool eeUl92Ec3ZOW6h7ijS8L(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
