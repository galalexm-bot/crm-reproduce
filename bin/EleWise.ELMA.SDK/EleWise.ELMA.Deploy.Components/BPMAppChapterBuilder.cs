using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

public abstract class BPMAppChapterBuilder : IBPMAppChapterBuilder
{
	protected class BPMAppChapterBuilderTemplate
	{
		private static BPMAppChapterBuilderTemplate MoUr7q8mHxUQ4pe3D4EO;

		public Guid ChapterUid
		{
			[CompilerGenerated]
			get
			{
				return _003CChapterUid_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CChapterUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CTitle_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string Image
		{
			[CompilerGenerated]
			get
			{
				return _003CImage_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CImage_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public BPMAppChapterBuilderTemplate(Guid chapterUid, string title, string image)
		{
			//Discarded unreachable code: IL_002a
			SingletonReader.PushGlobal();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					Image = image;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num = 0;
					}
					break;
				case 2:
					ChapterUid = chapterUid;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num = 1;
					}
					break;
				case 1:
				{
					Title = title;
					int num2 = 3;
					num = num2;
					break;
				}
				}
			}
		}

		internal static bool wbLK328mAiPVbK1tqOv6()
		{
			return MoUr7q8mHxUQ4pe3D4EO == null;
		}

		internal static BPMAppChapterBuilderTemplate lC1tcW8m7oYQrBnTqFb7()
		{
			return MoUr7q8mHxUQ4pe3D4EO;
		}
	}

	internal static BPMAppChapterBuilder z9bxTVEsYB1ALKHIOdBH;

	protected abstract IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate { get; }

	public IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppFakeManifest manifest)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A338030));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		if (BuilderTemplate == null)
		{
			return list;
		}
		foreach (BPMAppChapterBuilderTemplate item in BuilderTemplate)
		{
			if (item == null)
			{
				continue;
			}
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.template1 = item;
			foreach (BPMAppManifestFakeChapter item2 in manifest.Chapters.Where((BPMAppManifestFakeChapter c) => _003C_003Ec__DisplayClass1_0.bmtV148m9h4xSciYQfGc(_003C_003Ec__DisplayClass1_0.q9IAvy8mM43ioUB2GZ1A(c), _003C_003Ec__DisplayClass1_0.phbdbe8mJTPQuHfCoPBk(CS_0024_003C_003E8__locals0.template1))))
			{
				DeployTreeNode deployTreeNode = CreateNode(item.ChapterUid.ToString(), string.IsNullOrWhiteSpace(item2.Title) ? item.Title : item2.Title, item.Image);
				GetFakeItemNodes(deployTreeNode, item2.Items, deployTreeNode.Children);
				list.Add(deployTreeNode);
			}
		}
		return list;
	}

	public abstract IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters);

	protected virtual void GetFakeItemNodes(DeployTreeNode parentNode, List<BPMAppManifestFakeItem> parentItems, ICollection<DeployTreeNode> parentNodes)
	{
		foreach (BPMAppManifestFakeItem item in parentItems.OrderBy((BPMAppManifestFakeItem i) => (string)_003C_003Ec.Au0cr38m5InFhfIuEpp9(i)))
		{
			DeployTreeNode deployTreeNode = CreateNode(string.IsNullOrWhiteSpace(item.UidProxy) ? item.Uid.ToString() : item.UidProxy, string.IsNullOrWhiteSpace(item.TitleAdditional) ? item.Title : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269FA19A), item.Title, item.TitleAdditional), "");
			parentNodes.Add(deployTreeNode);
			GetFakeItemNodes(deployTreeNode, item.Items, deployTreeNode.Children);
		}
		parentNode.Count = parentNode.Children.Count;
	}

	protected DeployTreeNode CreateNode(string uid, string title, string icon)
	{
		return new DeployTreeNode((string)G0Yd5HEssmEeLfddL2Kg(uid), title, icon);
	}

	protected DeployTreeNode CreateNode(string uid, string title, string icon, bool isDirtyItem, bool isPublished)
	{
		return new DeployTreeNode((string)G0Yd5HEssmEeLfddL2Kg(uid), title, icon, isDirtyItem, isPublished);
	}

	protected BPMAppChapterBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nJEHNUEscQ30PYOkJoAj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object G0Yd5HEssmEeLfddL2Kg(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool zkhau7EsLCuaYviOqwoe()
	{
		return z9bxTVEsYB1ALKHIOdBH == null;
	}

	internal static BPMAppChapterBuilder tc0boCEsUq5u0opPcTdC()
	{
		return z9bxTVEsYB1ALKHIOdBH;
	}

	internal static void nJEHNUEscQ30PYOkJoAj()
	{
		SingletonReader.PushGlobal();
	}
}
