using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiFilterHelpers : IPublicApiNode
{
	private bool isDelta;

	public const string ClassName = "PublicApiFilterHelpers";

	private static PublicApiFilterHelpers uVIEinhHxOpSoA2cEIEn;

	public string ParentPath => (string)pPAFZThHyjfGq2mgs5fO(0x3B36AB09 ^ 0x3B35D019);

	public static string Path => (string)pPAFZThHyjfGq2mgs5fO(0x1DE3DD89 ^ 0x1DE0A6AF);

	string IPublicApiNode.Path => (string)groDyphHMIXSLFZK9q7a();

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__8))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__8(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__tree = tree
		};
	}

	internal void SetIsDelta()
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
				isDelta = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CBaseGenericFilter_003Ed__10))]
	private IEnumerable<ISyntaxNode> BaseGenericFilter()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBaseGenericFilter_003Ed__10(-2)
		{
			_003C_003E4__this = this
		};
	}

	public PublicApiFilterHelpers()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		By7p1JhHJKCegp8WNs6w();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object pPAFZThHyjfGq2mgs5fO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool EthclihH01oXotKVkRmV()
	{
		return uVIEinhHxOpSoA2cEIEn == null;
	}

	internal static PublicApiFilterHelpers vkrfILhHmBNxawv8exJQ()
	{
		return uVIEinhHxOpSoA2cEIEn;
	}

	internal static object groDyphHMIXSLFZK9q7a()
	{
		return Path;
	}

	internal static void By7p1JhHJKCegp8WNs6w()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
