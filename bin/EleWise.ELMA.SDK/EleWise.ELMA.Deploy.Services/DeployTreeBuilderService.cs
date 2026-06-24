using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal sealed class DeployTreeBuilderService : IDeployTreeBuilderService
{
	private IEnumerable<IBPMAppChapterBuilder> bpmAppChapterRenderer;

	private static DeployTreeBuilderService tj3Ta0EH8v8SiocJWOE1;

	public DeployTreeBuilderService(IEnumerable<IBPMAppChapterBuilder> bpmAppChapterRenderer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.bpmAppChapterRenderer = bpmAppChapterRenderer;
	}

	public DeployTreeModel BuildTree(BPMAppFakeManifest manifest, string id, string title)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		DeployTreeNode deployTreeNode = default(DeployTreeNode);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_.manifest = manifest;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				deployTreeNode = new DeployTreeNode(id, title, (string)HRyY5BEHIZQKAvGH2Xvi(0x3C5338FF ^ 0x3C57B6F9), bpmAppChapterRenderer.SelectMany(_003C_003Ec__DisplayClass2_._003CBuildTree_003Eb__0).ToList());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return new DeployTreeModel(id, new DeployTreeNode[1] { deployTreeNode });
			}
		}
	}

	public DeployTreeModel BuildTree(BPMAppManifest manifest, string id, IChapterParameters parameters)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		List<DeployTreeNode> children = default(List<DeployTreeNode>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass3_.parameters = parameters;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return new DeployTreeModel(id, children);
			case 3:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				children = bpmAppChapterRenderer.SelectMany(_003C_003Ec__DisplayClass3_._003CBuildTree_003Eb__0).ToList();
				num2 = 4;
				break;
			case 2:
				_003C_003Ec__DisplayClass3_.manifest = manifest;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object HRyY5BEHIZQKAvGH2Xvi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool hPTt27EHZF1jPO3LvM0G()
	{
		return tj3Ta0EH8v8SiocJWOE1 == null;
	}

	internal static DeployTreeBuilderService FUaRqTEHuKjmTLER9KgX()
	{
		return tj3Ta0EH8v8SiocJWOE1;
	}
}
