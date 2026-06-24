using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

[Component(Order = 100)]
internal class PublicApiNodeEnumProvider : IPublicApiNodeProvider
{
	private static readonly string[] EnumObsoleteNodes;

	private static PublicApiNodeEnumProvider tYA5shhAbSwy5chTLO0r;

	[IteratorStateMachine(typeof(_003CCreatePublicApiNodes_003Ed__0))]
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCreatePublicApiNodes_003Ed__0(-2);
	}

	[IteratorStateMachine(typeof(_003CBuildEnumsTree_003Ed__2))]
	private static IEnumerable<IPublicApiNode> BuildEnumsTree(object parentPath, object groupTreeNode, List<EnumMetadata> metadataList, bool hidden)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBuildEnumsTree_003Ed__2(-2)
		{
			_003C_003E3__parentPath = (string)parentPath,
			_003C_003E3__groupTreeNode = (MetadataTreeHelper.GroupNode)groupTreeNode,
			_003C_003E3__metadataList = metadataList,
			_003C_003E3__hidden = hidden
		};
	}

	public PublicApiNodeEnumProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PublicApiNodeEnumProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				EnumObsoleteNodes = new string[8]
				{
					(string)tBwkr2hAE7maMwWEF1he(0x1DE3DD89 ^ 0x1DE0A661),
					(string)tBwkr2hAE7maMwWEF1he(-420743386 ^ -420967498),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C50444F),
					(string)tBwkr2hAE7maMwWEF1he(-1852837372 ^ -1853059472),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488685823),
					(string)tBwkr2hAE7maMwWEF1he(-2138958856 ^ -2139001050),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317574744),
					(string)tBwkr2hAE7maMwWEF1he(0x3630F361 ^ 0x36338F97)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool JNbkvchAhUteF07QLUK9()
	{
		return tYA5shhAbSwy5chTLO0r == null;
	}

	internal static PublicApiNodeEnumProvider rbCQfQhAGeGmBdQq89DR()
	{
		return tYA5shhAbSwy5chTLO0r;
	}

	internal static object tBwkr2hAE7maMwWEF1he(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
