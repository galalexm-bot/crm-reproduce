using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

public class PageMetadataGenerator : FormMetadataGenerator<PageMetadata>
{
	internal static PageMetadataGenerator I5kURGBVD7ci90lUqiIZ;

	protected override IEnumerable<ISyntaxNode> GenerateMainFileContent()
	{
		return GenerateFileContent(new FormContextGenerator());
	}

	private IEnumerable<ISyntaxNode> GenerateFileContent(FormContextGenerator generator)
	{
		Contract.NotNull(base.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C538E3D));
		Contract.NotNull(base.Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42652B5B));
		Contract.NotNull(base.Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939444752));
		((ICodeGenerator)generator).Metadata = base.Metadata.Content.Context;
		((ICodeGenerator)generator).GenerationParams = new GenerationParams();
		return generator.Generate();
	}

	public PageMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GJvRIRBV4uMDh6vqD9l0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void GJvRIRBV4uMDh6vqD9l0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pO0ILyBVtufNtM0FU6XF()
	{
		return I5kURGBVD7ci90lUqiIZ == null;
	}

	internal static PageMetadataGenerator O8gcw6BVwbTqTfpeEknA()
	{
		return I5kURGBVD7ci90lUqiIZ;
	}
}
