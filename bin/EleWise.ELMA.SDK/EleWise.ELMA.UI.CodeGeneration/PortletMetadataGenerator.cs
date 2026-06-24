using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

public class PortletMetadataGenerator : FormMetadataGenerator<PortletMetadata>
{
	internal static PortletMetadataGenerator RTNyT0BV6i5NFDnMiWNi;

	protected override IEnumerable<ISyntaxNode> GenerateMainFileContent()
	{
		Contract.NotNull(base.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420789788));
		Contract.NotNull(base.Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CA5F13));
		Contract.NotNull(base.Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978415497));
		FormContextGenerator obj = new FormContextGenerator
		{
			Metadata = base.Metadata.Content.Context,
			GenerationParams = new GenerationParams()
		};
		PortletPersonalizationGenerator portletPersonalizationGenerator = new PortletPersonalizationGenerator
		{
			Metadata = base.Metadata.PersonalizationContext,
			GenerationParams = new GenerationParams()
		};
		return Enumerable.Concat(second: new PortletSettingsGenerator
		{
			Metadata = base.Metadata.Settings.Context,
			GenerationParams = new GenerationParams()
		}.Generate(), first: obj.Generate().Concat(portletPersonalizationGenerator.Generate()));
	}

	public PortletMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iIbmgEBV7LUaX7UhnHNH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void iIbmgEBV7LUaX7UhnHNH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ajKSrnBVHOQBwrORcfut()
	{
		return RTNyT0BV6i5NFDnMiWNi == null;
	}

	internal static PortletMetadataGenerator mkwQmKBVANGRhQsumfcS()
	{
		return RTNyT0BV6i5NFDnMiWNi;
	}
}
