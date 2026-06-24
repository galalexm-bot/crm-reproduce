using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class PageComponentMetadataGenerator : ComponentMetadataGenerator
{
	internal static PageComponentMetadataGenerator JJAtkkBI9E1nvZDeS2me;

	protected override ISyntaxNode GenerateViewModel()
	{
		PageViewModelGenerator pageViewModelGenerator = new PageViewModelGenerator();
		S7ef7UBIr2Y58WOf2Kny(pageViewModelGenerator, base.Metadata);
		return (ISyntaxNode)nF1Li7BIga4FsB6IdxWw(pageViewModelGenerator);
	}

	public PageComponentMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TYdDDHBI5RcaQf9WG9jW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void S7ef7UBIr2Y58WOf2Kny(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object nF1Li7BIga4FsB6IdxWw(object P_0)
	{
		return ((ComponentViewModelGenerator)P_0).Generate();
	}

	internal static bool OuwmuvBIdBbdkuCi65mp()
	{
		return JJAtkkBI9E1nvZDeS2me == null;
	}

	internal static PageComponentMetadataGenerator fdVdolBIl3lbcyal9DcJ()
	{
		return JJAtkkBI9E1nvZDeS2me;
	}

	internal static void TYdDDHBI5RcaQf9WG9jW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
